namespace Residencias.Vistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCordinador));
            this.BtnAT = new System.Windows.Forms.Button();
            this.BtnAR = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnResidente = new System.Windows.Forms.Button();
            this.LblCoordi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCalificarDocumentos = new System.Windows.Forms.Button();
            this.BtnDictamen = new System.Windows.Forms.Button();
            this.BtnFinalizarResidente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAT
            // 
            this.BtnAT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAT.Location = new System.Drawing.Point(12, 48);
            this.BtnAT.Name = "BtnAT";
            this.BtnAT.Size = new System.Drawing.Size(233, 23);
            this.BtnAT.TabIndex = 0;
            this.BtnAT.Text = "Asignar Tutor";
            this.BtnAT.UseVisualStyleBackColor = false;
            this.BtnAT.Click += new System.EventHandler(this.BtnAT_Click);
            // 
            // BtnAR
            // 
            this.BtnAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAR.Location = new System.Drawing.Point(12, 77);
            this.BtnAR.Name = "BtnAR";
            this.BtnAR.Size = new System.Drawing.Size(233, 23);
            this.BtnAR.TabIndex = 1;
            this.BtnAR.Text = "Asignar Revisores";
            this.BtnAR.UseVisualStyleBackColor = false;
            this.BtnAR.Click += new System.EventHandler(this.BtnAR_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(98, 232);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnResidente
            // 
            this.BtnResidente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnResidente.Location = new System.Drawing.Point(12, 19);
            this.BtnResidente.Name = "BtnResidente";
            this.BtnResidente.Size = new System.Drawing.Size(233, 23);
            this.BtnResidente.TabIndex = 3;
            this.BtnResidente.Text = "Solicitud de residente";
            this.BtnResidente.UseVisualStyleBackColor = false;
            this.BtnResidente.Click += new System.EventHandler(this.BtnResidente_Click);
            // 
            // LblCoordi
            // 
            this.LblCoordi.AutoSize = true;
            this.LblCoordi.Location = new System.Drawing.Point(9, 2);
            this.LblCoordi.Name = "LblCoordi";
            this.LblCoordi.Size = new System.Drawing.Size(120, 13);
            this.LblCoordi.TabIndex = 4;
            this.LblCoordi.Text = "Nombre del coordinador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFinalizarResidente);
            this.groupBox1.Controls.Add(this.BtnDictamen);
            this.groupBox1.Controls.Add(this.BtnCalificarDocumentos);
            this.groupBox1.Controls.Add(this.LblCoordi);
            this.groupBox1.Controls.Add(this.BtnResidente);
            this.groupBox1.Controls.Add(this.BtnAR);
            this.groupBox1.Controls.Add(this.BtnAT);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // BtnCalificarDocumentos
            // 
            this.BtnCalificarDocumentos.Location = new System.Drawing.Point(12, 106);
            this.BtnCalificarDocumentos.Name = "BtnCalificarDocumentos";
            this.BtnCalificarDocumentos.Size = new System.Drawing.Size(233, 23);
            this.BtnCalificarDocumentos.TabIndex = 5;
            this.BtnCalificarDocumentos.Text = "Calificar documentos";
            this.BtnCalificarDocumentos.UseVisualStyleBackColor = true;
            this.BtnCalificarDocumentos.Click += new System.EventHandler(this.BtnCalificarDocumentos_Click);
            // 
            // BtnDictamen
            // 
            this.BtnDictamen.Location = new System.Drawing.Point(12, 135);
            this.BtnDictamen.Name = "BtnDictamen";
            this.BtnDictamen.Size = new System.Drawing.Size(233, 23);
            this.BtnDictamen.TabIndex = 6;
            this.BtnDictamen.Text = "Dictamen";
            this.BtnDictamen.UseVisualStyleBackColor = true;
            this.BtnDictamen.Click += new System.EventHandler(this.BtnDictamen_Click);
            // 
            // BtnFinalizarResidente
            // 
            this.BtnFinalizarResidente.Location = new System.Drawing.Point(12, 164);
            this.BtnFinalizarResidente.Name = "BtnFinalizarResidente";
            this.BtnFinalizarResidente.Size = new System.Drawing.Size(233, 23);
            this.BtnFinalizarResidente.TabIndex = 7;
            this.BtnFinalizarResidente.Text = "Residente finalizado";
            this.BtnFinalizarResidente.UseVisualStyleBackColor = true;
            this.BtnFinalizarResidente.Click += new System.EventHandler(this.BtnFinalizarResidente_Click);
            // 
            // FrmCordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(286, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCordinador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cordinador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCordinador_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAT;
        private System.Windows.Forms.Button BtnAR;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnResidente;
        private System.Windows.Forms.Label LblCoordi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCalificarDocumentos;
        private System.Windows.Forms.Button BtnDictamen;
        private System.Windows.Forms.Button BtnFinalizarResidente;
    }
}