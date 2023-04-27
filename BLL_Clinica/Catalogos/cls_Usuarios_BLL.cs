﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL_Clinica.BD;
using DAL_Clinica.BD;
using DAL_Clinica.Catalogos;
using DAL;
using System.Configuration;

namespace BLL_Clinica.Catalogos
{
    public class cls_Usuarios_BLL
    {
        public void Inicio_Sesion(ref cls_Usuario_DAL Obj_Usuarios_DAL)
        {

            try
            {
                cls_BD_II_DAL Obj_BD_DAL = new cls_BD_II_DAL();
                cls_BD_II_BLL Obj_BD_BLL = new cls_BD_II_BLL();

                Obj_BD_DAL.sNombreDataTable = "Inicio Sesion";


                Obj_BD_DAL.sNobreSP = "dbo.SP_Iniciar_Sesion";

                Obj_BD_BLL.CrearDTParametros(ref Obj_BD_DAL);

                Obj_BD_DAL.dtParametros.Rows.Add("@Identificacion", "7", Obj_Usuarios_DAL.sIdentificacion);
                Obj_BD_DAL.dtParametros.Rows.Add("@Contrasena", "7", Obj_Usuarios_DAL.Contraseña);

                Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

                Obj_Usuarios_DAL.dsUsuarios = Obj_BD_DAL.dsDatos;
                Obj_Usuarios_DAL.sMsjError = Obj_BD_DAL.sMsjError;



            }
            catch (Exception ex)
            {
                Obj_Usuarios_DAL.sMsjError = ex.Message.ToString().Trim();

            }

        }


    }
}