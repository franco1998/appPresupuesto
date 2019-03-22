using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationPresupuesto
{
    class clsProducto
    {
        private int idProducto;
        private string urlImg;
        private string descripcion;
        private double precioUnit;

        public clsProducto()
        {
        }

        public clsProducto(int idProducto, string descripcion, double precioUnit, string urlImg)
        {
            this.idProducto = idProducto;
            this.descripcion = descripcion;
            this.precioUnit = precioUnit;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double PrecioUnit { get => precioUnit; set => precioUnit = value; }
        public string UrlImg { get => urlImg; set => urlImg = value; }
    }
}
