
namespace UI_CLINICA.Ventanas.Expedientes
{
    partial class frm_buscarexpediente
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
            this.components = new System.ComponentModel.Container();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Consultar_Expediente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.erp_Principal = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Identificacion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Identificacion.Location = new System.Drawing.Point(35, 81);
            this.txt_Identificacion.MaxLength = 14;
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.Size = new System.Drawing.Size(246, 33);
            this.txt_Identificacion.TabIndex = 76;
            this.txt_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Identificacion_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::UI_CLINICA.Properties.Resources.WhatsApp_Image_2023_03_07_at_4_51_53_PM;
            this.tabPage1.Controls.Add(this.btn_Consultar_Expediente);
            this.tabPage1.Controls.Add(this.txt_Identificacion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "          Buscar Expediente                       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Consultar_Expediente
            // 
            this.btn_Consultar_Expediente.BackgroundImage = global::UI_CLINICA.Properties.Resources.WhatsApp_Image_2023_03_07_at_4_52_06_PM;
            this.btn_Consultar_Expediente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar_Expediente.Image = global::UI_CLINICA.Properties.Resources.WhatsApp_Image_2023_03_07_at_4_52_06_PM;
            this.btn_Consultar_Expediente.Location = new System.Drawing.Point(81, 136);
            this.btn_Consultar_Expediente.Name = "btn_Consultar_Expediente";
            this.btn_Consultar_Expediente.Size = new System.Drawing.Size(150, 35);
            this.btn_Consultar_Expediente.TabIndex = 83;
            this.btn_Consultar_Expediente.Text = "Consultar";
            this.btn_Consultar_Expediente.UseVisualStyleBackColor = true;
            this.btn_Consultar_Expediente.Click += new System.EventHandler(this.btn_Consultar_Expediente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación de Paciente a Consultar";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 203);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 256);
            this.tabControl1.TabIndex = 83;
            // 
            // erp_Principal
            // 
            this.erp_Principal.ContainerControl = this;
            // 
            // frm_buscarexpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::UI_CLINICA.Properties.Resources.MEDICO_1_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(747, 685);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_buscarexpediente";
            this.Text = "frm_buscarexpediente";
            this.Load += new System.EventHandler(this.frm_buscarexpediente_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_Consultar_Expediente;
        private System.Windows.Forms.ErrorProvider erp_Principal;
    }
}