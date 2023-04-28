using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Direcciones_DAL
    {

        private int _ID_Direccion;
        private string _sMsjError, _ID_Provincia, _ID_Canton, _ID_Distrito, _Otras_Guias, _sIdentificacion;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsDirecciones;
        public int ID_Direccion { get => _ID_Direccion; set => _ID_Direccion = value; }
        public string ID_Provincia { get => _ID_Provincia; set => _ID_Provincia = value; }
        public string ID_Canton { get => _ID_Canton; set => _ID_Canton = value; }
        public string ID_Distrito { get => _ID_Distrito; set => _ID_Distrito = value; }
        public string Otras_Guias { get => _Otras_Guias; set => _Otras_Guias = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public DataSet dsDirecciones { get => _dsDirecciones; set => _dsDirecciones = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
    }
}
