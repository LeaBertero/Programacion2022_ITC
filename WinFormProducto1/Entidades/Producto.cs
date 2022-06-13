using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Producto
    {
        #region Atributos
        private int codigo;
        private string Descripcion;
        private int Stock;
        #endregion

        #region Constructores
        public Producto()
        {

        }

        public Producto(int Cod, string Desc)
        {
            codigo = Cod;
            Descripcion = Desc; 
            Stock = 0;
        }
        #endregion

        #region Metodos

        public void Imgreso(int Cantidad)
        {
            Stock = Stock + Cantidad;
        }

        public void Salida(int Cant)
        {
            Stock = Stock - Cant;
        }
        #endregion
    }
}



     
