using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
namespace CapaNegocio
{
    public class CNLogin
    {
        // encapsularemos variabes
        private CDLogin objDato = new CDLogin(); // instanciamos a la capa datos de empleado
        // variables

        private String _Usuario;
        private String _Contraseña;
        // todas las demas...

        // metodos GET Y SET --> Para el manejo de variables
        public String Usuario
        {
            set {
            if (value == "USUARIO")
                {
                    _Usuario = "Ingrese su Usuario por favor";
                }
                else
                {
                    _Usuario = value;
                }
                    }
            get { return _Usuario; }
        }

        public String Contraseña
        {
            set {if (value == "CONTRASEÑA")
                {
                    _Contraseña = "Ingrese su Contraseña";
                }
                else
                {
                    _Contraseña = value;
                }
            }
            get { return _Contraseña; }
        }

        // declaramos un contructor vacio
        public CNLogin() { }

        // funciones o metodos 

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.IniciarSesion(Usuario, Contraseña);
            return Loguear;
        }

    }
}
