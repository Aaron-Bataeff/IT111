using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing; // Needed for row selection

namespace CustomerManagementSystem
{
    public partial class FormMain : Form
    {
        private List<Customer> customers = new List<Customer>();
        private const string DataFile = "customers.json"; // File for saving/loading data
        private int selectedCustomerId = -1; // Stores selected customer ID

        public FormMain()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadCustomersFromFile();
        }

        private void InitializeDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select row only
            dgvCustomers.MultiSelect = false; // Prevent multiple selections
            dgvCustomers.AllowUserToAddRows = false; // Prevent empty row at bottom
            dgvCustomers.RowHeadersVisible = false; // Hide row selector
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Prevent header resizing
            dgvCustomers.EnableHeadersVisualStyles = false; // Allow custom header styles
            dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor;
            dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor;

            // Define columns
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CustomerId", DataPropertyName = "Id", Name = "CustomerId", Visible = false });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name", Width = 150, ReadOnly = false });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone Number", DataPropertyName = "Phone", Width = 120, ReadOnly = true });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email", Width = 180, ReadOnly = true });

            dgvCustomers.CellClick += DgvCustomers_CellClick; // Ensure only valid rows can be selected

            RefreshCustomerList();
        }

        private void DgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) // Prevent selecting headers
            {
                dgvCustomers.ClearSelection();
                return;
            }

            // Store the selected customer ID
            selectedCustomerId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["CustomerId"].Value);
        }

        private void RefreshCustomerList()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;

            // Restore the previously selected customer
            if (selectedCustomerId != -1)
            {
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    if (Convert.ToInt32(row.Cells["CustomerId"].Value) == selectedCustomerId)
                    {
                        row.Selected = true;
                        dgvCustomers.FirstDisplayedScrollingRowIndex = row.Index; // Scrolls to selected row
                        break;
                    }
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            if (formCustomer.ShowDialog() == DialogResult.OK)
            {
                customers.Add(formCustomer.CustomerData);
                SaveCustomersToFile();
                RefreshCustomerList();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a customer to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dgvCustomers.SelectedRows[0].Index;
            Customer selectedCustomer = customers[selectedIndex];

            FormCustomer formCustomer = new FormCustomer(selectedCustomer);
            if (formCustomer.ShowDialog() == DialogResult.OK)
            {
                customers[selectedIndex] = formCustomer.CustomerData;
                selectedCustomerId = selectedCustomer.Id; // Keep selection
                SaveCustomersToFile();
                RefreshCustomerList();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dgvCustomers.SelectedRows[0].Index;
            customers.RemoveAt(selectedIndex);
            selectedCustomerId = -1; // Reset selection
            SaveCustomersToFile();
            RefreshCustomerList();
        }

        private void SaveCustomersToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(customers);
                File.WriteAllText(DataFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomersFromFile()
        {
            try
            {
                if (File.Exists(DataFile))
                {
                    string json = File.ReadAllText(DataFile);
                    customers = JsonSerializer.Deserialize<List<Customer>>(json) ?? new List<Customer>();
                    RefreshCustomerList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCustomersToFile(); // Ensure data is saved before closing
        }
    }
}
