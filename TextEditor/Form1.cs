using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class PersonalEditor : Form
    {
        public PersonalEditor()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string name = saveFileDialog1.FileName + ".txt"; 
                File.WriteAllText(name, richTextBox1.Text);          
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();  
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font; 
            }
        }

        private void BtnOpen_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Contains(".txt")) //Checks if it's all ok and if the file name contains .txt  
            {
                string open = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = open;
            }
            else
            {
                MessageBox.Show("El archivo que ha elegido no es un archivo de texto.");
            }
        }
    }
}
