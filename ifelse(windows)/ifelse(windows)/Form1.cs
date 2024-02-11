using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelse_windows_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double discountedPrice;
            double purchaseAmount = Convert.ToDouble(textBox1.Text);

            double discountRate = 0.10; // 10% discount rate



            if (1000 >= purchaseAmount)
            {
                //if its less than 1000
                textBox2.Text =(" Discount: No Discount ");
            }
            else
            {
                // Apply the discount if the purchase amount is greater than 1000
                discountedPrice = purchaseAmount * discountRate;
                textBox2.Text = ($"Discounted price: {discountedPrice:N2}");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
