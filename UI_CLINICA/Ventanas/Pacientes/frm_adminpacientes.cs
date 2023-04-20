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

namespace UI_CLINICA.Ventanas.Pacientes
{
    public partial class frm_adminpacientes : Form
    {

        cls_Pacientes_BLL Obj_Pacientes_BLL = new cls_Pacientes_BLL();
        cls_Pacientes_DAL Obj_Pacientes_DAL = new cls_Pacientes_DAL();
        cls_BD_BLL BD_BLL = new cls_BD_BLL();
        cls_BD_DAL BD_DAL = new cls_BD_DAL();

        public frm_adminpacientes()
        {
            InitializeComponent();
        }

        private void frm_adminpacientes_Load(object sender, EventArgs e)
        {
            txt_Busqueda.Text = "";
            CargarDatos_II();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #region Metodos

        private void CargarDatos_II()
        {
            Obj_Pacientes_DAL.sID_Persona = txt_Busqueda.Text.Trim().ToString();
            Obj_Pacientes_BLL.listar_filtrar_Pacientes(ref Obj_Pacientes_DAL);

            if (Obj_Pacientes_DAL.sMsjError == string.Empty)
            {
                dgv_Pacientes.DataSource = null;
                dgv_Pacientes.DataSource = Obj_Pacientes_DAL.DtDatos;
            }
            else
            {
                MessageBox.Show("Se ha presentado un error al cargar los datos" + Obj_Pacientes_DAL.sMsjError, "Error en carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void btn_Cargar_Click(object sender, EventArgs e)
        {

            if (dgv_Pacientes.Rows.Count > 0)
            {
                if (MessageBox.Show("Desea realmente editar el Paciente [ " + dgv_Pacientes.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                        "Información o Alerta",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_Pacientes_DAL.ID_Paciente = Convert.ToInt32(dgv_Pacientes.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    Obj_Pacientes_DAL.Peso = dgv_Pacientes.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    Obj_Pacientes_DAL.Altura = dgv_Pacientes.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    Obj_Pacientes_DAL.Tipo_Sangre = dgv_Pacientes.SelectedRows[0].Cells[3].Value.ToString().Trim();


                    txtx_Nombre.Text = Obj_Pacientes_DAL.sID_Persona.ToString().Trim();    //Pone el ID en el txt correspondiente
                    txt_Apellido_I.Text = Obj_Pacientes_DAL.Tipo_Sangre.Trim();   //Pone el nombre en el txt correspondiente

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
    }
}
