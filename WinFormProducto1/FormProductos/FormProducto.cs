using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormProductos
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void BtCarga_Click(object sender, EventArgs e)
        {
            Producto Nuevoprod;
            Nuevoprod = new Producto(int.Parse(TxtCodigo.Text), TxtDesc.Text);

            MessageBox.Show("Producto ingresado");
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
