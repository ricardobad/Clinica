
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
            this.msEmpleado = new System.Windows.Forms.MenuStrip();
            this.tsmDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Doctor_Paciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Doctor_Expediente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Doctor_Alergias = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAdiccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPadecimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Administrador_Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearModicarDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Administrador_CrearDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Administrador_CrearEspecialidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Administrador_CrearConsultorio = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.msEmpleado.SuspendLayout();
            this.pnlMenuVertical.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // msEmpleado
            // 
            this.msEmpleado.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDoctor,
            this.tsmAdministrador});
            this.msEmpleado.Location = new System.Drawing.Point(0, 0);
            this.msEmpleado.Name = "msEmpleado";
            this.msEmpleado.Size = new System.Drawing.Size(1057, 33);
            this.msEmpleado.TabIndex = 1;
            this.msEmpleado.Text = "msEmpleado";
            // 
            // tsmDoctor
            // 
            this.tsmDoctor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Doctor_Paciente,
            this.tsm_Doctor_Expediente,
            this.tsm_Doctor_Alergias,
            this.crearAdiccionesToolStripMenuItem,
            this.crearPadecimientosToolStripMenuItem});
            this.tsmDoctor.Name = "tsmDoctor";
            this.tsmDoctor.Size = new System.Drawing.Size(101, 29);
            this.tsmDoctor.Text = "Doctor";
            this.tsmDoctor.Click += new System.EventHandler(this.aSToolStripMenuItem_Click);
            // 
            // tsm_Doctor_Paciente
            // 
            this.tsm_Doctor_Paciente.Name = "tsm_Doctor_Paciente";
            this.tsm_Doctor_Paciente.Size = new System.Drawing.Size(391, 30);
            this.tsm_Doctor_Paciente.Text = "Crear / Modificar Paciente";
            this.tsm_Doctor_Paciente.Click += new System.EventHandler(this.crearModificarPacienteToolStripMenuItem_Click);
            // 
            // tsm_Doctor_Expediente
            // 
            this.tsm_Doctor_Expediente.Name = "tsm_Doctor_Expediente";
            this.tsm_Doctor_Expediente.Size = new System.Drawing.Size(391, 30);
            this.tsm_Doctor_Expediente.Text = "Expedientes";
            // 
            // tsm_Doctor_Alergias
            // 
            this.tsm_Doctor_Alergias.Name = "tsm_Doctor_Alergias";
            this.tsm_Doctor_Alergias.Size = new System.Drawing.Size(391, 30);
            this.tsm_Doctor_Alergias.Text = "Crear Alergias";
            // 
            // crearAdiccionesToolStripMenuItem
            // 
            this.crearAdiccionesToolStripMenuItem.Name = "crearAdiccionesToolStripMenuItem";
            this.crearAdiccionesToolStripMenuItem.Size = new System.Drawing.Size(391, 30);
            this.crearAdiccionesToolStripMenuItem.Text = "Crear Adicciones";
            // 
            // crearPadecimientosToolStripMenuItem
            // 
            this.crearPadecimientosToolStripMenuItem.Name = "crearPadecimientosToolStripMenuItem";
            this.crearPadecimientosToolStripMenuItem.Size = new System.Drawing.Size(391, 30);
            this.crearPadecimientosToolStripMenuItem.Text = "Crear padecimientos";
            // 
            // tsmAdministrador
            // 
            this.tsmAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Administrador_Roles,
            this.reportesToolStripMenuItem,
            this.crearModicarDoctorToolStripMenuItem,
            this.tsm_Administrador_CrearDoctor,
            this.tsm_Administrador_CrearEspecialidad,
            this.tsm_Administrador_CrearConsultorio});
            this.tsmAdministrador.Name = "tsmAdministrador";
            this.tsmAdministrador.Size = new System.Drawing.Size(191, 29);
            this.tsmAdministrador.Text = "Administrador";
            // 
            // tsm_Administrador_Roles
            // 
            this.tsm_Administrador_Roles.Name = "tsm_Administrador_Roles";
            this.tsm_Administrador_Roles.Size = new System.Drawing.Size(414, 30);
            this.tsm_Administrador_Roles.Text = "Roles";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(414, 30);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // crearModicarDoctorToolStripMenuItem
            // 
            this.crearModicarDoctorToolStripMenuItem.Name = "crearModicarDoctorToolStripMenuItem";
            this.crearModicarDoctorToolStripMenuItem.Size = new System.Drawing.Size(414, 30);
            this.crearModicarDoctorToolStripMenuItem.Text = "Mantenimiento Doctor";
            // 
            // tsm_Administrador_CrearDoctor
            // 
            this.tsm_Administrador_CrearDoctor.Name = "tsm_Administrador_CrearDoctor";
            this.tsm_Administrador_CrearDoctor.Size = new System.Drawing.Size(414, 30);
            this.tsm_Administrador_CrearDoctor.Text = "Mantenimiento Empleado";
            // 
            // tsm_Administrador_CrearEspecialidad
            // 
            this.tsm_Administrador_CrearEspecialidad.Name = "tsm_Administrador_CrearEspecialidad";
            this.tsm_Administrador_CrearEspecialidad.Size = new System.Drawing.Size(414, 30);
            this.tsm_Administrador_CrearEspecialidad.Text = "Mantenimiento Especialidad";
            // 
            // tsm_Administrador_CrearConsultorio
            // 
            this.tsm_Administrador_CrearConsultorio.Name = "tsm_Administrador_CrearConsultorio";
            this.tsm_Administrador_CrearConsultorio.Size = new System.Drawing.Size(414, 30);
            this.tsm_Administrador_CrearConsultorio.Text = "Mantenimiento Consultorio";
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.pnlMenuVertical.Controls.Add(this.panel10);
            this.pnlMenuVertical.Controls.Add(this.panel6);
            this.pnlMenuVertical.Controls.Add(this.panel5);
            this.pnlMenuVertical.Controls.Add(this.panel4);
            this.pnlMenuVertical.Controls.Add(this.panel3);
            this.pnlMenuVertical.Controls.Add(this.panel2);
            this.pnlMenuVertical.Controls.Add(this.panel1);
            this.pnlMenuVertical.Controls.Add(this.button5);
            this.pnlMenuVertical.Controls.Add(this.button4);
            this.pnlMenuVertical.Controls.Add(this.button3);
            this.pnlMenuVertical.Controls.Add(this.button2);
            this.pnlMenuVertical.Controls.Add(this.button1);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 33);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(200, 551);
            this.pnlMenuVertical.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(3, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Citas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button2.Location = new System.Drawing.Point(3, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Doctor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button3.Location = new System.Drawing.Point(0, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Administrador";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button4.Location = new System.Drawing.Point(3, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cajas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button5.Location = new System.Drawing.Point(0, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Servicio al cliente";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 39);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel2.Location = new System.Drawing.Point(0, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 39);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 39);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel4.Location = new System.Drawing.Point(0, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 39);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel5.Location = new System.Drawing.Point(0, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 39);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(63, 246);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 97);
            this.panel6.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 27);
            this.button6.TabIndex = 8;
            this.button6.Text = "Roles";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel7.Location = new System.Drawing.Point(2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 27);
            this.panel7.TabIndex = 7;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel8.Location = new System.Drawing.Point(2, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 27);
            this.panel8.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button7.Location = new System.Drawing.Point(2, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 27);
            this.button7.TabIndex = 10;
            this.button7.Text = "Reportes";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel9.Location = new System.Drawing.Point(2, 68);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 27);
            this.panel9.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button8.Location = new System.Drawing.Point(3, 68);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 27);
            this.button8.TabIndex = 10;
            this.button8.Text = "Mantenimientos";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.button9);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.button10);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.button11);
            this.panel10.Location = new System.Drawing.Point(66, 394);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(134, 97);
            this.panel10.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel11.Location = new System.Drawing.Point(2, 68);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(7, 27);
            this.panel11.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button9.Location = new System.Drawing.Point(3, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 27);
            this.button9.TabIndex = 10;
            this.button9.Text = "Mantenimiento";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel12.Location = new System.Drawing.Point(2, 35);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(7, 27);
            this.panel12.TabIndex = 9;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button10.Location = new System.Drawing.Point(2, 35);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 27);
            this.button10.TabIndex = 10;
            this.button10.Text = "Expedientes";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.panel13.Location = new System.Drawing.Point(2, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(7, 27);
            this.panel13.TabIndex = 7;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(131, 27);
            this.button11.TabIndex = 8;
            this.button11.Text = "Crear Paciente";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // frm_menuempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 584);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.msEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menuempleado";
            this.Text = "frm_menuempleado";
            this.msEmpleado.ResumeLayout(false);
            this.msEmpleado.PerformLayout();
            this.pnlMenuVertical.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmDoctor;
        private System.Windows.Forms.ToolStripMenuItem tsm_Doctor_Paciente;
        private System.Windows.Forms.ToolStripMenuItem tsm_Doctor_Expediente;
        private System.Windows.Forms.ToolStripMenuItem tsm_Doctor_Alergias;
        private System.Windows.Forms.ToolStripMenuItem crearAdiccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPadecimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrador;
        private System.Windows.Forms.ToolStripMenuItem tsm_Administrador_Roles;
        private System.Windows.Forms.ToolStripMenuItem tsm_Administrador_CrearDoctor;
        private System.Windows.Forms.ToolStripMenuItem tsm_Administrador_CrearEspecialidad;
        private System.Windows.Forms.ToolStripMenuItem tsm_Administrador_CrearConsultorio;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearModicarDoctorToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button11;
    }
}