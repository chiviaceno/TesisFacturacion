using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CDClientes
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable Mostrar()
        {
           
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "MostrarCliente";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;

        }

        // capturamos los datos de la capa entidad para correr la sentencia sql procedure

        public void Insertar(CapaEntidad.CECliente cECliente)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "InsertarCliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_empl", cECliente.Id_Empl);
            command.Parameters.AddWithValue("@nombre", cECliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cECliente.Apellido);
            command.Parameters.AddWithValue("@cedula", cECliente.Cedula);
            command.Parameters.AddWithValue("@direccion", cECliente.Dirrecion);
            command.Parameters.AddWithValue("@telefono", cECliente.Telefono);
            command.Parameters.AddWithValue("@email", cECliente.Email);
            command.Parameters.AddWithValue("@fecha", cECliente.Fecha);
            command.Parameters.AddWithValue("@estado", cECliente.Estado);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();

        }

        public void Editar(CapaEntidad.CECliente cECliente )
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ModificarCliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_empl", cECliente.Id_Empl);
            command.Parameters.AddWithValue("@nombre", cECliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cECliente.Apellido);
            command.Parameters.AddWithValue("@cedula", cECliente.Cedula);
            command.Parameters.AddWithValue("@direccion", cECliente.Dirrecion);
            command.Parameters.AddWithValue("@telefono", cECliente.Telefono);
            command.Parameters.AddWithValue("@email", cECliente.Email);
            command.Parameters.AddWithValue("@fecha", cECliente.Fecha);
            command.Parameters.AddWithValue("@estado",cECliente.Estado);
            command.Parameters.AddWithValue("@id", cECliente.Id);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();
        }

        public void Eliminar(CapaEntidad.CECliente cECliente)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "EliminarCliente";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", cECliente.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
        }

        public DataTable ListarEmpresa()
        {

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "MostrarEmpresa";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();

            return tabla;

        }
    }

}
