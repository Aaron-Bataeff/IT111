using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Basic_Todo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTask.Text.Trim();
            DateTime dueDate = dtpDueDate.Value;

            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Task name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new TodoItem
            TodoItem newTask = new TodoItem(taskName, dueDate);
            newTask.TaskCompleted += TodoItem_TaskCompleted;

            // Insert it in sorted order inside flowLayoutPanelTasks
            List<TodoItem> sortedTasks = flowLayoutPanelTasks.Controls.OfType<TodoItem>()
                .Concat(new[] { newTask }) // Add new task to the existing list
                .OrderBy(task => task.DueDate) // Sort by DueDate
                .ToList();

            // Clear and re-add sorted tasks
            flowLayoutPanelTasks.Controls.Clear();
            foreach (var task in sortedTasks)
            {
                flowLayoutPanelTasks.Controls.Add(task);
            }

            // Clear input fields
            txtTask.Clear();
            dtpDueDate.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTask.Clear();
            dtpDueDate.Value = DateTime.Now;
        }

        private void TodoItem_TaskCompleted(object sender, EventArgs e)
        {
            TodoItem todoItem = sender as TodoItem;
            if (todoItem != null)
            {
                flowLayoutPanelTasks.Controls.Remove(todoItem);
                todoItem.Dispose();
            }
        }
    }
}
