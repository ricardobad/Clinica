using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Provincias_DAL
    {

        private string _sMsjError, _descripcion, _ID_Provincia;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsProvincias;

        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string iD_Provincia { get => _ID_Provincia; set => _ID_Provincia = value; }
        public DataSet dsProvincias { get => _dsProvincias; set => _dsProvincias = value; }
    }
}
