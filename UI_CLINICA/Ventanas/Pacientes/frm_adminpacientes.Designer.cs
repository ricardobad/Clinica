
namespace UI_CLINICA.Ventanas.Pacientes
{
    partial class frm_adminpacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_adminpacientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb_Provincia = new System.Windows.Forms.ComboBox();
            this.cmb_Distrito = new System.Windows.Forms.ComboBox();
            this.lbl_Distrito = new System.Windows.Forms.Label();
            this.cmb_Tipo_ID = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Correo_II = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Telefono_II = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtx_Correo_I = new System.Windows.Forms.TextBox();
            this.txt_Telefono_I = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtx_Contrasena = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.cmb_Canton = new System.Windows.Forms.ComboBox();
            this.txt_Otras_Guias = new System.Windows.Forms.TextBox();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.txt_Apellido_II = new System.Windows.Forms.TextBox();
            this.txtx_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido_I = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_Pacientes = new System.Windows.Forms.DataGridView();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.tbControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 120;
            this.label2.Text = "Identificación";
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.Location = new System.Drawing.Point(146, 27);
            this.txt_Busqueda.MaxLength = 14;
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(192, 33);
            this.txt_Busqueda.TabIndex = 118;
            this.txt_Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Identificacion_KeyPress);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Controls.Add(this.label7);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(747, 44);
            this.pnlTitulo.TabIndex = 238;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1440, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(126, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 38);
            this.label7.TabIndex = 231;
            this.label7.Text = "Mantenimiento de Pacientes";
            // 
            // tbControl1
            // 
            this.tbControl1.Controls.Add(this.tabPage1);
            this.tbControl1.Controls.Add(this.tabPage2);
            this.tbControl1.Location = new System.Drawing.Point(23, 60);
            this.tbControl1.Name = "tbControl1";
            this.tbControl1.SelectedIndex = 0;
            this.tbControl1.Size = new System.Drawing.Size(695, 604);
            this.tbControl1.TabIndex = 242;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.cmb_Provincia);
            this.tabPage1.Controls.Add(this.cmb_Distrito);
            this.tabPage1.Controls.Add(this.lbl_Distrito);
            this.tabPage1.Controls.Add(this.cmb_Tipo_ID);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txt_Correo_II);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txt_Telefono_II);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtx_Correo_I);
            this.tabPage1.Controls.Add(this.txt_Telefono_I);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtx_Contrasena);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cmb_Estado);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cmb_Sexo);
            this.tabPage1.Controls.Add(this.cmb_Canton);
            this.tabPage1.Controls.Add(this.txt_Otras_Guias);
            this.tabPage1.Controls.Add(this.txt_Identificacion);
            this.tabPage1.Controls.Add(this.txt_Apellido_II);
            this.tabPage1.Controls.Add(this.txtx_Nombre);
            this.tabPage1.Controls.Add(this.txt_Apellido_I);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informacion Personal                             ";
            // 
            // cmb_Provincia
            // 
            this.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Provincia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Provincia.FormattingEnabled = true;
            this.cmb_Provincia.Location = new System.Drawing.Point(8, 156);
            this.cmb_Provincia.Name = "cmb_Provincia";
            this.cmb_Provincia.Size = new System.Drawing.Size(139, 27);
            this.cmb_Provincia.TabIndex = 276;
            // 
            // cmb_Distrito
            // 
            this.cmb_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Distrito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distrito.FormattingEnabled = true;
            this.cmb_Distrito.Location = new System.Drawing.Point(384, 156);
            this.cmb_Distrito.Name = "cmb_Distrito";
            this.cmb_Distrito.Size = new System.Drawing.Size(237, 27);
            this.cmb_Distrito.TabIndex = 275;
            // 
            // lbl_Distrito
            // 
            this.lbl_Distrito.AutoSize = true;
            this.lbl_Distrito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.lbl_Distrito.Location = new System.Drawing.Point(451, 131);
            this.lbl_Distrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Distrito.Name = "lbl_Distrito";
            this.lbl_Distrito.Size = new System.Drawing.Size(61, 19);
            this.lbl_Distrito.TabIndex = 274;
            this.lbl_Distrito.Text = "Distrito:";
            // 
            // cmb_Tipo_ID
            // 
            this.cmb_Tipo_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipo_ID.FormattingEnabled = true;
            this.cmb_Tipo_ID.Location = new System.Drawing.Point(10, 231);
            this.cmb_Tipo_ID.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Tipo_ID.Name = "cmb_Tipo_ID";
            this.cmb_Tipo_ID.Size = new System.Drawing.Size(138, 21);
            this.cmb_Tipo_ID.TabIndex = 273;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button3.Location = new System.Drawing.Point(133, 528);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 31);
            this.button3.TabIndex = 272;
            this.button3.Text = "Crear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 223);
            this.pictureBox1.TabIndex = 271;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Correo_II
            // 
            this.txt_Correo_II.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Correo_II.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo_II.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Correo_II.Location = new System.Drawing.Point(384, 289);
            this.txt_Correo_II.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Correo_II.MaxLength = 50;
            this.txt_Correo_II.Name = "txt_Correo_II";
            this.txt_Correo_II.Size = new System.Drawing.Size(229, 31);
            this.txt_Correo_II.TabIndex = 269;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label12.Location = new System.Drawing.Point(451, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 268;
            this.label12.Text = "Correo 2:";
            // 
            // txt_Telefono_II
            // 
            this.txt_Telefono_II.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefono_II.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono_II.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Telefono_II.Location = new System.Drawing.Point(384, 96);
            this.txt_Telefono_II.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Telefono_II.MaxLength = 18;
            this.txt_Telefono_II.Name = "txt_Telefono_II";
            this.txt_Telefono_II.Size = new System.Drawing.Size(229, 31);
            this.txt_Telefono_II.TabIndex = 267;
            this.txt_Telefono_II.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_II_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label13.Location = new System.Drawing.Point(451, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 19);
            this.label13.TabIndex = 266;
            this.label13.Text = "Teléfono 2:";
            // 
            // txtx_Correo_I
            // 
            this.txtx_Correo_I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtx_Correo_I.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx_Correo_I.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtx_Correo_I.Location = new System.Drawing.Point(384, 222);
            this.txtx_Correo_I.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtx_Correo_I.MaxLength = 50;
            this.txtx_Correo_I.Name = "txtx_Correo_I";
            this.txtx_Correo_I.Size = new System.Drawing.Size(229, 31);
            this.txtx_Correo_I.TabIndex = 265;
            // 
            // txt_Telefono_I
            // 
            this.txt_Telefono_I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefono_I.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono_I.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Telefono_I.Location = new System.Drawing.Point(384, 35);
            this.txt_Telefono_I.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Telefono_I.MaxLength = 18;
            this.txt_Telefono_I.Name = "txt_Telefono_I";
            this.txt_Telefono_I.Size = new System.Drawing.Size(229, 31);
            this.txt_Telefono_I.TabIndex = 264;
            this.txt_Telefono_I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_I_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label20.Location = new System.Drawing.Point(451, 198);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 19);
            this.label20.TabIndex = 263;
            this.label20.Text = "Correo 1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label14.Location = new System.Drawing.Point(451, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 19);
            this.label14.TabIndex = 262;
            this.label14.Text = "Teléfono 1:";
            // 
            // txtx_Contrasena
            // 
            this.txtx_Contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtx_Contrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx_Contrasena.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtx_Contrasena.Location = new System.Drawing.Point(11, 374);
            this.txtx_Contrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtx_Contrasena.MaxLength = 16;
            this.txtx_Contrasena.Name = "txtx_Contrasena";
            this.txtx_Contrasena.PasswordChar = '*';
            this.txtx_Contrasena.Size = new System.Drawing.Size(141, 31);
            this.txtx_Contrasena.TabIndex = 258;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label11.Location = new System.Drawing.Point(32, 347);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 257;
            this.label11.Text = "Contraseña:";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Location = new System.Drawing.Point(187, 301);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(139, 27);
            this.cmb_Estado.TabIndex = 251;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label10.Location = new System.Drawing.Point(212, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 250;
            this.label10.Text = "Estado:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button1.Location = new System.Drawing.Point(242, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 242;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 305);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 23);
            this.dateTimePicker1.TabIndex = 248;
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Location = new System.Drawing.Point(188, 96);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(139, 27);
            this.cmb_Sexo.TabIndex = 247;
            // 
            // cmb_Canton
            // 
            this.cmb_Canton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Canton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Canton.FormattingEnabled = true;
            this.cmb_Canton.Location = new System.Drawing.Point(187, 156);
            this.cmb_Canton.Name = "cmb_Canton";
            this.cmb_Canton.Size = new System.Drawing.Size(139, 27);
            this.cmb_Canton.TabIndex = 241;
            // 
            // txt_Otras_Guias
            // 
            this.txt_Otras_Guias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Otras_Guias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Otras_Guias.Location = new System.Drawing.Point(11, 435);
            this.txt_Otras_Guias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Otras_Guias.MaxLength = 80;
            this.txt_Otras_Guias.Multiline = true;
            this.txt_Otras_Guias.Name = "txt_Otras_Guias";
            this.txt_Otras_Guias.Size = new System.Drawing.Size(318, 83);
            this.txt_Otras_Guias.TabIndex = 233;
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Identificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Identificacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Identificacion.Location = new System.Drawing.Point(187, 222);
            this.txt_Identificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.Size = new System.Drawing.Size(139, 31);
            this.txt_Identificacion.TabIndex = 222;
            // 
            // txt_Apellido_II
            // 
            this.txt_Apellido_II.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Apellido_II.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido_II.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Apellido_II.Location = new System.Drawing.Point(8, 95);
            this.txt_Apellido_II.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Apellido_II.MaxLength = 50;
            this.txt_Apellido_II.Name = "txt_Apellido_II";
            this.txt_Apellido_II.Size = new System.Drawing.Size(139, 31);
            this.txt_Apellido_II.TabIndex = 221;
            this.txt_Apellido_II.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_II_KeyPress);
            // 
            // txtx_Nombre
            // 
            this.txtx_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtx_Nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx_Nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtx_Nombre.Location = new System.Drawing.Point(8, 35);
            this.txtx_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtx_Nombre.MaxLength = 50;
            this.txtx_Nombre.Name = "txtx_Nombre";
            this.txtx_Nombre.Size = new System.Drawing.Size(139, 31);
            this.txtx_Nombre.TabIndex = 180;
            this.txtx_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellido_I
            // 
            this.txt_Apellido_I.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Apellido_I.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido_I.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Apellido_I.Location = new System.Drawing.Point(188, 35);
            this.txt_Apellido_I.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Apellido_I.MaxLength = 50;
            this.txt_Apellido_I.Name = "txt_Apellido_I";
            this.txt_Apellido_I.Size = new System.Drawing.Size(140, 31);
            this.txt_Apellido_I.TabIndex = 139;
            this.txt_Apellido_I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_I_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(15, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 232;
            this.label1.Text = "Dirección Exacta:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label21.Location = new System.Drawing.Point(212, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 19);
            this.label21.TabIndex = 179;
            this.label21.Text = "Apellido 1:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label33.Location = new System.Drawing.Point(232, 74);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 19);
            this.label33.TabIndex = 148;
            this.label33.Text = "Sexo:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label28.Location = new System.Drawing.Point(197, 198);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(119, 19);
            this.label28.TabIndex = 153;
            this.label28.Text = "Identificación:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label31.Location = new System.Drawing.Point(36, 131);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 19);
            this.label31.TabIndex = 160;
            this.label31.Text = "Provincia:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label22.Location = new System.Drawing.Point(44, 11);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 19);
            this.label22.TabIndex = 138;
            this.label22.Text = "Nombre:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label26.Location = new System.Drawing.Point(7, 270);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(180, 19);
            this.label26.TabIndex = 142;
            this.label26.Text = "Fecha de nacimiento:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label30.Location = new System.Drawing.Point(212, 131);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 19);
            this.label30.TabIndex = 161;
            this.label30.Text = "Cantón:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label29.Location = new System.Drawing.Point(4, 201);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(155, 19);
            this.label29.TabIndex = 158;
            this.label29.Text = "Tipo Identificación:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.label17.Location = new System.Drawing.Point(32, 76);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 19);
            this.label17.TabIndex = 181;
            this.label17.Text = "Apellido 2:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.btn_Cargar);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dgv_Pacientes);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_Busqueda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 578);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Buscar Paciente";
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cargar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.btn_Cargar.Location = new System.Drawing.Point(215, 535);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(231, 37);
            this.btn_Cargar.TabIndex = 248;
            this.btn_Cargar.Text = "Cargar información";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button2.Location = new System.Drawing.Point(356, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 33);
            this.button2.TabIndex = 243;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgv_Pacientes
            // 
            this.dgv_Pacientes.AllowUserToOrderColumns = true;
            this.dgv_Pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Pacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Pacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgv_Pacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Pacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_Pacientes.ColumnHeadersHeight = 30;
            this.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Pacientes.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_Pacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Pacientes.EnableHeadersVisualStyles = false;
            this.dgv_Pacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.dgv_Pacientes.Location = new System.Drawing.Point(20, 70);
            this.dgv_Pacientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Pacientes.MultiSelect = false;
            this.dgv_Pacientes.Name = "dgv_Pacientes";
            this.dgv_Pacientes.ReadOnly = true;
            this.dgv_Pacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Pacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_Pacientes.RowHeadersVisible = false;
            this.dgv_Pacientes.RowHeadersWidth = 62;
            this.dgv_Pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pacientes.Size = new System.Drawing.Size(631, 457);
            this.dgv_Pacientes.TabIndex = 243;
            // 
            // frm_adminpacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(747, 652);
            this.Controls.Add(this.tbControl1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_adminpacientes";
            this.Text = "frm_adminpacientes";
            this.Load += new System.EventHandler(this.frm_adminpacientes_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.tbControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tbControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_Sexo;
        private System.Windows.Forms.ComboBox cmb_Canton;
        private System.Windows.Forms.TextBox txt_Otras_Guias;
        private System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.TextBox txt_Apellido_II;
        private System.Windows.Forms.TextBox txtx_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido_I;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_Pacientes;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtx_Contrasena;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.TextBox txt_Correo_II;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Telefono_II;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtx_Correo_I;
        private System.Windows.Forms.TextBox txt_Telefono_I;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_Tipo_ID;
        private System.Windows.Forms.ComboBox cmb_Distrito;
        private System.Windows.Forms.Label lbl_Distrito;
        private System.Windows.Forms.ComboBox cmb_Provincia;
    }
}