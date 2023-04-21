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
            cmb_Estados.SelectedIndex = 0;
            CargarDatos();
        }
        #region METODOS




        private void CargarDatos()
        {
            CargarCombos();
            DAL_Adicciones.Descripcion = txt_Filtro.Text.Trim();
            BLL_Adicciones.listar_Adicciones(ref DAL_Adicciones);
            dgv_Datos.DataSource = null;



            if (DAL_Adicciones.sMsjError == string.Empty)
            {
                dgv_Datos.DataSource = DAL_Adicciones.dsAdicciones.Tables[0];


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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != string.Empty)
            { 

                if (txt_Nombre.Text.Trim() != string.Empty)
                {

                cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
                cls_Doctores_BLL Obj_Doctores_BLL = new cls_Doctores_BLL();

                DAL_Adicciones.Descripcion = txt_Nombre.Text.Trim();
                if (cmb_Estados.SelectedIndex == 0)
                {
                    DAL_Adicciones.booEstado = true;
                }
                else
                {
                    DAL_Adicciones.booEstado = false;
                }

                Obj_Doctores_DAL.Carnet = cmbDoctores.Text;
                Obj_Doctores_BLL.Listar_Filtrar_Doctores(ref Obj_Doctores_DAL);

                DataRow primeraFila = Obj_Doctores_DAL.dsDoctores.Tables["Doctores"].Rows[0];  //Trae el ID DEL DOCTOR
                DAL_Adicciones.ID_Doctor = Convert.ToInt32(primeraFila["ID_Doctor"]);

                BLL_Adicciones.Insertar_Adicciones(ref DAL_Adicciones);

                if (DAL_Adicciones.sMsjError == string.Empty)
                {
                    MessageBox.Show("Nueva Adicción creado exitosamente...!!!",
                                    "Proceso Éxitoso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    CargarDatos();
    
                }
                else
                {
                    MessageBox.Show("Se presentó un error en la creación de una nueva adicción .\n\nError: [" + DAL_Adicciones.sMsjError + " ].",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            }
            else
            {
                MessageBox.Show("No se puede crear si está en proceso de modificación.\n\n Utilice el botón limpiar para limpiar los datos o concluya su modificación ",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
            }
        }

        public void CargarCombos()
        {
            cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
            cls_Doctores_BLL Obj_Doctores_BLL = new cls_Doctores_BLL();

            cmbDoctores.DataSource = null;

            Obj_Doctores_DAL.Carnet = string.Empty;

            Obj_Doctores_BLL.Listar_Filtrar_Doctores(ref Obj_Doctores_DAL);

            if (Obj_Doctores_DAL.sMsjError == string.Empty)
            {

                cmbDoctores.DisplayMember = "Carnet";
                cmbDoctores.ValueMember = "ID_Doctor";
                cmbDoctores.DataSource = Obj_Doctores_DAL.dsDoctores.Tables[0];
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos del Doctor.Error = [ " +
                                Obj_Doctores_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {

                txt_Nombre.Text = string.Empty;
                txt_ID.Text = string.Empty;
                txt_Filtro.Text = string.Empty;
   

        }

        private void bnt_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == string.Empty)
            {
                if (dgv_Datos.Rows.Count > 0)
                {
                    if (MessageBox.Show("Desea realmente editar la Adicción [ " + dgv_Datos.SelectedRows[0].Cells[2].Value.ToString().Trim() + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DAL_Adicciones.ID_Adiccion = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString().Trim());
                        DAL_Adicciones.ID_Doctor = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim());
                        DAL_Adicciones.Descripcion = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString().Trim();
                        



                        txt_ID.Text = DAL_Adicciones.ID_Adiccion.ToString().Trim();    //Pone el ID en el txt correspondiente
                        txt_Nombre.Text = DAL_Adicciones.Descripcion.Trim();   //Pone el nombre en el txt correspondiente

                    }
                }
                else
                {
                    MessageBox.Show("No tiene padecimientos para Editar",
                                     "Información o Alerta",
                                     MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                }
            }
            else
            {
                if (txt_Nombre.Text.Trim() != string.Empty)
                {
                    if (MessageBox.Show("Desea realmente editar el Padecimiento [ " + DAL_Adicciones.Descripcion + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        DAL_Adicciones.Descripcion = txt_Nombre.Text;
                        if (cmb_Estados.SelectedIndex == 0)
                        {
                            DAL_Adicciones.booEstado = true;
                        }
                        else
                        {
                            DAL_Adicciones.booEstado = false;
                        }


                        BLL_Adicciones.Modificar_Adicciones(ref DAL_Adicciones);

                        if (DAL_Adicciones.sMsjError == String.Empty)
                        {
                            MessageBox.Show("Adicción modificada exitosamente...!!!",
                                            "Proceso Exitoso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            CargarDatos();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Se presentó un error en la modificación del Adicción.\n\nError: [ " + DAL_Adicciones.sMsjError + " ].",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                    }


                }
            }
    }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
                CargarDatos();
        }

        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8))
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

        private Boolean EspaciosVacioYLimite(TextBox txt)
        {
            if (txt.Text.Trim() == string.Empty)
            {

                txt.Focus();
                erp_Principal.SetError(txt, "No permite espacio vacíos   ");

                return false;
            }

            else
            {
                erp_Principal.Clear();
                return true;
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            EspaciosVacioYLimite(txt_Nombre);
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Nombre);
        }

        private void txt_Filtro_Leave(object sender, EventArgs e)
        {
            EspaciosVacioYLimite(txt_Nombre);
        }

        private void txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Nombre);
        }
    }
}
