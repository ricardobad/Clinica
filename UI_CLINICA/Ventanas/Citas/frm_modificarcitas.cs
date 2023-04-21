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

namespace UI_CLINICA.Ventanas.Citas
{
    public partial class frm_modificarcitas : Form
    {

        #region VARIABLES GLOBALES

        cls_Citas_DAL DAL_Citas = new cls_Citas_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();
        cls_Citas_BLL BLL_Citas = new cls_Citas_BLL();
        #endregion
        public frm_modificarcitas()
        {
            InitializeComponent();
        }

        private void frm_modificarcitas_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        #region Metodos

        
        private void CargarDatos()
        {

            //BLL_Citas.listar_Citas(ref DAL_Citas);

            //aqui se llama al datagrid del formulario

            if (DAL_Citas.sMsjError == string.Empty)
            {
                dgv_Citas.DataSource = null;

                dgv_Citas.DataSource = DAL_Citas.DtDatos;

            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos \n\n" + DAL_Citas.sMsjError,
                    "Error en carga de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }


        #endregion

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
