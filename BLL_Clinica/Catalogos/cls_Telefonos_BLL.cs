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
    public class cls_Telefonos_BLL
    {

        public void Modificar_Telefonos(ref cls_Telefonos_DAL Obj_Telefono_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Telefonos";


                Obj_BD_DAL.sNobreSP = "dbo.SP_MODIFICAR_TELEFONOS";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Telefono_DAL.sIdentificacion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Telefono_I", "7", Obj_Telefono_DAL.Telefono);
                Obj_BD_DAL.dtParametros.Rows.Add("@Telefono_II", "7", Obj_Telefono_DAL.telefono_II);

                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Telefono_DAL.dsTelefonos = Obj_BD_DAL.dsDatos;
                Obj_Telefono_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Telefono_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Crea_Telefonos(ref cls_Telefonos_DAL Obj_Telefono_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Telefonos";


                Obj_BD_DAL.sNobreSP = "dbo.SP_insertar_telefonos";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@Identificacion", "7", Obj_Telefono_DAL.sIdentificacion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Telefono_I", "7", Obj_Telefono_DAL.Telefono);
                Obj_BD_DAL.dtParametros.Rows.Add("@Telefono_II", "7", Obj_Telefono_DAL.telefono_II);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);


                Obj_Telefono_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Telefono_DAL.sMsjError = ex.Message.ToString().Trim();

            }


        }


        public void Filtrar_Telefonos(ref cls_Telefonos_DAL Obj_Telefono_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Telefonos";


                Obj_BD_DAL.sNobreSP = "dbo.SP_filtrar_telefonos";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@FILTRO", "7", Obj_Telefono_DAL.Telefono);


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Telefono_DAL.dsTelefonos = Obj_BD_DAL.dsDatos;
                Obj_Telefono_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Telefono_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }





    }

}
