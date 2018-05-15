namespace Residencias.Vistas
{
    partial class FrmExportacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportacion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBlocDeNotas = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el formato al que desea exportar el documento";
            // 
            // btnBlocDeNotas
            // 
            this.btnBlocDeNotas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBlocDeNotas.Location = new System.Drawing.Point(28, 67);
            this.btnBlocDeNotas.Name = "btnBlocDeNotas";
            this.btnBlocDeNotas.Size = new System.Drawing.Size(80, 40);
            this.btnBlocDeNotas.TabIndex = 1;
            this.btnBlocDeNotas.Text = "Documento de texto";
            this.btnBlocDeNotas.UseVisualStyleBackColor = false;
            this.btnBlocDeNotas.Click += new System.EventHandler(this.btnBlocDeNotas_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcel.Location = new System.Drawing.Point(166, 67);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(79, 40);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Hoja de calculo";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(97, 122);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmExportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(279, 188);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnBlocDeNotas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExportacion";
            this.Text = "Exportación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExportacion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBlocDeNotas;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSalir;
    }
}