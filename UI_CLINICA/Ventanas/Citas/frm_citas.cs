using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CLINICA.Ventanas.Citas
{
    public partial class frm_citas : Form
    {
        public frm_citas()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            frm_modificarcitas Obj_Men_Empleado = new frm_modificarcitas();
            Obj_Men_Empleado.ShowDialog();
        }

        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            frm_crearcitas Obj_Men_Empleado = new frm_crearcitas();
            Obj_Men_Empleado.ShowDialog();
        }
    }
}
