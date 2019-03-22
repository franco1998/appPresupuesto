using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applicationPresupuesto
{
    class clsGestor
    {
        private DataTable dtProducto = new DataTable("Productos");
        private DataTable dtCliente = new DataTable("Clientes");
        private DataTable dtUsuario = new DataTable("Usuarios");
        
        private void crearEsquemas()
        {
            //ESQUEMA DE LA LISTA DE PRODUCTOS
            DataColumn[] col = new DataColumn[3];
            col[0] = new DataColumn("idProducto", typeof(int));
            col[1] = new DataColumn("descripcion", typeof(string));
            col[2] = new DataColumn("precioUnit", typeof(double));

            col[0].AutoIncrement = true;
            col[0].AutoIncrementSeed = 1;
            col[0].AutoIncrementStep = 1;
            col[0].ReadOnly = true;

            dtProducto.Columns.AddRange(col);
            //campos claves
            DataColumn[] colkey = new DataColumn[1];
            colkey[0] = col[0];
            dtProducto.PrimaryKey = colkey;

            //ESQUEMAS DE CARTELERA DE CLIENTES
            DataColumn[] col2 = new DataColumn[6];
            col2[0] = new DataColumn("idCliente", typeof(int));
            col2[1] = new DataColumn("nombre", typeof(string));
            col2[2] = new DataColumn("apellido", typeof(string));
            col2[3] = new DataColumn("domicilio", typeof(string));
            col2[4] = new DataColumn("localidad", typeof(string));
            col2[5] = new DataColumn("telefono", typeof(string));

            col2[0].AutoIncrement = true;
            col2[0].AutoIncrementSeed = 1;
            col2[0].AutoIncrementStep = 1;
            col2[0].ReadOnly = true;

            dtCliente.Columns.AddRange(col2);
            //campos claves 
            DataColumn[] colkey2 = new DataColumn[1];
            colkey2[0] = col2[0];
            dtCliente.PrimaryKey = colkey2;

            //ESQUEMAS DE USUARIOS

            DataColumn[] col3 = new DataColumn[6];

            col3[0] = new DataColumn("nombreEmpresa", typeof(string));
            col3[1] = new DataColumn("urlFoto", typeof(string));
            col3[2] = new DataColumn("direccion", typeof(string));
            col3[3] = new DataColumn("localidad", typeof(string));
            col3[4] = new DataColumn("telefono", typeof(string));
            col3[5] = new DataColumn("cuit", typeof(string));

            col3[0].AutoIncrement = true;
            col3[0].AutoIncrementSeed = 1;
            col3[0].AutoIncrementStep = 1;
            col3[0].ReadOnly = true; 

            dtUsuario.Columns.AddRange(col3);

            DataColumn[] colkey3 = new DataColumn[1];
            colkey3[0] = col3[0];
            dtUsuario.PrimaryKey = colkey3;
        }
    }
}
