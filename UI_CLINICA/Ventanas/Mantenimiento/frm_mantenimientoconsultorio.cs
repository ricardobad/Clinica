using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Clinica.Catalogos;
using DAL_Clinica.Catalogos;

namespace UI_CLINICA.Ventanas.Mantenimiento
{
    public partial class frm_mantenimientoconsultorio : Form
    {
        public frm_mantenimientoconsultorio()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES

        cls_Consultorios_DAL Obj_Consultorios_DAL = new cls_Consultorios_DAL();
        cls_Consultorios_BLL Obj_Consultorios_BLL = new cls_Consultorios_BLL();

        #endregion

        #region METODOS


        //private void CargarDatos()
        //{

        //    dgvConsultorio.DataSource = null;

        //    Obj_Consultorios_DAL.Numero = Convert.ToInt32(txt_Consul_Num.Text.Trim());

        //    Obj_Consultorios_BLL.Listar_Filtrar_Regiones(ref Obj_Consultorios_DAL);

        //    if (Obj_Regiones_DAL.sMsjError == string.Empty)
        //    {
        //        dgv_Datos.DataSource = Obj_Regiones_DAL.dsRegiones.Tables[0];
        //    }

        //    else
        //    {
        //        MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de regiones. Error = [" +
        //            Obj_Regiones_DAL.sMsjError + " ].",
        //            "ERROR",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }

        //}


        #endregion
    }
}
