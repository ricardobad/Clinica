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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            frm_menuempleado Obj_Men_Empleado = new frm_menuempleado();
            Obj_Men_Empleado.ShowDialog();
        }

        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            if(txtLoginIdentificacion.Text != "0")
            {

                ExistePersona();
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ExistePersona()
        {
            cls_Usuario_DAL Obj_Usuarios_DAL = new cls_Usuario_DAL();
            cls_Usuarios_BLL Obj_Usuarios_BLL = new cls_Usuarios_BLL();

            Obj_Usuarios_DAL.sIdentificacion = txtLoginIdentificacion.Text;
            Obj_Usuarios_DAL.Contraseña = txtLoginContraseña.Text;
            Obj_Usuarios_BLL.Inicio_Sesion_Usuario(ref Obj_Usuarios_DAL);

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

                frm_menuempleado Obj_Men_Empleado = new frm_menuempleado();
                Obj_Men_Empleado.ShowDialog();
            }

            


        }

        private void txtLoginIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLoginContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 45) || (e.KeyChar == 95))
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

        private void txtLoginIdentificacion_Click(object sender, EventArgs e)
        {
            txtLoginIdentificacion.Text = string.Empty;
        }

        private void txtLoginContraseña_Click(object sender, EventArgs e)
        {
            txtLoginContraseña.Text = string.Empty;
        }
    }
}
