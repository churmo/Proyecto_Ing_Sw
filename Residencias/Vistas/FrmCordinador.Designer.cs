﻿namespace Residencias.Vistas
{
    partial class FrmCordinador
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
            this.BtnAT = new System.Windows.Forms.Button();
            this.BtnAR = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnResidente = new System.Windows.Forms.Button();
            this.LblCoordi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAT
            // 
            this.BtnAT.Location = new System.Drawing.Point(23, 66);
            this.BtnAT.Name = "BtnAT";
            this.BtnAT.Size = new System.Drawing.Size(233, 23);
            this.BtnAT.TabIndex = 0;
            this.BtnAT.Text = "Asignar Tutor";
            this.BtnAT.UseVisualStyleBackColor = true;
            this.BtnAT.Click += new System.EventHandler(this.BtnAT_Click);
            // 
            // BtnAR
            // 
            this.BtnAR.Location = new System.Drawing.Point(23, 95);
            this.BtnAR.Name = "BtnAR";
            this.BtnAR.Size = new System.Drawing.Size(233, 23);
            this.BtnAR.TabIndex = 1;
            this.BtnAR.Text = "Asignar Revisores";
            this.BtnAR.UseVisualStyleBackColor = true;
            this.BtnAR.Click += new System.EventHandler(this.BtnAR_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(182, 124);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnResidente
            // 
            this.BtnResidente.Location = new System.Drawing.Point(23, 37);
            this.BtnResidente.Name = "BtnResidente";
            this.BtnResidente.Size = new System.Drawing.Size(233, 23);
            this.BtnResidente.TabIndex = 3;
            this.BtnResidente.Text = "Solicitud de residente";
            this.BtnResidente.UseVisualStyleBackColor = true;
            this.BtnResidente.Click += new System.EventHandler(this.BtnResidente_Click);
            // 
            // LblCoordi
            // 
            this.LblCoordi.AutoSize = true;
            this.LblCoordi.Location = new System.Drawing.Point(23, 18);
            this.LblCoordi.Name = "LblCoordi";
            this.LblCoordi.Size = new System.Drawing.Size(120, 13);
            this.LblCoordi.TabIndex = 4;
            this.LblCoordi.Text = "Nombre del coordinador";
            // 
            // FrmCordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 159);
            this.Controls.Add(this.LblCoordi);
            this.Controls.Add(this.BtnResidente);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAR);
            this.Controls.Add(this.BtnAT);
            this.Name = "FrmCordinador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cordinador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCordinador_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAT;
        private System.Windows.Forms.Button BtnAR;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnResidente;
        private System.Windows.Forms.Label LblCoordi;
    }
}