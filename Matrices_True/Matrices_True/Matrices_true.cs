using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices_True
{
    public partial class Matrices_true : Form
    {
        public Matrices_true()
        {
            InitializeComponent();
        }

        private void BtGenMatriz_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView3.Columns.Clear();
                int tamaño = int.Parse(TxDimension.Text);
                int incremento = 1;
                while (incremento <= tamaño)
                {
                    DataGridViewColumn columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    columna.Width = 25; //ancho
                    this.dataGridView1.Columns.Add(columna);
                    DataGridViewColumn columna2 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    columna2.Width = 25;
                    this.dataGridView2.Columns.Add(columna2);
                    DataGridViewColumn columna3 = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    columna3.Width = 25;
                    this.dataGridView3.Columns.Add(columna3);
                    incremento++;
                }

                int[,] _matriz1 = new int[tamaño, tamaño]; // se declaran variables de tipo matriz
                int[,] _matriz2 = new int[tamaño, tamaño];
                int[,] _matriz3 = new int[tamaño, tamaño];
                dataGridView1.Rows.Add(tamaño);
                dataGridView2.Rows.Add(tamaño);
                dataGridView3.Rows.Add(tamaño);
                Random r = new Random();
                // genera un dato de manera aleatoria, se utiliza para revolver los datos llena los datos de las casillas
                // vacias.


                for (int f = 0; f < tamaño; f++)
                {
                    for (int c = 0; c < tamaño; c++)
                    {
                        _matriz1[f, c] = r.Next(10); // valor inicial que agarra valores del 0 al 10

                        _matriz2[f, c] = r.Next(10);
                        _matriz3[f, c] = 0;
                        dataGridView1[f, c].Value = _matriz1[f, c]; // se agrega filas y colmnas

                        dataGridView2[f, c].Value = _matriz2[f, c];
                        dataGridView3[f, c].Value = _matriz3[f, c];
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar una dimensión para la matriz");
            }
        }

        private void BtSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int tam = int.Parse(TxDimension.Text);
                int[,] _matriz1 = new int[tam, tam];
                int[,] _matriz2 = new int[tam, tam];
                int[,] _matriz3 = new int[tam, tam];
                for (int f = 0; f < tam; f++) // filas
                {
                    for (int c = 0; c < tam; c++) //columnas
                    {
                        _matriz1[f, c] = int.Parse(dataGridView1[f, c].Value.ToString()); // almacena
                        _matriz2[f, c] = int.Parse(dataGridView2[f, c].Value.ToString());

                        _matriz3[f, c] = _matriz1[f, c] + _matriz2[f, c];
                        dataGridView3.CurrentCell = dataGridView3[f, c];
                        dataGridView3.CurrentCell.Value = _matriz3[f, c];
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese la dimensión de la matriz para sumar");
            }
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtRestar_Click(object sender, EventArgs e)
        {
            try
            {
                int Tam = int.Parse(TxDimension.Text);
                int[,] _matriz1 = new int[Tam, Tam];
                int[,] _matriz2 = new int[Tam, Tam];
                int[,] _matriz3 = new int[Tam, Tam];
                for (int fila = 0; fila < Tam; fila++) // filas
                {
                    for (int c = 0; c < Tam; c++) //columnas
                    {
                        _matriz1[fila, c] = int.Parse(dataGridView1[fila, c].Value.ToString()); // almacena
                        _matriz2[fila, c] = int.Parse(dataGridView2[fila, c].Value.ToString());

                        _matriz3[fila, c] = _matriz1[fila, c] - _matriz2[fila, c];
                        dataGridView3.CurrentCell = dataGridView3[fila, c];
                        dataGridView3.CurrentCell.Value = _matriz3[fila, c];
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese la dimensión de la matriz para restar");
            }
        }

        private void BtMult_Click(object sender, EventArgs e)
        {
            try
            {
                int Tam = int.Parse(TxDimension.Text);
                int[,] _matriz1 = new int[Tam, Tam];
                int[,] _matriz2 = new int[Tam, Tam];
                int[,] _matriz3 = new int[Tam, Tam];
                for (int fila = 0; fila < Tam; fila++) // filas
                {
                    for (int c = 0; c < Tam; c++) //columnas
                    {
                        _matriz1[fila, c] = int.Parse(dataGridView1[fila, c].Value.ToString()); // almacena
                        _matriz2[fila, c] = int.Parse(dataGridView2[fila, c].Value.ToString());

                        _matriz3[fila, c] = _matriz1[fila, c] * _matriz2[fila, c];
                        dataGridView3.CurrentCell = dataGridView3[fila, c];
                        dataGridView3.CurrentCell.Value = _matriz3[fila, c];
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese la dimensión de la matriz para multiplicar");
            }
        }

        private void BtDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int Tam = int.Parse(TxDimension.Text);
                int[,] _matriz1 = new int[Tam, Tam];
                int[,] _matriz2 = new int[Tam, Tam];
                int[,] _matriz3 = new int[Tam, Tam];
                for (int fila = 0; fila < Tam; fila++) // filas
                {
                    for (int c = 0; c < Tam; c++) //columnas
                    {
                        _matriz1[fila, c] = int.Parse(dataGridView1[fila, c].Value.ToString()); // almacena
                        _matriz2[fila, c] = int.Parse(dataGridView2[fila, c].Value.ToString());

                        _matriz3[fila, c] = _matriz1[fila, c] / _matriz2[fila, c];
                        dataGridView3.CurrentCell = dataGridView3[fila, c];
                        dataGridView3.CurrentCell.Value = _matriz3[fila, c];
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese la dimensión de la matriz para dividir");
            }
        }
    }
}



