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
    public partial class frm_seleccionPerfil : Form
    {
        public frm_seleccionPerfil()
        {
            InitializeComponent();
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIngresoColaborador_Click(object sender, EventArgs e)
        {
            frm_login Obj_Log_User = new frm_login();
            Obj_Log_User.ShowDialog();
        }

        private void btnIngresoPaciente_Click(object sender, EventArgs e)
        {
            frm_loginPaciente Obj_Log_Pac = new frm_loginPaciente();
            Obj_Log_Pac.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
