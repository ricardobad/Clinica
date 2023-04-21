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

                Obj_BD_DAL.sNomTabla = "tbl_CONSULTORIOS";

                if (Obj_Consultorios_DAL.iNumero == 0)
                {

                    Obj_BD_DAL.sNomSp = "dbo.SP_listar_consultorio";
                }
                else
                {
                    Obj_BD_DAL.sNomSp = "dbo.SP_filtrar_Consultorio";

                    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Consultorio", "VarChar", Obj_Consultorios_DAL.iNumero);

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


        public void Crear_Consultorios(ref cls_Consultorios_DAL Obj_Consultorios_DAL)
        {

            try
            {
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

                Obj_BD_DAL.sNomSp = "dbo.SP_insertar_consultorio";

                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                //Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Consultorio", "INT", Obj_Consultorios_DAL.ID_Consultorio);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Numero", "INT", Obj_Consultorios_DAL.iNumero);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Estado", "BIT", Obj_Consultorios_DAL.iEstado);

                Obj_BD_DAL.SIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Consultorios_DAL.DsConsultorios = Obj_BD_DAL.obj_ds;

                Obj_Consultorios_DAL.sMsjError = Obj_BD_DAL.sMsjError;

                if (Obj_Consultorios_DAL.sMsjError == string.Empty)
                {
                    Obj_Consultorios_DAL.CIndAxn = 'M';
                }
                else
                {
                    Obj_Consultorios_DAL.CIndAxn = 'N';
                }



            }
            catch (Exception ex)
            {

                Obj_Consultorios_DAL.CIndAxn = 'N';

                Obj_Consultorios_DAL.sMsjError = ex.Message.ToString().Trim();


            }




        }


        public void Modificar_Consultorios(ref cls_Consultorios_DAL Obj_Consultorios_DAL)
        {

            try
            {
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

                Obj_BD_DAL.sNomSp = "dbo.SP_modificar_consultorio";

                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Consultorio", "INT", Obj_Consultorios_DAL.ID_Consultorio);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Numero", "INT", Obj_Consultorios_DAL.iNumero);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Estado", "BIT", Obj_Consultorios_DAL.iEstado);

                Obj_BD_DAL.SIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Consultorios_DAL.DsConsultorios = Obj_BD_DAL.obj_ds;

                Obj_Consultorios_DAL.sMsjError = Obj_BD_DAL.sMsjError;

                Obj_Consultorios_DAL.CIndAxn = 'M';

            }
            catch (Exception ex)
            {

                Obj_Consultorios_DAL.CIndAxn = 'M';

                Obj_Consultorios_DAL.sMsjError = ex.Message.ToString().Trim();


            }

        }

    }
}
