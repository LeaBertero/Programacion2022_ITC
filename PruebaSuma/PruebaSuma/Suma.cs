using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSuma
{
    public partial class Suma : Form
    {
        int a = 2;
        int b = 2;
        int res;

        public Suma()
        {
            InitializeComponent();
        }

        private void BtSuma_Click(object sender, EventArgs e)
        {
            //TxtRes.Enabled = false;

            
            a = Convert.ToInt32(TxtNum1.Text);
            b = Convert.ToInt32(TxtNum2.Text);
            //res.(ToString);

            res = a + b;

            TxtRes.Text = Convert.ToString(res);

            //return res;
        }
    }
}


        

        


