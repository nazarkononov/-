using System;
using System.Windows.Forms;

namespace BMIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtWeight.TextChanged += TextBox_TextChanged;
            txtHeight.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            double weight, height, bmi;

            if (double.TryParse(txtWeight.Text, out weight) &&
                double.TryParse(txtHeight.Text, out height))
            {
                bmi = weight / Math.Pow(height / 100, 2);
                lblResult.Text = $"BMI: {bmi:F2}";
            }
            else
            {
                lblResult.Text = "Invalid input. Please enter a number.";
            }
        }
    }
}