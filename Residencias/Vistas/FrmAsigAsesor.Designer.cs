namespace Residencias
{
    partial class FrmAsigAsesor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxAsesores = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.CbxAlumno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asesores";
            // 
            // CbxAsesores
            // 
            this.CbxAsesores.FormattingEnabled = true;
            this.CbxAsesores.Location = new System.Drawing.Point(13, 70);
            this.CbxAsesores.Name = "CbxAsesores";
            this.CbxAsesores.Size = new System.Drawing.Size(181, 21);
            this.CbxAsesores.TabIndex = 3;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(12, 97);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CbxAlumno
            // 
            this.CbxAlumno.FormattingEnabled = true;
            this.CbxAlumno.Location = new System.Drawing.Point(13, 30);
            this.CbxAlumno.Name = "CbxAlumno";
            this.CbxAlumno.Size = new System.Drawing.Size(181, 21);
            this.CbxAlumno.TabIndex = 5;
            // 
            // FrmAsigAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 133);
            this.Controls.Add(this.CbxAlumno);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CbxAsesores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmAsigAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asesores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAsigAsesor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxAsesores;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox CbxAlumno;
    }
}

