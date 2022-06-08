namespace Matrices_True
{
    partial class Matrices_true
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.BtGenMatriz = new System.Windows.Forms.Button();
            this.BtSumar = new System.Windows.Forms.Button();
            this.TxDimension = new System.Windows.Forms.TextBox();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtRestar = new System.Windows.Forms.Button();
            this.BtMult = new System.Windows.Forms.Button();
            this.BtDiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matriz resultante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Escriba la dimension de la matriz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(293, 132);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(575, 132);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 6;
            // 
            // BtGenMatriz
            // 
            this.BtGenMatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtGenMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGenMatriz.Location = new System.Drawing.Point(293, 310);
            this.BtGenMatriz.Name = "BtGenMatriz";
            this.BtGenMatriz.Size = new System.Drawing.Size(240, 43);
            this.BtGenMatriz.TabIndex = 7;
            this.BtGenMatriz.Text = "Generar matriz";
            this.BtGenMatriz.UseVisualStyleBackColor = true;
            this.BtGenMatriz.Click += new System.EventHandler(this.BtGenMatriz_Click);
            // 
            // BtSumar
            // 
            this.BtSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSumar.Location = new System.Drawing.Point(169, 372);
            this.BtSumar.Name = "BtSumar";
            this.BtSumar.Size = new System.Drawing.Size(99, 33);
            this.BtSumar.TabIndex = 8;
            this.BtSumar.Text = "Sumar";
            this.BtSumar.UseVisualStyleBackColor = true;
            this.BtSumar.Click += new System.EventHandler(this.BtSumar_Click);
            // 
            // TxDimension
            // 
            this.TxDimension.Location = new System.Drawing.Point(310, 53);
            this.TxDimension.Name = "TxDimension";
            this.TxDimension.Size = new System.Drawing.Size(189, 20);
            this.TxDimension.TabIndex = 9;
            // 
            // BtSalir
            // 
            this.BtSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Location = new System.Drawing.Point(16, 433);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(60, 50);
            this.BtSalir.TabIndex = 10;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtRestar
            // 
            this.BtRestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRestar.Location = new System.Drawing.Point(302, 372);
            this.BtRestar.Name = "BtRestar";
            this.BtRestar.Size = new System.Drawing.Size(99, 33);
            this.BtRestar.TabIndex = 11;
            this.BtRestar.Text = "Restar";
            this.BtRestar.UseVisualStyleBackColor = true;
            this.BtRestar.Click += new System.EventHandler(this.BtRestar_Click);
            // 
            // BtMult
            // 
            this.BtMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMult.Location = new System.Drawing.Point(430, 372);
            this.BtMult.Name = "BtMult";
            this.BtMult.Size = new System.Drawing.Size(99, 33);
            this.BtMult.TabIndex = 12;
            this.BtMult.Text = "Multiplicar";
            this.BtMult.UseVisualStyleBackColor = true;
            this.BtMult.Click += new System.EventHandler(this.BtMult_Click);
            // 
            // BtDiv
            // 
            this.BtDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDiv.Location = new System.Drawing.Point(554, 372);
            this.BtDiv.Name = "BtDiv";
            this.BtDiv.Size = new System.Drawing.Size(99, 33);
            this.BtDiv.TabIndex = 13;
            this.BtDiv.Text = "Dividir";
            this.BtDiv.UseVisualStyleBackColor = true;
            this.BtDiv.Click += new System.EventHandler(this.BtDiv_Click);
            // 
            // Matrices_true
            // 
            this.AcceptButton = this.BtGenMatriz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(830, 495);
            this.Controls.Add(this.BtDiv);
            this.Controls.Add(this.BtMult);
            this.Controls.Add(this.BtRestar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.TxDimension);
            this.Controls.Add(this.BtSumar);
            this.Controls.Add(this.BtGenMatriz);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Matrices_true";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button BtGenMatriz;
        private System.Windows.Forms.Button BtSumar;
        private System.Windows.Forms.TextBox TxDimension;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtRestar;
        private System.Windows.Forms.Button BtMult;
        private System.Windows.Forms.Button BtDiv;
    }
}

