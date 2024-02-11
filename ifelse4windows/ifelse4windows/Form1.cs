using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelse4windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            //indexing


            int index1 = input.IndexOf(' ');
            int index2 = input.LastIndexOf(' ');

            int num1;
            int num2;
            int num3;



            //initiate the numbers for comparison
            num1 = int.Parse(input.Substring(0, index1));
            num2 = int.Parse(input.Substring(index1 + 1, index2 - index1 - 1));
            num3 = int.Parse(input.Substring(index2 + 1));


            if (num1 > num2 && num1 > num3)
            {
               textBox2.Text = ("First  is the largest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                textBox2.Text = ("second is the largest");
            }
            else
            {
                textBox2.Text = ("third is the largest");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
