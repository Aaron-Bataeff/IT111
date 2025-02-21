namespace Basic_Todo_App
{
    partial class TodoItem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTaskText;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblDueDateText;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button btnMarkDone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDueDateText = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblTaskText = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnMarkDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDueDateText ("Due Date:")
            // 
            this.lblDueDateText.AutoSize = true;
            this.lblDueDateText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueDateText.Location = new System.Drawing.Point(3, 5);
            this.lblDueDateText.Name = "lblDueDateText";
            this.lblDueDateText.Size = new System.Drawing.Size(67, 15);
            this.lblDueDateText.Text = "Due Date:";
            // 
            // lblDueDate (Date)
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDueDate.Location = new System.Drawing.Point(75, 5);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(100, 15);
            this.lblDueDate.Text = "1/1/2025"; // Placeholder, will be set dynamically
            // 
            // lblTaskText ("Task:")
            // 
            this.lblTaskText.AutoSize = true;
            this.lblTaskText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaskText.Location = new System.Drawing.Point(3, 25);
            this.lblTaskText.Name = "lblTaskText";
            this.lblTaskText.Size = new System.Drawing.Size(37, 15);
            this.lblTaskText.Text = "Task:";
            // 
            // lblTask (Multi-line Wrapping)
            // 
            this.lblTask.AutoSize = true;  // Allow dynamic resizing
            this.lblTask.MaximumSize = new System.Drawing.Size(260, 0); // Width limit, but height grows
            this.lblTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTask.Location = new System.Drawing.Point(50, 25);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(200, 15);
            this.lblTask.Text = "Sample Task"; // Placeholder
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMarkDone.Location = new System.Drawing.Point(260, 10);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Size = new System.Drawing.Size(75, 30);
            this.btnMarkDone.TabIndex = 2;
            this.btnMarkDone.Text = "Mark Done";
            this.btnMarkDone.UseVisualStyleBackColor = true;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // TodoItem (Container)
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnMarkDone);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblTaskText);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblDueDateText);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TodoItem";
            this.Size = new System.Drawing.Size(350, 60);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
