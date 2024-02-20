using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = Convert.ToInt32(textBox1.Text);//to get the input
            preview ui = new preview();//connecting the page
            ui.setvalues(num);//getting the value from here and sending it to the second page
            ui.Show();//show
        }
    }
}
