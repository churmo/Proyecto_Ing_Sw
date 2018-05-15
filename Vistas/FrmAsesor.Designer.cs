namespace Residencias.Vistas
{
    partial class FrmAsesor
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
            this.BtnCalificaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalificaciones
            // 
            this.BtnCalificaciones.Location = new System.Drawing.Point(12, 12);
            this.BtnCalificaciones.Name = "BtnCalificaciones";
            this.BtnCalificaciones.Size = new System.Drawing.Size(260, 23);
            this.BtnCalificaciones.TabIndex = 0;
            this.BtnCalificaciones.Text = "Calificaiones";
            this.BtnCalificaciones.UseVisualStyleBackColor = true;
            this.BtnCalificaciones.Click += new System.EventHandler(this.BtnCalificaciones_Click);
            // 
            // FrmAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCalificaciones);
            this.Name = "FrmAsesor";
            this.Text = "FrmAsesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAsesor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalificaciones;
    }
}