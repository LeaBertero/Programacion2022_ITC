using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private int codigo;
        private string Descripcion;
        private int Stock;
        #endregion

        public int p_Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public string p_descripcion
        {
            set { Descripcion = value; }
            get { return Descripcion; }
        }

        public int p_stock 
        {
            //set { Stock = value; }
            get { return Stock; }
        }
        
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

        public void Egreso(int Cant)
        {
            Stock = Stock - Cant;
        }
        #endregion
    }
}




        




     
