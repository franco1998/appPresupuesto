using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationPresupuesto
{
    class clsItem
    {
        private int nroItem;
        private clsProducto lista;
        private int cantidad;


        public clsItem()
        {
        }

        public clsItem(int nroItem, clsProducto lista,int cantidad)
        {
            this.nroItem = nroItem;
            this.lista = lista;
            this.cantidad = cantidad;
        }

        public int NroItem { get => nroItem; set => nroItem = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal clsProducto Lista { get => lista; set => lista = value; }
    }
}
