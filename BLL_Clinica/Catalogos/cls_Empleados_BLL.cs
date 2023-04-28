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




        public void listar_Empleados(ref cls_Empleados_DAL Obj_EMPLEADOS_DAL)
        {

            //aqui se llama el Store Procedure que esta en el APP.Config


            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["listar_personas"].ToString();
         



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

        public void insertarEmpleado(ref cls_Empleados_DAL DAL_emple) {


           
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
                cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

                Obj_BD_DAL.sNomSp = "dbo.SP_INSERTAR_PERSONAS";

                Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

                // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Nombre", "7", DAL_emple.sNombre);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@primer_apellido", "7", DAL_emple.sPrimer_apellido);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@segundo_apellido", "7", DAL_emple.sSegundo_apellido);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Tipo_ID", "7", DAL_emple.B_TIPO_ID1);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Sexo", "7", DAL_emple.B_SEXO1);
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@fecha_nacimiento", "8", DAL_emple.sFecha_nacimiento);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("fecha_ingreso", "8", DateTime.Now);
                // saltamos fecha ingreso
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Estado", "7", DAL_emple.B_ESTADO1);
                
                Obj_BD_DAL.obj_dtParametros.Rows.Add("@Tipo_Persona", "7", DAL_emple.sTipoPersona);

                Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

                DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;


            
            



        }

        public void obtenerProvincia(ref cls_Empleados_DAL DAL_emple) {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            //primero obtiene el ID de Provincia de acuerdo al nombre para posterior insertarlo en la tabla Direcciones
          
            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["SP_FILTRAR_Provincias"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "7", DAL_emple.sID_Provincia);
            Obj_BD_DAL.sNomTabla = "T_Provincias";
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                DAL_emple.sMsjError = string.Empty;
                DAL_emple.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;
                DAL_emple.DtDatos = null;
            }


        }


        public void insertartelefonosEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "dbo.SP_insertar_telefonos";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Telefono_I", "7", DAL_emple.sTelefonoI);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Telefono_II", "7", DAL_emple.sTelefonoII);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }

        public void insertarCorreosEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "dbo.SP_INSERTAR_CORREOS";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Correo_I", "7", DAL_emple.sCorreoI);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Correo_II", "7", DAL_emple.sCorreoII);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }


        public void obtenerCanton(ref cls_Empleados_DAL DAL_emple)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            //primero obtiene el ID de Provincia de acuerdo al nombre para posterior insertarlo en la tabla Direcciones

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["SP_FILTRAR_Cantones"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "7", DAL_emple.sID_Canton);
            Obj_BD_DAL.sNomTabla = "T_Cantones";
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                DAL_emple.sMsjError = string.Empty;
                DAL_emple.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;
                DAL_emple.DtDatos = null;
            }


        }


        public void obtenerDistrito(ref cls_Empleados_DAL DAL_emple)
        {
            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            //primero obtiene el ID de Provincia de acuerdo al nombre para posterior insertarlo en la tabla Direcciones

            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["SP_FILTRAR_Distrito_EMPLEADOS"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Filtro", "7", DAL_emple.sID_Distrito);
            Obj_BD_DAL.sNomTabla = "T_DIstrito";
            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                DAL_emple.sMsjError = string.Empty;
                DAL_emple.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;
                DAL_emple.DtDatos = null;
            }


        }





        public void insertarUsuarioEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "dbo.SP_Insertar_usuario_empleado";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Nombre_usuario", "7", DAL_emple.sNombreUser);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Contraseña", "7", DAL_emple.sContrasena);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Rol", "7", DAL_emple.sRol_Descripcion);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }
        public void insertarDireccionesEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "dbo.SP_INSERTAR_DIRECCIONES";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Provincia", "7", DAL_emple.sID_Provincia);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Canton", "7", DAL_emple.sID_Canton);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Distrito", "7", DAL_emple.sID_Distrito);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Otras_guias", "7", DAL_emple.sOtras_Guias);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }


        public void modificarEmpleado(ref cls_Empleados_DAL DAL_emple) {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "SP_MODIFICAR_PERSONAS_EMPLEADOS";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Nombre", "7", DAL_emple.sNombre);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@primer_apellido", "7", DAL_emple.sPrimer_apellido);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@segundo_apellido", "7", DAL_emple.sSegundo_apellido);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Tipo_ID", "7", DAL_emple.B_TIPO_ID1);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Sexo", "7", DAL_emple.B_SEXO1);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@fecha_nacimiento", "8", DAL_emple.sFecha_nacimiento);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("fecha_ingreso", "8", DateTime.Now);
            // saltamos fecha ingreso
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Estado", "7", DAL_emple.B_ESTADO1);

            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Tipo_Persona", "7", DAL_emple.sTipoPersona);

            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;





        }

        public void modificartelefonosEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "SP_modificar_telefonos_EMPLEADOS";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Telefono_I", "7", DAL_emple.sTelefonoI);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Telefono_II", "7", DAL_emple.sTelefonoII);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }

        public void modificarCorreosEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "SP_MODIFICAR_CORREOS_EMPLEADOS";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Correo_I", "7", DAL_emple.sCorreoI);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Correo_II", "7", DAL_emple.sCorreoII);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }

        public void modificarDireccionesEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "SP_MODIFICAR_DIRECCION_EMPLEADOS";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Provincia", "7", DAL_emple.sID_Provincia);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Canton", "7", DAL_emple.sID_Canton);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Distrito", "7", DAL_emple.sID_Distrito);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Otras_guias", "7", DAL_emple.sOtras_Guias);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }

        public void modificarUsuarioEmpleado(ref cls_Empleados_DAL DAL_emple)
        {

            cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

            Obj_BD_DAL.sNomSp = "SP_Modificar_usuario_empleado";

            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);

            // Obj_BD_DAL.dtParametros.Rows.Add("@ID_Alergia", "1", Obj_Alergias_DAL.ID_Alergia); NO SE PONE PORQUE ES IDENTITY
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Nombre_usuario", "7", DAL_emple.sNombreUser);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Contraseña", "7", DAL_emple.sContrasena);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@ID_Rol", "7", DAL_emple.sRol_Descripcion);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@Identificacion", "7", DAL_emple.sIdentificacion);


            Obj_BD_BLL.ExecCommand(ref Obj_BD_DAL);

            DAL_emple.sMsjError = Obj_BD_DAL.sMsjError;

        }

    }
     




}


