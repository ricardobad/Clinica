using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Adicciones_DAL
    {

        private int _ID_Adiccion, _ID_Doctor, _iIdPaciente;
        private string _sMsjError, _Descripcion;
        private DataTable _dtDatos, _dtParametros;
        private char _cIndAxn;
        private bool _booEstado;

        private DataSet _dsAdicciones;
        public int ID_Adiccion { get => _ID_Adiccion; set => _ID_Adiccion = value; }
        public int ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public char cIndAxn { get => _cIndAxn; set => _cIndAxn = value; }
        public bool booEstado { get => _booEstado; set => _booEstado = value; }
        public DataSet dsAdicciones { get => _dsAdicciones; set => _dsAdicciones = value; }
        public int iIdPaciente { get => _iIdPaciente; set => _iIdPaciente = value; }
    }
}
