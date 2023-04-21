using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Alergias_DAL
    {

        private int _ID_Alergia, _ID_Doctor;
        private string _sMsjError, _Descripcion;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsAlergias;
        private bool _bEstado;
        private char _cIndAxn;   //Nuevo o Modificado

        public int ID_Alergia { get => _ID_Alergia; set => _ID_Alergia = value; }
        public int ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public DataSet dsAlergias { get => _dsAlergias; set => _dsAlergias = value; }
        public char cIndAxn { get => _cIndAxn; set => _cIndAxn = value; }
        public bool bEstado { get => _bEstado; set => _bEstado = value; }
    }
}
