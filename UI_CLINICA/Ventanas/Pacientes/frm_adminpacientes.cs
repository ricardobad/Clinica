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
            Obj_Pacientes_DAL.sIdentificacion = txt_Busqueda.Text.Trim().ToString();
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


                    txtx_Nombre.Text = Obj_Pacientes_DAL.sIdentificacion.ToString().Trim();    //Pone el ID en el txt correspondiente
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtx_Nombre.Text == string.Empty || txt_Apellido_I.Text == string.Empty ||
            txt_Apellido_II.Text == string.Empty || txt_Identificacion.Text == string.Empty ||
            txt_Otras_Guias.Text == string.Empty || cmb_Provincia.Text == string.Empty ||
            cmb_Canton.Text == string.Empty || cmb_Distrito.Text == string.Empty ||
            txt_Telefono_I.Text == string.Empty || txtx_Correo_I.Text == string.Empty ||
            cmb_Tipo_ID.Text == string.Empty || cmb_Sexo.Text == string.Empty ||
            cmb_Estado.Text == string.Empty || txtx_Contrasena.Text == string.Empty 

            )
            {
                MessageBox.Show("Debe rellenar todos los campos obligatorios",
                                        "Información o Alerta",
                                        MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

            }

            if (txtx_Contrasena.Text.Length <= 6)
            {
                MessageBox.Show("La contraseña debe tener un minimo de 6 caracteres",
                                        "Información o Alerta",
                                        MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            }

            DateTime A = DateTime.Today;
            DateTime B = dateTimePicker1.Value;

            if (B > A)
            {
                MessageBox.Show("No se aceptan fechas de nacimiento en futuro",
                                        "Información o Alerta",
                                        MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            }

            else
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtx_Nombre.Text = string.Empty;
            txt_Apellido_I.Text = string.Empty;
            txt_Apellido_II.Text = string.Empty;
            txt_Identificacion.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            txt_Otras_Guias.Text = string.Empty;
            cmb_Provincia.Text = string.Empty; ;
            cmb_Canton.Text = string.Empty;
            cmb_Distrito.Text = string.Empty;
            txt_Telefono_I.Text = string.Empty;
            txt_Telefono_II.Text = string.Empty;
            txtx_Correo_I.Text = string.Empty;
            txtx_Correo_I.Text = string.Empty;
            cmb_Tipo_ID.Text = string.Empty;
            cmb_Sexo.Text = string.Empty;
            cmb_Estado.Text = string.Empty;
            txtx_Contrasena.Text = string.Empty;
        }

        private void ValidaTXT(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
               // erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
                //erp_Principal.SetError(txt, "Está presionando una tecla no permitida para esta caja de texto ");
            }

        }

        private void ValidaNumeros(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 43) || (e.KeyChar == 45))
            {
               // erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
               // erp_Principal.SetError(txt, "Solo se admiten numeros");
            }

        }

        private void ValidaNumeros2(KeyPressEventArgs e, TextBox txt)
        {        // LETRAS en teclado       ///Tecla borrar     //Tecla de espacio
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 45))
            {
                //erp_Principal.Clear();
                e.Handled = false; // Permite // Continua 
            }
            else
            {
                e.Handled = true; // Cancela 
               // erp_Principal.SetError(txt, "Solo se admiten numeros");
            }

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txtx_Nombre);
        }

        private void txt_Apellido_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Apellido_I);
        }

        private void txt_Apellido_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaTXT(e, txt_Apellido_II);
        }

        private void txt_Telefono_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(e, txt_Telefono_I);
        }

        private void txt_Telefono_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(e, txt_Telefono_II);
        }

        private void txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros2(e, txt_Busqueda);
        }
    }
}
