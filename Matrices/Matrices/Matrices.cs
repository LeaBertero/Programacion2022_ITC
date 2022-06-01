using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Matrices : Form
    {
        public Matrices()
        {
            InitializeComponent();
        }

        private void BtExplorarIm_Click(object sender, EventArgs e)
        {
            if (AbrirImage.ShowDialog() == DialogResult.OK)
            { // Carga la imagen dentro del cuadro picture box.
                PicImage.Image = Image.FromFile(AbrirImage.FileName);
                // Muestra el nombre del archivo en el titulo de forma

               this.Text = string.Concat("Visor de Imagenes(" + AbrirImage.FileName+ ")");
            }
                
        }

        private void LinkCalclu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkCalclu.LinkVisited = true;
            System.Diagnostics.Process.Start("Calc");
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkWeb.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore",
            "http://www.google.com");
        }

        private void LinkExplorar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkExplorar.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\");
        }
    }
}

