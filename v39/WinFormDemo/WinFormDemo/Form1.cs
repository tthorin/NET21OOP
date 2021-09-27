namespace WinFormDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] companies =
            {
                "Campus Mölndal",
                "Codic Edication AB",
                "Net21"
            };
            listBox1.Items.AddRange(companies);
            textBox1.Text = (string)listBox1.Items[0];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Check on");
            }
            else MessageBox.Show("Check off");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    textBox1.Text = "Coolaste skolan.";
                    break;
                case 1:
                    textBox1.Text = "Coolaste utbildarna.";
                    break;
                case 2:
                    textBox1.Text = "Coolaste kodarna.";
                    break;
                default:
                    break;
            }
        }
    }
}
