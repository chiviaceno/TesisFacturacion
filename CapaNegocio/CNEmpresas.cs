using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CNEmpresas
    {
        private CDEmpresas objetoCD = new CDEmpresas();

        public DataTable MostrarEmpresa()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarEmpresa(CEEmpresas cEEmpresas)
        {
            objetoCD.Insertar(cEEmpresas);
        }

        public void EditarEmpresa(CEEmpresas cEEmpresas)
        {
            objetoCD.Editar(cEEmpresas);

        }

        public void EliminarEmpresa(CEEmpresas cEEmpresas)
        {
            objetoCD.Eliminar(cEEmpresas);
        }
    }
}
