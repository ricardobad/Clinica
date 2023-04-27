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
    public class cls_Expedientes_BLL
    {


        public void Listar_Filtrar_InfoPersona(ref cls_Personas_DAL Obj_Personas_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Personas";


                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_EMPLEADOS";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@Identificacion", "7", Obj_Personas_DAL.Identificacion);

                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Personas_DAL.dsPersonas = Obj_BD_DAL.dsDatos;
                

                if((Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0])["Nombre"] == null)
                {
                    Obj_Personas_DAL.sMsjError = "No se encontró a la persona en el sistema";
                }

                Obj_Personas_DAL.sMsjError = Obj_BD_DAL.sMsjError;


            }
            catch (Exception ex)
            {
                Obj_Personas_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

        //public void Crear_Padecimientos(ref cls_Expedientes_DAL Obj_Expedientes_DAL)
        //{
        //    try
        //    {
        //        cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
        //        cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

        //        Obj_BD_DAL.sNobreSP = "dbo.SP_INSERTAR_EXPEDIENTE";

        //        Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

        //        // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Padecimiento", "1", Obj_Padecimientos_DAL.ID_Padecimiento); NO SE PONE PORQUE ES IDENTITY
        //        Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Expedientes_DAL.ID_Doctor);
        //        Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Expedientes_DAL.sDescripcion);
        //        Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Expedientes_DAL.booEstado);



        //        Obj_BD_DAL.sIndAxn = "IDENTITY";

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_Expedientes_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        if (Obj_Expedientes_DAL.sMsjError == string.Empty)
        //        {
        //            Obj_Expedientes_DAL.ID_Padecimiento = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
        //            Obj_Expedientes_DAL.cIndAxn = 'M';
        //        }
        //        else
        //        {
        //            Obj_Expedientes_DAL.cIndAxn = 'N';
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        Obj_Expedientes_DAL.cIndAxn = 'N';
        //        Obj_Expedientes_DAL.sMsjError = ex.Message.ToString().Trim();

        //    }

        //}

        //public void Modificar_Padecimientos(ref cls_Expedientes_DAL Obj_Padecimientos_DAL)
        //{
        //    try
        //    {
        //        cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
        //        cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

        //        Obj_BD_DAL.sNobreSP = "dbo.Sp_Modificar__Padecimiento";

        //        Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

        //        Obj_BD_DAL.dtParametros.Rows.Add("@ID_Padecimiento", "1", Obj_Padecimientos_DAL.ID_Padecimiento);
        //        Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Padecimientos_DAL.sDescripcion);
        //        Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Padecimientos_DAL.ID_Doctor);
        //        Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Padecimientos_DAL.booEstado);

        //        Obj_BD_DAL.sIndAxn = "NORMAL";

        //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //        Obj_Padecimientos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        //        Obj_Padecimientos_DAL.cIndAxn = 'M';

        //    }
        //    catch (Exception ex)
        //    {
        //        Obj_Padecimientos_DAL.cIndAxn = 'M';
        //        Obj_Padecimientos_DAL.sMsjError = ex.Message.ToString().Trim();

        //    }

        //}


    }
}
