using System;
using System.IO;
using System.Windows.Forms;

namespace BinaryFileComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFile1Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File1PathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void SelectFile2Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File2PathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void CompareFilesButton_Click(object sender, EventArgs e)
        {
            string file1Path = File1PathTextBox.Text;
            string file2Path = File2PathTextBox.Text;

            if (string.IsNullOrEmpty(file1Path) || string.IsNullOrEmpty(file2Path))
            {
                MessageBox.Show("Будь ласка, виберіть обидва файли.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (new FileInfo(file1Path).Length != new FileInfo(file2Path).Length)
            {
                ResultTextBox.Text = "Файли мають різні розміри.";
                return;
            }

            int differencesCount = CompareFiles(file1Path, file2Path);
            ResultTextBox.Text = $"Кількість розбіжностей: {differencesCount}";
        }

        private int CompareFiles(string file1Path, string file2Path)
        {
            int differencesCount = 0;
            byte[] file1Bytes = File.ReadAllBytes(file1Path);
            byte[] file2Bytes = File.ReadAllBytes(file2Path);

            for (int i = 0; i < file1Bytes.Length; i++)
            {
                if (file1Bytes[i] != file2Bytes[i])
                {
                    differencesCount++;
                }
            }

            return differencesCount;
        }
    }
}