using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Clinica.BD;
using DAL_Clinica.BD;
using DAL;
using DAL_Clinica.Catalogos;
using System.Configuration;

namespace BLL_Clinica.Catalogos
{
    public class cls_Pacientes_BLL
    {

        #region VARIABLES GLOBALES
        cls_Pacientes_DAL Pacientes_DAL = new cls_Pacientes_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        ///comentar
        #endregion


        public void listar_filtrar_Pacientes(ref cls_Pacientes_DAL Obj_PACIENTES_DAL)
        {

            if (Obj_PACIENTES_DAL.sID_Persona == string.Empty)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_pacientes"].ToString();
            }
            else
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_pacientes"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "7", Obj_PACIENTES_DAL.sID_Persona);
            }


            Obj_BD_DAL.sNomTabla = "T_PACIENTES";
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_PACIENTES_DAL.sMsjError = string.Empty;
                Obj_PACIENTES_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_PACIENTES_DAL.DtDatos = null;
            }

        }
    }
}
