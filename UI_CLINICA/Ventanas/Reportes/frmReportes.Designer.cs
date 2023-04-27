
namespace UI_CLINICA.Ventanas.Reportes
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cld_Final = new System.Windows.Forms.MonthCalendar();
            this.cld_inicio = new System.Windows.Forms.MonthCalendar();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Reportes = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reportes)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Enabled = false;
            this.txtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(179, 88);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(242, 26);
            this.txtIdentificacion.TabIndex = 37;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(8, 88);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(115, 19);
            this.lblIdentificacion.TabIndex = 36;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Enabled = false;
            this.cmbEspecialidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Odontologia",
            "Psicologia",
            "Pediatria",
            "Medicina General",
            "Oftamologia",
            "Ginecologia"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(179, 57);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(242, 28);
            this.cmbEspecialidad.TabIndex = 33;
            this.cmbEspecialidad.Text = "Seleccione especialidad";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(8, 57);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(110, 19);
            this.lblEspecialidad.TabIndex = 32;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(8, 27);
            this.lblTipoReporte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(125, 19);
            this.lblTipoReporte.TabIndex = 30;
            this.lblTipoReporte.Text = "Tipo de reporte";
            // 
            // cmbReporte
            // 
            this.cmbReporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Items.AddRange(new object[] {
            "Reporte de citas totales",
            "Reporte de citas por especialidad",
            "Reporte de citas por paciente",
            "Reporte de citas por médico"});
            this.cmbReporte.Location = new System.Drawing.Point(179, 27);
            this.cmbReporte.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(242, 28);
            this.cmbReporte.TabIndex = 29;
            this.cmbReporte.Text = "Seleccione un reporte";
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha Inicial";
            // 
            // cld_Final
            // 
            this.cld_Final.Location = new System.Drawing.Point(349, 196);
            this.cld_Final.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.cld_Final.Name = "cld_Final";
            this.cld_Final.TabIndex = 25;
            this.cld_Final.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cld_Final_DateChanged);
            // 
            // cld_inicio
            // 
            this.cld_inicio.Location = new System.Drawing.Point(69, 196);
            this.cld_inicio.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.cld_inicio.Name = "cld_inicio";
            this.cld_inicio.TabIndex = 24;
            this.cld_inicio.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cld_inicio_DateChanged);
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(8, 122);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(167, 19);
            this.lblMedico.TabIndex = 38;
            this.lblMedico.Text = "Nombre del médico";
            this.lblMedico.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbMedico
            // 
            this.cmbMedico.Enabled = false;
            this.cmbMedico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(179, 122);
            this.cmbMedico.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(242, 28);
            this.cmbMedico.TabIndex = 39;
            this.cmbMedico.Text = "Seleccione Carnet medico";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.button3.Location = new System.Drawing.Point(499, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 49);
            this.button3.TabIndex = 219;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Reportes);
            this.groupBox1.Controls.Add(this.lblTipoReporte);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cmbReporte);
            this.groupBox1.Controls.Add(this.cmbMedico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cld_Final);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMedico);
            this.groupBox1.Controls.Add(this.cld_inicio);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.lblIdentificacion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 558);
            this.groupBox1.TabIndex = 220;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Reporte";
            // 
            // dgv_Reportes
            // 
            this.dgv_Reportes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reportes.Location = new System.Drawing.Point(39, 376);
            this.dgv_Reportes.Name = "dgv_Reportes";
            this.dgv_Reportes.ReadOnly = true;
            this.dgv_Reportes.RowHeadersWidth = 62;
            this.dgv_Reportes.RowTemplate.Height = 28;
            this.dgv_Reportes.Size = new System.Drawing.Size(581, 167);
            this.dgv_Reportes.TabIndex = 240;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.pnlTitulo.Controls.Add(this.label7);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Controls.Add(this.btn_cerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(741, 44);
            this.pnlTitulo.TabIndex = 239;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(153, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 38);
            this.label7.TabIndex = 240;
            this.label7.Text = "Generador de Reportes";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
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
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1218, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 236;
            this.btn_cerrar.TabStop = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(741, 620);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reportes)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.ComboBox cmbReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar cld_Final;
        private System.Windows.Forms.MonthCalendar cld_inicio;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Reportes;
    }
}