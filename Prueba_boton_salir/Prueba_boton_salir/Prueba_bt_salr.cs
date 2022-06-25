using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_boton_salir
{
    public partial class Prueba_bt_salr : Form
    {
        public Prueba_bt_salr()
        {
            InitializeComponent();
        }

        
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            if (TxLetra.Text == "s")
            {
                Close();
            }
            if (TxLetra.Text == "")
            {
                MessageBox.Show("Ingrese (s), para salir");
                TxLetra.Focus();
                TxLetra.SelectAll();
                TxLetra.Text = null;
            }
            else
            {
                MessageBox.Show("Caracter/es no validos - Imposible salir");
            }
        }
    }
}









