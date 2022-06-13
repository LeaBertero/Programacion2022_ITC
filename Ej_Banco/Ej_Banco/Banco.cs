using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_Banco
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Banco_Load(object sender, EventArgs e)
        {
            BtSolicitar.Enabled = false;
        }

        private void TxNombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
