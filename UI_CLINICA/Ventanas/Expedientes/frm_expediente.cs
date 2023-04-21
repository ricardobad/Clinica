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

namespace UI_CLINICA.Ventanas.Expedientes
{
    public partial class frm_expediente : Form
    {

        public cls_Personas_DAL Obj_Personas_DAL;

        public frm_expediente()
        {
            InitializeComponent();
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_expediente_Load(object sender, EventArgs e)
        {
            CargarDatos();
            

        }


        private void CargarDatos()
        {
            DataRow Fila = Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0];
            //Obj_Padecimientos_DAL.ID_Doctor = Convert.ToInt32(primeraFila["ID_Doctor"]);


            txt_Nombre.Text = Fila["Nombre"].ToString().Trim() + " " + Fila["Primer Apellido"].ToString().Trim()+ " " + Fila["Segundo Apellido"].ToString().Trim();

            if (Obj_Personas_DAL.Tipo_ID)
            {
                txt_TipoIdentificacion.Text = "Extranjero";
            }
            else
            {
                txt_TipoIdentificacion.Text = "Nacional";
            }

            

            txt_Identificacion.Text = Obj_Personas_DAL.Identificacion.ToString().Trim();

            txt_FechaNacimiento.Text = Obj_Personas_DAL.fecha_nacimiento.ToString().Trim();
            
            if (Fila["Sexo"].ToString().Trim() == "True")
            {
                txt_Sexo.Text = "Masculino";
            }
            else
            {
                txt_Sexo.Text = "Femenino";
            }



            //txt_Telefono_II.Text = Obj_Personas_DAL.fecha_nacimiento.ToString().Trim();

            //txt_Correo_I.Text = Obj_Personas_DAL.fecha_nacimiento.ToString().Trim();

            //txt_Correo_II.Text = Obj_Personas_DAL.fecha_nacimiento.ToString().Trim();



        }
    }
}
