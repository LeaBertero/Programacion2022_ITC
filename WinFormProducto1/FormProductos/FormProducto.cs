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
            //Instanciamos utilizando el constructor con parametros
            Nuevoprod = new Producto(int.Parse(TxtCodigo.Text), TxtDesc.Text);
            LbCodMovimiento.Text = Nuevoprod.p_Codigo.ToString();
            LbDescMovimiento.Text = Nuevoprod.p_descripcion;
            Lb_StockMovimiento.Text = "Hay " + Nuevoprod.p_stock.ToString() + " Unidades";
            MessageBox.Show("Producto ingresado");
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            if (TxLetra.Text == "S")
            {
                Close();
            }
            if (TxLetra.Text == "")
            {
                MessageBox.Show("Imposible salir");
                TxLetra.Focus();
                TxLetra.SelectAll();
            }
            else
            {
                MessageBox.Show("Palabra incorrecta - Imposible salir");
            }
        }
    }
}
