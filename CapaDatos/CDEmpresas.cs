using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDEmpresas
    {
        private CDConexion conexion = new CDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable Mostrar()
        {

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "MostrarEmpresa";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;

        }

        // capturamos los datos de la capa entidad para correr la sentencia sql procedure

        public void Insertar(CapaEntidad.CEEmpresas cEEmpresas)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            cEEmpresas.Logo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "InsertarEmpresa";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@razonSocial", cEEmpresas.RazonSocial);
            command.Parameters.AddWithValue("@nombreFantasia", cEEmpresas.NombreFantasia );
            command.Parameters.AddWithValue("@ruc", cEEmpresas.Ruc);
            command.Parameters.AddWithValue("@direccion", cEEmpresas.Dirrecion);
            command.Parameters.AddWithValue("@telefono", cEEmpresas.Telefono);
            command.Parameters.AddWithValue("@email", cEEmpresas.Email);
            command.Parameters.AddWithValue("@logo", ms.GetBuffer());
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();

        }

        public void Editar(CapaEntidad.CEEmpresas cEEmpresas)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            cEEmpresas.Logo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "ModificarEmpresa";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@razonSocial", cEEmpresas.RazonSocial);
            command.Parameters.AddWithValue("@nombreFantasia", cEEmpresas.NombreFantasia);
            command.Parameters.AddWithValue("@ruc", cEEmpresas.Ruc);
            command.Parameters.AddWithValue("@direccion", cEEmpresas.Dirrecion);
            command.Parameters.AddWithValue("@telefono", cEEmpresas.Telefono);
            command.Parameters.AddWithValue("@email", cEEmpresas.Email);
            command.Parameters.AddWithValue("@logo", ms.GetBuffer());
            command.Parameters.AddWithValue("@id", cEEmpresas.Id);
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
            command.Parameters.Clear();
        }

        public void Eliminar(CapaEntidad.CEEmpresas cEEmpresas)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "EliminarEmpresa";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", cEEmpresas.Id);

            command.ExecuteNonQuery();

            command.Parameters.Clear();
        }
    }
}
