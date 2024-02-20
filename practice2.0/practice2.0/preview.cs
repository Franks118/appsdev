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
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }
        public void setvalues(int num) {
            String pop = "Gay";
            String pop1 = "not Gay";
            int total = 0;
            for (int i = 0; i < 3; i++) { 
            total += num;
                label1.Text =   total.ToString("N2");
                String oi = "Php"+total.ToString("c");
                label2.Text = oi;
            }
            if (num >= 1000)
            {

                label3.Text = pop;


            }
            else {

                label3.Text = pop1;

            }


        }
    }
}
