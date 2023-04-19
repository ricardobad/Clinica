using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL_Clinica.BD
{
   public class cls_BD_II_DAL
    {
        #region Variables Privadas

        private SqlConnection _obj_SqlCnx; //objeto de conexion

        private SqlDataAdapter _obj_SqlDap;

        private SqlCommand _obj_SqlCmd;

        private DataSet _DsDatos;

        private DataTable _DtParametros;

        private string _sMsjError, _sNombreDataTable, _sNobreSP, _sValorScalar, _sIndAxn;

        #endregion



        #region Variables Publicas
        public SqlConnection obj_SqlCnx { get => _obj_SqlCnx; set => _obj_SqlCnx = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public SqlDataAdapter Obj_SqlDap { get => _obj_SqlDap; set => _obj_SqlDap = value; }
        public SqlCommand Obj_SqlCmd { get => _obj_SqlCmd; set => _obj_SqlCmd = value; }
        public string sNombreDataTable { get => _sNombreDataTable; set => _sNombreDataTable = value; }
        public string sNobreSP { get => _sNobreSP; set => _sNobreSP = value; }
        public DataSet dsDatos { get => _DsDatos; set => _DsDatos = value; }
        public DataTable dtParametros { get => _DtParametros; set => _DtParametros = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sIndAxn { get => _sIndAxn; set => _sIndAxn = value; }

        #endregion

    }
}
