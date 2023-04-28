using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Cantones_DAL
    {

        private string _sMsjError, _descripcion, _ID_Canton;
        private DataTable _dtDatos, _dtParametros;

        private DataSet _dsCantones;

        public string ID_Canton { get => _ID_Canton; set => _ID_Canton = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }


        public DataSet dsCantones { get => _dsCantones; set => _dsCantones = value; }
    }
}
