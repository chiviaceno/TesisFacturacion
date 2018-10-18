using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNCliente
    {
        private CDClientes objetoCD = new CDClientes();

        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarCliente(CECliente cECliente)
        {
            objetoCD.Insertar(cECliente);
        }

        public void EditarCliente(CECliente cECliente)
        {
            objetoCD.Editar(cECliente);

        }

        public void EliminarCliente(CECliente cECliente)
        {
            objetoCD.Eliminar(cECliente);
        }

        public DataTable MostrarEmpresa()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarEmpresa();
            return tabla;
        }
    }
}
