﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Correos_DAL
    {

        private string _sMsjError, _ID_Persona, _Correo, _sIdentificacion, _Correo_II;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsCorreos;

        public string ID_Persona { get => _ID_Persona; set => _ID_Persona = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public DataSet dsCorreos { get => _dsCorreos; set => _dsCorreos = value; }
        public string correo_II { get => _Correo_II; set => _Correo_II = value; }
    }
}
