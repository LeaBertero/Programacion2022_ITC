namespace Prueba_boton_salir
{
    partial class Prueba_bt_salr
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
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.TxLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.Location = new System.Drawing.Point(30, 71);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Salir.TabIndex = 0;
            this.Bt_Salir.Text = "Salir";
            this.Bt_Salir.UseVisualStyleBackColor = true;
            this.Bt_Salir.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // TxLetra
            // 
            this.TxLetra.Location = new System.Drawing.Point(137, 71);
            this.TxLetra.Name = "TxLetra";
            this.TxLetra.Size = new System.Drawing.Size(100, 20);
            this.TxLetra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese \"S\" - para salir";
            // 
            // Prueba_bt_salr
            // 
            this.AcceptButton = this.Bt_Salir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxLetra);
            this.Controls.Add(this.Bt_Salir);
            this.Name = "Prueba_bt_salr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Salir;
        private System.Windows.Forms.TextBox TxLetra;
        private System.Windows.Forms.Label label1;
    }
}

