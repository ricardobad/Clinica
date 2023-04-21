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
            if(Obj_Personas_DAL == null)
            {

            }
            else
            {
                CargarDatos();
            }
            
            

        }

        //public void CargarCombos()
        //{
        //    cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
        //    cls_Doctores_BLL Obj_Doctores_BLL = new cls_Doctores_BLL();

        //    cmb_Provincias.DataSource = null;
        //    cmb_Distritos.DataSource = null;
        //    cmb_Cantones.DataSource = null;

        //    Obj_Doctores_DAL.Carnet = string.Empty;

        //    Obj_Doctores_BLL.Listar_Filtrar_Doctores(ref Obj_Doctores_DAL);

        //    if (Obj_Doctores_DAL.sMsjError == string.Empty)
        //    {

        //        cmbDoctores.DisplayMember = "Carnet";
        //        cmbDoctores.ValueMember = "ID_Doctor";
        //        cmbDoctores.DataSource = Obj_Doctores_DAL.dsDoctores.Tables[0];
        //    }
        //    else
        //    {
        //        MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Regiones.Error = [ " +
        //                        Obj_Doctores_DAL.sMsjError + " ].",
        //                        "ERROR",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //    }
        //}

        private void CargarDatos()
        {
            //CargarCombos();
            DataRow Fila = Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0];
            //Obj_Padecimientos_DAL.ID_Doctor = Convert.ToInt32(primeraFila["ID_Doctor"]);


            txt_Nombre.Text = Fila["Nombre"].ToString().Trim() + " " + Fila["Primer Apellido"].ToString().Trim() + " " + Fila["Segundo Apellido"].ToString().Trim();

            if (Fila["Tipo_ID"].ToString().Trim() == "True")    //SI ES VERDADERO ES EXTRANJERO (1 EN LA BASE DE DATOS)
            {
                txt_TipoIdentificacion.Text = "Extranjero";
            }
            else
            {
                txt_TipoIdentificacion.Text = "Nacional";    //SI ES FALSO ES NACIONAL (0 EN LA BASE DE DATOS)
            }



            txt_Identificacion.Text = Obj_Personas_DAL.Identificacion.ToString().Trim();
            txt_FechaNacimiento.Text = Fila["fecha_nacimiento"].ToString().Trim();
            
            cmb_Provincias.Text = Fila["Provincia"].ToString().Trim();
            cmb_Distritos.Text = Fila["Distrito"].ToString().Trim();
            cmb_Cantones.Text = Fila["Canton"].ToString().Trim();
            txt_Correo_I.Text = Fila["Correo_I"].ToString().Trim();
            txt_Correo_II.Text = Fila["Correo_II"].ToString().Trim();
            txt_Telefono_I.Text = Fila["Telefono_I"].ToString().Trim();
            txt_Telefono_II.Text = Fila["Telefono_II"].ToString().Trim();
            txt_Direccion.Text = Fila["Otras Guias"].ToString().Trim();

            if (Fila["Sexo"].ToString().Trim() == "True")
            {
                txt_Sexo.Text = "Masculino";
            }
            else
            {
                txt_Sexo.Text = "Femenino";
            }

            //LLENADO DE TAB CONTROL DE INFORMACIÓN DEL PACIENTE

            cls_Pacientes_DAL Obj_Paciente_DAL = new cls_Pacientes_DAL();
            cls_Pacientes_BLL Obj_Paciente_BLL = new cls_Pacientes_BLL();

            dgv_Datos.DataSource = null;

            Obj_Paciente_DAL.sIdentificacion = Obj_Personas_DAL.Identificacion;

            Obj_Paciente_BLL.listar_filtrar_Pacientes(ref Obj_Paciente_DAL);

            if (Obj_Paciente_DAL.sMsjError == string.Empty)
            {


                txt_Peso.Text = Obj_Paciente_DAL.DtDatos.Rows[0]["Peso"].ToString().Trim();
                txt_Altura.Text = Obj_Paciente_DAL.DtDatos.Rows[0]["Altura"].ToString().Trim();

                if (Obj_Paciente_DAL.DtDatos.Rows[0]["Tipo de Sangre"].ToString().Trim() == "A")
                {
                    cmb_TipoSangre.SelectedIndex = 0;
                }
                else if(Obj_Paciente_DAL.DtDatos.Rows[0]["Tipo de Sangre"].ToString().Trim() == "B")
                {
                    cmb_TipoSangre.SelectedIndex = 1;
                }
                else if (Obj_Paciente_DAL.DtDatos.Rows[0]["Tipo de Sangre"].ToString().Trim() == "AB")
                {
                    cmb_TipoSangre.SelectedIndex = 2;
                }
                else 
                {
                    cmb_TipoSangre.SelectedIndex = 3;
                }

                //LLENADO DE INFORMACIÓN DE LAS ADICCIONES


                cls_Adicciones_DAL Obj_Adicciones_DAL = new cls_Adicciones_DAL();
                cls_Adicciones_BLL Obj_Adicciones_BLL = new cls_Adicciones_BLL();

                Obj_Adicciones_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);

                Obj_Adicciones_BLL.Filtrar_Adicciones_Pacientes(ref Obj_Adicciones_DAL);




                //LLENADO DE INFORMACIÓN DE LAS ALERGIAS

                //cls_Alergias_DAL Obj_Alergias_DAL = new cls_Alergias_DAL();
                //cls_Alergias_BLL Obj_Alergias_BLL = new cls_Alergias_BLL();

                //Obj_Alergias_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);

                //Obj_Alergias_BLL.Filtrar_Alergias_Pacientes(ref Obj_Alergias_DAL);




                dgv_Datos.DataSource = Obj_Adicciones_DAL.dsAdicciones.Tables[0];



            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Paciente Error = [ " +
                                Obj_Paciente_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }






        }

        private void btn_ActualizarCorreos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente modificar los correos?",
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cls_Correos_BLL Obj_Correos_BLL = new cls_Correos_BLL();
                cls_Correos_DAL Obj_Correos_DAL = new cls_Correos_DAL();

                Obj_Correos_DAL.sIdentificacion = Obj_Personas_DAL.Identificacion;
                Obj_Correos_DAL.Correo = txt_Correo_I.Text;
                Obj_Correos_DAL.correo_II = txt_Correo_II.Text;
                Obj_Correos_BLL.Modificar_Correos(ref Obj_Correos_DAL);

                if (Obj_Correos_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Datos de correos actualizados con éxito",
                                    "Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txt_Correo_I.Text = Obj_Correos_DAL.Correo;
                    txt_Correo_II.Text = Obj_Correos_DAL.correo_II;
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar los correos Error = [ " +
                                    Obj_Personas_DAL.sMsjError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);


                }

            }
        }

        private void btn_ActualizarTelefonos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente modificar los teléfonos?",
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cls_Telefonos_BLL Obj_Telefonos_BLL = new cls_Telefonos_BLL();
                cls_Telefonos_DAL Obj_Telefonos_DAL = new cls_Telefonos_DAL();
                Obj_Telefonos_DAL.sIdentificacion = Obj_Personas_DAL.Identificacion;
                Obj_Telefonos_DAL.Telefono = txt_Telefono_I.Text;
                Obj_Telefonos_DAL.telefono_II = txt_Telefono_II.Text;
                Obj_Telefonos_BLL.Modificar_Telefonos(ref Obj_Telefonos_DAL);

                if (Obj_Telefonos_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Datos de Teléfonos actualizados con éxito",
                                    "Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txt_Telefono_I.Text = Obj_Telefonos_DAL.Telefono;
                    txt_Telefono_II.Text = Obj_Telefonos_DAL.telefono_II;
                }
                else
                {
                    MessageBox.Show("Se presento un error a la hora de modificar los Telefonos Error = [ " +
                                    Obj_Personas_DAL.sMsjError + " ].",
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);


                }

            }
        



            

        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
