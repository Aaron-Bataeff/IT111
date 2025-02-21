using System;
using System.Windows.Forms;

namespace Basic_Todo_App
{
    public partial class TodoItem : UserControl
    {
        public event EventHandler TaskCompleted;
        public DateTime DueDate { get; private set; }

        public TodoItem()
        {
            InitializeComponent();
        }

        public TodoItem(string task, DateTime dueDate) : this()
        {
            lblTask.Text = task;
            lblDueDate.Text = dueDate.ToShortDateString();
            DueDate = dueDate; // Store the due date for sorting
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            TaskCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
