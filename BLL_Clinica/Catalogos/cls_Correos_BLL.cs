using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL_Clinica.BD;
using DAL_Clinica.BD;
using DAL_Clinica.Catalogos;
using DAL;
using System.Configuration;

namespace BLL_Clinica.Catalogos
{
    public class cls_Correos_BLL
    {
        public void Modificar_Correos(ref cls_Correos_DAL Obj_Correos_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Correos";


                Obj_BD_DAL.sNobreSP = "dbo.SP_MODIFICAR_CORREOS";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Correos_DAL.sIdentificacion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Correo_I", "7", Obj_Correos_DAL.Correo);
                Obj_BD_DAL.dtParametros.Rows.Add("@Correo_II", "7", Obj_Correos_DAL.correo_II);

                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Correos_DAL.dsCorreos = Obj_BD_DAL.dsDatos;
                Obj_Correos_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

        public void Crea_Correos(ref cls_Correos_DAL Obj_Correos_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Correos";


                Obj_BD_DAL.sNobreSP = "dbo.SP_INSERTAR_CORREOS";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@Identificacion", "7", Obj_Correos_DAL.sIdentificacion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Correo_I", "7", Obj_Correos_DAL.Correo);
                Obj_BD_DAL.dtParametros.Rows.Add("@Correo_II", "7", Obj_Correos_DAL.correo_II);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);


                Obj_Correos_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Filtrar_Correos(ref cls_Correos_DAL Obj_Correos_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Correos";


                Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_CORREOS";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Correos_DAL.Correo);


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Correos_DAL.dsCorreos = Obj_BD_DAL.dsDatos;
                Obj_Correos_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


    }
}
