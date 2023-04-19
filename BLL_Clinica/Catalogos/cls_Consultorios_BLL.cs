using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL_Clinica.Catalogos;
using DAL_Clinica.BD;
using BLL_Clinica.BD;

namespace BLL_Clinica.Catalogos
{
    public class cls_Consultorios_BLL
    {
        public void Listar_Filtrar_Consultorios(ref cls_Consultorios_DAL Obj_Consultorios_DAL)
        {

            try
            {
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

                Obj_BD_DAL.sNomTabla = "CONSULTORIOS";

                if (Obj_Consultorios_DAL.Numero == 0)
                {

                    Obj_BD_DAL.sNomSp = "dbo.SP_LISTAR_CONSULTORIOS";
                }
                else
                {
                    Obj_BD_DAL.sNomSp = "dbo.SP_FILTRAR_CONSULTORIOS";

                    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "VarChar", Obj_Consultorios_DAL.Numero);

                }



                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Consultorios_DAL.DsConsultorios = Obj_BD_DAL.obj_ds;

                Obj_Consultorios_DAL.sMsjError = Obj_BD_DAL.sMsjError;


            }
            catch (Exception ex)
            {
                Obj_Consultorios_DAL.sMsjError = ex.Message.ToString().Trim();
            }

        }
    }
}
