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
        #region Variables 
        //Variable
        int Fila = 0;
        
        #endregion


        public FormProducto()
        {
            InitializeComponent();
        }

        private void BtCarga_Click(object sender, EventArgs e)
        {
            //if (TxtStock == null)
            //{
            //    MessageBox.Show("No puede dejar vacio este segmento");
            //}
            
            //Instanciamos utilizando el constructor con parametros
            Producto Nuevoprod;

            Nuevoprod = new Producto(int.Parse(TxtCodigo.Text), TxtDesc.Text);

            LbCodMovimiento.Text = Nuevoprod.p_Codigo.ToString();
            LbDescMovimiento.Text = Nuevoprod.p_descripcion;
            Lb_StockMovimiento.Text = "Hay " + Nuevoprod.p_stock.ToString() + " Unidades";


            MessageBox.Show("Producto ingresado");
           

            int Fila = Dgv_producto.Rows.Add(Nuevoprod.p_Codigo.ToString,);


            TxtCodigo.Text = null;
            TxtDesc.Text = null;
            TxtStock.Text = null;
            
            //Dgv_producto.Rows[Fila].Cells[0].Value = TxtCodigo.Text;
            //Dgv_producto.Rows[Fila].Cells[1].Value = TxtDesc.Text;
            //Dgv_producto.Rows[Fila].Cells[2].Value = TxtStock.Text;

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            if (TxLetra.Text == "s")
            {
                Close();
            }
            if (TxLetra.Text == "")
            {
                MessageBox.Show("Debe Ingresar (s) para salir ");
                TxLetra.Focus();
                TxLetra.SelectAll();
                
            }
            if (TxLetra.Text != "")
            {
                MessageBox.Show("ingrese una letra valida");
                if (TxLetra.Text != "")
                {
                    MessageBox.Show("Demasiados caracteres");
                }
            }
            //else
            //{
            //    MessageBox.Show("Error");
            //}
            

           
        }
        

        private void Dgv_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;

            if (Fila != -1)
            {
                LbMostrarProd.Text = (string)Dgv_producto.Rows[Fila].Cells[1].Value;
            }
        }
       
        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (RadIngreso.Checked == true && RadEgreso.Checked == false)
            {
                MessageBox.Show("Producto ingresado");
            }
        }
    }
}




