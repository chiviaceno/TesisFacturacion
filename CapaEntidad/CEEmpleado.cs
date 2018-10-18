using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEEmpleado
    {
        private string _Nombre;
        private string _Apellido;
        private string _Cedula;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Estado;
        private int _Id;
        private int _Id_Empl;

        public int Id_Empl
        {
            get { return _Id_Empl; }
            set { _Id_Empl = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        } 
      
        public string  Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Dirrecion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        
    }
}

