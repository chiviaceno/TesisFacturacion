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
   public class CNEmpleado
    {
        private CDEmpleados objetoCD = new CDEmpleados();

        public DataTable MostrarEmpleado()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
         
        public void InsertarEmpleado(CEEmpleado cEEmpleado)
        {
            objetoCD.Insertar(cEEmpleado);
        }

        public void EditarEmpleado(CEEmpleado cEEmpleado)
        {
            objetoCD.Editar(cEEmpleado);
            
        }

        public void EliminarEmpleado(CEEmpleado cEEmpleado)
        {
            objetoCD.Eliminar(cEEmpleado);
        }

        public DataTable MostrarEmpresa()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarEmpresa();
            return tabla;
        }
    }
}
