using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Usuario_DAL
    {

        private int _ID_Usuario;
        private string _sMsjError, _Nombre_Usuario, _Contraseña, _ID_Rol, _sIdentificacion;
        private DataTable _dtDatos, _dtParametros;

        private DataSet _dsUsuarios;


        public int ID_Usuario { get => _ID_Usuario; set => _ID_Usuario = value; }
        public string Nombre_Usuario { get => _Nombre_Usuario; set => _Nombre_Usuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string ID_Rol { get => _ID_Rol; set => _ID_Rol = value; }

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public DataSet dsUsuarios { get => _dsUsuarios; set => _dsUsuarios = value; }


    }
}
