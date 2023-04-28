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
using BLL_Clinica.Catalogos;
using DAL_Clinica.Catalogos;

namespace UI_CLINICA.Ventanas.Principal
{
    public partial class frm_loginPaciente : Form
    {

        cls_Personas_DAL Obj_Personas_DAL = new cls_Personas_DAL();

        public frm_loginPaciente()
        {
            InitializeComponent();
        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void frm_loginPaciente_Load(object sender, EventArgs e)
        {
            Titulo.Focus();
        }

        private void lblCrearPaciente_Click(object sender, EventArgs e)
        {
            Pacientes.frm_pacientes Obj_Crear_Paciente = new Pacientes.frm_pacientes();
            Obj_Crear_Paciente.ShowDialog();
        }



        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bntLoginIngresar_Click(object sender, EventArgs e)
        {


            Obj_Personas_DAL.Identificacion = txtLoginIdentificacion.Text;

            CargarDatos();

            
        }

        private void ExistePersona()
        {
            cls_Usuario_DAL Obj_Usuarios_DAL = new cls_Usuario_DAL();
            cls_Usuarios_BLL Obj_Usuarios_BLL = new cls_Usuarios_BLL();

            Obj_Usuarios_DAL.sIdentificacion = txtLoginIdentificacion.Text;
            Obj_Usuarios_DAL.Contraseña = txtLoginContraseña.Text;
            Obj_Usuarios_BLL.Inicio_Sesion(ref Obj_Usuarios_DAL);

            if (Obj_Usuarios_DAL.dsUsuarios.Tables["Inicio Sesion"].Rows[0]["Inicio_Exitoso"].ToString().Trim() == "False")
            {

                MessageBox.Show("La contraseña es incorrecta, intente de nuevo",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Inicio de sesión éxitoso",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            
            frm_menupaciente Obj_Men_Empleado = new frm_menupaciente();
            Obj_Men_Empleado.Obj_Personas_DAL = Obj_Personas_DAL;
            Obj_Men_Empleado.ShowDialog();
        }
        private void CargarDatos()
        {


            cls_Expedientes_BLL Obj_Expedientes_BLL = new cls_Expedientes_BLL();

            Obj_Expedientes_BLL.Listar_Filtrar_InfoPersona(ref Obj_Personas_DAL);

            if (Obj_Personas_DAL.sMsjError == "No hay ninguna fila en la posición 0.")
            {
                MessageBox.Show("La identificación del paciente no existe en el sistema",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if(Obj_Personas_DAL.sMsjError != string.Empty)
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos del paciente Error = [ " +
                                Obj_Personas_DAL.sMsjError + " ].",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                switch (Convert.ToInt32(Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0]["Tipo_Persona"]))
                {

                    case 0:

                        break;
                    case 1:
                        ExistePersona();


                        break;
                    case 2:


                        break;
                    case 3:


                        break;
                    case 4:
                        ExistePersona();

                        break;
                    case 5:
                        ExistePersona();

                        break;
                    default:

                        break;
                }
            }

            

            

        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOlvidarContrasena_Click(object sender, EventArgs e)
        {
            Pacientes.frm_actualizarcontrasena Obj_RecuperarContrasena = new Pacientes.frm_actualizarcontrasena();
            Obj_RecuperarContrasena.ShowDialog();
        }

        private void txtLoginIdentificacion_Click(object sender, EventArgs e)
        {
            txtLoginIdentificacion.Text = string.Empty;
        }

        private void txtLoginContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtLoginContraseña_Click(object sender, EventArgs e)
        {
            txtLoginContraseña.Text = string.Empty;
        }

        private void txtLoginIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txtLoginIdentificacion);
        }

        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 45)   || (e.KeyChar == 95))
            {
                erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }



        }
    }
}
