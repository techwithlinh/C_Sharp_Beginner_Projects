namespace Lập_trình_C__WinForm
{
    partial class MainForm
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
            btnCount = new Button();
            lblCount = new Label();
            SuspendLayout();
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCount.ForeColor = Color.Coral;
            btnCount.Location = new Point(61, 111);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(127, 70);
            btnCount.TabIndex = 0;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCount.Location = new Point(112, 40);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 28);
            lblCount.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 212);
            Controls.Add(lblCount);
            Controls.Add(btnCount);
            Name = "MainForm";
            Text = "Number Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCount;
        private Label lblCount;
    }
}