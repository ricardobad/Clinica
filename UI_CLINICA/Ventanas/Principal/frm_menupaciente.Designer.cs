
namespace UI_CLINICA.Ventanas.Principal
{
    partial class frm_menupaciente
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
            this.msPaciente = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPaciente
            // 
            this.msPaciente.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msPaciente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aSToolStripMenuItem});
            this.msPaciente.Location = new System.Drawing.Point(0, 0);
            this.msPaciente.Name = "msPaciente";
            this.msPaciente.Size = new System.Drawing.Size(800, 33);
            this.msPaciente.TabIndex = 0;
            this.msPaciente.Text = "msPaciente";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 29);
            this.toolStripMenuItem1.Text = "Citas";
            // 
            // aSToolStripMenuItem
            // 
            this.aSToolStripMenuItem.Name = "aSToolStripMenuItem";
            this.aSToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.aSToolStripMenuItem.Text = "Pacientes";
            // 
            // frm_menupaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msPaciente);
            this.MainMenuStrip = this.msPaciente;
            this.Name = "frm_menupaciente";
            this.Text = "frm_menupaciente";
            this.msPaciente.ResumeLayout(false);
            this.msPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPaciente;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aSToolStripMenuItem;
    }
}