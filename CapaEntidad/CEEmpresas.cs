using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaEntidad
{
    public class CEEmpresas
    {
        private string _RazonSocial;
        private string _NombreFantasia;
        private string _Ruc;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private PictureBox _Logo;
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public PictureBox Logo
        {
            get { return _Logo; }
            set { _Logo = value; }
        }

        public string Email
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

        public string Ruc
        {
            get { return _Ruc; }
            set { _Ruc = value; }
        }

        public string NombreFantasia
        {
            get { return _NombreFantasia; }
            set { _NombreFantasia = value; }
        }

        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
    }
}
