namespace FormProductos
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtCarga = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.Dgv_producto = new System.Windows.Forms.DataGridView();
            this.BtSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LbMostrarProd = new System.Windows.Forms.Label();
            this.BtBorrar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Lb_StockMovimiento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.RadEgreso = new System.Windows.Forms.RadioButton();
            this.RadIngreso = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbDescMovimiento = new System.Windows.Forms.Label();
            this.LbCodMovimiento = new System.Windows.Forms.Label();
            this.TxLetra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_producto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // BtCarga
            // 
            this.BtCarga.Location = new System.Drawing.Point(247, 81);
            this.BtCarga.Name = "BtCarga";
            this.BtCarga.Size = new System.Drawing.Size(75, 23);
            this.BtCarga.TabIndex = 3;
            this.BtCarga.Text = "Ingresar";
            this.BtCarga.UseVisualStyleBackColor = true;
            this.BtCarga.Click += new System.EventHandler(this.BtCarga_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(91, 16);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(130, 20);
            this.TxtCodigo.TabIndex = 4;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(91, 51);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(312, 20);
            this.TxtDesc.TabIndex = 5;
            this.TxtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(91, 84);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(130, 20);
            this.TxtStock.TabIndex = 6;
            this.TxtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dgv_producto
            // 
            this.Dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dgv_producto.Location = new System.Drawing.Point(12, 251);
            this.Dgv_producto.Name = "Dgv_producto";
            this.Dgv_producto.Size = new System.Drawing.Size(538, 242);
            this.Dgv_producto.TabIndex = 7;
            this.Dgv_producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_producto_CellContentClick);
            // 
            // BtSalir
            // 
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(203, 553);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 31);
            this.BtSalir.TabIndex = 8;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 233);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabPage1.Controls.Add(this.LbMostrarProd);
            this.tabPage1.Controls.Add(this.BtBorrar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BtCarga);
            this.tabPage1.Controls.Add(this.TxtCodigo);
            this.tabPage1.Controls.Add(this.TxtDesc);
            this.tabPage1.Controls.Add(this.TxtStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // LbMostrarProd
            // 
            this.LbMostrarProd.AutoSize = true;
            this.LbMostrarProd.Location = new System.Drawing.Point(11, 165);
            this.LbMostrarProd.Name = "LbMostrarProd";
            this.LbMostrarProd.Size = new System.Drawing.Size(0, 13);
            this.LbMostrarProd.TabIndex = 8;
            // 
            // BtBorrar
            // 
            this.BtBorrar.Location = new System.Drawing.Point(328, 81);
            this.BtBorrar.Name = "BtBorrar";
            this.BtBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtBorrar.TabIndex = 7;
            this.BtBorrar.Text = "Borrar";
            this.BtBorrar.UseVisualStyleBackColor = true;
            this.BtBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Lb_StockMovimiento);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtAceptar);
            this.tabPage2.Controls.Add(this.RadEgreso);
            this.tabPage2.Controls.Add(this.RadIngreso);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.LbDescMovimiento);
            this.tabPage2.Controls.Add(this.LbCodMovimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_StockMovimiento
            // 
            this.Lb_StockMovimiento.AutoSize = true;
            this.Lb_StockMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_StockMovimiento.Location = new System.Drawing.Point(147, 94);
            this.Lb_StockMovimiento.Name = "Lb_StockMovimiento";
            this.Lb_StockMovimiento.Size = new System.Drawing.Size(0, 16);
            this.Lb_StockMovimiento.TabIndex = 9;
            this.Lb_StockMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtAceptar
            // 
            this.BtAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtAceptar.Location = new System.Drawing.Point(423, 133);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(82, 55);
            this.BtAceptar.TabIndex = 6;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = false;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // RadEgreso
            // 
            this.RadEgreso.AutoSize = true;
            this.RadEgreso.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RadEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadEgreso.Location = new System.Drawing.Point(315, 168);
            this.RadEgreso.Name = "RadEgreso";
            this.RadEgreso.Size = new System.Drawing.Size(75, 20);
            this.RadEgreso.TabIndex = 5;
            this.RadEgreso.TabStop = true;
            this.RadEgreso.Text = "Egreso";
            this.RadEgreso.UseVisualStyleBackColor = false;
            // 
            // RadIngreso
            // 
            this.RadIngreso.AutoSize = true;
            this.RadIngreso.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RadIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadIngreso.Location = new System.Drawing.Point(315, 133);
            this.RadIngreso.Name = "RadIngreso";
            this.RadIngreso.Size = new System.Drawing.Size(77, 20);
            this.RadIngreso.TabIndex = 4;
            this.RadIngreso.TabStop = true;
            this.RadIngreso.Text = "Ingreso";
            this.RadIngreso.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // LbDescMovimiento
            // 
            this.LbDescMovimiento.AutoSize = true;
            this.LbDescMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescMovimiento.Location = new System.Drawing.Point(147, 57);
            this.LbDescMovimiento.Name = "LbDescMovimiento";
            this.LbDescMovimiento.Size = new System.Drawing.Size(0, 16);
            this.LbDescMovimiento.TabIndex = 1;
            this.LbDescMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbCodMovimiento
            // 
            this.LbCodMovimiento.AutoSize = true;
            this.LbCodMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCodMovimiento.Location = new System.Drawing.Point(147, 27);
            this.LbCodMovimiento.Name = "LbCodMovimiento";
            this.LbCodMovimiento.Size = new System.Drawing.Size(0, 16);
            this.LbCodMovimiento.TabIndex = 0;
            this.LbCodMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxLetra
            // 
            this.TxLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxLetra.Location = new System.Drawing.Point(293, 557);
            this.TxLetra.Name = "TxLetra";
            this.TxLetra.Size = new System.Drawing.Size(84, 22);
            this.TxLetra.TabIndex = 10;
            this.TxLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ingrese \"S\", para salir";
            // 
            // FormProducto
            // 
            this.AcceptButton = this.BtCarga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(563, 601);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxLetra);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.Dgv_producto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormProducto";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_producto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtCarga;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.DataGridView Dgv_producto;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.RadioButton RadEgreso;
        private System.Windows.Forms.RadioButton RadIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbDescMovimiento;
        private System.Windows.Forms.Label LbCodMovimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lb_StockMovimiento;
        private System.Windows.Forms.TextBox TxLetra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtBorrar;
        private System.Windows.Forms.Label LbMostrarProd;
    }
}