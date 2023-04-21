using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Clinica.Catalogos
{
    public class cls_Expedientes_DAL
    {
        private int _iIdCita;
        private string _sTelefono_I, _sTelefono_II, _sCorreo_I, _sCorreo_II, _sProvincia, _sCanton, _sDistrito, _sNombreCompleto, _sIdentificacion, _sDireccion;
        private string _sMsjError, _sDescripcion;
        private bool _booTipoIdentificacion;
        private DataSet _dsExpedientes;
        private bool _booEstado, _booSexo;

        public int iIdCita { get => _iIdCita; set => _iIdCita = value; }
        public string sTelefono_I { get => _sTelefono_I; set => _sTelefono_I = value; }
        public string sTelefono_II { get => _sTelefono_II; set => _sTelefono_II = value; }
        public string sCorreo_I { get => _sCorreo_I; set => _sCorreo_I = value; }
        public string sCorreo_II { get => _sCorreo_II; set => _sCorreo_II = value; }
        public string sProvincia { get => _sProvincia; set => _sProvincia = value; }
        public string sCanton { get => _sCanton; set => _sCanton = value; }
        public string sDistrito { get => _sDistrito; set => _sDistrito = value; }
        public string sNombreCompleto { get => _sNombreCompleto; set => _sNombreCompleto = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public bool bootipoIdentificacion { get => _booTipoIdentificacion; set => _booTipoIdentificacion = value; }
        public DataSet dsExpedientes { get => _dsExpedientes; set => _dsExpedientes = value; }
        public bool booEstado { get => _booEstado; set => _booEstado = value; }
        public bool booSexo { get => _booSexo; set => _booSexo = value; }
    }
}
