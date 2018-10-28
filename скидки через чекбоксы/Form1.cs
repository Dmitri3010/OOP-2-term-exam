using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win
{
    public partial class Form1 : Form
    {
        public double Sale { get; set; } = 0.3;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                int data, output = -1;
                if (checkBox1.Checked)
                {
                    Sale = 0.3;
                }
                if (checkBox2.Checked)
                {
                    Sale = 0.5;
                }
                if (checkBox3.Checked)
                {
                    Sale = 0.7;
                }
                if (int.TryParse(textBox1.Text, out data))
                {
                    output = Convert.ToInt32(Convert.ToDouble(data) - Convert.ToDouble(data) * Sale);
                }
                textBox2.Text = output.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
