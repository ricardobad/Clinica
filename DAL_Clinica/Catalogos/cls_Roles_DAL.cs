using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Clinica.Catalogos
{
    public class cls_Roles_DAL
    {
        #region VARIABLES PRIVADAS
        private char _cIndAxn;
        private string _sMsjError, _sDescripcion, _sIDRol;
        private int _iTipoLE, _iTipoES, _iEstado;//Lectura-Escritura
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsRoles;


        #endregion

        #region VARIABLES PUBLICAS

        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public char cIndAxn { get => _cIndAxn; set => _cIndAxn = value; }
        public DataSet dsRoles { get => _dsRoles; set => _dsRoles = value; }
        public int ITipoLE { get => _iTipoLE; set => _iTipoLE = value; }
        public string sIDRol { get => _sIDRol; set => _sIDRol = value; }
        public int iEstado { get => _iEstado; set => _iEstado = value; }
        public int ITipoES { get => _iTipoES; set => _iTipoES = value; }

        #endregion


    }
}
