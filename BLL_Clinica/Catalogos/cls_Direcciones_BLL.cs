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
    public class cls_Direcciones_BLL
    {
        public void Listar_Direcciones(ref cls_Provincias_DAL Obj_Provincias_DAL, ref cls_Cantones_DAL Obj_Cantones_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "DIRECCIONES";


                if (Obj_Cantones_DAL.ID_Canton == ""){
                    Obj_BD_DAL.sNobreSP = "dbo.SP_LISTAR_DIRECCIONES";
                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_LISTAR_DISTRITOS";
                }
                

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Provincia", "6", Obj_Provincias_DAL.iD_Provincia);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Cantones", "6", Obj_Cantones_DAL.ID_Canton);






                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                if (Obj_Cantones_DAL.ID_Canton == "")
                {
                    Obj_Provincias_DAL.dsProvincias = Obj_BD_DAL.dsDatos;
                }
                else
                {
                    Obj_Cantones_DAL.dsCantones= Obj_BD_DAL.dsDatos;
                }

                
                Obj_Provincias_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Provincias_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }



        public void ModificarDireccion(ref cls_Direcciones_DAL Obj_Direcciones_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_MODIFICAR_DIRECCION";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Provincia", "1", Obj_Direcciones_DAL.ID_Provincia);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Canton", "6", Obj_Direcciones_DAL.ID_Canton);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Distrito", "6", Obj_Direcciones_DAL.ID_Distrito);
                Obj_BD_DAL.dtParametros.Rows.Add("@Otras_Guias", "6", Obj_Direcciones_DAL.Otras_Guias);
                Obj_BD_DAL.dtParametros.Rows.Add("@Identificacion", "7", Obj_Direcciones_DAL.sIdentificacion);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Direcciones_DAL.sMsjError = Obj_BD_DAL.sMsjError;
            }
            catch (Exception ex)
            {

                Obj_Direcciones_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }



        public void Crea_Direcciones(ref cls_Direcciones_DAL Obj_Direcciones_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Correos";


                Obj_BD_DAL.sNobreSP = "dbo.SP_INSERTAR_DIRECCIONES";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Provincia", "1", Obj_Direcciones_DAL.ID_Provincia);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Canton", "6", Obj_Direcciones_DAL.ID_Canton);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Distrito", "6", Obj_Direcciones_DAL.ID_Distrito);
                Obj_BD_DAL.dtParametros.Rows.Add("@Otras_Guias", "6", Obj_Direcciones_DAL.Otras_Guias);
                Obj_BD_DAL.dtParametros.Rows.Add("@Identificacion", "7", Obj_Direcciones_DAL.sIdentificacion);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);


                Obj_Direcciones_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Direcciones_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

       






    }
}
