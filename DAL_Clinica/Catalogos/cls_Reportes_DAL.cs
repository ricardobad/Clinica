using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Reportes_DAL
    {

        private int _ID_Reporte, _ID_Especialidad, _ID_Paciente, _ID_Cita;
        private DateTime _FechaInicial, _FechaFinal;
        private string _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        public int ID_Cita { get => _ID_Cita; set => _ID_Cita = value; }
        public int ID_Paciente { get => _ID_Paciente; set => _ID_Paciente = value; }
        public int ID_Especialidad { get => _ID_Especialidad; set => _ID_Especialidad = value; }
        public int ID_Reporte { get => _ID_Reporte; set => _ID_Reporte = value; }
        public DateTime FechaInicial { get => _FechaInicial; set => _FechaInicial = value; }
        public DateTime FechaFinal { get => _FechaFinal; set => _FechaFinal = value; }
       public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
