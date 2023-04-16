using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI_CLINICA.Ventanas.Principal
{
    public partial class frm_loginPaciente : Form
    {
        public frm_loginPaciente()
        {
            InitializeComponent();
        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void frm_loginPaciente_Load(object sender, EventArgs e)
        {

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
            frm_menupaciente Obj_Men_Empleado = new frm_menupaciente();
            Obj_Men_Empleado.ShowDialog();
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
    }
}
