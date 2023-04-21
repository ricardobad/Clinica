using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Padecimiento_DAL
    {

        private int _ID_Padecimiento, _ID_Doctor, _iIdPaciente;
        private string _sMsjError, _sDescripcion;
        private DataSet _dsPadecimientos;
        private bool _booEstado;
        private char _cIndAxn;   //Nuevo o Modificado



        public int ID_Padecimiento { get => _ID_Padecimiento; set => _ID_Padecimiento = value; }
        public int ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataSet dsPadecimientos { get => _dsPadecimientos; set => _dsPadecimientos = value; }
        public char cIndAxn { get => _cIndAxn; set => _cIndAxn = value; }
        public bool booEstado { get => _booEstado; set => _booEstado = value; }
        public int iIdPaciente { get => _iIdPaciente; set => _iIdPaciente = value; }
    }
}
