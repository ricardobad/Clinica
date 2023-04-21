using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Personas_DAL
    {

        private int _ID_Direccion;
        private DateTime _fecha_nacimiento, _fecha_ingreso;
        private string _sMsjError, _ID_Persona, _Nombre, _primer_apellido, _segundo_apellido, _Identificacion, _TipoCliente;
        private bool _Tipo_ID, _Sexo, _Estado;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsPersonas;
        public int ID_Direccion { get => _ID_Direccion; set => _ID_Direccion = value; }
        public string ID_Persona { get => _ID_Persona; set => _ID_Persona = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string primer_apellido { get => _primer_apellido; set => _primer_apellido = value; }
        public string segundo_apellido { get => _segundo_apellido; set => _segundo_apellido = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string TipoCliente { get => _TipoCliente; set => _TipoCliente = value; }
        public bool Tipo_ID { get => _Tipo_ID; set => _Tipo_ID = value; }
        public bool Sexo { get => _Sexo; set => _Sexo = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public DateTime fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        public DateTime fecha_ingreso { get => _fecha_ingreso; set => _fecha_ingreso = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public DataSet dsPersonas { get => _dsPersonas; set => _dsPersonas = value; }
    }
}
