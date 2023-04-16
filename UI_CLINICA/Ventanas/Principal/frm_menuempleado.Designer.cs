
namespace UI_CLINICA.Ventanas.Principal
{
    partial class frm_menuempleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menuempleado));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlMenuGeneral = new System.Windows.Forms.Panel();
            this.pnlMenuDoctor = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenuAdmin = new System.Windows.Forms.Panel();
            this.pnlMenuCitas = new System.Windows.Forms.Panel();
            this.pnlMenuPacientes = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPacientesCrear = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnCitasVisualizar = new System.Windows.Forms.Button();
            this.btnCitasModificar = new System.Windows.Forms.Button();
            this.btnCitasCrear = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnAdminEspecialidades = new System.Windows.Forms.Button();
            this.btnAdminDoctores = new System.Windows.Forms.Button();
            this.btnAdminEmpleados = new System.Windows.Forms.Button();
            this.btnAdminConsultorios = new System.Windows.Forms.Button();
            this.btnAdminReportes = new System.Windows.Forms.Button();
            this.btnAdminRoles = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDoctorPadecimientos = new System.Windows.Forms.Button();
            this.btnDoctorExpedientes = new System.Windows.Forms.Button();
            this.btnDoctorAlergias = new System.Windows.Forms.Button();
            this.btnDoctorAdicciones = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlMenuGeneral.SuspendLayout();
            this.pnlMenuDoctor.SuspendLayout();
            this.pnlMenuAdmin.SuspendLayout();
            this.pnlMenuCitas.SuspendLayout();
            this.pnlMenuPacientes.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(934, 35);
            this.pnlTitulo.TabIndex = 3;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // pnlMenuGeneral
            // 
            this.pnlMenuGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.pnlMenuGeneral.Controls.Add(this.btnCerrarSesion);
            this.pnlMenuGeneral.Controls.Add(this.pnlMenuPacientes);
            this.pnlMenuGeneral.Controls.Add(this.btnPacientes);
            this.pnlMenuGeneral.Controls.Add(this.pnlMenuCitas);
            this.pnlMenuGeneral.Controls.Add(this.btnCitas);
            this.pnlMenuGeneral.Controls.Add(this.pnlMenuAdmin);
            this.pnlMenuGeneral.Controls.Add(this.btnAdmin);
            this.pnlMenuGeneral.Controls.Add(this.pnlMenuDoctor);
            this.pnlMenuGeneral.Controls.Add(this.btnDoctor);
            this.pnlMenuGeneral.Location = new System.Drawing.Point(0, 240);
            this.pnlMenuGeneral.Name = "pnlMenuGeneral";
            this.pnlMenuGeneral.Size = new System.Drawing.Size(200, 599);
            this.pnlMenuGeneral.TabIndex = 4;
            // 
            // pnlMenuDoctor
            // 
            this.pnlMenuDoctor.Controls.Add(this.btnDoctorPadecimientos);
            this.pnlMenuDoctor.Controls.Add(this.btnDoctorExpedientes);
            this.pnlMenuDoctor.Controls.Add(this.btnDoctorAlergias);
            this.pnlMenuDoctor.Controls.Add(this.btnDoctorAdicciones);
            this.pnlMenuDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuDoctor.Location = new System.Drawing.Point(0, 39);
            this.pnlMenuDoctor.Name = "pnlMenuDoctor";
            this.pnlMenuDoctor.Size = new System.Drawing.Size(200, 117);
            this.pnlMenuDoctor.TabIndex = 23;
            this.pnlMenuDoctor.Visible = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 33);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(732, 686);
            this.pnlContenedor.TabIndex = 5;
            // 
            // pnlMenuAdmin
            // 
            this.pnlMenuAdmin.Controls.Add(this.btnAdminEspecialidades);
            this.pnlMenuAdmin.Controls.Add(this.btnAdminDoctores);
            this.pnlMenuAdmin.Controls.Add(this.btnAdminEmpleados);
            this.pnlMenuAdmin.Controls.Add(this.btnAdminConsultorios);
            this.pnlMenuAdmin.Controls.Add(this.btnAdminReportes);
            this.pnlMenuAdmin.Controls.Add(this.btnAdminRoles);
            this.pnlMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuAdmin.Location = new System.Drawing.Point(0, 195);
            this.pnlMenuAdmin.Name = "pnlMenuAdmin";
            this.pnlMenuAdmin.Size = new System.Drawing.Size(200, 174);
            this.pnlMenuAdmin.TabIndex = 23;
            this.pnlMenuAdmin.Visible = false;
            // 
            // pnlMenuCitas
            // 
            this.pnlMenuCitas.Controls.Add(this.btnCitasVisualizar);
            this.pnlMenuCitas.Controls.Add(this.btnCitasModificar);
            this.pnlMenuCitas.Controls.Add(this.btnCitasCrear);
            this.pnlMenuCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuCitas.Location = new System.Drawing.Point(0, 408);
            this.pnlMenuCitas.Name = "pnlMenuCitas";
            this.pnlMenuCitas.Size = new System.Drawing.Size(200, 88);
            this.pnlMenuCitas.TabIndex = 26;
            this.pnlMenuCitas.Visible = false;
            // 
            // pnlMenuPacientes
            // 
            this.pnlMenuPacientes.Controls.Add(this.btnPacientesCrear);
            this.pnlMenuPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuPacientes.Location = new System.Drawing.Point(0, 529);
            this.pnlMenuPacientes.Name = "pnlMenuPacientes";
            this.pnlMenuPacientes.Size = new System.Drawing.Size(200, 32);
            this.pnlMenuPacientes.TabIndex = 28;
            this.pnlMenuPacientes.Visible = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Location = new System.Drawing.Point(0, 35);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 207);
            this.pnlLogo.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnPacientesCrear
            // 
            this.btnPacientesCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientesCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientesCrear.FlatAppearance.BorderSize = 0;
            this.btnPacientesCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientesCrear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientesCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPacientesCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientesCrear.Image")));
            this.btnPacientesCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientesCrear.Location = new System.Drawing.Point(0, 0);
            this.btnPacientesCrear.Name = "btnPacientesCrear";
            this.btnPacientesCrear.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPacientesCrear.Size = new System.Drawing.Size(200, 27);
            this.btnPacientesCrear.TabIndex = 8;
            this.btnPacientesCrear.Text = "Crear Paciente";
            this.btnPacientesCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPacientesCrear.UseVisualStyleBackColor = true;
            this.btnPacientesCrear.Click += new System.EventHandler(this.btnPacientesCrear_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Image")));
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 496);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPacientes.Size = new System.Drawing.Size(200, 33);
            this.btnPacientes.TabIndex = 26;
            this.btnPacientes.Text = "Paciente";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnCitasVisualizar
            // 
            this.btnCitasVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasVisualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasVisualizar.FlatAppearance.BorderSize = 0;
            this.btnCitasVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitasVisualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasVisualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCitasVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnCitasVisualizar.Image")));
            this.btnCitasVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitasVisualizar.Location = new System.Drawing.Point(0, 54);
            this.btnCitasVisualizar.Name = "btnCitasVisualizar";
            this.btnCitasVisualizar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCitasVisualizar.Size = new System.Drawing.Size(200, 27);
            this.btnCitasVisualizar.TabIndex = 11;
            this.btnCitasVisualizar.Text = "Visualizar Citas";
            this.btnCitasVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCitasVisualizar.UseVisualStyleBackColor = true;
            this.btnCitasVisualizar.Click += new System.EventHandler(this.btnCitasVisualizar_Click);
            // 
            // btnCitasModificar
            // 
            this.btnCitasModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasModificar.FlatAppearance.BorderSize = 0;
            this.btnCitasModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitasModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCitasModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnCitasModificar.Image")));
            this.btnCitasModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitasModificar.Location = new System.Drawing.Point(0, 27);
            this.btnCitasModificar.Name = "btnCitasModificar";
            this.btnCitasModificar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCitasModificar.Size = new System.Drawing.Size(200, 27);
            this.btnCitasModificar.TabIndex = 10;
            this.btnCitasModificar.Text = "Modificar Citas";
            this.btnCitasModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCitasModificar.UseVisualStyleBackColor = true;
            this.btnCitasModificar.Click += new System.EventHandler(this.btnCitasModificar_Click);
            // 
            // btnCitasCrear
            // 
            this.btnCitasCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasCrear.FlatAppearance.BorderSize = 0;
            this.btnCitasCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitasCrear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCitasCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCitasCrear.Image")));
            this.btnCitasCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitasCrear.Location = new System.Drawing.Point(0, 0);
            this.btnCitasCrear.Name = "btnCitasCrear";
            this.btnCitasCrear.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCitasCrear.Size = new System.Drawing.Size(200, 27);
            this.btnCitasCrear.TabIndex = 8;
            this.btnCitasCrear.Text = "Crear Citas";
            this.btnCitasCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCitasCrear.UseVisualStyleBackColor = true;
            this.btnCitasCrear.Click += new System.EventHandler(this.btnCitasCrear_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCitas.Image = ((System.Drawing.Image)(resources.GetObject("btnCitas.Image")));
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(0, 369);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCitas.Size = new System.Drawing.Size(200, 39);
            this.btnCitas.TabIndex = 25;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click_1);
            // 
            // btnAdminEspecialidades
            // 
            this.btnAdminEspecialidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnAdminEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEspecialidades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEspecialidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdminEspecialidades.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminEspecialidades.Image")));
            this.btnAdminEspecialidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEspecialidades.Location = new System.Drawing.Point(0, 135);
            this.btnAdminEspecialidades.Name = "btnAdminEspecialidades";
            this.btnAdminEspecialidades.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminEspecialidades.Size = new System.Drawing.Size(200, 27);
            this.btnAdminEspecialidades.TabIndex = 12;
            this.btnAdminEspecialidades.Text = "Especialidades";
            this.btnAdminEspecialidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminEspecialidades.UseVisualStyleBackColor = true;
            this.btnAdminEspecialidades.Click += new System.EventHandler(this.btnAdminEspecialidades_Click);
            // 
            // btnAdminDoctores
            // 
            this.btnAdminDoctores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminDoctores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminDoctores.FlatAppearance.BorderSize = 0;
            this.btnAdminDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDoctores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDoctores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdminDoctores.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminDoctores.Image")));
            this.btnAdminDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminDoctores.Location = new System.Drawing.Point(0, 108);
            this.btnAdminDoctores.Name = "btnAdminDoctores";
            this.btnAdminDoctores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminDoctores.Size = new System.Drawing.Size(200, 27);
            this.btnAdminDoctores.TabIndex = 14;
            this.btnAdminDoctores.Text = "Doctores";
            this.btnAdminDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminDoctores.UseVisualStyleBackColor = true;
            this.btnAdminDoctores.Click += new System.EventHandler(this.btnAdminDoctores_Click);
            // 
            // btnAdminEmpleados
            // 
            this.btnAdminEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminEmpleados.FlatAppearance.BorderSize = 0;
            this.btnAdminEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdminEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminEmpleados.Image")));
            this.btnAdminEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEmpleados.Location = new System.Drawing.Point(0, 81);
            this.btnAdminEmpleados.Name = "btnAdminEmpleados";
            this.btnAdminEmpleados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminEmpleados.Size = new System.Drawing.Size(200, 27);
            this.btnAdminEmpleados.TabIndex = 10;
            this.btnAdminEmpleados.Text = "Empleados";
            this.btnAdminEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminEmpleados.UseVisualStyleBackColor = true;
            this.btnAdminEmpleados.Click += new System.EventHandler(this.btnAdminEmpleados_Click);
            // 
            // btnAdminConsultorios
            // 
            this.btnAdminConsultorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminConsultorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminConsultorios.FlatAppearance.BorderSize = 0;
            this.btnAdminConsultorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminConsultorios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminConsultorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdminConsultorios.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminConsultorios.Image")));
            this.btnAdminConsultorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminConsultorios.Location = new System.Drawing.Point(0, 54);
            this.btnAdminConsultorios.Name = "btnAdminConsultorios";
            this.btnAdminConsultorios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminConsultorios.Size = new System.Drawing.Size(200, 27);
            this.btnAdminConsultorios.TabIndex = 14;
            this.btnAdminConsultorios.Text = "Consultorios";
            this.btnAdminConsultorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminConsultorios.UseVisualStyleBackColor = true;
            this.btnAdminConsultorios.Click += new System.EventHandler(this.btnAdminConsultorios_Click);
            // 
            // btnAdminReportes
            // 
            this.btnAdminReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminReportes.FlatAppearance.BorderSize = 0;
            this.btnAdminReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdminReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminReportes.Image")));
            this.btnAdminReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminReportes.Location = new System.Drawing.Point(0, 27);
            this.btnAdminReportes.Name = "btnAdminReportes";
            this.btnAdminReportes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminReportes.Size = new System.Drawing.Size(200, 27);
            this.btnAdminReportes.TabIndex = 10;
            this.btnAdminReportes.Text = "Reportes";
            this.btnAdminReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminReportes.UseVisualStyleBackColor = true;
            this.btnAdminReportes.Click += new System.EventHandler(this.btnAdminReportes_Click);
            // 
            // btnAdminRoles
            // 
            this.btnAdminRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminRoles.FlatAppearance.BorderSize = 0;
            this.btnAdminRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminRoles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdminRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminRoles.Image")));
            this.btnAdminRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminRoles.Location = new System.Drawing.Point(0, 0);
            this.btnAdminRoles.Name = "btnAdminRoles";
            this.btnAdminRoles.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAdminRoles.Size = new System.Drawing.Size(200, 27);
            this.btnAdminRoles.TabIndex = 8;
            this.btnAdminRoles.Text = "Roles";
            this.btnAdminRoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminRoles.UseVisualStyleBackColor = true;
            this.btnAdminRoles.Click += new System.EventHandler(this.btnAdminRoles_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 156);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(200, 39);
            this.btnAdmin.TabIndex = 14;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDoctorPadecimientos
            // 
            this.btnDoctorPadecimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorPadecimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorPadecimientos.FlatAppearance.BorderSize = 0;
            this.btnDoctorPadecimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorPadecimientos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorPadecimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDoctorPadecimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctorPadecimientos.Image")));
            this.btnDoctorPadecimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorPadecimientos.Location = new System.Drawing.Point(0, 81);
            this.btnDoctorPadecimientos.Name = "btnDoctorPadecimientos";
            this.btnDoctorPadecimientos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDoctorPadecimientos.Size = new System.Drawing.Size(200, 27);
            this.btnDoctorPadecimientos.TabIndex = 10;
            this.btnDoctorPadecimientos.Text = "Padecimientos";
            this.btnDoctorPadecimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctorPadecimientos.UseVisualStyleBackColor = true;
            this.btnDoctorPadecimientos.Click += new System.EventHandler(this.btnDoctorPadecimientos_Click);
            // 
            // btnDoctorExpedientes
            // 
            this.btnDoctorExpedientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorExpedientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorExpedientes.FlatAppearance.BorderSize = 0;
            this.btnDoctorExpedientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorExpedientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorExpedientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDoctorExpedientes.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctorExpedientes.Image")));
            this.btnDoctorExpedientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorExpedientes.Location = new System.Drawing.Point(0, 54);
            this.btnDoctorExpedientes.Name = "btnDoctorExpedientes";
            this.btnDoctorExpedientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDoctorExpedientes.Size = new System.Drawing.Size(200, 27);
            this.btnDoctorExpedientes.TabIndex = 10;
            this.btnDoctorExpedientes.Text = "Expedientes";
            this.btnDoctorExpedientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctorExpedientes.UseVisualStyleBackColor = true;
            this.btnDoctorExpedientes.Click += new System.EventHandler(this.btnDoctorExpedientes_Click);
            // 
            // btnDoctorAlergias
            // 
            this.btnDoctorAlergias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorAlergias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorAlergias.FlatAppearance.BorderSize = 0;
            this.btnDoctorAlergias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorAlergias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorAlergias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDoctorAlergias.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctorAlergias.Image")));
            this.btnDoctorAlergias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorAlergias.Location = new System.Drawing.Point(0, 27);
            this.btnDoctorAlergias.Name = "btnDoctorAlergias";
            this.btnDoctorAlergias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDoctorAlergias.Size = new System.Drawing.Size(200, 27);
            this.btnDoctorAlergias.TabIndex = 10;
            this.btnDoctorAlergias.Text = "Alergias";
            this.btnDoctorAlergias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctorAlergias.UseVisualStyleBackColor = true;
            this.btnDoctorAlergias.Click += new System.EventHandler(this.btnDoctorAlergias_Click);
            // 
            // btnDoctorAdicciones
            // 
            this.btnDoctorAdicciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorAdicciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorAdicciones.FlatAppearance.BorderSize = 0;
            this.btnDoctorAdicciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorAdicciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorAdicciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDoctorAdicciones.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctorAdicciones.Image")));
            this.btnDoctorAdicciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorAdicciones.Location = new System.Drawing.Point(0, 0);
            this.btnDoctorAdicciones.Name = "btnDoctorAdicciones";
            this.btnDoctorAdicciones.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDoctorAdicciones.Size = new System.Drawing.Size(200, 27);
            this.btnDoctorAdicciones.TabIndex = 8;
            this.btnDoctorAdicciones.Text = "Adicciones";
            this.btnDoctorAdicciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctorAdicciones.UseVisualStyleBackColor = true;
            this.btnDoctorAdicciones.Click += new System.EventHandler(this.btnDoctorAdicciones_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctor.Image")));
            this.btnDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctor.Location = new System.Drawing.Point(0, 0);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDoctor.Size = new System.Drawing.Size(200, 39);
            this.btnDoctor.TabIndex = 13;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(900, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 561);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 33);
            this.btnCerrarSesion.TabIndex = 28;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frm_menuempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 719);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenuGeneral);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menuempleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_menuempleado";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlMenuGeneral.ResumeLayout(false);
            this.pnlMenuDoctor.ResumeLayout(false);
            this.pnlMenuAdmin.ResumeLayout(false);
            this.pnlMenuCitas.ResumeLayout(false);
            this.pnlMenuPacientes.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlMenuGeneral;
        private System.Windows.Forms.Panel pnlMenuDoctor;
        private System.Windows.Forms.Button btnDoctorExpedientes;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnDoctorPadecimientos;
        private System.Windows.Forms.Button btnDoctorAlergias;
        private System.Windows.Forms.Button btnDoctorAdicciones;
        private System.Windows.Forms.Panel pnlMenuPacientes;
        private System.Windows.Forms.Button btnPacientesCrear;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Panel pnlMenuCitas;
        private System.Windows.Forms.Button btnCitasVisualizar;
        private System.Windows.Forms.Button btnCitasModificar;
        private System.Windows.Forms.Button btnCitasCrear;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Panel pnlMenuAdmin;
        private System.Windows.Forms.Button btnAdminEspecialidades;
        private System.Windows.Forms.Button btnAdminDoctores;
        private System.Windows.Forms.Button btnAdminEmpleados;
        private System.Windows.Forms.Button btnAdminConsultorios;
        private System.Windows.Forms.Button btnAdminReportes;
        private System.Windows.Forms.Button btnAdminRoles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}