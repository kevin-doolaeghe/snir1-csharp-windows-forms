using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int choice = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            choice = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choice = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            choice = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            switch(choice)
            {
                case 0:
                    result = Convert.ToDouble(this.textBox1.Text) + Convert.ToDouble(this.textBox2.Text);
                    break;
                case 1:
                    result = Convert.ToDouble(this.textBox1.Text) - Convert.ToDouble(this.textBox2.Text);
                    break;
                case 2:
                    result = Convert.ToDouble(this.textBox1.Text) * Convert.ToDouble(this.textBox2.Text);
                    break;
                case 3:
                    result = Convert.ToDouble(this.textBox1.Text) / Convert.ToDouble(this.textBox2.Text);
                    break;
            }
            this.label1.Text = result.ToString();
        }
    }
}
