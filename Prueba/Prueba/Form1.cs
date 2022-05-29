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

        private void Btseleccion_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked == false)
            //{
            //    MessageBox.Show("Ingrese una de las opciones");
            //}

            if (checkBox1.Checked && checkBox2.Checked == true)
            {
                MessageBox.Show("Se han marcado las casillas 1 y 2 solamente");
            }
            if (checkBox1.Checked == false && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked == true)
            {
                MessageBox.Show("Se han marcado casillas 2,3 y 4 , menos la casilla 1");
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked == false)
            {
                MessageBox.Show("No se ha marcado ninguna casilla");
            }
            //if (checkBox1.Checked == false && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked == true)
            //{
            //    MessageBox.Show("Se han marcado casillas 2,3 y 4 , menos la casilla 1");
            //}
        }
    }
}
