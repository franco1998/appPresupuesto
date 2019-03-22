using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationPresupuesto
{
    class clsCliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string domicilio;
        private string localidad;
        private string telefono;

        public clsCliente(int idCliente , string nombre, string apellido, string telefono, string localidad, string domicilio)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.localidad = localidad;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Localidad { get => localidad; set => localidad = value; }
    }
}
