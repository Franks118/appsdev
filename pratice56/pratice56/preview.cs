using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratice56
{
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }
        public void setvalues(int num,int num2) { 
            int total = 0;
            total = num + num2 ;
            txtout.Text = total.ToString();
          
        }
      
        private void txtout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
