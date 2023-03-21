using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }



        private void button3_Click(object sender, EventArgs e)
        {
           openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            label2.Text = saveFileDialog1.FileName;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label3.Text = fontDialog1.Font.Name;
            label3.Font = fontDialog1.Font;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
