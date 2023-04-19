﻿using System;
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

        #region VARIABLES GLOBALES
        cls_Especialidades_DAL Obj_especialidades = new cls_Especialidades_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        ///comentar
        #endregion

        #region Metodos
        public void listar_filtrar_especialidades(ref cls_Especialidades_DAL Obj_especidades_DAL)
        {


            if (Obj_especidades_DAL.ID_Especialidad == 0)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_especialidades"].ToString();

            }
            else
            {

                //Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_especialidades"].ToString();
                //Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
                //Obj_BD_DAL.obj_dtParametros.Rows.Add("@FILTRO", "5", Obj_especidades_DAL.sespecialidad);

            }

            Obj_BD_DAL.sNomTabla = "T_ESPECIALIDADES";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_especidades_DAL.sMsjError = string.Empty;
                Obj_especidades_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_especidades_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_especidades_DAL.DtDatos = null;
            }
        }

        public void listar_especialidades(ref cls_Especialidades_DAL Obj_especialidades_DAL)
        {



            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_especialidades"].ToString();

            Obj_BD_DAL.sNomTabla = "T_ESPECIALIDADES";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_especialidades_DAL.sMsjError = string.Empty;
                Obj_especialidades_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_especialidades.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_especialidades.DtDatos = null;
            }

        }

       
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
