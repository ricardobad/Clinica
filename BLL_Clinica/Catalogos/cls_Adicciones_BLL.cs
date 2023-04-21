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
   public class cls_Adicciones_BLL
    {
        #region VARIABLES GLOBALES

        cls_Adicciones_DAL Obj_Adicciones_DAL = new cls_Adicciones_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        ///comentar
        #endregion





        public void listar_Adicciones(ref cls_Adicciones_DAL Obj_Adicciones_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "T_ADICCIONES";

                if (Obj_Adicciones_DAL.Descripcion == string.Empty)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.SP_listar_adicciones";

                    Obj_BD_DAL.dtParametros = null;



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_ADICCIONES";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@Filtro", "7", Obj_Adicciones_DAL.Descripcion);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Adicciones_DAL.dsAdicciones = Obj_BD_DAL.dsDatos;
                Obj_Adicciones_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Adicciones_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }



        public void Filtrar_Adicciones_Pacientes(ref cls_Adicciones_DAL Obj_Adicciones_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "T_ADICCIONES_PACIENTES";

                if (Obj_Adicciones_DAL.Descripcion == string.Empty)
                {

                    Obj_BD_DAL.sNobreSP = "dbo.SP_listar_adicciones";

                    Obj_BD_DAL.dtParametros = null;



                }
                else
                {
                    Obj_BD_DAL.sNobreSP = "dbo.SP_FILTRAR_ADICCIONES_PACIENTES";

                    Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                    Obj_BD_DAL.dtParametros.Rows.Add("@ID_Paciente", "1", Obj_Adicciones_DAL.iIdPaciente);
                }


                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Adicciones_DAL.dsAdicciones = Obj_BD_DAL.dsDatos;
                Obj_Adicciones_DAL.sMsjError = Obj_BD_DAL.sMsjError;




            }
            catch (Exception ex)
            {
                Obj_Adicciones_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }



        public void Modificar_Adicciones(ref cls_Adicciones_DAL Obj_Adicciones_DAL)
            {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_modificar_adicciones";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Adicciones", "1", Obj_Adicciones_DAL.ID_Adiccion);
                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Adicciones_DAL.ID_Doctor);
                Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Adicciones_DAL.Descripcion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Adicciones_DAL.booEstado);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Adicciones_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Adicciones_DAL.cIndAxn = 'M';

            }
            catch (Exception ex)
            {
                Obj_Adicciones_DAL.cIndAxn = 'M';
                Obj_Adicciones_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


        public void Insertar_Adicciones(ref cls_Adicciones_DAL Obj_Adicciones_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_insertar_adicciones";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Adicciones_DAL.ID_Doctor);
                Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Adicciones_DAL.Descripcion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Adicciones_DAL.booEstado);



                Obj_BD_DAL.sIndAxn = "IDENTITY";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Adicciones_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                if (Obj_Adicciones_DAL.sMsjError == string.Empty)
                {
                    Obj_Adicciones_DAL.ID_Adiccion = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
                    Obj_Adicciones_DAL.cIndAxn = 'M';
                }
                else
                {
                    Obj_Adicciones_DAL.cIndAxn = 'N';
                }


            }
            catch (Exception ex)
            {
                Obj_Adicciones_DAL.cIndAxn = 'N';
                Obj_Adicciones_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }



    
}
}
