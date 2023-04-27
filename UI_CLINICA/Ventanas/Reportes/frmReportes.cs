using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Clinica.BD;
using DAL;
using DAL_Clinica.BD;
using BLL_Clinica.Catalogos;
using DAL_Clinica.Catalogos;

namespace UI_CLINICA.Ventanas.Reportes
{
    public partial class frmReportes : Form
    {

        #region Globales
        cls_Reportes_BLL reporte_BLL = new cls_Reportes_BLL();
        cls_Reportes_DAL reporte_DAL = new cls_Reportes_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();
        public DateTime FechaInicio, FechaFinal;
        #endregion

        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // carga fechas por si usuario no selecciona nada
            FechaInicio = cld_inicio.SelectionStart;
            FechaFinal = cld_Final.SelectionStart;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }


        private void CargarDatos() {

            if (reporte_DAL.sMsjError == string.Empty)
            {

                
               string respuesta =Convert.ToString( reporte_DAL.DtDatos.Rows[0][0]);
                MessageBox.Show("carga exitosa , las cantidad de citas en esa fecha es de " + respuesta);

            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos" + reporte_DAL.sMsjError, "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //fechas aplica para todo
            reporte_DAL.FechaInicial = FechaInicio;
            reporte_DAL.FechaFinal = FechaFinal;

            //para citas totales
            if (cmbReporte.SelectedIndex == 0) {

                reporte_BLL.CitasTotales(ref reporte_DAL);
                CargarDatos();

            }


           
           
        }

        private void cld_Final_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaFinal = cld_Final.SelectionStart;
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void cld_inicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaInicio = cld_inicio.SelectionStart;
        }
    }
}
