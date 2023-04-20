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
    public partial class frm_mantenimientoadicciones : Form
    {
        #region VARIABLES GLOBALES

        cls_Adicciones_BLL BLL_Adicciones = new cls_Adicciones_BLL();
        cls_Adicciones_DAL DAL_Adicciones = new cls_Adicciones_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();
       // cls_Adicciones_BLL BLL_Adicciones = new cls_Adicciones_BLL();
        #endregion
        public frm_mantenimientoadicciones()
        {
            
            InitializeComponent();
        }

        private void frm_mantenimientoadicciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        #region METODOS
        private void CargarDatos()
        {

             BLL_Adicciones.listar_Adicciones(ref DAL_Adicciones);

            //aqui se llama al datagrid del formulario

            if (DAL_Adicciones.sMsjError == string.Empty)
            {
                dgv_Numero.DataSource = null;

                dgv_Numero.DataSource = DAL_Adicciones.DtDatos;

            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos \n\n" + DAL_Adicciones.sMsjError,
                    "Error en carga de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
        #endregion

    }
}
