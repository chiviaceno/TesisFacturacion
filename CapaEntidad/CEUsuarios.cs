﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEUsuarios
    {
        private int _Id;
        private string _Tipo;
        private int _Empl_Id;
        private string _Usuario;
        private string _Password;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public int Empl_Id
        {
            get { return _Empl_Id; }
            set { _Empl_Id = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
}
