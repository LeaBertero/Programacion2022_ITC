﻿using System;
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
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSolicitar_Click(object sender, EventArgs e)
        {
            Form PrmForm = new FrmCalculadora();
            Caculadora.ShowDialog();
        }
    }
}