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
    public partial class frm_mantenimientoespecialidad : Form
    {
        #region VARIABLES GLOBALES

        cls_Especialidades_DAL Obj_Especialidades_DAL = new cls_Especialidades_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();
        cls_Especialidades_BLL Obj_Especialidades_BLL = new cls_Especialidades_BLL();
        #endregion
        public frm_mantenimientoespecialidad()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void frm_mantenimientoespecialidad_Load(object sender, EventArgs e)
        {
            CargarDatos();


        }


        #region MÉTODOS

        private void CargarDatos()
        {

            dgvEspecialidades.DataSource = null;



            Obj_Especialidades_BLL.listar_especialidades(ref Obj_Especialidades_DAL);

            if (Obj_Especialidades_DAL.sMsjError == string.Empty)
            {
                dgvEspecialidades.DataSource = Obj_Especialidades_DAL.dsEspecialidades.Tables[0];
            }

            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de consultorios. Error = [" +
                    Obj_Especialidades_DAL.sMsjError + " ].",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgvEspecialidades.ReadOnly = true;

        }

        //private void EliminarDatos()
        //{
        //    if (dgv_Datos.Rows.Count >= 1)
        //    {
        //        if (MessageBox.Show("Confirma que desea eliminar realmente el Centro [ " + dgv_Datos.SelectedRows[0].Cells[0].Value.ToString() + " - "
        //            + dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ]...???",
        //                               "Confirmación",
        //                               MessageBoxButtons.YesNo,
        //                               MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            Obj_Centros_DAL.sCodCentro = dgv_Datos.SelectedRows[0].Cells[0].Value.ToString();

        //            Obj_Centros_BLL.eliminar_Centros(ref Obj_Centros_DAL);

        //            if (Obj_Centros_DAL.sMsjError == string.Empty)
        //            {
        //                MessageBox.Show("El Centro [ " + dgv_Datos.SelectedRows[0].Cells[0].Value.ToString() + " - "
        //                                               + dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ], fue eliminada exitosamente",
        //                               "Proceso Exitoso",
        //                               MessageBoxButtons.OK,
        //                               MessageBoxIcon.Information);

        //                CargarDatos();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Se ha presentado un error a la hora de eliminar el centro [ " + dgv_Datos.SelectedRows[0].Cells[0].Value.ToString() + " - "
        //                                                                                               + dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim() +
        //                                                                                               " ].\n\n Error¨: [ " + Obj_Centros_DAL.sMsjError + " ].",
        //                                "Error eliminando el centro",
        //                                MessageBoxButtons.OK,
        //                                MessageBoxIcon.Error);

        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No tiene centros para poder eliminar.",
        //                        "Alerta",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Exclamation);
        //    }
        //}

        //private void EditarDatos(char cOpcion)
        //{
        //    Pantallas.Editar.frm_Editar_CENTROS Pant_Editar = new Editar.frm_Editar_CENTROS();

        //    Obj_Centros_DAL.cAxn = cOpcion;

        //    if (cOpcion == 'U')
        //    {
        //        if (dgv_Datos.Rows.Count >= 1)
        //        {
        //            if (MessageBox.Show("Confirma que desea Editar o Modificar realmente el centro [ " + dgv_Datos.SelectedRows[0].Cells[0].Value.ToString() + " - "
        //                + dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ]...???",
        //                                   "Confirmación",
        //                                   MessageBoxButtons.YesNo,
        //                                   MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                Obj_Centros_DAL.sCodCentro = dgv_Datos.SelectedRows[0].Cells[0].Value.ToString().Trim();
        //                Obj_Centros_DAL.sCodJunta = dgv_Datos.SelectedRows[0].Cells[1].Value.ToString().Trim();
        //                Obj_Centros_DAL.sCedJur = dgv_Datos.SelectedRows[0].Cells[2].Value.ToString().Trim();
        //                Obj_Centros_DAL.sNombreC = dgv_Datos.SelectedRows[0].Cells[3].Value.ToString().Trim();
        //                Obj_Centros_DAL.sDirrecionC = dgv_Datos.SelectedRows[0].Cells[4].Value.ToString().Trim();

        //                Pant_Editar.Obj_Centros_Recibe_DAL = Obj_Centros_DAL;

        //                Pant_Editar.ShowDialog();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No tiene centros para poder eliminar.",
        //                            "Alerta",
        //                            MessageBoxButtons.OK,
        //                            MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    else
        //    {
        //        Pant_Editar.Obj_Centros_Recibe_DAL = Obj_Centros_DAL;

        //        Pant_Editar.ShowDialog();
        //    }
        //}


        #endregion

        private void dgvNumero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ValidaNU(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 32) || (char.IsDigit(e.KeyChar)))
            {
                //erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                //erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }

        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNU(e, textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            cmb_Estado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }
    }
}
