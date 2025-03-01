using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CustomerManagementSystem
{
    public partial class FormCustomer : Form
    {
        public Customer CustomerData { get; private set; }

        public FormCustomer()
        {
            InitializeComponent();
            CustomerData = new Customer();
        }

        public FormCustomer(Customer customer) : this()
        {
            txtName.Text = customer.Name;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            CustomerData = customer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerData.Name = txtName.Text;
            CustomerData.Email = txtEmail.Text;
            CustomerData.Phone = txtPhone.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}
