using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class cls_Distritos_DAL
    {

        private string _sMsjError, _descripcion, _ID_Distrito;
        private DataTable _dtDatos, _dtParametros;

        public string ID_Distrito { get => _ID_Distrito; set => _ID_Distrito = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
