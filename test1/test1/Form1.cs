using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtyears_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngetbonus_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(txtsalary.Text);
            int year = Convert.ToInt32(txtyears.Text);
            double bonus;
            Display dis = new Display();


            if(year == 1) 
            {
                bonus = salary * 0.10;
                dis.setValues(bonus, salary, 0.10);
                dis.Show();

            }
            if (year >= 2 && year <= 5)
            {
                bonus = salary * 0.20;
                dis.setValues(bonus, salary, 0.20);
                dis.Show();

            }
            if (year >= 6 && year < 10)
            {
                bonus = salary * 0.50;
                dis.setValues(bonus, salary, 0.50);
                dis.Show();

            }
            if (year >= 11)
            {
                bonus = salary * 0.75;
                dis.setValues(bonus, salary, 0.75);
                dis.Show();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
