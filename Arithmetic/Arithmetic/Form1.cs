using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1, num2, sum, min, max;
            double ave;
            int choice = Convert.ToInt32(txtoption.Text);
            Display dis = new Display();

            string [] values = txtnum.Text.Split();

            num1 = int.Parse(values[0]);
            num2 = int.Parse(values[1]);

            switch(choice) 
            {
                case 1:
                    sum = num1 + num2;
                    dis.setValues1(num1, num2, sum);
                    dis.Show();
                    break;
                case 2:
                    sum = num2 + num1;
                    ave = sum / 2;
                    dis.setValues2(num1, num2, sum, ave);
                    dis.Show();
                    break;
                case 3:
                    sum = num1 + num2;
                    ave = sum / 2;
                    if(num1 > num2)
                    {
                        max = num1;
                        min = num2;
                    }
                    else
                    {
                        max = num2;
                        min = num1;
                    }
                    dis.setValues3(num1, num2, sum, ave, min, max);
                    dis.Show();
                    break;
            }
        }
    }
}
