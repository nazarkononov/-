namespace BinaryFileComparer
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
            SelectFile1Button = new Button();
            SelectFile2Button = new Button();
            ResultTextBox = new TextBox();
            File1PathTextBox = new TextBox();
            File2PathTextBox = new TextBox();
            CompareFilesButton = new Button();
            SuspendLayout();
            // 
            // SelectFile1Button
            // 
            SelectFile1Button.Location = new Point(127, 65);
            SelectFile1Button.Name = "SelectFile1Button";
            SelectFile1Button.Size = new Size(120, 29);
            SelectFile1Button.TabIndex = 0;
            SelectFile1Button.Text = "Файл 1";
            SelectFile1Button.UseVisualStyleBackColor = true;
            SelectFile1Button.Click += SelectFile1Button_Click;
            // 
            // SelectFile2Button
            // 
            SelectFile2Button.Location = new Point(127, 100);
            SelectFile2Button.Name = "SelectFile2Button";
            SelectFile2Button.Size = new Size(120, 29);
            SelectFile2Button.TabIndex = 1;
            SelectFile2Button.Text = "Файл 2";
            SelectFile2Button.UseVisualStyleBackColor = true;
            SelectFile2Button.Click += SelectFile2Button_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(127, 135);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(460, 27);
            ResultTextBox.TabIndex = 2;
            // 
            // File1PathTextBox
            // 
            File1PathTextBox.Location = new Point(253, 65);
            File1PathTextBox.Name = "File1PathTextBox";
            File1PathTextBox.Size = new Size(334, 27);
            File1PathTextBox.TabIndex = 3;
            // 
            // File2PathTextBox
            // 
            File2PathTextBox.Location = new Point(253, 100);
            File2PathTextBox.Name = "File2PathTextBox";
            File2PathTextBox.Size = new Size(334, 27);
            File2PathTextBox.TabIndex = 4;
            // 
            // CompareFilesButton
            // 
            CompareFilesButton.Location = new Point(127, 179);
            CompareFilesButton.Name = "CompareFilesButton";
            CompareFilesButton.Size = new Size(139, 29);
            CompareFilesButton.TabIndex = 5;
            CompareFilesButton.Text = "Порівняти файли";
            CompareFilesButton.UseVisualStyleBackColor = true;
            CompareFilesButton.Click += CompareFilesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 320);
            Controls.Add(CompareFilesButton);
            Controls.Add(File2PathTextBox);
            Controls.Add(File1PathTextBox);
            Controls.Add(ResultTextBox);
            Controls.Add(SelectFile2Button);
            Controls.Add(SelectFile1Button);
            Name = "Form1";
            Text = "Binary File Comparer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SelectFile1Button;
        private System.Windows.Forms.Button SelectFile2Button;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox File1PathTextBox;
        private System.Windows.Forms.TextBox File2PathTextBox;
        private System.Windows.Forms.Button CompareFilesButton;
    }
}