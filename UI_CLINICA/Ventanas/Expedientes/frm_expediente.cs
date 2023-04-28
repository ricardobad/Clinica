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
        #region VARIABLES GLOBALES
        public cls_Personas_DAL Obj_Personas_DAL;
        public cls_Pacientes_DAL Obj_Paciente_DAL = new cls_Pacientes_DAL();
        public cls_Pacientes_BLL Obj_Paciente_BLL = new cls_Pacientes_BLL();
        public cls_Provincias_DAL Obj_Provincias_DAL = new cls_Provincias_DAL();
        cls_Citas_DAL Obj_Citas_DAL = new cls_Citas_DAL();
        cls_Citas_BLL Obj_Citas_BLL = new cls_Citas_BLL();


        #endregion

        public frm_expediente()
        {
            InitializeComponent();
        }


        #region EVENTOS

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


            if (Obj_Personas_DAL == null)
            {
                
            }
            else
            {

                if (Convert.ToInt32(Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0]["Tipo_Persona"])==1)
                {
                    dgv_Adicciones.Enabled = false;
                    dgv_Alergias.Enabled = false;
                    dgv_Padecimientos.Enabled = false;
                    btn_Modificar_Adicciones.Enabled = false;
                    btn_Modificar_Alergias.Enabled = false;
                    btn_Modificar_Padecimientos.Enabled = false;
                    txt_Altura.Enabled = false;
                    txt_Peso.Enabled = false;
                    cmb_TipoSangre.Enabled = false;
                    btn_ModificarDatosPaciente.Enabled = false;
                }
                cmb_Cantones.SelectedIndex = 0;
                cmb_Provincias.SelectedIndex = 1;




                CargarDatos();


                CargarComboCanton();


                //DESPUES DE CARGAR CANTONES EN BASE A LA PROVINCIA, VA A BUSCAR EL CANTÓN DE LA PERSONA Y LO COLOCA EN EL INDEX

                int indiceItem = cmb_Cantones.FindStringExact(Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0]["Nombre_Canton"].ToString().Trim());

                cmb_Cantones.SelectedIndex = indiceItem;

                CargarComboDistrito();



                cmb_Distritos.SelectedIndex = Convert.ToInt32(Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0]["ID_Distrito"]) - 1;
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

        private void btn_Modificar_Adicciones_Click(object sender, EventArgs e)
        {
            cls_Adicciones_DAL Obj_Adicciones_DAL = new cls_Adicciones_DAL();
            cls_Adicciones_BLL Obj_Adicciones_BLL = new cls_Adicciones_BLL();

            Obj_Adicciones_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);

            for (int i = 0; i < dgv_Adicciones.Rows.Count; i++) //Recorre todo el datagriv para observar cuáles están activos para añadirlos a un string al final separado con un espacio
            {
                // Se comprueba si la segunda columna de la tabla que se este viendo es true y si lo es añade al obj la adicción
                if ((bool)dgv_Adicciones.Rows[i].Cells[1].Value == true)
                {
                    Obj_Adicciones_DAL.sAdiccionesTotales += dgv_Adicciones.Rows[i].Cells[0].Value.ToString() + " ";
                }
            }

            Obj_Adicciones_BLL.Modificar_Adicciones_Pacientes(ref Obj_Adicciones_DAL);







        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Alergias_Click(object sender, EventArgs e)
        {
            cls_Alergias_DAL Obj_Alergias_DAL = new cls_Alergias_DAL();
            cls_Alergias_BLL Obj_Alergias_BLL = new cls_Alergias_BLL();

            Obj_Alergias_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);

            for (int i = 0; i < dgv_Alergias.Rows.Count; i++) //Recorre todo el datagriv para observar cuáles están activos para añadirlos a un string al final separado con un espacio
            {
                // Se comprueba si la segunda columna de la tabla que se este viendo es true y si lo es añade al obj la adicción
                if ((bool)dgv_Alergias.Rows[i].Cells[1].Value == true)
                {
                    Obj_Alergias_DAL.sAlergiasTotales += dgv_Alergias.Rows[i].Cells[0].Value.ToString() + " ";
                }
            }

            Obj_Alergias_BLL.Modificar_Alergias_Pacientes(ref Obj_Alergias_DAL);


            if (Obj_Alergias_DAL.sMsjError == string.Empty)
            {
                MessageBox.Show("Alergias modificadas con éxito",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se presento un error al modificar las alergias Error = [ " +
                                Obj_Personas_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Adicciones_Click_1(object sender, EventArgs e)
        {
            cls_Adicciones_DAL Obj_Adicciones_DAL = new cls_Adicciones_DAL();
            cls_Adicciones_BLL Obj_Adicciones_BLL = new cls_Adicciones_BLL();

            Obj_Adicciones_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);

            for (int i = 0; i < dgv_Adicciones.Rows.Count; i++) //Recorre todo el datagriv para observar cuáles están activos para añadirlos a un string al final separado con un espacio
            {
                // Se comprueba si la segunda columna de la tabla que se este viendo es true y si lo es añade al obj la adicción
                if ((bool)dgv_Adicciones.Rows[i].Cells[1].Value == true)
                {
                    Obj_Adicciones_DAL.sAdiccionesTotales += dgv_Adicciones.Rows[i].Cells[0].Value.ToString() + " ";
                }
            }

            Obj_Adicciones_BLL.Modificar_Adicciones_Pacientes(ref Obj_Adicciones_DAL);


            if (Obj_Adicciones_DAL.sMsjError == string.Empty)
            {
                MessageBox.Show("Adicciones modificadas con éxito",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se presento un error al modificar las adicciones Error = [ " +
                                Obj_Personas_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Modificar_Padecimientos_Click(object sender, EventArgs e)
        {
            cls_Padecimiento_DAL Obj_Padecimientos_DAL = new cls_Padecimiento_DAL();
            cls_Padecimientos_BLL Obj_Padecimientos_BLL = new cls_Padecimientos_BLL();

            Obj_Padecimientos_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);

            for (int i = 0; i < dgv_Padecimientos.Rows.Count; i++) //Recorre todo el datagriv para observar cuáles están activos para añadirlos a un string al final separado con un espacio
            {
                // Se comprueba si la segunda columna de la tabla que se este viendo es true y si lo es añade al obj la adicción
                if ((bool)dgv_Padecimientos.Rows[i].Cells[1].Value == true)
                {
                    Obj_Padecimientos_DAL.sPadecimientosTotales += dgv_Padecimientos.Rows[i].Cells[0].Value.ToString() + " ";
                }
            }

            Obj_Padecimientos_BLL.Modificar_Padecimientos_Pacientes(ref Obj_Padecimientos_DAL);


            if (Obj_Padecimientos_DAL.sMsjError == string.Empty)
            {
                MessageBox.Show("Padecimientos modificadas con éxito",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se presento un error al modificar los padecimientos Error = [ " +
                                Obj_Personas_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }



        private void cmb_Provincias_DropDownClosed(object sender, EventArgs e)
        {
            CargarComboCanton();
            CargarComboDistrito();
        }

        private void cmb_Cantones_DropDownClosed(object sender, EventArgs e)
        {
            CargarComboDistrito();

        }

        private void cmb_Cantones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ActualizarDireccion_Click(object sender, EventArgs e)
        {
            cls_Direcciones_BLL Obj_Direcciones_BLL = new cls_Direcciones_BLL();
            cls_Direcciones_DAL Obj_Direcciones_DAL = new cls_Direcciones_DAL();


            Obj_Direcciones_DAL.ID_Canton = Obj_Provincias_DAL.dsProvincias.Tables["DIRECCIONES"].Rows[cmb_Cantones.SelectedIndex]["ID_Canton"].ToString().Trim();

            Obj_Direcciones_DAL.ID_Provincia = (cmb_Provincias.SelectedIndex + 1).ToString().Trim();

            Obj_Direcciones_DAL.ID_Distrito = (cmb_Distritos.SelectedIndex + 1).ToString().Trim();

            Obj_Direcciones_DAL.Otras_Guias = txt_Direccion.Text;

            Obj_Direcciones_DAL.sIdentificacion = Obj_Personas_DAL.Identificacion;

            Obj_Direcciones_BLL.ModificarDireccion(ref Obj_Direcciones_DAL);

            if (Obj_Direcciones_DAL.sMsjError == string.Empty)
            {
                MessageBox.Show("Datos de la dirección actualizados con éxito",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de la dirección .Error = [ " +
                                Obj_Direcciones_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btn_ModificarDatosPaciente_Click(object sender, EventArgs e)
        {
            Obj_Paciente_DAL.Peso = txt_Peso.Text;
            Obj_Paciente_DAL.sIdentificacion = Obj_Personas_DAL.Identificacion;
            Obj_Paciente_DAL.Altura = txt_Altura.Text;
            if (cmb_TipoSangre.SelectedIndex == 0)
            {
                Obj_Paciente_DAL.Tipo_Sangre = "A";
            }
            else if (cmb_TipoSangre.SelectedIndex == 1)
            {
                Obj_Paciente_DAL.Tipo_Sangre = "B";
            }
            else if (cmb_TipoSangre.SelectedIndex == 2)
            {
                Obj_Paciente_DAL.Tipo_Sangre = "AB";
            }
            else
            {
                Obj_Paciente_DAL.Tipo_Sangre = "C";
            }

            Obj_Paciente_BLL.ModificarDatosPaciente(ref Obj_Paciente_DAL);


            if (Obj_Paciente_DAL.sMsjError == string.Empty)
            {
                MessageBox.Show("Datos del paciente actualizados con éxito",
                                "Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos del paciente.Error = [ " +
                                Obj_Paciente_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        #endregion





        #region METODOS

        private void CargarDatosCitas()
        {



            Obj_Citas_DAL.ID_Paciente = Convert.ToInt32(Obj_Personas_DAL.dsPersonas.Tables["Personas"].Rows[0]["ID_Paciente"]);

            Obj_Citas_BLL.Filtrar_Citas_Expediente(ref Obj_Citas_DAL);

            if (Obj_Citas_DAL.sMsjError == string.Empty)
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID_Cita");
                table.Columns.Add("Especialidad");
                table.Columns.Add("Fecha");
                table.Columns.Add("Consultorio");
                table.Columns.Add("Estado");

                foreach (DataRow row in Obj_Citas_DAL.DsDatos.Tables[0].Rows)
                {
                    DataRow newRow = table.NewRow();
                    newRow["ID_Cita"] = row["ID_Cita"];
                    newRow["Especialidad"] = row["NombreEspecialidad"];
                    newRow["Fecha"] = row["FechaHoraInicio"];
                    newRow["Consultorio"] = row["ID_Consultorio"];
                    switch (row["EstadoCita"])
                    {
                        case "0":

                            newRow["Estado"] = "Pendiente";
                            break;
                        case "1":

                            newRow["Estado"] = "Confirmada";
                            break;
                        case "2":
                            newRow["Estado"] = "Terminada";
                            break;

                        default:
                            newRow["Estado"] = "Cancelada";
                            break;
                    }
                    table.Rows.Add(newRow);
                }




                dgv_Datos_Citas.DataSource = table;


            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de las citas del paciente.Error = [ " +
                                Obj_Paciente_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
        private void CargarDatos()
        {
            CargarDatosCitas();
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
            txt_FechaNacimiento.Text = Convert.ToDateTime(Fila["fecha_nacimiento"]).Day.ToString() + " / " + Convert.ToDateTime(Fila["fecha_nacimiento"]).Month.ToString() + " / " + Convert.ToDateTime(Fila["fecha_nacimiento"]).Year.ToString();

            cmb_Provincias.SelectedIndex = Convert.ToInt32(Fila["ID_Provincia"]) - 1;



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


            CargarDatosClinica();








        }

        private void CargarDatosClinica()
        {
            //LLENADO DE TAB CONTROL DE INFORMACIÓN DEL PACIENTE

            dgv_Adicciones.DataSource = null;

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
                else if (Obj_Paciente_DAL.DtDatos.Rows[0]["Tipo de Sangre"].ToString().Trim() == "B")
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

                Obj_Adicciones_DAL.Descripcion = string.Empty;

                Obj_Adicciones_BLL.Filtrar_Adicciones_Pacientes(ref Obj_Adicciones_DAL);

                dgv_Adicciones.DataSource = Obj_Adicciones_DAL.dsAdicciones.Tables[0];

                dgv_Adicciones.Columns[0].ReadOnly = true;

                //LLENADO DE INFORMACIÓN DE LAS ALERGIAS

                cls_Alergias_DAL Obj_Alergias_DAL = new cls_Alergias_DAL();
                cls_Alergias_BLL Obj_Alergias_BLL = new cls_Alergias_BLL();

                Obj_Alergias_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);
                Obj_Alergias_DAL.Descripcion = string.Empty;
                Obj_Alergias_BLL.Filtrar_Alergias_Pacientes(ref Obj_Alergias_DAL);



                dgv_Alergias.DataSource = Obj_Alergias_DAL.dsAlergias.Tables[0];

                dgv_Alergias.Columns[0].ReadOnly = true;

                //LLENADO DE INFORMACION DE PADECIMIENTOS

                cls_Padecimiento_DAL Obj_Padecimientos_DAL = new cls_Padecimiento_DAL();
                cls_Padecimientos_BLL Obj_Padecimientos_BLL = new cls_Padecimientos_BLL();

                Obj_Padecimientos_DAL.iIdPaciente = Convert.ToInt32(Obj_Paciente_DAL.DtDatos.Rows[0]["CODIGO PACIENTE"]);
                Obj_Padecimientos_DAL.sDescripcion = string.Empty;
                Obj_Padecimientos_BLL.Filtrar_Padecimientos_Pacientes(ref Obj_Padecimientos_DAL);



                dgv_Padecimientos.DataSource = Obj_Padecimientos_DAL.dsPadecimientos.Tables[0];

                dgv_Padecimientos.Columns[0].ReadOnly = true;

            }


        }



        private void CargarComboCanton()
        {
            Obj_Provincias_DAL = new cls_Provincias_DAL();

            cls_Direcciones_BLL Obj_Direcciones_BLL = new cls_Direcciones_BLL();
            cls_Cantones_DAL Obj_Cantones_DAL = new cls_Cantones_DAL();
            cmb_Provincias.DataSource = null;
            cmb_Cantones.DataSource = null;
            cmb_Distritos.DataSource = null;
            Obj_Cantones_DAL.ID_Canton = "";

            Obj_Provincias_DAL.iD_Provincia = (cmb_Provincias.SelectedIndex + 1).ToString().Trim(); //CMB EMPIEZA EN 0 ENTONCES, EL ID PROVINCIA 0 NO EXISTE ENTONCES SE LE SUMA 1
            Obj_Direcciones_BLL.Listar_Direcciones(ref Obj_Provincias_DAL, ref Obj_Cantones_DAL);

            if (Obj_Provincias_DAL.sMsjError == string.Empty)
            {

                cmb_Cantones.DisplayMember = "CANTONES";
                cmb_Cantones.ValueMember = "ID_Provincia";
                cmb_Cantones.DataSource = Obj_Provincias_DAL.dsProvincias.Tables[0];



            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de la dirección .Error = [ " +
                                Obj_Provincias_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }




        private void CargarComboDistrito()
        {
            cls_Cantones_DAL Obj_Cantones_DAL = new cls_Cantones_DAL();
            cls_Direcciones_BLL Obj_Direcciones_BLL = new cls_Direcciones_BLL();
            cmb_Distritos.DataSource = null;

            Obj_Cantones_DAL.ID_Canton = Obj_Provincias_DAL.dsProvincias.Tables["DIRECCIONES"].Rows[cmb_Cantones.SelectedIndex]["ID_Canton"].ToString().Trim();



            Obj_Provincias_DAL.iD_Provincia = (cmb_Provincias.SelectedIndex + 1).ToString().Trim(); //CMB EMPIEZA EN 0 ENTONCES, EL ID PROVINCIA 0 NO EXISTE ENTONCES SE LE SUMA 1

            Obj_Direcciones_BLL.Listar_Direcciones(ref Obj_Provincias_DAL, ref Obj_Cantones_DAL);

            if (Obj_Provincias_DAL.sMsjError == string.Empty)
            {

                cmb_Distritos.DisplayMember = "DISTRITO";
                cmb_Distritos.ValueMember = "ID_Provincia";
                cmb_Distritos.DataSource = Obj_Cantones_DAL.dsCantones.Tables[0];



            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de la dirección .Error = [ " +
                                Obj_Provincias_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }








        #endregion

        private void btn_CargarCita_Click(object sender, EventArgs e)
        {
            CargarCita();
        }



        private void CargarCita()
        {

            if (dgv_Datos_Citas.Rows.Count > 0)
            {

                int numFila = dgv_Datos_Citas.CurrentRow.Index;
                DateTime Fecha = Convert.ToDateTime(Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["FechaHoraInicio"]);
                txt_IDCita.Text = Convert.ToString(Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["ID_Cita"]);
                lbl_infocita.Text = "El día " + Fecha.Day + " de " + Fecha.ToString("MMMM") + " del año " + Fecha.Year + " el paciente " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["Nombre"] + " " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["primer_apellido"] + " " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["segundo_apellido"] +
                                    "\ncon la identificación " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["Identificacion"] + " se presentó en el consultorio número " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["ID_Consultorio"] + "\npara su cita con el doctor " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["NombreDoctor"] + " " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["PrimerApellido_Doctor"] + " " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["SegundoApellido_Doctor"] +
                                    ", especialista en " + Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["NombreEspecialidad"] + "\n\nSe anota la siguiente información acerca de la cita:";
                txt_InfoCita.Text = Obj_Citas_DAL.DsDatos.Tables[0].Rows[numFila]["notasAdd"].ToString();
                MessageBox.Show("Información de la cita cargada con éxito",
                                 "Información o Alerta",
                                 MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                tab_Expediente.SelectTab(1);



            }
            else
            {
                MessageBox.Show("No tiene padecimientos para Editar",
                                 "Información o Alerta",
                                 MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

            }
        }


        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 99) || (e.KeyChar == 109))
            {
                erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }
        }
        private void txt_Telefono_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Telefono_I);
        }

        private void txt_Telefono_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Telefono_II);
        }

        private void ValidaPeso(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8)||(e.KeyChar == 107) || (e.KeyChar == 103) || (e.KeyChar == 108))
            {
                erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }
        }
        private void txt_Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaAltura(e, txt_Altura);
        }

        private void txt_Peso_HideSelectionChanged(object sender, EventArgs e)
        {

        }



        private void ValidaAltura(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8)|| (e.KeyChar == 107) || (e.KeyChar == 76) || (e.KeyChar == 71) || (e.KeyChar == 250))
            {
                erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }
        }
        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaPeso(e, txt_Peso);
        }

        private void txt_Correo_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNoEspacios(e, txt_Correo_I);
        }

        private void txt_Correo_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNoEspacios(e, txt_Correo_II);
        }

        private void ValidaNoEspacios(KeyPressEventArgs e, TextBox txt)
        {

            if (e.KeyChar == 32) 
            {
                
                e.Handled = true;
                erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }
            else
            {
                e.Handled = false;
                erp_Principal.Clear();
                
            }

        }
    }
}


