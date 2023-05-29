namespace WinForm_Calculator
{
    partial class Calculator
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            lblResult = new Label();
            btnCalculate = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(96, 23);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(100, 26);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(96, 66);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(100, 26);
            txtNumber2.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(12, 207);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(64, 28);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(96, 121);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 41);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "=";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(48, 37);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(12, 55);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(48, 37);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(12, 98);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(48, 41);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(12, 145);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(48, 41);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 264);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Calculator";
            Text = "The Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label lblResult;
        private Button btnCalculate;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
    }
}