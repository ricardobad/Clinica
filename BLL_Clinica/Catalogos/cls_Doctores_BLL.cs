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
    public class cls_Doctores_BLL
    {
        cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
        cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();
        cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
        public void Listar_Filtrar_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {

            try
            {
                

                Obj_BD_DAL.sNombreDataTable = "tbl_DOCTORES";

                if (Obj_Doctores_DAL.Carnet == null)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.SP_LISTAR_DOCTORES";

                    Obj_BD_DAL.dtParametros = null;



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_DOCTORES";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Doctores_DAL.Carnet);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Doctores_DAL.dsDoctores = Obj_BD_DAL.dsDatos;
                Obj_Doctores_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Doctores_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }





        public void listarCarnetDoctores(ref cls_Doctores_DAL ObJ_DOCTORES_DAL) {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
            cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["combo_doctores"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
           
          

            Obj_BD_DAL.sNomTabla = "ComboDOCTORES";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Doctores_DAL.sMsjError = string.Empty;
                Obj_Doctores_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
                ObJ_DOCTORES_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Doctores_DAL.DtDatos = null;
            }
        }
    }
}
