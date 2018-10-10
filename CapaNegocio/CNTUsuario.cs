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
   public class CNTUsuario
    {
        private CDTUsuario objetoCD = new CDTUsuario();

        public DataTable MostrarTipoUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarTipoUsuario(CETUsuario cETUsuario)
        {
            objetoCD.Insertar(cETUsuario);
        }

        public void EditarTipoUsuario(CETUsuario cETUsuario)
        {
            objetoCD.Editar(cETUsuario);

        }

        public void EliminaTipoUsuario(CETUsuario cETUsuario)
        {
            objetoCD.Eliminar(cETUsuario);
        }
    }
}
