using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 


namespace CapaDatos
{
    public class CDEmpleados
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable Mostrar()
        {
            // TRANSAC SQL
            //command.Connection = conexion.AbrirConexion();
            //command.CommandText = "SELECT * FROM FAC_EMPLEADO";
            //leer = command.ExecuteReader();
            //tabla.Load(leer);
            //conexion.CerrarConexion();

            //return tabla;

            //PRICEDIMIENTO ALMACENADO

            
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "MostrarEmpleado";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla; 
            
        }
         
        // capturamos los datos de la capa entidad para correr la sentencia sql procedure

        public void Insertar(CapaEntidad.CEEmpleado cEEmpleado )
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "InsertarEmpleado";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_empl", cEEmpleado.Id_Empl);
            command.Parameters.AddWithValue("@nombre", cEEmpleado.Nombre);
            command.Parameters.AddWithValue("@apellido", cEEmpleado.Apellido);
            command.Parameters.AddWithValue("@cedula", cEEmpleado.Cedula);
            command.Parameters.AddWithValue("@direccion", cEEmpleado.Dirrecion);
            command.Parameters.AddWithValue("@telefono", cEEmpleado.Telefono);
            command.Parameters.AddWithValue("@email", cEEmpleado.Email);
            command.Parameters.AddWithValue("@estado", cEEmpleado.Estado);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();

        }

        public void Editar(CapaEntidad.CEEmpleado cEEmpleado)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ModificarEmpleado";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_empl", cEEmpleado.Id_Empl);
            command.Parameters.AddWithValue("@nombre", cEEmpleado.Nombre);
            command.Parameters.AddWithValue("@apellido", cEEmpleado.Apellido);
            command.Parameters.AddWithValue("@cedula", cEEmpleado.Cedula);
            command.Parameters.AddWithValue("@direccion", cEEmpleado.Dirrecion);
            command.Parameters.AddWithValue("@telefono", cEEmpleado.Telefono);
            command.Parameters.AddWithValue("@email", cEEmpleado.Email);
            command.Parameters.AddWithValue("@estado", cEEmpleado.Estado);
            command.Parameters.AddWithValue("@id", cEEmpleado.Id);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();
        }

        public void Eliminar(CapaEntidad.CEEmpleado cEEmpleado)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "EliminarEmpleado";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", cEEmpleado.Id);

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
