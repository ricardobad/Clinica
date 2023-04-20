using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Clinica.BD;
using DAL_Clinica.BD;
using DAL;
using System.Configuration;
using System.Data;

namespace BLL_Clinica.Catalogos
{
   public class cls_Adicciones_BLL
    {
        #region VARIABLES GLOBALES

        cls_Adicciones_DAL Obj_Adicciones = new cls_Adicciones_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        ///comentar
        #endregion

        public void listar_Adicciones (ref cls_Adicciones_DAL Obj_Adicciones)
        {

            //aqui se llama el Store Procedure que esta en el APP.Config

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_adicciones"].ToString();

            //aqui abajo se pone el nombrre de la tabla
            Obj_BD_DAL.sNomTabla = "T_ADICCIONES";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Adicciones.sMsjError = string.Empty;
                Obj_Adicciones.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_Adicciones.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Adicciones.DtDatos = null;
            }

        }

    }
}
