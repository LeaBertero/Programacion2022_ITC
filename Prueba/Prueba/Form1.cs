using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btseleccion_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked && checkBox3.Checked || checkBox4.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado nada");
            }
            //else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked == true)
            //{
            //    MessageBox.Show("No puede seleccionar todas las opciones");
            //}


        }
    }
}
           
            



