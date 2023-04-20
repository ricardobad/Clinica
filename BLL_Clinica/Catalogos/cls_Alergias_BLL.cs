using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL_Clinica.BD;
using DAL_Clinica.BD;
using DAL;
using System.Configuration;


namespace BLL_Clinica.Catalogos
{
    public class cls_Alergias_BLL
    {
        // declaracion de variales globlaes
        #region VARIABLES GLOBALES

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        ///comentar
        #endregion

        #region Metodos
        public void listar_alergias(ref cls_Alergias_DAL Obj_alergias_DAL)
        {
            //aqui se llama el Store Procedure que esta en el APP.Config

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_alergias"].ToString();

            //aqui abajo se pone el nombrre de la tabla
            Obj_BD_DAL.sNomTabla = "T_ALERGIAS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_alergias_DAL.sMsjError = string.Empty;
                Obj_alergias_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_alergias_DAL.DtDatos = null;
            }
        }
        #endregion
    }
}
