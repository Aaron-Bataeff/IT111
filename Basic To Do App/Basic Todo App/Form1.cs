using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Basic_Todo_App
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTask.Text.Trim();
            DateTime dueDate = dtpDueDate.Value;

            // Validate task name
            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Task name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the new task to the list
            TaskItem newTask = new TaskItem
            {
                Task = taskName,
                DueDate = dueDate,
                IsCompleted = false
            };

            tasks.Add(newTask);
            UpdateTaskList();

            // Clear the form inputs
            txtTask.Clear();
            dtpDueDate.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTask.Clear();
            dtpDueDate.Value = DateTime.Now;
        }

        private void lstTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                // Get the selected task
                TaskItem selectedTask = tasks[lstTasks.SelectedIndex];

                // Mark the task as completed
                selectedTask.IsCompleted = true;

                // Show a completion message
                MessageBox.Show($"Task '{selectedTask.Task}' marked as completed!", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update the task list to reflect changes
                UpdateTaskList();
            }
        }

        private void UpdateTaskList()
        {
            // Sort tasks: incomplete tasks first, then by due date
            tasks = tasks
                .OrderBy(t => t.IsCompleted)
                .ThenBy(t => t.DueDate)
                .ToList();

            // Clear and repopulate the ListBox
            lstTasks.Items.Clear();

            foreach (TaskItem task in tasks)
            {
                lstTasks.Items.Add(task.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes here if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label click here if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click here if needed
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            // Handle date picker value change if needed
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Handle label click here if needed
        }
    }
}
