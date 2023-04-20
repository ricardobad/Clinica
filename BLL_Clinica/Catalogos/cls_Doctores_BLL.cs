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
        public void Listar_Filtrar_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Doctores";

                if (Obj_Doctores_DAL.Carnet == string.Empty)
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


    }
}
