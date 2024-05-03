namespace BMIForm
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
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(70, 134);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(244, 27);
            txtWeight.TabIndex = 0;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(407, 134);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(244, 27);
            txtHeight.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(294, 202);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(120, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "body mass index";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(lblResult);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label lblResult;
    }
}
