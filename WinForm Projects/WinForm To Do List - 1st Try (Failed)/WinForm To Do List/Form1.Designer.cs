namespace WinForm_To_Do_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTask = new TextBox();
            btnAddTask = new Button();
            listBoxTasks = new ListBox();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            SuspendLayout();
            // 
            // textTask
            // 
            txtTask.Location = new Point(12, 488);
            txtTask.Name = "textTask";
            txtTask.Size = new Size(224, 26);
            txtTask.TabIndex = 0;

            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(242, 488);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(60, 26);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 19;
            listBoxTasks.Location = new Point(12, 12);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(224, 460);
            listBoxTasks.TabIndex = 2;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(242, 449);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(60, 23);
            btnDeleteTask.TabIndex = 3;
            btnDeleteTask.Text = "Delete";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(242, 411);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(60, 23);
            btnCompleteTask.TabIndex = 4;
            btnCompleteTask.Text = "Check";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 526);
            Controls.Add(btnCompleteTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(listBoxTasks);
            Controls.Add(btnAddTask);
            Controls.Add(textTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTask;
        private Button btnAddTask;
        private ListBox listBoxTasks;
        private Button btnDeleteTask;
        private Button btnCompleteTask;
        private TextBox txtTask;


    }
}