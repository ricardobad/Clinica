using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL_Clinica.BD;
using DAL_Clinica.BD;
using DAL;
using DAL_Clinica.Catalogos;
using System.Configuration;

namespace BLL_Clinica.Catalogos
{
    public class cls_Empleados_BLL
    {


        #region VARIABLES GLOBALES
        cls_Empleados_DAL EMPLEADOS_DAL = new cls_Empleados_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        ///comentar
        #endregion


        #region Metodos

        public void listar_Empleados(ref cls_Empleados_DAL Obj_EMPLEADOS_DAL)
        {

            //aqui se llama el Store Procedure que esta en el APP.Config


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_personas"].ToString();
            //   Obj_BD_DAL.sNomSpIII = ConfigurationManager.AppSettings["listar_correos"].ToString();
            //  Obj_BD_DAL.sNomSpIV = ConfigurationManager.AppSettings["listar_direcciones"].ToString();
            //  Obj_BD_DAL.sNomSpV = ConfigurationManager.AppSettings["listar_telefonos"].ToString();
            //  Obj_BD_DAL.sNomSpVI = ConfigurationManager.AppSettings["listar_distritos"].ToString();



            //aqui abajo se pone el nombrre de la tabla
            Obj_BD_DAL.sNomTabla = "T_Empleados";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_EMPLEADOS_DAL.sMsjError = string.Empty;
                Obj_EMPLEADOS_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                EMPLEADOS_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                EMPLEADOS_DAL.DtDatos = null;
            }

        }
        public void listar_filtrar_Empleados(ref cls_Empleados_DAL Obj_EMPLEADOS_DAL)
        {

            if (Obj_EMPLEADOS_DAL.sID_Persona == string.Empty)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_empleados"].ToString();
            }
            else
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_mant_empleados"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", Obj_EMPLEADOS_DAL.sID_Persona);
            }


            Obj_BD_DAL.sNomTabla = "T_PERSONAS";
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_EMPLEADOS_DAL.sMsjError = string.Empty;
                Obj_EMPLEADOS_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_EMPLEADOS_DAL.DtDatos = null;
            }
        }

        public void insertar_Empleados(ref cls_Empleados_DAL Obj_EMPLEADOS_DAL)
        {

            //    try
            //    {
            //        cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
            //        cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

            //        Obj_BD_DAL.sNobreSP = "dbo.Sp_insertar_empleados";

            //        Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

            //        // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            //        Obj_BD_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Alergias_DAL.ID_Doctor);
            //        Obj_BD_DAL.dtParametros.Rows.Add("@Descripcion", "7", Obj_Alergias_DAL.Descripcion);
            //        //Obj_BD_DAL.dtParametros.Rows.Add("@Estado", "9", Obj_Alergias_DAL.bEstado);



            //        Obj_BD_DAL.sIndAxn = "IDENTITY";

            //        Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            //        Obj_Alergias_DAL.sMsjError = Obj_BD_DAL.sMsjError;
            //        if (Obj_Alergias_DAL.sMsjError == string.Empty)
            //        {
            //            Obj_Alergias_DAL.ID_Alergia = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
            //            Obj_Alergias_DAL.cIndAxn = 'M';
            //        }
            //        else
            //        {
            //            Obj_Alergias_DAL.cIndAxn = 'N';
            //        }


            //    }
            //    catch (Exception ex)
            //    {
            //        Obj_Alergias_DAL.cIndAxn = 'N';
            //        Obj_Alergias_DAL.sMsjError = ex.Message.ToString().Trim();

            //    }

            //}
            #endregion
        }





    }
}

