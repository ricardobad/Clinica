using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Roles_DAL
    {

        private string _sMsjError, _ID_Rol, _Descripcion;
        private bool _Lectura, _Escritura;
        private DataTable _dtDatos, _dtParametros;

        public bool Lectura { get => _Lectura; set => _Lectura = value; }
        public bool Escritura { get => _Escritura; set => _Escritura = value; }
        public string ID_Rol { get => _ID_Rol; set => _ID_Rol = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
