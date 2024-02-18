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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }
        public void setValues1(int num1, int num2, int sum)
        {
            lblresult.Text = num1+" + "+ num2 +" = "+sum.ToString();
        }
        public void setValues2(int num1, int num2, int sum, double ave)
        {
            lblresult.Text = num1 + " + " + num2 + " = " + sum.ToString();
            lblave.Text = num1 + " and " + num2 + " = " + ave.ToString("N2");
        }
        public void setValues3(int num1, int num2, int sum, double ave, int min, int max)
        {
            lblresult.Text = num1 + " + " + num2 + " = " + sum.ToString();
            lblave.Text = num1 + " and " + num2 + " = " + ave.ToString("N2");
            lblmin.Text = num1 + " and " + num2 + " = " + min.ToString();
            lblmax.Text = num1 + " and " + num2 + " = " + max.ToString();
        }


        private void lblresult_Click(object sender, EventArgs e)

        {

        }

        

        private void Display_Load(object sender, EventArgs e)
        {

        }
    }
}
