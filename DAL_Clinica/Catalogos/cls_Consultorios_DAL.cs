using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class cls_Consultorios_DAL
    {
        private int _ID_Consultorio, _Numero;
        private bool _Estado;
        private string _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        public int ID_Consultorio { get => _ID_Consultorio; set => _ID_Consultorio = value; }
        public int Numero { get => _Numero; set => _Numero = value; }
        public  bool Estado { get => _Estado; set => _Estado = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
