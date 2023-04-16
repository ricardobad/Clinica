using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class cls_Padecimiento_DAL
    {

        private int _ID_Padecimiento, _ID_Doctor;
        private string _sMsjError, _Descripcion;
        private DataTable _dtDatos, _dtParametros;

        public int ID_Padecimiento { get => _ID_Padecimiento; set => _ID_Padecimiento = value; }
        public int ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
