using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Pacientes_DAL
    {

        private int _ID_Paciente, _ID_Usuario;
        private string _sMsjError, _Peso, _Altura, _Tipo_Sangre, _sIdentificacion;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsPacientes;
        public int ID_Paciente { get => _ID_Paciente; set => _ID_Paciente = value; }
        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string Peso { get => _Peso; set => _Peso = value; }
        public string Altura { get => _Altura; set => _Altura = value; }
        public string Tipo_Sangre { get => _Tipo_Sangre; set => _Tipo_Sangre = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public DataSet dsPacientes { get => _dsPacientes; set => _dsPacientes = value; }
    }
}
