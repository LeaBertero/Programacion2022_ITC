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
        int num1;
        int num2;
        int resultado;

        public Suma()
        {
            InitializeComponent();
        }

        private void BtSuma_Click(object sender, EventArgs e)
        {
            //TxtRes.Enabled = false;

            
            num1 = Convert.ToInt32(TxtNum1.Text);
            num2 = Convert.ToInt32(TxtNum2.Text);
            //res.(ToString);

            resultado = num1 + num2;

            TxtRes.Text = Convert.ToString(resultado);

            //return resultado;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


        

        


