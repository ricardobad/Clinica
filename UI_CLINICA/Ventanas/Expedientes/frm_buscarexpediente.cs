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

namespace UI_CLINICA.Ventanas.Expedientes
{
    public partial class frm_buscarexpediente : Form
    {

        cls_Personas_DAL Obj_Personas_DAL = new cls_Personas_DAL();
        cls_Expedientes_BLL Obj_Expedientes_BLL = new cls_Expedientes_BLL();

        cls_Direcciones_DAL Obj_Direcciones_DAL = new cls_Direcciones_DAL();

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
            if(txt_Identificacion.Text == string.Empty)
            {
                MessageBox.Show("No se permiten espacios en blanco en la identificación",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                CargarDatos();
            }
            

        }


        private void CargarDatos()
        {

            Obj_Personas_DAL.Identificacion = txt_Identificacion.Text.Trim();

            Obj_Expedientes_BLL.Listar_Filtrar_InfoPersona(ref Obj_Personas_DAL);

            if (Obj_Personas_DAL.sMsjError == string.Empty)
            {
                MessageBox.Show("Datos del expediente cargados con éxito",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                //DESPUES DE FILTRAR INFO DE PERSONA FILTRA DIRECCIONES
                Obj_Direcciones_DAL.ID_Direccion = Obj_Personas_DAL.dsPersonas.Tables["ID_Direccion"].Rows[0])["Nombre"]

                frm_expediente Obj_Expediente = new frm_expediente();

                Obj_Expediente.Obj_Personas_DAL = Obj_Personas_DAL;

                Obj_Expediente.ShowDialog();

            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos del expediente Error = [ " +
                                Obj_Personas_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                
            }
        }





    }
}
