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
            frm_menuempleado Obj_Men_Empleado = new frm_menuempleado();
            Obj_Men_Empleado.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
