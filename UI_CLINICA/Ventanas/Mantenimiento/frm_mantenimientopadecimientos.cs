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
    public partial class frm_mantenimientopadecimientos : Form
    {
        #region Variables Globales

        cls_Padecimiento_DAL Obj_Padecimientos_DAL = new cls_Padecimiento_DAL();
        cls_Padecimientos_BLL Obj_Padecimientos_BLL = new cls_Padecimientos_BLL();

        #endregion
        public frm_mantenimientopadecimientos()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void frm_mantenimientopadecimientos_Load(object sender, EventArgs e)
        {
            cmb_Estados.SelectedIndex = 0;
            CargarDatos();
            CargarCombos();
        }

        private void CargarDatos()
        {
            dgv_Datos.DataSource = null;

            Obj_Padecimientos_DAL.sDescripcion = txt_Filtro.Text.Trim(); 

            Obj_Padecimientos_BLL.Listar_Filtrar_Padecimientos(ref Obj_Padecimientos_DAL);

            if (Obj_Padecimientos_DAL.sMsjError == string.Empty)
            {
                dgv_Datos.DataSource = Obj_Padecimientos_DAL.dsPadecimientos.Tables[0];


            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Padecimientos Error = [ " +
                                Obj_Padecimientos_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(txt_ID.Text.Trim() == string.Empty)
            {
                if (dgv_Datos.Rows.Count > 0)
                {
                    if (MessageBox.Show("Desea realmente editar el Padecimiento [ " + dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Obj_Padecimientos_DAL.ID_Padecimiento = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[0].Value.ToString().Trim());
                        Obj_Padecimientos_DAL.sDescripcion = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim();
                        Obj_Padecimientos_DAL.ID_Doctor = Convert.ToInt32(dgv_Datos.SelectedRows[0].Cells[2].Value.ToString().Trim());


                        
                        txt_ID.Text = Obj_Padecimientos_DAL.ID_Padecimiento.ToString().Trim();    //Pone el ID en el txt correspondiente
                        txt_Nombre.Text = Obj_Padecimientos_DAL.sDescripcion.Trim();   //Pone el nombre en el txt correspondiente
                        cmb_Estados.SelectedItem = dgv_Datos.SelectedRows[0].Cells[3].Value.ToString().Trim();

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
                if(txt_Nombre.Text.Trim() != string.Empty)
                {
                    if (MessageBox.Show("Desea realmente editar el Padecimiento [ " + Obj_Padecimientos_DAL.sDescripcion + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Obj_Padecimientos_DAL.sDescripcion = txt_Nombre.Text;
                        if (cmb_Estados.SelectedIndex == 0)
                        {
                            Obj_Padecimientos_DAL.booEstado = true;
                        }
                        else
                        {
                            Obj_Padecimientos_DAL.booEstado = false;
                        }


                        Obj_Padecimientos_BLL.Modificar_Padecimientos(ref Obj_Padecimientos_DAL);

                        if (Obj_Padecimientos_DAL.sMsjError == String.Empty)
                        {
                            MessageBox.Show("Padecimiento modificado exitosamente...!!!",
                                            "Proceso Exitoso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            CargarDatos();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Se presentó un error en la modificación del Padecimiento.\n\nError: [ " + Obj_Padecimientos_DAL.sMsjError + " ].",
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txt_Nombre.Text = string.Empty;
            txt_ID.Text = string.Empty;
            txt_Filtro.Text = string.Empty;
            //falta
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if(txt_ID.Text == string.Empty)
            {
                if (txt_Nombre.Text.Trim() != string.Empty)
                {
                    cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
                    cls_Doctores_BLL Obj_Doctores_BLL = new cls_Doctores_BLL();


                    Obj_Padecimientos_DAL.sDescripcion = txt_Nombre.Text.Trim();
                    if (cmb_Estados.SelectedIndex == 0)
                    {
                        Obj_Padecimientos_DAL.booEstado = true;
                    }
                    else
                    {
                        Obj_Padecimientos_DAL.booEstado = false;
                    }

                    Obj_Doctores_DAL.Carnet = cmbDoctores.Text;
                    Obj_Doctores_BLL.Listar_Filtrar_Doctores(ref Obj_Doctores_DAL);

                    DataRow primeraFila = Obj_Doctores_DAL.dsDoctores.Tables["Doctores"].Rows[0];
                    Obj_Padecimientos_DAL.ID_Doctor = Convert.ToInt32(primeraFila["ID_Doctor"]);

                    Obj_Padecimientos_BLL.Crear_Padecimientos(ref Obj_Padecimientos_DAL);

                    if (Obj_Padecimientos_DAL.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo Padecimiento creado exitosamente...!!!",
                                        "Proceso Exitoso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        CargarDatos();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error en la creación de un nuevo Padecimiento .\n\nError: [" + Obj_Padecimientos_DAL.sMsjError + " ].",
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
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Regiones.Error = [ " +
                                Obj_Doctores_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }




      
        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 32))
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

        }

        private void txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Filtro);
        }

        
    }

   


}

