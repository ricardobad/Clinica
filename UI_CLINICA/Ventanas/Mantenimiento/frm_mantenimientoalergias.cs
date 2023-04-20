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

namespace UI_CLINICA.Ventanas.Mantenimiento
{
    public partial class frm_mantenimientoalergias : Form
    {
        #region VARIABLES GLOBALES

        cls_Alergias_DAL DAL_Alergias = new cls_Alergias_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();
        cls_Alergias_BLL BLL_Alergias = new cls_Alergias_BLL();
        #endregion
        public frm_mantenimientoalergias()
        {
            InitializeComponent();
        }

        private void frm_mantenimientoalergias_Load(object sender, EventArgs e)
        {
            CargarDatos();


        }

        #region MÉTODOS

        private void CargarDatos()
        {

            BLL_Alergias.listar_alergias(ref DAL_Alergias);

            //aqui se llama al datagrid del formulario

            if (DAL_Alergias.sMsjError == string.Empty)
            {
                dgvNumero.DataSource = null;

                dgvNumero.DataSource = DAL_Alergias.DtDatos;

            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos \n\n" + DAL_Alergias.sMsjError,
                    "Error en carga de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void dgvNumero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
