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
    public class cls_Alergias_BLL
    {
        // declaracion de variales globlaes
        #region VARIABLES GLOBALES

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        ///comentar
        #endregion

        #region Metodos
        public void listar_alergias(ref cls_Alergias_DAL Obj_alergias_DAL)
        {
            //aqui se llama el Store Procedure que esta en el APP.Config

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_alergias"].ToString();

            //aqui abajo se pone el nombrre de la tabla
            Obj_BD_DAL.sNomTabla = "T_ALERGIAS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_alergias_DAL.sMsjError = string.Empty;
                Obj_alergias_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_alergias_DAL.DtDatos = null;
            }
        }







        public void Listar_Filtrar_Alergias(ref cls_Alergias_DAL Obj_Alergias_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "ALERGIAS";

                if (Obj_Alergias_DAL.Descripcion == string.Empty)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.Sp_Listar_Alergias";

                    Obj_BD_DAL.dtParametros = null;



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_ALERGIAS";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Alergias_DAL.Descripcion);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Alergias_DAL.dsAlergias = Obj_BD_DAL.dsDatos;
                Obj_Alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Alergias_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Filtrar_Alergias_Pacientes(ref cls_Alergias_DAL Obj_Alergias_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "ALERGIAS_PACIENTES";

                if (Obj_Alergias_DAL.Descripcion == string.Empty)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.SP_LISTAR_ALERGIAS_EXPEDIENTE";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Alergias_DAL.iIdPaciente);



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_ALERGIAS_PACIENTES";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Alergias_DAL.iIdPaciente);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Alergias_DAL.dsAlergias = Obj_BD_DAL.dsDatos;
                Obj_Alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Alergias_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Crear_Alergias(ref cls_Alergias_DAL Obj_Alergias_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.Sp_insertar_alergias";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Alergias_DAL.ID_Doctor);
                Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Alergias_DAL.Descripcion);
                //Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Alergias_DAL.bEstado);



                Obj_BD_DAL.sIndAxn = "IDENTITY";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                if (Obj_Alergias_DAL.sMsjError == string.Empty)
                {
                    Obj_Alergias_DAL.ID_Alergia = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
                    Obj_Alergias_DAL.cIndAxn = 'M';
                }
                else
                {
                    Obj_Alergias_DAL.cIndAxn = 'N';
                }


            }
            catch (Exception ex)
            {
                Obj_Alergias_DAL.cIndAxn = 'N';
                Obj_Alergias_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }



        public void Modificar_Alergias(ref cls_Alergias_DAL Obj_Alergias_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_MODIFICAR_ALERGIAS";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia);
                Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Alergias_DAL.Descripcion);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Alergias_DAL.ID_Doctor);
                // Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Alergias_DAL.bEstado);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Alergias_DAL.cIndAxn = 'M';

            }
            catch (Exception ex)
            {
                Obj_Alergias_DAL.cIndAxn = 'M';
                Obj_Alergias_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Modificar_Alergias_Pacientes(ref cls_Alergias_DAL Obj_Alergias_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "T_ALERGIAS_PACIENTES";


                Obj_BD_DAL.sNobreSP = "dbo.SP_MODIFICAR_ALERGIAS_PACIENTE";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Alergias_DAL.iIdPaciente);

                Obj_BD_DAL.dtParametros.Rows.Add("@Alergias", "7", Obj_Alergias_DAL.sAlergiasTotales);

                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Alergias_DAL.dsAlergias = Obj_BD_DAL.dsDatos;
                Obj_Alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Alergias_DAL.sMsjError = ex.Message.ToString().Trim();

            }
        }
        #endregion
    }
}
