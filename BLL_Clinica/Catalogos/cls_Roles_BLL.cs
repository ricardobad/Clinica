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
    public class cls_Roles_BLL
    {
        public void Listar_Filtrar_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {

            try
            {
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

                Obj_BD_DAL.sNomTabla = "tbl_ROLES";

                if (Obj_Roles_DAL.sDescripcion == null)
                {

                    Obj_BD_DAL.sNomSp = "dbo.SP_listar_roles";
                }
                else
                {
                    Obj_BD_DAL.sNomSp = "dbo.SP_filtrar_roles";

                    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Rol", "VarChar", Obj_Roles_DAL.sIDRol);

                }



                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Roles_DAL.dsRoles = Obj_BD_DAL.obj_ds;

                Obj_Roles_DAL.sMsjError = Obj_BD_DAL.sMsjError;


            }
            catch (Exception ex)
            {
                Obj_Roles_DAL.sMsjError = ex.Message.ToString().Trim();
            }

        }


        public void Crear_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {

            try
            {
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

                Obj_BD_DAL.sNomSp = "dbo.SP_insertar_roles";

                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                //Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Consultorio", "INT", Obj_Consultorios_DAL.ID_Consultorio);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Rol", "NVarChar", Obj_Roles_DAL.sIDRol);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Descripcion", "NVarChar", Obj_Roles_DAL.sDescripcion);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Lectura", "BIT", Obj_Roles_DAL.ITipoLE);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Escritura", "BIT", Obj_Roles_DAL.ITipoES);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Estado", "INT", Obj_Roles_DAL.iEstado);

                Obj_BD_DAL.SIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Roles_DAL.dsRoles = Obj_BD_DAL.obj_ds;

                Obj_Roles_DAL.sMsjError = Obj_BD_DAL.sMsjError;

                if (Obj_Roles_DAL.sMsjError == string.Empty)
                {
                    Obj_Roles_DAL.cIndAxn = 'M';
                }
                else
                {
                    Obj_Roles_DAL.cIndAxn = 'N';
                }



            }
            catch (Exception ex)
            {

                Obj_Roles_DAL.cIndAxn = 'N';

                Obj_Roles_DAL.sMsjError = ex.Message.ToString().Trim();


            }




        }


        public void Modificar_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {

            try
            {
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

                Obj_BD_DAL.sNomSp = "dbo.SP_modificar_roles";

                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Rol", "NVarChar", Obj_Roles_DAL.sIDRol);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Descripcion", "NVarChar", Obj_Roles_DAL.sDescripcion);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Lectura", "BIT", Obj_Roles_DAL.ITipoLE);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Escritura", "BIT", Obj_Roles_DAL.ITipoES);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Estado", "INT", Obj_Roles_DAL.iEstado);

                Obj_BD_DAL.SIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Roles_DAL.dsRoles = Obj_BD_DAL.obj_ds;

                Obj_Roles_DAL.sMsjError = Obj_BD_DAL.sMsjError;

                Obj_Roles_DAL.cIndAxn = 'M';

            }
            catch (Exception ex)
            {

                Obj_Roles_DAL.cIndAxn = 'M';

                Obj_Roles_DAL.sMsjError = ex.Message.ToString().Trim();


            }

        }
    }
}
