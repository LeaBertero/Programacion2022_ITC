namespace PruebaSuma
{
    partial class Suma
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
            this.BtSuma = new System.Windows.Forms.Button();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtSuma
            // 
            this.BtSuma.Location = new System.Drawing.Point(48, 73);
            this.BtSuma.Name = "BtSuma";
            this.BtSuma.Size = new System.Drawing.Size(85, 67);
            this.BtSuma.TabIndex = 0;
            this.BtSuma.Text = "Sumar";
            this.BtSuma.UseVisualStyleBackColor = true;
            this.BtSuma.Click += new System.EventHandler(this.BtSuma_Click);
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(202, 73);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(72, 20);
            this.TxtNum1.TabIndex = 1;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(202, 120);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(72, 20);
            this.TxtNum2.TabIndex = 2;
            // 
            // TxtRes
            // 
            this.TxtRes.Location = new System.Drawing.Point(314, 97);
            this.TxtRes.Name = "TxtRes";
            this.TxtRes.Size = new System.Drawing.Size(72, 20);
            this.TxtRes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "El resultado es:";
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRes);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.BtSuma);
            this.Name = "Suma";
            this.Text = "Prueba_Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSuma;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtRes;
        private System.Windows.Forms.Label label1;
    }
}

