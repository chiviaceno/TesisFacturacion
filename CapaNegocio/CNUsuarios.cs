using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public class CNUsuarios
    {
        private CDUsuarios objetoCD = new CDUsuarios();

        public DataTable MostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable MostrarEmpleado()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarEmpleado();
            return tabla;
        }
        //public DataTable MostrarTipoUsuario()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = objetoCD.ListarTipoUsuario();
        //    return tabla;
        //}
        public void InsertarUsuario(CEUsuarios cEUsuarios)
        {
            objetoCD.Insertar(cEUsuarios);
        }

        public void EditarUsuario(CEUsuarios cEUsuarios)
        {
            objetoCD.Editar(cEUsuarios);

        }

        public void EliminarUsuario(CEUsuarios cEUsuarios)
        {
            objetoCD.Eliminar(cEUsuarios);
        }
    }
}
