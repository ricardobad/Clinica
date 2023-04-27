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
using System.Runtime.InteropServices;

namespace UI_CLINICA.Ventanas.Principal
{
    public partial class frm_menupaciente : Form
    {


        public cls_Personas_DAL Obj_Personas_DAL;


        public frm_menupaciente()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void reporteCitasPorPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            
            AbrirFormHijo(new Citas.frm_crearcitas());
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            Expedientes.frm_expediente Obj_Expediente = new Expedientes.frm_expediente();

            Obj_Expediente.Obj_Personas_DAL = Obj_Personas_DAL;
            AbrirFormHijo(Obj_Expediente);



        }


        

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_menupaciente_Load(object sender, EventArgs e)
        {
        }
    }
}
