using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Especialidades_DAL
    {

        private int _ID_Especialidad;
        private bool _Estado;
        private string _sMsjError, _Nombre, _Duracion_Aproximada;
        private DataTable _dtDatos, _dtParametros;

        public int ID_Especialidad { get => _ID_Especialidad; set => _ID_Especialidad = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Duracion_Aproximada { get => _Duracion_Aproximada; set => _Duracion_Aproximada = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
