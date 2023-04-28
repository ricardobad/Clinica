using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Clinica.BD;
using BLL_Clinica.BD;
using DAL;
using DAL_Clinica.Catalogos;
using BLL_Clinica.Catalogos;
namespace UI_CLINICA.Ventanas.Mantenimiento
{
    public partial class frm_mantenimientoempleado : Form
    {
        #region VARIABLES GLOBALES

        public cls_Empleados_DAL Obj_Empleados_Recibe_DAL;

        cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();
        public cls_Personas_DAL Obj_Personas_DAL;
        public cls_Provincias_DAL Obj_Provincias_DAL = new cls_Provincias_DAL();
        #endregion

        public frm_mantenimientoempleado()
        {
            InitializeComponent();
        }

        private void frm_mantenimientoempleado_Load(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            CargarDatos_II();



            cmb_Canton.SelectedIndex = 0;
            cmb_Provincia.SelectedIndex = 1;
            CargarComboCanton();
            CargarComboDistrito();
            CargarComboRoles();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        #region Metodos

        private void CargarDatos_II()
        {



            Obj_Empleados_DAL.sID_Persona = txt_busqueda.Text.Trim().ToString();
            Obj_Empleados_BLL.listar_filtrar_Empleados(ref Obj_Empleados_DAL);


            if (Obj_Empleados_DAL.sMsjError == string.Empty)
            {
                dgv_Empleados.DataSource = null;
                dgv_Empleados.DataSource = Obj_Empleados_DAL.DtDatos;



            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos" + Obj_Empleados_DAL.sMsjError, "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CargarComboDistrito()
        {
            cls_Cantones_DAL Obj_Cantones_DAL = new cls_Cantones_DAL();
            cls_Direcciones_BLL Obj_Direcciones_BLL = new cls_Direcciones_BLL();
            cmb_Distrito.DataSource = null;

            Obj_Cantones_DAL.ID_Canton = Obj_Provincias_DAL.dsProvincias.Tables["DIRECCIONES"].Rows[cmb_Canton.SelectedIndex]["ID_Canton"].ToString().Trim();



            Obj_Provincias_DAL.iD_Provincia = (cmb_Provincia.SelectedIndex + 1).ToString().Trim(); //CMB EMPIEZA EN 0 ENTONCES, EL ID PROVINCIA 0 NO EXISTE ENTONCES SE LE SUMA 1

            Obj_Direcciones_BLL.Listar_Direcciones(ref Obj_Provincias_DAL, ref Obj_Cantones_DAL);

            if (Obj_Provincias_DAL.sMsjError == string.Empty)
            {

                cmb_Distrito.DisplayMember = "DISTRITO";
                cmb_Distrito.ValueMember = "ID_Provincia";
                cmb_Distrito.DataSource = Obj_Cantones_DAL.dsCantones.Tables[0];



            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de la dirección .Error = [ " +
                                Obj_Provincias_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void CargarComboCanton()
        {
            Obj_Provincias_DAL = new cls_Provincias_DAL();

            cls_Direcciones_BLL Obj_Direcciones_BLL = new cls_Direcciones_BLL();
            cls_Cantones_DAL Obj_Cantones_DAL = new cls_Cantones_DAL();
            cmb_Provincia.DataSource = null;
            cmb_Canton.DataSource = null;
            cmb_Distrito.DataSource = null;
            Obj_Cantones_DAL.ID_Canton = "";

            Obj_Provincias_DAL.iD_Provincia = (cmb_Provincia.SelectedIndex + 1).ToString().Trim(); //CMB EMPIEZA EN 0 ENTONCES, EL ID PROVINCIA 0 NO EXISTE ENTONCES SE LE SUMA 1
            Obj_Direcciones_BLL.Listar_Direcciones(ref Obj_Provincias_DAL, ref Obj_Cantones_DAL);

            if (Obj_Provincias_DAL.sMsjError == string.Empty)
            {

                cmb_Canton.DisplayMember = "CANTONES";
                cmb_Canton.ValueMember = "ID_Provincia";
                cmb_Canton.DataSource = Obj_Provincias_DAL.dsProvincias.Tables[0];



            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de la dirección .Error = [ " +
                                Obj_Provincias_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        #endregion

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            //aqui va el llamado al filtro        
            CargarDatos_II();

        }



        #region MEtodos

        private void CargarCombox()
        {
            Obj_Empleados_BLL.listar_filtrar_Empleados(ref Obj_Empleados_DAL);
            Obj_Empleados_DAL.DtDatos.Rows.Add("--- Seleccione una Sexo ---");


            cmb_Sexo.DataSource = null;

            //  cmb_Sexo.DataSource = Obj_Empleados_DAL.bSexo;

            //   cmb_Sexo.DisplayMember = "Sexo";
            //   cmb_Sexo.ValueMember = "Sexo";
        }


        #endregion
        private void btn_Cargar_Click(object sender, EventArgs e)
        {





            if (dgv_Empleados.Rows.Count > 0)
            {
                if (MessageBox.Show("Desea realmente editar el Empleado [ " + dgv_Empleados.SelectedRows[0].Cells[0].Value.ToString().Trim() + " "
                    + dgv_Empleados.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                        "Información o Alerta",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Obj_Empleados_DAL.sID_Provincia = dgv_Empleados.SelectedRows[0].Cells[9].Value.ToString().Trim();
                    Obj_Empleados_DAL.sID_Provincia = Convert.ToString(Convert.ToInt32(Obj_Empleados_DAL.sID_Provincia) - 1);

                    Obj_Empleados_DAL.sID_Canton = dgv_Empleados.SelectedRows[0].Cells[10].Value.ToString().Trim();
                    Obj_Empleados_DAL.sID_Distrito = dgv_Empleados.SelectedRows[0].Cells[11].Value.ToString().Trim();
                    Obj_Empleados_DAL.sNombre = dgv_Empleados.SelectedRows[0].Cells[0].Value.ToString().Trim();//id
                    Obj_Empleados_DAL.sPrimer_apellido = dgv_Empleados.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    Obj_Empleados_DAL.sSegundo_apellido = dgv_Empleados.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    Obj_Empleados_DAL.bTipo_ID = Convert.ToByte(dgv_Empleados.SelectedRows[0].Cells[3].Value);
                    Obj_Empleados_DAL.bSexo = Convert.ToByte(dgv_Empleados.SelectedRows[0].Cells[4].Value);
                    Obj_Empleados_DAL.sFecha_nacimiento = dgv_Empleados.SelectedRows[0].Cells[5].Value.ToString().Trim();
                    Obj_Empleados_DAL.sIdentificacion = dgv_Empleados.SelectedRows[0].Cells[6].Value.ToString().Trim();
                    Obj_Empleados_DAL.bEstado = Convert.ToByte(dgv_Empleados.SelectedRows[0].Cells[7].Value);
                    // Obj_Empleados_DAL.sID_Provincia = dgv_Empleados.SelectedRows[0].Cells[8].Value.ToString().Trim();
                    Obj_Empleados_DAL.sOtras_Guias = dgv_Empleados.SelectedRows[0].Cells[8].Value.ToString().Trim();

                    // Obj_Empleados_DAL.sID_Canton = dgv_Empleados.SelectedRows[0].Cells[10].Value.ToString().Trim();
                    // Obj_Empleados_DAL.sID_Distrito= dgv_Empleados.SelectedRows[0].Cells[11].Value.ToString().Trim();
                    Obj_Empleados_DAL.sTelefonoI = dgv_Empleados.SelectedRows[0].Cells[12].Value.ToString().Trim();
                    Obj_Empleados_DAL.sTelefonoII = dgv_Empleados.SelectedRows[0].Cells[13].Value.ToString().Trim();
                    Obj_Empleados_DAL.sCorreoI = dgv_Empleados.SelectedRows[0].Cells[14].Value.ToString().Trim();
                    Obj_Empleados_DAL.sCorreoII = dgv_Empleados.SelectedRows[0].Cells[15].Value.ToString().Trim();
                    Obj_Empleados_DAL.sNombreUser = dgv_Empleados.SelectedRows[0].Cells[16].Value.ToString().Trim();
                    //// Obj_Empleados_DAL.sContrasena = dgv_Empleados.SelectedRows[0].Cells[17].Value.ToString().Trim();
                    Obj_Empleados_DAL.sRol_Descripcion = dgv_Empleados.SelectedRows[0].Cells[17].Value.ToString().Trim();



                    txt_Nombre.Text = Obj_Empleados_DAL.sNombre.ToString().Trim();    //Pone el ID en el txt correspondiente
                    txt_Apellido_I.Text = Obj_Empleados_DAL.sPrimer_apellido.Trim();   //Pone el nombre en el txt correspondiente
                    txt_Apellido_II.Text = Obj_Empleados_DAL.sSegundo_apellido.Trim();
                    txt_Identificacion.Text = Obj_Empleados_DAL.sIdentificacion.Trim();
                    dtp_FechaNacimiento.Value = DateTime.Parse(Obj_Empleados_DAL.sFecha_nacimiento);
                    txt_Otras_Guias.Text = Obj_Empleados_DAL.sOtras_Guias.Trim();
                    cmb_Provincia.SelectedIndex = Convert.ToInt32(Obj_Empleados_DAL.sID_Provincia);
                   
                    CargarComboCanton();


                    //DESPUES DE CARGAR CANTONES EN BASE A LA PROVINCIA, VA A BUSCAR EL CANTÓN DE LA PERSONA Y LO COLOCA EN EL INDEX

                    int indiceItem = cmb_Canton.FindStringExact(Obj_Empleados_DAL.sID_Canton);

                    cmb_Canton.SelectedIndex = indiceItem;


                    CargarComboDistrito();

                    cmb_Distrito.SelectedIndex = Convert.ToInt32(Obj_Empleados_DAL.sID_Distrito) - 1;

                    txt_Telefono_I.Text = Obj_Empleados_DAL.sTelefonoI.Trim();
                    txt_Telefono_II.Text = Obj_Empleados_DAL.sTelefonoII.Trim();
                    txt_Correo_I.Text = Obj_Empleados_DAL.sCorreoI.Trim();
                    txt_Correo_I.Text = Obj_Empleados_DAL.sCorreoI.Trim();
                    txtx_Nomb_Usuario.Text = Obj_Empleados_DAL.sNombreUser.Trim();
                   
                    cmb_Rol.Text = Obj_Empleados_DAL.sRol_Descripcion.Trim();

                    //rellena combo de estado
                    if (Obj_Empleados_DAL.bEstado == 1)
                    {

                        cmb_Estado_Empleado.Text = "Activo";

                    }

                    else
                    {

                        cmb_Estado_Empleado.Text = "Inactivo";
                    }

                    // rellena combo de Sexo
                    if (Obj_Empleados_DAL.bSexo == 1) {
                        cmb_Sexo.Text = "Masculino";

                    }
                    else {

                        cmb_Sexo.Text = "Femenino";
                    }

                    //rellena combo de tipo de cedula

                    if (Obj_Empleados_DAL.bTipo_ID == 0)
                    {

                        cmb_Tipo_ID.Text = "Nacional";
                    }
                    else {

                        cmb_Tipo_ID.Text = "Extranjero";
                    }


                     CargarComboRoles();
                    tbControl1.SelectedTab = tabPage1;
                    //  int indiceItem = cmb_Canton.FindStringExact(Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0]["Nombre_Canton"].ToString().Trim());




                }
            }
            else
            {
                MessageBox.Show("No tiene persona elegida para Editar",
                                 "Información o Alerta",
                                 MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

            }



        }

        private void CargarComboRoles() {
            cls_Roles_BLL rolesBLL = new cls_Roles_BLL();
            cls_Roles_DAL rolesDAL = new cls_Roles_DAL();

            rolesBLL.Listar_Filtrar_Roles(ref rolesDAL);
            cmb_Rol.DataSource = null;
            cmb_Rol.ValueMember = "ID_Rol";
            cmb_Rol.DisplayMember = "ID_Rol";
           
            cmb_Rol.DataSource = rolesDAL.dtDatos;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {//LIMPIAR
            txt_Nombre.Text = string.Empty;
            txt_Apellido_I.Text = string.Empty;
            txt_Apellido_II.Text = string.Empty;
            txt_Identificacion.Text = string.Empty;
            dtp_FechaNacimiento.Value = DateTime.Now;
            txt_Otras_Guias.Text = string.Empty;
            cmb_Provincia.Text = string.Empty; ;
            cmb_Canton.Text = string.Empty;
            cmb_Distrito.Text = string.Empty;
            txt_Telefono_I.Text = string.Empty;
            txt_Telefono_II.Text = string.Empty;
            txt_Correo_I.Text = string.Empty;
            txt_Correo_I.Text = string.Empty;
            cmb_Tipo_ID.Text = string.Empty;
            cmb_Sexo.Text = string.Empty;
            cmb_Estado_Empleado.Text = string.Empty;
            txtx_Nomb_Usuario.Text = string.Empty;
            txt_Contrasena.Text = string.Empty;
            cmb_Rol.Text = string.Empty;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //if (txt_Nombre.Text == string.Empty || txt_Apellido_I.Text == string.Empty ||
            //txt_Apellido_II.Text == string.Empty || txt_Identificacion.Text == string.Empty ||
            //txt_Otras_Guias.Text == string.Empty || cmb_Provincia.Text == string.Empty ||
            //cmb_Canton.Text == string.Empty || cmb_Distrito.Text == string.Empty ||
            //txt_Telefono_I.Text == string.Empty || txt_Correo_I.Text == string.Empty ||
            //cmb_Tipo_ID.Text == string.Empty || cmb_Sexo.Text == string.Empty ||
            //cmb_Estado_Empleado.Text == string.Empty || txtx_Nomb_Usuario.Text == string.Empty ||
            //txt_Contrasena.Text == string.Empty || cmb_Rol.Text == string.Empty

            //)
            //{
            //    MessageBox.Show("Debe rellenar todos los campos obligatorios",
            //                            "Información o Alerta",
            //                            MessageBoxButtons.OK,
            //                             MessageBoxIcon.Information);

            //}

            //if (txt_Contrasena.Text.Length <= 6)
            //{
            //    MessageBox.Show("La contraseña debe tener un minimo de 6 caracteres",
            //                            "Información o Alerta",
            //                            MessageBoxButtons.OK,
            //                             MessageBoxIcon.Information);
            //}

            DateTime A = new DateTime(2008, 01, 01);
            DateTime B = dtp_FechaNacimiento.Value;

            if (B > A)
            {
                MessageBox.Show("No se aceptan menores de 15 años",
                                        "Información o Alerta",
                                        MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            }

            else {
                //aqui vamos insertando cosas 

                Obj_Empleados_DAL.sIdentificacion = txt_Identificacion.Text.ToString().Trim();
                Obj_Empleados_DAL.sNombre = txt_Nombre.Text.ToString().Trim();
                Obj_Empleados_DAL.sPrimer_apellido = txt_Apellido_I.Text.ToString().Trim();
                Obj_Empleados_DAL.sSegundo_apellido = txt_Apellido_II.Text.ToString().Trim();
                Obj_Empleados_DAL.B_TIPO_ID1 = Convert.ToBoolean(cmb_Tipo_ID.SelectedIndex);
                Obj_Empleados_DAL.B_SEXO1 =Convert.ToBoolean(cmb_Sexo.SelectedIndex);
                Obj_Empleados_DAL.sFecha_nacimiento = dtp_FechaNacimiento.Value.ToString();
                //nos saltamos fecha de ingreso
                Obj_Empleados_DAL.B_ESTADO1 = Convert.ToBoolean(cmb_Estado_Empleado.SelectedIndex);
                Obj_Empleados_DAL.sTipoPersona = "2";
                Obj_Empleados_DAL.sTelefonoI = txt_Telefono_I.Text.ToString().Trim();
                Obj_Empleados_DAL.sTelefonoII = txt_Telefono_II.Text.ToString().Trim();
                Obj_Empleados_DAL.sCorreoI = txt_Correo_I.Text.ToString().Trim();
                Obj_Empleados_DAL.sCorreoII = txt_Correo_II.Text.ToString().Trim();
                Obj_Empleados_DAL.sID_Canton = cmb_Canton.Text;
                Obj_Empleados_DAL.sID_Provincia = cmb_Provincia.Text;
                Obj_Empleados_DAL.sID_Distrito = cmb_Distrito.Text;
                Obj_Empleados_DAL.sOtras_Guias = txt_Otras_Guias.Text.ToString().Trim();
                Obj_Empleados_DAL.sContrasena = txt_Contrasena.Text.ToString().Trim();
                Obj_Empleados_DAL.sNombreUser = txtx_Nomb_Usuario.Text.ToString().Trim();
                Obj_Empleados_DAL.sRol_Descripcion = cmb_Rol.Text;
                Obj_Empleados_DAL.iRol_Activo = 1;






               
                //consulta cual ID PROVINCIA de acuerdo al nombrre
                Obj_Empleados_BLL.obtenerProvincia(ref Obj_Empleados_DAL);
                //re asigna el ID de la provincia
                Obj_Empleados_DAL.sID_Provincia = Obj_Empleados_DAL.DtDatos.Rows[0][0].ToString();
                //consulta a Distristo
                Obj_Empleados_BLL.obtenerDistrito(ref Obj_Empleados_DAL);
                Obj_Empleados_DAL.sID_Distrito = Obj_Empleados_DAL.DtDatos.Rows[0][0].ToString();

                //Cantones
                Obj_Empleados_BLL.obtenerCanton(ref Obj_Empleados_DAL);
                Obj_Empleados_DAL.sID_Canton = Obj_Empleados_DAL.DtDatos.Rows[0][0].ToString();

                //roles
              //  Obj_Empleados_BLL.obtenerROL(ref Obj_Empleados_DAL);
               // Obj_Empleados_DAL.sRol_Descripcion = Obj_Empleados_DAL.DtDatos.Rows[0][0].ToString();

                //llamado a metodos de insercion
                Obj_Empleados_BLL.insertarEmpleado(ref Obj_Empleados_DAL);
                Obj_Empleados_BLL.insertartelefonosEmpleado(ref Obj_Empleados_DAL);
                Obj_Empleados_BLL.insertarCorreosEmpleado(ref Obj_Empleados_DAL);
                Obj_Empleados_BLL.insertarDireccionesEmpleado(ref Obj_Empleados_DAL);
                Obj_Empleados_BLL.insertarUsuarioEmpleado(ref Obj_Empleados_DAL);

                MessageBox.Show("Usuario agregado con exito");

                //LIMPIAR
                txt_Nombre.Text = string.Empty;
                txt_Apellido_I.Text = string.Empty;
                txt_Apellido_II.Text = string.Empty;
                txt_Identificacion.Text = string.Empty;
                dtp_FechaNacimiento.Value = DateTime.Now;
                txt_Otras_Guias.Text = string.Empty;
              
                txt_Telefono_I.Text = string.Empty;
                txt_Telefono_II.Text = string.Empty;
                txt_Correo_I.Text = string.Empty;
                txt_Correo_I.Text = string.Empty;
              
              
                txtx_Nomb_Usuario.Text = string.Empty;
                txt_Contrasena.Text = string.Empty;
                cmb_Rol.Text = string.Empty;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmb_Provincia_DropDownClosed(object sender, EventArgs e)
        {
            CargarComboCanton();
            CargarComboDistrito();
        }

        private void cmb_Canton_DropDownClosed(object sender, EventArgs e)
        {
            CargarComboDistrito();

        }
    

        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                //erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
              //  erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }

        }

        private void ValidaNU(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 32) || (char.IsDigit(e.KeyChar)))
            {
                //erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
              //  erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }

        }

        private void ValidaNumeros(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 43) || (e.KeyChar == 45))
            {
              //  erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
              //  erp_Principal.SetError(txt, "Solo se admiten numeros");
            }

        }

     

        private void txt_Apellido_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Apellido_I);
        }

        private void txt_Apellido_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Apellido_II);
        }

        private void txt_Telefono_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(e, txt_Telefono_I);
        }

        private void txt_NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNU(e, txtx_Nomb_Usuario);
        }

        private void txt_Telefono_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(e, txt_Telefono_II);
        }


        //validacion paciente



    }
}
