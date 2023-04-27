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
    public class cls_Especialidades_BLL
    {
        // declaracion de variales globlaes
        #region VARIABLES GLOBALES
        cls_Especialidades_DAL Obj_especialidades = new cls_Especialidades_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        ///comentar
        #endregion

        #region Metodos

        // ojo a este ref de abajo, que no se enrede con el de arriba
        public void listar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)
        {
            
            //aqui se llama el Store Procedure que esta en el APP.Config
            Obj_BD_DAL.sNomTabla = "tbl_Especialidades";
            Obj_BD_DAL.sNomSp = "dbo.SP_Listar_Especialidades";
            
            //aqui abajo se pone el nombrre de la tabla
            //Obj_BD_DAL.sNomTabla = "tbl_ESPECIALIDADES";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            Obj_especialidades_DAL.dsEspecialidades = Obj_BD_DAL.obj_ds;

            Obj_especialidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;

        }

       //De momento no hacer nada aca 
        public void eliminar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)
        {



            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["eliminar_especialidades"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Especialidad", "1", Obj_especialidades_DAL.ID_Especialidad);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_especialidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }

        public void insertar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL)
        {

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["insertar_especialidades"].ToString();

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

           // Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Especialidad", "7", Obj_especialidad_DAL.scedempleado);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Nombre", "7", Obj_especialidad_DAL.Nombre);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Estado", "9", Obj_especialidad_DAL.Estado);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Duracion_Aproximada", "6", Obj_especialidad_DAL.Estado);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            Obj_especialidad_DAL.sMsjError = Obj_BD_DAL.sMsjError;
        }
        //HASTA AQUI LLEGAMOS
        //public void modificar_especialidades(ref cls_Especialidades_DAL Obj_especialidad_DAL)
        //{

        //    Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["modificar_especialidades"].ToString();

        //    Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@CED_EMPLEADO", "7", Obj_especialidad_DAL.scedempleado);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@ESPECIALIDAD", "4", Obj_especialidad_DAL.sespecialidad);
        //    Obj_BD_DAL.obj_dtParametros.Rows.Add("@DEPARTAMENTO", "4", Obj_especialidad_DAL.sdepartamento);

        //    Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

        //    Obj_especialidad_DAL.sMsjError = Obj_BD_DAL.sMsjError;


        //}
        #endregion

    }
}
