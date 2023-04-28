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

namespace UI_CLINICA.Ventanas.Pacientes
{
    public partial class frm_adminpacientes : Form
    {

        cls_Pacientes_BLL Obj_Pacientes_BLL = new cls_Pacientes_BLL();
        cls_Pacientes_DAL Obj_Pacientes_DAL = new cls_Pacientes_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();
        public cls_Empleados_DAL Obj_Empleados_Recibe_DAL;
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();
        public cls_Personas_DAL Obj_Personas_DAL;
        public cls_Provincias_DAL Obj_Provincias_DAL = new cls_Provincias_DAL();
        public frm_adminpacientes()
        {
            InitializeComponent();
        }

        private void frm_adminpacientes_Load(object sender, EventArgs e)
        {
            txt_Busqueda.Text = "";
            CargarDatos_II();

            cmb_Canton.SelectedIndex = 0;
            cmb_Provincia.SelectedIndex = 1;
            CargarComboCanton();
            CargarComboDistrito();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #region Metodos

        private void CargarDatos_II()
        {
            Obj_Pacientes_DAL.sIdentificacion = "";
            Obj_Pacientes_BLL.Listar_Pacientes(ref Obj_Pacientes_DAL);

            if (Obj_Pacientes_DAL.sMsjError == string.Empty)
            {
                dgv_Pacientes.DataSource = null;
                dgv_Pacientes.DataSource = Obj_Pacientes_DAL.dsPacientes.Tables[0];
            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos" + Obj_Pacientes_DAL.sMsjError, "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void btn_Cargar_Click(object sender, EventArgs e)
        {

            if (dgv_Pacientes.Rows.Count > 0)
            {
                if (MessageBox.Show("Desea realmente editar el Paciente [ " + dgv_Pacientes.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                        "Información o Alerta",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    txtx_Nombre.Text = dgv_Pacientes.SelectedRows[0].Cells[0].Value.ToString().Trim();
                    txt_Apellido_I.Text = dgv_Pacientes.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    txt_Apellido_II.Text = dgv_Pacientes.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    cmb_Tipo_ID.SelectedIndex = Convert.ToInt32(dgv_Pacientes.SelectedRows[0].Cells[3].Value);
                    cmb_Sexo.SelectedIndex = Convert.ToInt32(dgv_Pacientes.SelectedRows[0].Cells[4].Value);
                    dateTimePicker1.Value = Convert.ToDateTime(dgv_Pacientes.SelectedRows[0].Cells[5].Value);
                    txt_Identificacion.Text = dgv_Pacientes.SelectedRows[0].Cells[6].Value.ToString().Trim();
                    cmb_Estado.SelectedIndex = Convert.ToInt32(dgv_Pacientes.SelectedRows[0].Cells[7].Value);
                    txt_Otras_Guias.Text = dgv_Pacientes.SelectedRows[0].Cells[8].Value.ToString().Trim();
                    cmb_Provincia.SelectedIndex = Convert.ToInt32(dgv_Pacientes.SelectedRows[0].Cells[9].Value)-1;
                    CargarComboCanton();

                    //DESPUES DE CARGAR CANTONES EN BASE A LA PROVINCIA, VA A BUSCAR EL CANTÓN DE LA PERSONA Y LO COLOCA EN EL INDEX
                    int indiceItem = cmb_Canton.FindStringExact(dgv_Pacientes.SelectedRows[0].Cells[10].Value.ToString().Trim());

                    cmb_Canton.SelectedIndex = indiceItem;

                    CargarComboDistrito();

                    cmb_Distrito.SelectedIndex = Convert.ToInt32(dgv_Pacientes.SelectedRows[0].Cells[11].Value) - 1;
                    txt_Telefono_I.Text = dgv_Pacientes.SelectedRows[0].Cells[12].Value.ToString().Trim();
                    txt_Telefono_II.Text = dgv_Pacientes.SelectedRows[0].Cells[13].Value.ToString().Trim();
                    txtx_Correo_I.Text = dgv_Pacientes.SelectedRows[0].Cells[14].Value.ToString().Trim();
                    txt_Correo_II.Text = dgv_Pacientes.SelectedRows[0].Cells[15].Value.ToString().Trim();



                    MessageBox.Show("Se cargó la información exitosamente",
                                 "Información o Alerta",
                                 MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    btn_Crear.Text = "Modificar";
                    tbControl1.SelectTab(0);

                }
            }
            else
            {
                MessageBox.Show("No tiene Pacientes para Editar",
                                 "Información o Alerta",
                                 MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtx_Nombre.Text == string.Empty || txt_Apellido_I.Text == string.Empty ||
            txt_Apellido_II.Text == string.Empty || txt_Identificacion.Text == string.Empty ||
            txt_Otras_Guias.Text == string.Empty || cmb_Provincia.Text == string.Empty ||
            cmb_Canton.Text == string.Empty || cmb_Distrito.Text == string.Empty ||
            txt_Telefono_I.Text == string.Empty || txtx_Correo_I.Text == string.Empty ||
            cmb_Tipo_ID.Text == string.Empty || cmb_Sexo.Text == string.Empty ||
            cmb_Estado.Text == string.Empty || txtx_Contrasena.Text == string.Empty 

            )
            {
                MessageBox.Show("Debe rellenar todos los campos obligatorios",
                                        "Información o Alerta",
                                        MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

            }
            else
            {
                if (txtx_Contrasena.Text.Length <= 6)
                {
                    MessageBox.Show("La contraseña debe tener un minimo de 6 caracteres",
                                            "Información o Alerta",
                                            MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                }
                else
                {

                    DateTime A = DateTime.Today;
                    DateTime B = dateTimePicker1.Value;

                    if (B > A)
                    {
                        MessageBox.Show("No se aceptan fechas de nacimiento en futuro",
                                                "Información o Alerta",
                                                MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
                    }


                    else
                    {
                        if (btn_Crear.Text == "Crear")
                        {
                            cls_Direcciones_DAL Obj_Direcciones_DAL = new cls_Direcciones_DAL();
                            cls_Direcciones_BLL Obj_Direcciones_BLL = new cls_Direcciones_BLL();
                            cls_Telefonos_BLL Obj_Telefonos_BLL = new cls_Telefonos_BLL();
                            Obj_Personas_DAL = new cls_Personas_DAL();
                            cls_Telefonos_DAL Obj_Telefonos_DAL = new cls_Telefonos_DAL();
                            cls_Correos_DAL Obj_Correo_DAL = new cls_Correos_DAL();
                            cls_Correos_BLL Obj_Correos_BLL = new cls_Correos_BLL();
                            cls_Usuarios_BLL Obj_Usuarios_BLL = new cls_Usuarios_BLL();
                            cls_Usuario_DAL Obj_Usuarios_DAL = new cls_Usuario_DAL();


                            Obj_Personas_DAL.Nombre = txtx_Nombre.Text;
                            Obj_Personas_DAL.primer_apellido = txt_Apellido_I.Text;
                            Obj_Personas_DAL.segundo_apellido = txt_Apellido_II.Text;
                            Obj_Personas_DAL.Tipo_ID = Convert.ToBoolean(cmb_Tipo_ID.SelectedIndex);
                            Obj_Personas_DAL.Sexo = Convert.ToBoolean(cmb_Sexo.SelectedIndex);
                            Obj_Personas_DAL.fecha_nacimiento = dateTimePicker1.Value;


                            Obj_Personas_DAL.Identificacion = txt_Identificacion.Text;
                            Obj_Personas_DAL.Estado = Convert.ToBoolean(cmb_Estado.SelectedIndex);

                            Obj_Direcciones_DAL.ID_Canton = Obj_Provincias_DAL.dsProvincias.Tables["DIRECCIONES"].Rows[cmb_Canton.SelectedIndex]["ID_Canton"].ToString().Trim();
                            Obj_Direcciones_DAL.ID_Provincia = (cmb_Provincia.SelectedIndex + 1).ToString().Trim();
                            Obj_Direcciones_DAL.ID_Distrito = (cmb_Distrito.SelectedIndex + 1).ToString().Trim();
                            Obj_Direcciones_DAL.Otras_Guias = txt_Otras_Guias.Text;
                            Obj_Direcciones_DAL.sIdentificacion = txt_Identificacion.Text;


                            Obj_Telefonos_DAL.Telefono = txt_Telefono_I.Text;
                            Obj_Telefonos_DAL.telefono_II = txt_Telefono_II.Text;
                            Obj_Telefonos_DAL.sIdentificacion = txt_Identificacion.Text;

                            Obj_Correo_DAL.Correo = txtx_Correo_I.Text;
                            Obj_Correo_DAL.correo_II = txt_Correo_II.Text;
                            Obj_Correo_DAL.sIdentificacion = txt_Identificacion.Text;

                            Obj_Usuarios_DAL.Nombre_Usuario = "0";
                            Obj_Usuarios_DAL.ID_Rol = "Paciente";
                            Obj_Usuarios_DAL.sIdentificacion = txt_Identificacion.Text;
                            Obj_Usuarios_DAL.Contraseña = txtx_Contrasena.Text;


                            Obj_Pacientes_BLL.Insertar_Pacientes(ref Obj_Personas_DAL);
                            Obj_Direcciones_BLL.Crea_Direcciones(ref Obj_Direcciones_DAL);
                            Obj_Telefonos_BLL.Crea_Telefonos(ref Obj_Telefonos_DAL);
                            Obj_Correos_BLL.Crea_Correos(ref Obj_Correo_DAL);
                            Obj_Usuarios_BLL.Crea_Usuario(ref Obj_Usuarios_DAL);

                            if (Obj_Personas_DAL.sMsjError == string.Empty&& Obj_Direcciones_DAL.sMsjError == string.Empty && Obj_Telefonos_DAL.sMsjError == string.Empty && Obj_Correo_DAL.sMsjError == string.Empty)
                            {

                                MessageBox.Show("Paciente insertado con éxito",
                                                "Información o Alerta",
                                                MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
                                Limpiar();
                                CargarDatos_II();

                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al insertar el paciente, intente de nuevo más tarde",
                                                "Información o Alerta",
                                                MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
                            }



                        }





                    }

                }




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


        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {

            txtx_Nombre.Text = string.Empty;
            txt_Apellido_I.Text = string.Empty;
            txt_Apellido_II.Text = string.Empty;
            txt_Identificacion.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            txt_Otras_Guias.Text = string.Empty;
            cmb_Provincia.Text = string.Empty; ;
            cmb_Canton.Text = string.Empty;
            cmb_Distrito.Text = string.Empty;
            txt_Telefono_I.Text = string.Empty;
            txt_Telefono_II.Text = string.Empty;
            txtx_Correo_I.Text = string.Empty;
            txtx_Correo_I.Text = string.Empty;
            cmb_Tipo_ID.Text = string.Empty;
            cmb_Sexo.Text = string.Empty;
            cmb_Estado.Text = string.Empty;
            txtx_Contrasena.Text = string.Empty;
            btn_Crear.Text = "Crear";


        }
        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
               // erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                //erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }

        }

        private void ValidaNumeros(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 43) || (e.KeyChar == 45))
            {
               // erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
               // erp_Principal.SetError(txt, "Solo se admiten numeros");
            }

        }

        private void ValidaNumeros2(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 45))
            {
                //erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
               // erp_Principal.SetError(txt, "Solo se admiten numeros");
            }

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txtx_Nombre);
        }

        private void txt_Apellido_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Apellido_I);
        }

        private void txt_Apellido_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Apellido_II);
        }

        private void txt_Telefono_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(e, txt_Telefono_I);
        }

        private void txt_Telefono_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(e, txt_Telefono_II);
        }

        private void txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros2(e, txt_Busqueda);
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
    }
}
