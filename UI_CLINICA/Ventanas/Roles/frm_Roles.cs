using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CLINICA.Ventanas.Roles
{
    public partial class frm_Roles : Form
    {
        public frm_Roles()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Roles_Load(object sender, EventArgs e)
        {
            dgvPermisos.Rows.Add("Crear Cita");
            dgvPermisos.Rows.Add("Editar Cita (Pago)");
            dgvPermisos.Rows.Add("Editar Cita (Confirmación)");
            dgvPermisos.Rows.Add("Modulo Doctor");
            dgvPermisos.Rows.Add("Modulo Administrador");
            dgvPermisos.Rows.Add("Modulo Pacientes");
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
