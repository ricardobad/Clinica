using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_CLINICA.Ventanas.Expedientes
{
    public partial class frm_buscarexpediente : Form
    {
        public frm_buscarexpediente()
        {
            InitializeComponent();
        }

        private void frm_buscarexpediente_Load(object sender, EventArgs e)
        {

        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Consultar_Expediente_Click(object sender, EventArgs e)
        {
            frm_expediente Obj_Expediente = new frm_expediente();
            Obj_Expediente.ShowDialog();
        }
    }
}
