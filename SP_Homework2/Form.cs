using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Homework2
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int byteSize = 4096;
        public Form()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void FromPathButton_Click(object sender, EventArgs e)
        {
            fromOpenFileDialog.ShowDialog();
            fromPathTextBox.Text = fromOpenFileDialog.FileName;
        }

        private void ToPathButton_Click(object sender, EventArgs e)
        {
            toOpenFileDialog.ShowDialog();
            toPathTextBox.Text = toOpenFileDialog.FileName;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fromPathTextBox.Text))
            {
                MessageBox.Show("Файл не выбран!");
            }
            if (String.IsNullOrEmpty(toPathTextBox.Text))
            {
                MessageBox.Show("Не выбран путь для копирования!");
            }
            else
            {
                progressBar.Visible = true;
                Copy();
                progressBar.Visible = false;
                fromPathTextBox.Text = null;
                toPathTextBox.Text = null;
            }
        }

        private void Copy()
        {
            byte[] array = new byte[byteSize];
            using (FileStream from = new FileStream(fromPathTextBox.Text, FileMode.Open),
                                to = new FileStream(toPathTextBox.Text, FileMode.OpenOrCreate))
            {
                progressBar.Invoke(new Action<int>((p => progressBar.Maximum = p)), (int)(from.Length / byteSize));

                while (from.Position < from.Length)
                {
                    from.Read(array, 0, byteSize);
                    to.Write(array, 0, byteSize);
                    progressBar.Invoke(new Action<int>((p => progressBar.Value = p)), (int)(from.Position / byteSize));
                }
            }
            if (progressBar.Value == progressBar.Maximum)
            {
                MessageBox.Show("Файл успешно скопирован!");
            }
        }

        private void ToPathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (String.IsNullOrEmpty(fromPathTextBox.Text))
                {
                    MessageBox.Show("Файл не выбран!");
                }
                if (String.IsNullOrEmpty(toPathTextBox.Text))
                {
                    MessageBox.Show("Не выбран путь для копирования!");
                }
                else
                {
                    progressBar.Visible = true;
                    Copy();
                    progressBar.Visible = false;
                    fromPathTextBox.Text = null;
                    toPathTextBox.Text = null;
                }
            }
        }
    }
}
