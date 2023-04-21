using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Clinica.Catalogos
{
    public class cls_Empleados_DAL
    {

        #region Privadas
        private byte _bTipo_ID, _bSexo,_bEstado;
        private string _sMsjError, _sID_Persona, _sNombre, _sPrimer_apellido, _sSegundo_apellido, _sFecha_nacimiento, _sTipoCliente,
            _sOtras_Guias, _sID_Canton, _sID_Distrito, _sID_Provincia, _sContrasena, _sTelefonoI, _sTelefonoII, _sCorreoI, _sCorreoII;
        private DataTable _dtDatos, _dtParametros;
        private int _iID_Direccion, _iRol_Activo;
        private string _sIdentificacion, _sNombreUser, _sRol_Descripcion;


        #endregion

        #region Publicas
        public byte bTipo_ID { get => _bTipo_ID; set => _bTipo_ID = value; }
        public byte bSexo { get => _bSexo; set => _bSexo = value; }
        public byte bEstado { get => _bEstado; set => _bEstado = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sID_Persona { get => _sID_Persona; set => _sID_Persona = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sPrimer_apellido { get => _sPrimer_apellido; set => _sPrimer_apellido = value; }
        public string sSegundo_apellido { get => _sSegundo_apellido; set => _sSegundo_apellido = value; }
        public string sFecha_nacimiento { get => _sFecha_nacimiento; set => _sFecha_nacimiento = value; }
        public string sTipoCliente { get => _sTipoCliente; set => _sTipoCliente = value; }
        public string sOtras_Guias { get => _sOtras_Guias; set => _sOtras_Guias = value; }
        public string sID_Canton { get => _sID_Canton; set => _sID_Canton = value; }
        public string sID_Distrito { get => _sID_Distrito; set => _sID_Distrito = value; }
        public string sID_Provincia { get => _sID_Provincia; set => _sID_Provincia = value; }
        public string sContrasena { get => _sContrasena; set => _sContrasena = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iID_Direccion { get => _iID_Direccion; set => _iID_Direccion = value; }
        public string sTelefonoI { get => _sTelefonoI; set => _sTelefonoI = value; }
        public string sTelefonoII { get => _sTelefonoII; set => _sTelefonoII = value; }
        public string sCorreoI { get => _sCorreoI; set => _sCorreoI = value; }
        public string sCorreoII { get => _sCorreoII; set => _sCorreoII = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public string sNombreUser { get => _sNombreUser; set => _sNombreUser = value; }
        public string sRol_Descripcion { get => _sRol_Descripcion; set => _sRol_Descripcion = value; }
        public int iRol_Activo { get => _iRol_Activo; set => _iRol_Activo = value; }



        #endregion

    }
}
