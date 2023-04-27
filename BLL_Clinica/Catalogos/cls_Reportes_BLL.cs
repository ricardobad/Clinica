using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL_Clinica;
using System.Data.SqlClient;

namespace BLL_Clinica.Catalogos
{
    public class cls_Reportes_BLL
    {


        public void Listar_Filtrar_Padecimientos(ref cls_Padecimiento_DAL Obj_Padecimientos_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "PADECIMIENTOS";

                if (Obj_Padecimientos_DAL.sDescripcion == string.Empty)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.Sp_Listar_Padecimiento";

                    Obj_BD_DAL.dtParametros = null;



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_PADECIMIENTOS";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Padecimientos_DAL.sDescripcion);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Padecimientos_DAL.dsPadecimientos = Obj_BD_DAL.dsDatos;
                Obj_Padecimientos_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Padecimientos_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

    }
}
