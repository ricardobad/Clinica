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
using DAL_Clinica.Catalogos;
using BLL_Clinica.Catalogos;
namespace UI_CLINICA.Ventanas.Mantenimiento
{
    public partial class frm_mantenimientoempleado : Form
    {
        #region VARIABLES GLOBALES

        public cls_Empleados_DAL Obj_Empleados_Recibe_DAL;

        cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
        cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();

        #endregion

        public frm_mantenimientoempleado()
        {
            InitializeComponent();
        }

        private void frm_mantenimientoempleado_Load(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            CargarDatos_II();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        #region Metodos

        private void CargarDatos_II() {
            Obj_Empleados_DAL.sID_Persona = txt_busqueda.Text.Trim().ToString();
            Obj_Empleados_BLL.listar_filtrar_Empleados(ref Obj_Empleados_DAL);
            
            if (Obj_Empleados_DAL.sMsjError == string.Empty)
            {
                dgv_Empleados.DataSource = null;
                dgv_Empleados.DataSource = Obj_Empleados_DAL.DtDatos;
            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos" + Obj_Empleados_DAL.sMsjError, "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarDatos() {

            
            Obj_Empleados_BLL.listar_Empleados(ref Obj_Empleados_DAL);
            if (Obj_Empleados_DAL.sMsjError == string.Empty)
            {
                dgv_Empleados.DataSource = null;

                dgv_Empleados.DataSource = Obj_Empleados_DAL.DtDatos;


            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos \n\n" + Obj_Empleados_DAL.sMsjError,
                    "Error en carga de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }



        }

        #endregion

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            //aqui va el llamado al filtro        
            CargarDatos_II();

        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            Obj_Empleados_BLL.cargaempleados(ref Obj_Empleados_DAL);
            txt_Nombre.Text = Obj_Empleados_DAL.sID_Persona.ToString();

        }
    }
}
