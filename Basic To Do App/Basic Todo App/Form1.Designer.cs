namespace Basic_Todo_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpDueDate = new DateTimePicker();
            txtTask = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            lstTasks = new ListBox();
            label3 = new Label();
            lblDoubleClicktoMarkaTaskasCompleted = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDueDate);
            groupBox1.Controls.Add(txtTask);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Task";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(70, 56);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(270, 23);
            dtpDueDate.TabIndex = 2;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(70, 27);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(270, 23);
            txtTask.TabIndex = 1;
            txtTask.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Due Date";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Task";
            label1.Click += label1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(265, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(180, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(12, 175);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(360, 184);
            lstTasks.TabIndex = 5;
            lstTasks.DoubleClick += lstTasks_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "Tasks to do";
            // 
            // lblDoubleClicktoMarkaTaskasCompleted
            // 
            lblDoubleClicktoMarkaTaskasCompleted.AutoSize = true;
            lblDoubleClicktoMarkaTaskasCompleted.Location = new Point(144, 157);
            lblDoubleClicktoMarkaTaskasCompleted.Name = "lblDoubleClicktoMarkaTaskasCompleted";
            lblDoubleClicktoMarkaTaskasCompleted.Size = new Size(228, 15);
            lblDoubleClicktoMarkaTaskasCompleted.TabIndex = 7;
            lblDoubleClicktoMarkaTaskasCompleted.Text = "Double Click to Mark a Task as Completed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(lblDoubleClicktoMarkaTaskasCompleted);
            Controls.Add(label3);
            Controls.Add(lstTasks);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "To-Do App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label label3;
        private Label lblDoubleClicktoMarkaTaskasCompleted;
    }
}
