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

namespace UI_CLINICA.Ventanas.Citas
{
    public partial class frm_crearcitas : Form
    {

        #region Variables Globales

        cls_Citas_DAL Obj_Citas_DAL = new cls_Citas_DAL();
        cls_Citas_BLL Obj_Citas_BLL = new cls_Citas_BLL();

        #endregion
        public frm_crearcitas()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txt_Identificacion.Text.Trim() != string.Empty)
            {
                cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
                cls_Doctores_BLL Obj_Doctores_BLL = new cls_Doctores_BLL();
                cls_Especialidades_DAL Obj_Especialidades_DAL = new cls_Especialidades_DAL();
                cls_Especialidades_BLL Obj_Especialidades_BLL = new cls_Especialidades_BLL();
                cls_Consultorios_DAL Obj_Consultorios_DAL = new cls_Consultorios_DAL();
                cls_Consultorios_BLL Obj_Consultorios_BLL = new cls_Consultorios_BLL();

                Obj_Citas_DAL.ID_Cita = 1;
                //Falta meter ID Paciente, para eso hay que leer el txt_Identificacion, buscarla en la BD en Pacientes, si existe, sacar el ID Paciente y meterlo en Insertar Citas, si No, tirar error
                Obj_Especialidades_DAL.ID_Especialidad = Convert.ToInt32(cmb_Especialidad.Text);
                Obj_Especialidades_BLL.listar_especialidades(ref Obj_Especialidades_DAL); //cuidado se el cambia el nombre en el BLL ya que no es listar/filtrar por lo que veo
                DataRow drEspecialidad = Obj_Especialidades_DAL.dsEspecialidades.Tables["Especialidades"].Rows[1];
                Obj_Citas_DAL.ID_Especialidad = Convert.ToInt32(drEspecialidad["ID_Especialidad"]);
                Obj_Doctores_DAL.ID_Doctor = Convert.ToInt32(cmb_Doctor.Text);
                Obj_Doctores_BLL.Listar_Filtrar_Doctores(ref Obj_Doctores_DAL);
                DataRow drDoctores = Obj_Doctores_DAL.dsDoctores.Tables["Doctores"].Rows[0];
                Obj_Citas_DAL.ID_Doctor = Convert.ToInt32(drDoctores["ID_Doctor"]);
                Obj_Citas_DAL.FechaHoraInicio = dtp_Fecha.Value.Date.AddHours(dtp_Hora.Value.Hour).AddMinutes(dtp_Hora.Value.Minute).AddSeconds(dtp_Hora.Value.Second);
                Obj_Consultorios_DAL.ID_Consultorio = Convert.ToInt32(cmb_Consultorio.Text);
                Obj_Consultorios_BLL.Listar_Filtrar_Consultorios(ref Obj_Consultorios_DAL);
                DataRow drConsultorio = Obj_Consultorios_DAL.DsConsultorios.Tables["Consultorios"].Rows[1];
                Obj_Citas_DAL.ID_Consultorio = Convert.ToInt32(drEspecialidad["ID_Consultorio"]);

                Obj_Citas_BLL.Crear_Citas(ref Obj_Citas_DAL);

                if (Obj_Citas_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Nueva Cita creada exitosamente...!!!",
                                    "Proceso Éxitoso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Se presentó un error en la creación de la cita .\n\nError: [" + Obj_Citas_DAL.sMsjError + " ].",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

        }

        public void CargarCombos()
        {
            cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
            cls_Doctores_BLL Obj_Doctores_BLL = new cls_Doctores_BLL();
            cls_Especialidades_DAL Obj_Especialidades_DAL = new cls_Especialidades_DAL();
            cls_Especialidades_BLL Obj_Especialidades_BLL = new cls_Especialidades_BLL();
            cls_Consultorios_DAL Obj_Consultorios_DAL = new cls_Consultorios_DAL();
            cls_Consultorios_BLL Obj_Consultorios_BLL = new cls_Consultorios_BLL();

            dtp_Fecha.MinDate = DateTime.Now;
            dtp_Hora.MinDate = DateTime.Now;



            //dtp_Fecha.MinDate.ToString("hh:mm");

            cmb_Doctor.DataSource = null;

            Obj_Doctores_DAL.ID_Doctor = 0;

            Obj_Doctores_BLL.Listar_Filtrar_Doctores(ref Obj_Doctores_DAL);

            if (Obj_Doctores_DAL.sMsjError == string.Empty)
            {
                cmb_Doctor.DataSource = Obj_Doctores_DAL.dsDoctores.Tables[0];
                cmb_Doctor.DisplayMember = "NOMBRE";
                cmb_Doctor.ValueMember = "ID_Doctor";

            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Doctores.Error = [ " +
                                Obj_Doctores_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }


            cmb_Consultorio.DataSource = null;

            Obj_Consultorios_DAL.ID_Consultorio = 0;

            Obj_Consultorios_BLL.Listar_Filtrar_Consultorios(ref Obj_Consultorios_DAL);

            if (Obj_Consultorios_DAL.sMsjError == string.Empty)
            {
                cmb_Consultorio.DataSource = Obj_Consultorios_DAL.DsConsultorios.Tables[0];
                cmb_Consultorio.DisplayMember = "NUMERO";
                cmb_Consultorio.ValueMember = "ID_CONSULTORIO";

            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Consultorios.Error = [ " +
                                Obj_Doctores_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


            cmb_Especialidad.DataSource = null;

            Obj_Especialidades_DAL.ID_Especialidad = 0;

            Obj_Especialidades_BLL.listar_especialidades(ref Obj_Especialidades_DAL);

            if (Obj_Especialidades_DAL.sMsjError == string.Empty)
            {
                cmb_Especialidad.DataSource = Obj_Especialidades_DAL.dsEspecialidades.Tables[0];
                cmb_Especialidad.DisplayMember = "NOMBRE";
                cmb_Especialidad.ValueMember = "ID ESPECIALIDAD";

            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Especialidades.Error = [ " +
                                Obj_Doctores_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        #region FECHAS





        #endregion


        private void txt_Identificacion_Leave(object sender, EventArgs e)
        {

        }

        private void frm_crearcitas_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }




        private void ValidaNumeros(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 45))
            {
                //erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                                  //  erp_Principal.SetError(txt, "Solo se admiten numeros");
            }

        }
        private void txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(e, txt_Identificacion);
        }
    }
}
    

