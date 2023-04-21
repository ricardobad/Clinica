using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Clinica.Catalogos;
using DAL_Clinica.Catalogos;

namespace UI_CLINICA.Ventanas.Mantenimiento
{
    public partial class frm_mantenimientoconsultorio : Form
    {
        public frm_mantenimientoconsultorio()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES

        cls_Consultorios_DAL Obj_Consultorios_DAL = new cls_Consultorios_DAL();
        cls_Consultorios_BLL Obj_Consultorios_BLL = new cls_Consultorios_BLL();

        #endregion

        #region METODOS


        private void CargarDatos()
        {

           dgvConsultorio.DataSource = null;

            

            Obj_Consultorios_BLL.Listar_Filtrar_Consultorios(ref Obj_Consultorios_DAL);

            if (Obj_Consultorios_DAL.sMsjError == string.Empty)
            {
                dgvConsultorio.DataSource = Obj_Consultorios_DAL.DsConsultorios.Tables[0];
            }

            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de consultorios. Error = [" +
                    Obj_Consultorios_DAL.sMsjError + " ].",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgvConsultorio.ReadOnly = true;

        }



        private void EditarConsultorios()
        {



            if (Obj_Consultorios_DAL.CIndAxn == 'N')
            {
                Obj_Consultorios_DAL.ID_Consultorio = 0;
                Obj_Consultorios_DAL.iNumero = Convert.ToInt32(string.Empty);
                Obj_Consultorios_DAL.iEstado = Convert.ToInt32(string.Empty);

            }
            else //"Modificar
            {
                if (dgvConsultorio.Rows.Count > 0)
                {
                    if (MessageBox.Show("Desea Realmente Editar el Consultorio [ " + dgvConsultorio.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ]...???",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Obj_Consultorios_DAL.ID_Consultorio = Convert.ToInt32(dgvConsultorio.SelectedRows[0].Cells[0].Value.ToString().Trim());
                        Obj_Consultorios_DAL.iNumero = Convert.ToInt32(dgvConsultorio.SelectedRows[0].Cells[1].Value.ToString().Trim());
                        if (dgvConsultorio.SelectedRows[0].Cells[2].Value.ToString().Trim() == "True")
                        {
                            cbox_Estado.SelectedItem = "Activo";
                            Obj_Consultorios_DAL.iEstado = 1;
                        }
                        else
                        {
                            cbox_Estado.SelectedItem = "Inactivo";
                            Obj_Consultorios_DAL.iEstado = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No tiene datos para editar",
                        "Información o Alerta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            CargarDatosListar();
            //Ventanas.Mantenimiento.frm_mantenimientoconsultorio Obj_editar = new Editar.frm_Editar_Regiones();
            //Obj_PantEditar.Obj_Consultorios_DAL = Obj_Consultorios_DAL;
            //Obj_PantEditar.ShowDialog();
        }



        public void CargarDatosListar()
        {
            if (Obj_Consultorios_DAL.CIndAxn == 'N')
            {

                txt_IDConsultorio.Enabled = true;
                txt_IDConsultorio.ReadOnly = false;
                txt_IDConsultorio.Text = string.Empty;
                txt_Consul_Num.Text = string.Empty;


            }
            else
            {
                txt_IDConsultorio.Enabled = false;
                txt_IDConsultorio.ReadOnly = true;
                txt_IDConsultorio.Text = Obj_Consultorios_DAL.ID_Consultorio.ToString().Trim();
                txt_Consul_Num.Text = Convert.ToString(Obj_Consultorios_DAL.iNumero);
                if (Obj_Consultorios_DAL.iEstado == 1)
                {
                    cbox_Estado.SelectedItem = "Activo";
                }
                else
                {
                    cbox_Estado.SelectedItem = "Inactivo";
                }
                


            }
        }


        private void AlmacenarDatos()
        {
            //int iTemp = 0;
            //int.TryParse(txt_IDConsultorio.Text.ToString().Trim(), out iTemp);
            //if (iTemp == 0)
            //{
              //  MessageBox.Show("El Id del Consultorio debe ser un numero mayor a 0 y menor a 2147483647, favor corregirlo para continuar.", "Alerta de Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
              //  Obj_Consultorios_DAL.ID_Consultorio = iTemp;
            //}

            if (txt_Consul_Num.Text.Trim() == string.Empty)
            {
                erp_Mensajes.SetError(txt_Consul_Num, "El numero del consultorio no puede ser vacia, favor corregir el error");
            }
            else
            {
                erp_Mensajes.Clear();
                Obj_Consultorios_DAL.iNumero = Convert.ToInt32(txt_Consul_Num.Text.Trim());
                if (cbox_Estado.SelectedItem == "Activo")
                {
                    Obj_Consultorios_DAL.iEstado = 1;
                }
                else
                {
                    Obj_Consultorios_DAL.iEstado = 0;
                }
            }



            //if ((Obj_Consultorios_DAL.ID_Consultorio != 0))
            //{
                if (Obj_Consultorios_DAL.CIndAxn == 'N')
                {



                    Obj_Consultorios_BLL.Crear_Consultorios(ref Obj_Consultorios_DAL);


                    if (Obj_Consultorios_DAL.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Consultorio creada Exitosamente...!!!", "Confirmacióon", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Se Presento un error en la creacion del nuevo consultorio. \n\nError: [ " + Obj_Consultorios_DAL.sMsjError + " ].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    Obj_Consultorios_BLL.Modificar_Consultorios(ref Obj_Consultorios_DAL);

                    if (Obj_Consultorios_DAL.sMsjError == string.Empty)
                    {
                        MessageBox.Show("Consultorio Modificado Exitosamente...!!!", "Confirmacióon", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Se Presento un error en la modificación del Consultorio. \n\nError: [ " + Obj_Consultorios_DAL.sMsjError + " ].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            //}
            Obj_Consultorios_DAL.ID_Consultorio = 0;
            Obj_Consultorios_DAL.iNumero = 0;
            Obj_Consultorios_DAL.iEstado = 0;
            CargarDatos();

            #endregion


        }

        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (btn_Agregar.Text == "Agregar")
            {
                Obj_Consultorios_DAL.CIndAxn = 'N';
            }
            else
            {
                Obj_Consultorios_DAL.CIndAxn = 'M';
            }
            AlmacenarDatos();
            btn_Agregar.Text = "Agregar";

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            Obj_Consultorios_DAL.CIndAxn = 'M';
            EditarConsultorios();
            btn_Agregar.Text = "Actualizar";
            dgvConsultorio.ReadOnly = false;
        }

        private void frm_mantenimientoconsultorio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        public void LimpiarCampos()
        {

            txt_IDConsultorio.Text = "";
            txt_Consul_Num.Text = "";
            cbox_Estado.SelectedItem = "Activo";
            btn_Agregar.Text = "Agregar";
            dgvConsultorio.ReadOnly = true;

        }

       

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            
        }

        private void txt_Consul_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
