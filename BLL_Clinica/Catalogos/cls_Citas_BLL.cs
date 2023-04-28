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
    public class cls_Citas_BLL
    {

        public void Listar_Filtrar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "CITAS";

                if (Obj_Citas_DAL.ID_Cita == 0)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.SP_Listar_Citas";

                    Obj_BD_DAL.dtParametros = null;



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_Filtrar_Citas";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "1", Obj_Citas_DAL.ID_Cita);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Citas_DAL.DtDatos = Obj_BD_DAL.dtParametros; //Fallo?
                Obj_Citas_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Citas_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }
        public void Listar_Filtrar_Cedula(ref cls_Pacientes_DAL Obj_Pacientes_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Pacientes";

                if (Obj_Pacientes_DAL.ID_Paciente == 0)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.SP_Listar_Citas";

                    Obj_BD_DAL.dtParametros = null;



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_Filtrar_Citas";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    //Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "1", Obj_Citas_DAL.ID_Cita);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                //Obj_Citas_DAL.DtDatos = Obj_BD_DAL.dtParametros; //Fallo?
                //Obj_Citas_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                //Obj_Citas_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Crear_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_Insertar_Citas";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Padecimiento", "1", Obj_Padecimientos_DAL.ID_Padecimiento); NO SE PONE PORQUE ES IDENTITY
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Citas_DAL.ID_Paciente);
                Obj_BD_DAL.dtParametros.Rows.Add("@FechaHoraInicio", "8", Convert.ToString(Obj_Citas_DAL.FechaHoraInicio));
                Obj_BD_DAL.dtParametros.Rows.Add("@EstadoCita", "13", Obj_Citas_DAL.EstadoCita);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Especialidad", "1", Obj_Citas_DAL.ID_Especialidad);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Consultorio", "1", Obj_Citas_DAL.ID_Consultorio);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Citas_DAL.ID_Doctor);




                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);
                Obj_Citas_DAL.DsDatos = Obj_BD_DAL.dsDatos;
                Obj_Citas_DAL.sMsjError = Obj_BD_DAL.sMsjError;

                if (Obj_Citas_DAL.sMsjError == string.Empty)
                {
                    Obj_Citas_DAL.cIndAxn = 'M';
                }
                else
                {
                    Obj_Citas_DAL.cIndAxn = 'N';
                }


            }
            catch (Exception ex)
            {
                Obj_Citas_DAL.cIndAxn = 'N';
                Obj_Citas_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

        public void Modificar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_Modificar__Citas";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Citas_DAL.ID_Paciente);
                Obj_BD_DAL.dtParametros.Rows.Add("@FechaHoraInicio", "8", Obj_Citas_DAL.FechaHoraInicio);
                Obj_BD_DAL.dtParametros.Rows.Add("@FechaHoraFin", "8", Obj_Citas_DAL.FechaHoraFin);
                Obj_BD_DAL.dtParametros.Rows.Add("@EstadoCita", "13", Obj_Citas_DAL.EstadoCita);
                Obj_BD_DAL.dtParametros.Rows.Add("@notasAdd", "7", Obj_Citas_DAL.NotasAdd);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Especialidad", "1", Obj_Citas_DAL.ID_Especialidad);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Consultorio", "1", Obj_Citas_DAL.ID_Consultorio);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Citas_DAL.ID_Doctor);
                Obj_BD_DAL.dtParametros.Rows.Add("@FechCreacionCita", "12", Obj_Citas_DAL.FechaCreacionCita);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Citas_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Citas_DAL.cIndAxn = 'M';

            }
            catch (Exception ex)
            {
                Obj_Citas_DAL.cIndAxn = 'M';
                Obj_Citas_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

        public void Eliminar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_Eliminar_Citas";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Cita", "1", Obj_Citas_DAL.ID_Cita);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Citas_DAL.sMsjError = Obj_BD_DAL.sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Citas_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }

    }

}
