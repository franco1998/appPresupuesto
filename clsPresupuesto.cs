using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationPresupuesto
{
    class clsPresupuesto
    {
        private int idPresuspuesto;
        private List<clsItem> items;
        private bool iva;
        private DateTime fecha;

        
        public List<double> precioXitem()
        {
            double res = 0;
            List<double> listaPrecio = new List<double>();
            foreach (clsItem i in items)
            {
                res = i.Lista.PrecioUnit * i.Cantidad;
                listaPrecio.Add(res);
            }
            return listaPrecio;
        }
        public double subtotal()
        {
            double res = 0;
            List<double> arr = new List<double>();
            arr = precioXitem();
            foreach(double i in arr)
            {
                res += i;
            }
            return res;
        }

        public double total()
        {
            double res = 0;
            double ivaImp = 0;
            if (iva)
            {
                res = subtotal();
                ivaImp = subtotal() * 0.21;
                res = res + ivaImp;
            }
            else
            {
                res = subtotal();
            }
            return res;
        }
        public void agregarItems(clsItem item)
        {
            items.Add(item);
        }

        public void elminarItem(clsItem item)
        {
            items.Remove(item);
        }

        public clsPresupuesto()
        {
        }

        public clsPresupuesto(int idPresuspuesto, List<clsItem> items, bool iva, DateTime fecha)
        {
            this.idPresuspuesto = idPresuspuesto;
            this.items = items;
            this.iva = iva;
            this.fecha = fecha;
        }

        public int IdPresuspuesto { get => idPresuspuesto; set => idPresuspuesto = value; }
        public bool Iva { get => iva; set => iva = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal List<clsItem> Items { get => items; set => items = value; }
    }
}
