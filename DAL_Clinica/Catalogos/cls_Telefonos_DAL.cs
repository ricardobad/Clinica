using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Telefonos_DAL
    {

        private string _sMsjError, _ID_Persona, _Telefono;
        private DataTable _dtDatos, _dtParametros;

        public string ID_Persona { get => _ID_Persona; set => _ID_Persona = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
