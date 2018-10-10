using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class CDTUsuario
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable Mostrar()
        {

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "MostrarTipoUsuario";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;

        }

        // capturamos los datos de la capa entidad para correr la sentencia sql procedure

        public void Insertar(CapaEntidad.CETUsuario cETUsuario)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "InsertarTipoUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@rol", cETUsuario.Rol);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();

        }

        public void Editar(CapaEntidad.CETUsuario cETUsuario)
        {
            
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ModificarTipoUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@rol", cETUsuario.Rol);
            command.Parameters.AddWithValue("@id", cETUsuario.Id);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();
        }

        public void Eliminar(CapaEntidad.CETUsuario cETUsuario)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "EliminarTipoUsuario";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", cETUsuario.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
        }
    }
}
