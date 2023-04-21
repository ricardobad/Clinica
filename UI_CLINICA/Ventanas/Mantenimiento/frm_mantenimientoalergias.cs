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
    public partial class frm_mantenimientoalergias : Form
    {
        //#region VARIABLES GLOBALES

        //cls_Alergias_DAL DAL_Alergias = new cls_Alergias_DAL();
        //cls_BD_BLL BD_BLL = new cls_BD_BLL();
        //cls_BD_DAL BD_DAL = new cls_BD_DAL();
        //cls_Alergias_BLL BLL_Alergias = new cls_Alergias_BLL();
        //#endregion

        #region Variables Globales

        cls_Alergias_DAL Obj_Alergias_DAL = new cls_Alergias_DAL();
        cls_Alergias_BLL Obj_Alergias_BLL = new cls_Alergias_BLL();

        #endregion

        public frm_mantenimientoalergias()
        {
            InitializeComponent();
        }

        private void frm_mantenimientoalergias_Load(object sender, EventArgs e)
        {
            cmb_Estados.SelectedIndex = 0;
            CargarDatos();
            CargarCombos();
        }

        #region MÉTODOS

        //private void CargarDatos()
        //{

        //    BLL_Alergias.listar_alergias(ref DAL_Alergias);

        //    //aqui se llama al datagrid del formulario

        //    if (DAL_Alergias.sMsjError == string.Empty)
        //    {
        //        dgvNumero.DataSource = null;

        //        dgvNumero.DataSource = DAL_Alergias.DtDatos;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Se ha presentado un error al cargar los datos \n\n" + DAL_Alergias.sMsjError,
        //            "Error en carga de datos",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);

        //    }
        //}

        private void CargarDatos()
        {
            dgvNumero.DataSource = null;

            Obj_Alergias_DAL.Descripcion = txt_Filtro.Text.Trim();

            Obj_Alergias_BLL.Listar_Filtrar_Alergias(ref Obj_Alergias_DAL);

            if (Obj_Alergias_DAL.sMsjError == string.Empty)
            {
                dgvNumero.DataSource = Obj_Alergias_DAL.dsAlergias.Tables[0];


            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de ejecutar el listado de los datos de Padecimientos Error = [ " +
                                Obj_Alergias_DAL.sMsjError + " ].",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }



        private void dgvNumero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == string.Empty)
            {
                if (dgvNumero.Rows.Count > 0)
                {
                    if (MessageBox.Show("Desea realmente editar la Alergia [ " + dgvNumero.SelectedRows[0].Cells[1].Value.ToString().Trim() + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Obj_Alergias_DAL.ID_Alergia = Convert.ToInt32(dgvNumero.SelectedRows[0].Cells[0].Value.ToString().Trim());
                        Obj_Alergias_DAL.Descripcion = dgvNumero.SelectedRows[0].Cells[1].Value.ToString().Trim();
                        Obj_Alergias_DAL.ID_Doctor = Convert.ToInt32(dgvNumero.SelectedRows[0].Cells[2].Value.ToString().Trim());



                        textBox1.Text = Obj_Alergias_DAL.ID_Alergia.ToString().Trim();    //Pone el ID en el txt correspondiente
                        textBox2.Text = Obj_Alergias_DAL.Descripcion.Trim();   //Pone el nombre en el txt correspondiente

                    }
                }
                else
                {
                    MessageBox.Show("No tiene Alergias para Editar",
                                     "Información o Alerta",
                                     MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                }
            }
            else
            {
                if (textBox2.Text.Trim() != string.Empty)
                {
                    if (MessageBox.Show("Desea realmente editar la Alergia [ " + Obj_Alergias_DAL.Descripcion + " ] ...?",//seleccionar la celda marcada con el nombre de la region
                            "Información o Alerta",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Obj_Alergias_DAL.Descripcion = textBox2.Text;
                        if (cmb_Estados.SelectedIndex == 0)
                        {
                            Obj_Alergias_DAL.bEstado = true;
                        }
                        else
                        {
                            Obj_Alergias_DAL.bEstado = false;
                        }


                        Obj_Alergias_BLL.Modificar_Alergias(ref Obj_Alergias_DAL);

                        if (Obj_Alergias_DAL.sMsjError == String.Empty)
                        {
                            MessageBox.Show("Alergia modificada exitosamente...!!!",
                                            "Proceso Exitoso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            CargarDatos();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Se presentó un error en la modificación de la Alergia.\n\nError: [ " + Obj_Alergias_DAL.sMsjError + " ].",
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
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            txt_Filtro.Text = string.Empty;
            //falta
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != string.Empty)
            {
                cls_Doctores_DAL Obj_Doctores_DAL = new cls_Doctores_DAL();
                cls_Doctores_BLL Obj_Doctores_BLL = new cls_Doctores_BLL();

                Obj_Alergias_DAL.ID_Doctor = 1;
                Obj_Alergias_DAL.Descripcion = textBox2.Text.Trim();
                if (cmb_Estados.SelectedIndex == 0)
                {
                    Obj_Alergias_DAL.bEstado = true;
                }
                else
                {
                    Obj_Alergias_DAL.bEstado = false;
                }

                Obj_Doctores_DAL.Carnet = cmbDoctores.Text;
                Obj_Doctores_BLL.Listar_Filtrar_Doctores(ref Obj_Doctores_DAL);

                DataRow primeraFila = Obj_Doctores_DAL.dsDoctores.Tables["Doctores"].Rows[0];
                Obj_Alergias_DAL.ID_Doctor = Convert.ToInt32(primeraFila["ID_Doctor"]);

                Obj_Alergias_BLL.Crear_Alergias(ref Obj_Alergias_DAL);

                if (Obj_Alergias_DAL.sMsjError == string.Empty)
                {
                    MessageBox.Show("Nueva Alergia creada exitosamente...!!!",
                                    "Proceso Éxitoso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    CargarDatos();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Se presentó un error en la creación de una nueva Alergia .\n\nError: [" + Obj_Alergias_DAL.sMsjError + " ].",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

            else {
                MessageBox.Show("no Digito ningun nombre  ].",
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

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Filtro.Text = "";
            textBox2.Text = "";
        }

        private void txt_Filtro_TextChanged_1(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
