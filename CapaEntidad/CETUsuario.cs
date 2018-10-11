using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class CETUsuario
    {
        private int _Id;
        private string _Rol;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }
       
    }
}
