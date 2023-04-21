using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Clinica.Catalogos
{
    public class cls_Telefonos_DAL
    {

        private string _sMsjError, _ID_Persona, _Telefono, _sIdentificacion, _Telefono_II;
        private DataTable _dtDatos, _dtParametros;
        private DataSet _dsTelefonos;
        public string ID_Persona { get => _ID_Persona; set => _ID_Persona = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public DataSet dsTelefonos { get => _dsTelefonos; set => _dsTelefonos = value; }
        public string telefono_II { get => _Telefono_II; set => _Telefono_II = value; }
    }
}
