using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Clinica.Catalogos
{
    public class cls_Consultorios_DAL
    {
        private char _cIndAxn;
        private int _ID_Consultorio, _iNumero, _iEstado;
        
        private string _sMsjError;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsConsultorios;

        public int ID_Consultorio { get => _ID_Consultorio; set => _ID_Consultorio = value; }
        public int iNumero { get => _iNumero; set => _iNumero = value; }
        public  int iEstado { get => _iEstado; set => _iEstado = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public DataSet DsConsultorios { get => _dsConsultorios; set => _dsConsultorios = value; }
        public char CIndAxn { get => _cIndAxn; set => _cIndAxn = value; }
    }
}
