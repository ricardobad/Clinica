using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Citas_DAL
    {

        private int _ID_Cita, _ID_Paciente, _ID_Especialidad, _ID_Consultorio, _ID_Doctor;
        private short _EstadoCita;
        private string _sMsjError, _NotasAdd;
        private DateTime _FechaHoraInicio, _FechaHoraFin, _FechaCreacionCita;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsDatos;
        private char _cIndAxn;   //Nuevo o Modificado

        public int ID_Cita { get => _ID_Cita; set => _ID_Cita = value; }
        public int ID_Paciente { get => _ID_Paciente; set => _ID_Paciente = value; }
        public int ID_Especialidad { get => _ID_Especialidad; set => _ID_Especialidad = value; }
        public int ID_Consultorio { get => _ID_Consultorio; set => _ID_Consultorio = value; }
        public int ID_Doctor { get => _ID_Doctor; set => _ID_Doctor = value; }
        public short EstadoCita { get => _EstadoCita; set => _EstadoCita = value; }
        public string NotasAdd { get => _NotasAdd; set => _NotasAdd = value; }
        public DateTime FechaHoraInicio { get => _FechaHoraInicio; set => _FechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => _FechaHoraFin; set => _FechaHoraFin = value; }
        public DateTime FechaCreacionCita { get => _FechaCreacionCita; set => _FechaCreacionCita = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public char cIndAxn { get => _cIndAxn; set => _cIndAxn = value; }
        public DataSet DsDatos { get => _dsDatos; set => _dsDatos = value; }
    }
}
