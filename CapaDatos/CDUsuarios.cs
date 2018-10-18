using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    
    public class CDUsuarios
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable ListarEmpleado()
        {
           
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "MostrarEmpleadoContac";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();

            return tabla;

        }


        //public DataTable ListarTipoUsuario()
        //{

        //    command.Connection = conexion.AbrirConexion();
        //    command.CommandText = "MostrarTipoUsuario";
        //    command.CommandType = CommandType.StoredProcedure;
        //    leer = command.ExecuteReader();
        //    tabla.Load(leer);
        //    leer.Close();
        //    conexion.CerrarConexion();

        //    return tabla;

        //}

        public DataTable Mostrar()
        {

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "MostrarUsuario";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();

            return tabla;

        }

        public void Insertar(CapaEntidad.CEUsuarios cEUsuarios)
        {
            
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "InsertarUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tipo", cEUsuarios.Tipo);
            command.Parameters.AddWithValue("@empl_id", cEUsuarios.Empl_Id);
            command.Parameters.AddWithValue("@usuario", cEUsuarios.Usuario);
            command.Parameters.AddWithValue("@password", cEUsuarios.Password);
            
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();

        }

        public void Editar(CapaEntidad.CEUsuarios cEUsuarios)
        {
            

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ModificarUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@tipo", cEUsuarios.Tipo);
            command.Parameters.AddWithValue("@empl_id", cEUsuarios.Empl_Id);
            command.Parameters.AddWithValue("@usuario", cEUsuarios.Usuario);
            command.Parameters.AddWithValue("@password", cEUsuarios.Password);
            command.Parameters.AddWithValue("@id", cEUsuarios.Id);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();
        }

        public void Eliminar(CapaEntidad.CEUsuarios cEUsuarios)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "EliminarUsuario";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", cEUsuarios.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
        }
    }
}
