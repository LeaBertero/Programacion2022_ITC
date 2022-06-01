namespace Matrices
{
    partial class Matrices
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
            this.PicImage = new System.Windows.Forms.PictureBox();
            this.AbrirImage = new System.Windows.Forms.OpenFileDialog();
            this.BtExplorarIm = new System.Windows.Forms.Button();
            this.LinkCalclu = new System.Windows.Forms.LinkLabel();
            this.LinkWeb = new System.Windows.Forms.LinkLabel();
            this.LinkExplorar = new System.Windows.Forms.LinkLabel();
            this.BtSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PicImage
            // 
            this.PicImage.Location = new System.Drawing.Point(34, 59);
            this.PicImage.Name = "PicImage";
            this.PicImage.Size = new System.Drawing.Size(359, 322);
            this.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImage.TabIndex = 0;
            this.PicImage.TabStop = false;
            // 
            // AbrirImage
            // 
            this.AbrirImage.FileName = "openFileDialog1";
            // 
            // BtExplorarIm
            // 
            this.BtExplorarIm.Location = new System.Drawing.Point(417, 301);
            this.BtExplorarIm.Name = "BtExplorarIm";
            this.BtExplorarIm.Size = new System.Drawing.Size(103, 32);
            this.BtExplorarIm.TabIndex = 1;
            this.BtExplorarIm.Text = "Abrir Imagen";
            this.BtExplorarIm.UseVisualStyleBackColor = true;
            this.BtExplorarIm.Click += new System.EventHandler(this.BtExplorarIm_Click);
            // 
            // LinkCalclu
            // 
            this.LinkCalclu.AutoSize = true;
            this.LinkCalclu.Location = new System.Drawing.Point(431, 79);
            this.LinkCalclu.Name = "LinkCalclu";
            this.LinkCalclu.Size = new System.Drawing.Size(86, 13);
            this.LinkCalclu.TabIndex = 2;
            this.LinkCalclu.TabStop = true;
            this.LinkCalclu.Text = "Abrir calculadora";
            this.LinkCalclu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCalclu_LinkClicked);
            // 
            // LinkWeb
            // 
            this.LinkWeb.AutoSize = true;
            this.LinkWeb.Location = new System.Drawing.Point(431, 126);
            this.LinkWeb.Name = "LinkWeb";
            this.LinkWeb.Size = new System.Drawing.Size(89, 13);
            this.LinkWeb.TabIndex = 3;
            this.LinkWeb.TabStop = true;
            this.LinkWeb.Text = "www.google.com";
            this.LinkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkWeb_LinkClicked);
            // 
            // LinkExplorar
            // 
            this.LinkExplorar.AutoSize = true;
            this.LinkExplorar.Location = new System.Drawing.Point(431, 174);
            this.LinkExplorar.Name = "LinkExplorar";
            this.LinkExplorar.Size = new System.Drawing.Size(88, 13);
            this.LinkExplorar.TabIndex = 4;
            this.LinkExplorar.TabStop = true;
            this.LinkExplorar.Text = "Explorar Disco C:";
            this.LinkExplorar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkExplorar_LinkClicked);
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(414, 349);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(103, 32);
            this.BtSalir.TabIndex = 5;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(580, 414);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.LinkExplorar);
            this.Controls.Add(this.LinkWeb);
            this.Controls.Add(this.LinkCalclu);
            this.Controls.Add(this.BtExplorarIm);
            this.Controls.Add(this.PicImage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Matrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir una imagen";
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicImage;
        private System.Windows.Forms.OpenFileDialog AbrirImage;
        private System.Windows.Forms.Button BtExplorarIm;
        private System.Windows.Forms.LinkLabel LinkCalclu;
        private System.Windows.Forms.LinkLabel LinkWeb;
        private System.Windows.Forms.LinkLabel LinkExplorar;
        private System.Windows.Forms.Button BtSalir;
    }
}

