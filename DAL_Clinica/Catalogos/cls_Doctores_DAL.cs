using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Doctores_DAL
    {

        private int _ID_Doctor;
        private string _sMsjError,  _Carnet, _ID_Usuario;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsDoctores;
        public int ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public string Carnet { get => _Carnet; set => _Carnet = value; }
        public string ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public DataSet dsDoctores { get => _dsDoctores; set => _dsDoctores = value; }
    }
}
