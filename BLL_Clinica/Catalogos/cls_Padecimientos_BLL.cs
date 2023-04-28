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
    public class cls_Padecimientos_BLL
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

        public void Filtrar_Padecimientos_Pacientes(ref cls_Padecimiento_DAL Obj_Padecimientos_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "T_PADECIMIENTOS_PACIENTE";


                if (Obj_Padecimientos_DAL.sDescripcion == string.Empty)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.SP_LISTAR_PADECIMIENTOS_PACIENTE";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Padecimientos_DAL.iIdPaciente);



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_PADECIMIENTOS_PACIENTES";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Padecimientos_DAL.iIdPaciente);
                    Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Padecimientos_DAL.iIdPaciente);
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


        public void Crear_Padecimientos(ref cls_Padecimiento_DAL Obj_Padecimientos_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.Sp_insertar_Padecimiento";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);
                // la linea de abajo no se pone por que es el valor Identity de la tabla
                // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Padecimiento", "1", Obj_Padecimientos_DAL.ID_Padecimiento); NO SE PONE PORQUE ES IDENTITY
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Padecimientos_DAL.ID_Doctor);
                Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Padecimientos_DAL.sDescripcion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Padecimientos_DAL.booEstado);



                Obj_BD_DAL.sIndAxn = "IDENTITY";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Padecimientos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                if (Obj_Padecimientos_DAL.sMsjError == string.Empty)
                {
                    Obj_Padecimientos_DAL.ID_Padecimiento = Convert.ToInt32(Obj_BD_DAL.sValorScalar);

                }
                else
                {
                }


            }
            catch (Exception ex)
            {
                Obj_Padecimientos_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

        public void Modificar_Padecimientos(ref cls_Padecimiento_DAL Obj_Padecimientos_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.Sp_Modificar__Padecimiento";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Padecimiento", "1", Obj_Padecimientos_DAL.ID_Padecimiento);
                Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Padecimientos_DAL.sDescripcion);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Padecimientos_DAL.ID_Doctor);
                Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Padecimientos_DAL.booEstado);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Padecimientos_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Padecimientos_DAL.cIndAxn = 'M';

            }
            catch (Exception ex)
            {
                Obj_Padecimientos_DAL.cIndAxn = 'M';
                Obj_Padecimientos_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Modificar_Padecimientos_Pacientes(ref cls_Padecimiento_DAL Obj_Padecimientos_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "T_Padecimientos_PACIENTES";


                Obj_BD_DAL.sNobreSP = "dbo.SP_MODIFICAR_PADECIMIENTOS_PACIENTE";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Padecimientos_DAL.iIdPaciente);

                Obj_BD_DAL.dtParametros.Rows.Add("@Padecimientos", "7", Obj_Padecimientos_DAL.sPadecimientosTotales);

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

