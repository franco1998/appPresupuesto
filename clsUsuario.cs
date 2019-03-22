using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationPresupuesto
{
    class clsUsuario
    {
        private string nombreEmpresa;
        private string urlFoto;
        private string cuit;
        private string direccion;
        private string localidad;
        private string telefono;

        public clsUsuario()
        {
        }

        public clsUsuario(string nombreEmpresa, string urlFoto, string cuit, string direccion, string telefono, string localidad)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.urlFoto = urlFoto;
            this.cuit = cuit;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public string UrlFoto { get => urlFoto; set => urlFoto = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
    }
}
