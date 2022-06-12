namespace Ej_Banco
{
    partial class Banco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.BtSolicitar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // TxNombre
            // 
            this.TxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombre.Location = new System.Drawing.Point(373, 162);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(163, 31);
            this.TxNombre.TabIndex = 2;
            // 
            // BtSolicitar
            // 
            this.BtSolicitar.BackColor = System.Drawing.Color.Sienna;
            this.BtSolicitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSolicitar.Location = new System.Drawing.Point(233, 225);
            this.BtSolicitar.Name = "BtSolicitar";
            this.BtSolicitar.Size = new System.Drawing.Size(303, 66);
            this.BtSolicitar.TabIndex = 3;
            this.BtSolicitar.Text = "Solicitar préstamo";
            this.BtSolicitar.UseVisualStyleBackColor = false;
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.Color.Sienna;
            this.BtSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(691, 398);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(81, 40);
            this.BtSalir.TabIndex = 4;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.BtSolicitar);
            this.Controls.Add(this.TxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Banco";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Button BtSolicitar;
        private System.Windows.Forms.Button BtSalir;
    }
}

