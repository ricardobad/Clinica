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

namespace UI_CLINICA.Ventanas.Roles
{
    public partial class frm_Roles : Form
    {
        public frm_Roles()
        {
            InitializeComponent();
        }
        #region VARIABLES GLOBALES

        cls_Roles_DAL Obj_Roles_DAL = new cls_Roles_DAL();
        cls_Roles_BLL Obj_Roles_BLL = new cls_Roles_BLL();

        #endregion

        #region METODOS


        private void CargarDatos()
        {

            dgvRoles.DataSource = null;



            Obj_Roles_BLL.Listar_Filtrar_Roles(ref Obj_Roles_DAL);

            if (Obj_Roles_DAL.sMsjError == string.Empty)
            {
                dgvRoles.DataSource = Obj_Roles_DAL.dsRoles.Tables[0];
            }

            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de consultorios. Error = [" +
                    Obj_Roles_DAL.sMsjError + " ].",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgvRoles.ReadOnly = true;

        }



        private void EditarRoles()
        {



            if (Obj_Roles_DAL.cIndAxn == 'N')
            {
                Obj_Roles_DAL.sIDRol = string.Empty;
                Obj_Roles_DAL.sDescripcion = string.Empty;
                Obj_Roles_DAL.iEstado = Convert.ToInt32(string.Empty);

            }
            else //"Modificar
            {
                if (dgvRoles.Rows.Count > 0)
                {
                    if (MessageBox.Show("Desea Realmente Editar el Rol [ " + dgvRoles.SelectedRows[0].Cells[0].Value.ToString().Trim() + " ]...???",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Obj_Roles_DAL.sIDRol = dgvRoles.SelectedRows[0].Cells[0].Value.ToString().Trim();
                        Obj_Roles_DAL.sDescripcion = dgvRoles.SelectedRows[0].Cells[1].Value.ToString().Trim();
                        Obj_Roles_DAL.ITipoLE = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells[2].Value.ToString().Trim());
                        Obj_Roles_DAL.ITipoES = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells[3].Value.ToString().Trim());
                        if (dgvRoles.SelectedRows[0].Cells[4].Value.ToString().Trim() == "True")
                        {
                            cbo_Estado.SelectedItem = "Activo";
                            Obj_Roles_DAL.iEstado = 1;
                        }
                        else
                        {
                            cbo_Estado.SelectedItem = "Inactivo";
                            Obj_Roles_DAL.iEstado = 0;
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
            if (Obj_Roles_DAL.cIndAxn == 'N')
            {

                txt_IDRol.Enabled = true;
                txt_IDRol.ReadOnly = false;
                txt_IDRol.Text = string.Empty;
                txt_Descripcion.Text = string.Empty;
                cbox_Escritura.Checked = false;
                cbox_Lectura.Checked = false;


            }
            else
            {
                txt_IDRol.Enabled = true;
                txt_IDRol.ReadOnly = false;
                txt_IDRol.Text = Obj_Roles_DAL.sIDRol.ToString().Trim();
                txt_Descripcion.Text = Obj_Roles_DAL.sDescripcion;
                if (Obj_Roles_DAL.ITipoLE == 1)
                {
                    cbox_Lectura.Checked = true;

                }
                else
                {
                    cbox_Lectura.Checked = false;
                }

                if (Obj_Roles_DAL.ITipoES == 1)
                {
                    cbox_Escritura.Checked = true;

                }
                else
                {
                    cbox_Escritura.Checked = false;
                }


                if (Obj_Roles_DAL.iEstado == 1)
                {
                    cbo_Estado.SelectedItem = "Activo";
                }
                else
                {
                    cbo_Estado.SelectedItem = "Inactivo";
                }



            }
        }


        private void AlmacenarDatos()
        {
            //int iTemp = 0;
            //int.TryParse(txt_IDConsultorio.Text.ToString().Trim(), out iTemp);
            if (txt_IDRol.Text.Trim() == "")
            {
              MessageBox.Show("El Id de Rol no puede ser vacio, favor corregirlo para continuar.", "Alerta de Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Obj_Roles_DAL.sIDRol = txt_IDRol.Text.Trim();
            }

            if(txt_Descripcion.Text.Trim() == string.Empty || txt_IDRol.Text.Trim() == string.Empty)
            {
                erp_Mensajes.SetError(txt_Descripcion, "El campo de Descripcion no puede ser vacia, favor corregir el error");
                //btn_Agregar.Enabled = false;
                MessageBox.Show("No debe dejar campos de texto vacios para crear un nuevo Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                erp_Mensajes.Clear();
                Obj_Roles_DAL.sDescripcion = txt_Descripcion.Text.Trim();
                if (cbo_Estado.SelectedItem == "Activo")
                {
                    Obj_Roles_DAL.iEstado = 1;
                }
                else
                {
                    Obj_Roles_DAL.iEstado = 0;
                }
            }



            if (Obj_Roles_DAL.sIDRol != null || Obj_Roles_DAL.sDescripcion != null)
            {
            if (Obj_Roles_DAL.cIndAxn == 'N')
            {



                Obj_Roles_BLL.Crear_Roles(ref Obj_Roles_DAL);


                if (Obj_Roles_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Rol creada Exitosamente...!!!", "Confirmacióon", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Se Presento un error en la creacion del nuevo Rol. \n\nError: [ " + Obj_Roles_DAL.sMsjError + " ].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                Obj_Roles_BLL.Modificar_Roles(ref Obj_Roles_DAL);

                if (Obj_Roles_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Rol Modificado Exitosamente...!!!", "Confirmacióon", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Se Presento un error en la modificación del Rol. \n\nError: [ " + Obj_Roles_DAL.sMsjError + " ].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            }
            Obj_Roles_DAL.sIDRol = null;
            Obj_Roles_DAL.sDescripcion = null;
            Obj_Roles_DAL.iEstado = 0;
            Obj_Roles_DAL.ITipoES = 0;
            Obj_Roles_DAL.ITipoLE = 0;
            CargarDatos();

            #endregion

            

        }



        #region EVENTOS

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (btn_Agregar.Text == "Agregar")
            {
                Obj_Roles_DAL.cIndAxn = 'N';
            }
            else
            {
                Obj_Roles_DAL.cIndAxn = 'M';
            }
            AlmacenarDatos();
            btn_Agregar.Text = "Agregar";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Obj_Roles_DAL.cIndAxn = 'M';
            EditarRoles();
            btn_Agregar.Text = "Actualizar";
            dgvRoles.ReadOnly = false;
        }

        private void frm_Roles_Load(object sender, EventArgs e)
        {

            CargarDatos();

            //dgvPermisos.Rows.Add("Crear Cita");
            //dgvPermisos.Rows.Add("Editar Cita (Pago)");
            //dgvPermisos.Rows.Add("Editar Cita (Confirmación)");
            //dgvPermisos.Rows.Add("Modulo Doctor");
            //dgvPermisos.Rows.Add("Modulo Administrador");
            //dgvPermisos.Rows.Add("Modulo Pacientes");

        }

        public void LimpiarCampos()
        {

            txt_IDRol.Text = "";
            txt_Descripcion.Text = "";
            cbo_Estado.SelectedItem = "Activo";
            btn_Agregar.Text = "Agregar";
            dgvRoles.ReadOnly = true;
            cbox_Escritura.Checked = false;
            cbox_Lectura.Checked = false;

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        


        #endregion

        
    }
}
