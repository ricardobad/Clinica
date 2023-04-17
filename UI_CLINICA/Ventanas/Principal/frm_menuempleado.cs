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
    public partial class frm_menuempleado : Form
    {
        public frm_menuempleado()
        {
            InitializeComponent();
        }

        private void aSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearModificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmServicioCliente_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            pnlMenuCitas.Visible = false;
            pnlMenuPacientes.Visible = false;
            if (pnlMenuAdmin.Visible)
            {
                pnlMenuAdmin.Visible = false;
            }
            else
            {
                pnlMenuAdmin.Visible = true;
            }

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            pnlMenuAdmin.Visible = false;
            pnlMenuCitas.Visible = false;
            pnlMenuPacientes.Visible = false;
            if (pnlMenuDoctor.Visible)
            {
                pnlMenuDoctor.Visible = false;
            }
            else
            {
                pnlMenuDoctor.Visible = true;
            }
            
        }



        private void btnAdminReportes_Click(object sender, EventArgs e)
        {
            pnlMenuAdmin.Visible = false;
            AbrirFormHijo(new Reportes.frmReportes());
        }



        private void btnDoctorPacientes_Click(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            AbrirFormHijo(new Pacientes.frm_adminpacientes());
        }

        private void btnDoctorExpedientes_Click(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            AbrirFormHijo(new Expedientes.frm_buscarexpediente());
        }





        private void AbrirFormHijo(object frmHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }
            Form fh = frmHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnlContenedor.Controls.Add(fh);
                this.pnlContenedor.Tag = fh;
                fh.Show();
            
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Citas.frm_citas());
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Citas.frm_citas());
        }

        private void btnServicioCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Citas.frm_citas());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

  
        
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDoctorAdicciones_Click(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            AbrirFormHijo(new Mantenimiento.frm_mantenimientoadicciones());
        }

        private void btnDoctorAlergias_Click(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            AbrirFormHijo(new Mantenimiento.frm_mantenimientoalergias());
        }

        private void btnDoctorPadecimientos_Click(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            AbrirFormHijo(new Mantenimiento.frm_mantenimientopadecimientos());
        }

        private void btnAdminConsultorios_Click(object sender, EventArgs e)
        {
            pnlMenuAdmin.Visible = false;
            AbrirFormHijo(new Mantenimiento.frm_mantenimientoconsultorio());
        }

        private void btnAdminDoctores_Click(object sender, EventArgs e)
        {
            pnlMenuAdmin.Visible = false;
            //AbrirFormHijo(new Mantenimiento.frm_mantenimientodoctor());
        }

        private void btnAdminEmpleados_Click(object sender, EventArgs e)
        {
            pnlMenuAdmin.Visible = false;
            AbrirFormHijo(new Mantenimiento.frm_mantenimientoempleado());
        }

        private void btnAdminEspecialidades_Click(object sender, EventArgs e)
        {
            pnlMenuAdmin.Visible = false;
            AbrirFormHijo(new Mantenimiento.frm_mantenimientoespecialidad());
        }



        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            pnlMenuAdmin.Visible = false;
            pnlMenuPacientes.Visible = false;
            if (pnlMenuCitas.Visible)
            {
                pnlMenuCitas.Visible = false;
            }
            else
            {
                pnlMenuCitas.Visible = true;
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            pnlMenuDoctor.Visible = false;
            pnlMenuAdmin.Visible = false;
            pnlMenuCitas.Visible = false;
            if (pnlMenuPacientes.Visible)
            {
                pnlMenuPacientes.Visible = false;
            }
            else
            {
                pnlMenuPacientes.Visible = true;
            }
        }

        private void btnAdminRoles_Click_1(object sender, EventArgs e)
        {
            pnlMenuAdmin.Visible = false;
            AbrirFormHijo(new Roles.frm_Roles());
        }

        private void btnCitasCrear_Click(object sender, EventArgs e)
        {
            pnlMenuCitas.Visible = false;
            AbrirFormHijo(new Citas.frm_crearcitas());
        }

        private void btnCitasModificar_Click(object sender, EventArgs e)
        {
            pnlMenuCitas.Visible = false;
            AbrirFormHijo(new Citas.frm_modificarcitas());
        }

        private void btnCitasVisualizar_Click(object sender, EventArgs e)
        {
            pnlMenuCitas.Visible = false;
            AbrirFormHijo(new Citas.frm_citas());
        }

        private void btnPacientesCrear_Click(object sender, EventArgs e)
        {
            pnlMenuPacientes.Visible = false;
            AbrirFormHijo(new Pacientes.frm_adminpacientes());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
