using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CDLogin
    {
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;

        public SqlDataReader IniciarSesion(string user, string pass)
        {
            // DE LA MANERA TRADICIONAL
            //string sql = "select * from FAC_USUARIO where USE_USUARIO='" + user + "'and USE_PASSWORD='" + pass+"'";
            //SqlCommand comando = new SqlCommand();
            //comando.Connection = Conexion.AbrirConexion();
            //comando.CommandText = sql;
            //Leer = comando.ExecuteReader();
            //return Leer;

            // ESTO ES MEDIANTE UN STOREPROCEDURE
            SqlCommand comando = new SqlCommand("sp_acceder",Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", user);
            comando.Parameters.AddWithValue("@contraseña", pass);

            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
