﻿using System;
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
    public class cls_Pacientes_BLL
    {

        #region VARIABLES GLOBALES
        cls_Pacientes_DAL Pacientes_DAL = new cls_Pacientes_DAL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        ///comentar
        #endregion


        public void listar_filtrar_Pacientes(ref cls_Pacientes_DAL Obj_PACIENTES_DAL)
        {

            if (Obj_PACIENTES_DAL.sIdentificacion == string.Empty)
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_pacientes"].ToString();
            }
            else
            {
                Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["filtrar_pacientes"].ToString();
                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "7", Obj_PACIENTES_DAL.sIdentificacion);
            }


            Obj_BD_DAL.sNomTabla = "T_PACIENTES";
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_PACIENTES_DAL.sMsjError = string.Empty;
                Obj_PACIENTES_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_PACIENTES_DAL.DtDatos = null;
            }

        }


        public void ModificarDatosPaciente(ref cls_Pacientes_DAL Obj_Pacientes_DAL)
        {
            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNobreSP = "dbo.SP_MODIFICAR_PACIENTE";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);


                Obj_BD_DAL.dtParametros.Rows.Add("@Peso", "7", Obj_Pacientes_DAL.Peso);
                Obj_BD_DAL.dtParametros.Rows.Add("@Altura", "7", Obj_Pacientes_DAL.Altura);
                Obj_BD_DAL.dtParametros.Rows.Add("@TipoSangre", "7", Obj_Pacientes_DAL.Tipo_Sangre);
                Obj_BD_DAL.dtParametros.Rows.Add("@Identificacion", "7", Obj_Pacientes_DAL.sIdentificacion);

                Obj_BD_DAL.sIndAxn = "NORMAL";

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                Obj_Pacientes_DAL.sMsjError = Obj_BD_DAL.sMsjError;

            }
            catch (Exception ex)
            {

                Obj_Pacientes_DAL.sMsjError = ex.Message.ToString().Trim();

            }
        }
    }
}
