namespace Residencias.Vistas
{
    partial class FrmDictamenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDictamenes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRevisionInforme = new System.Windows.Forms.Button();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxAlumno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Control:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha:";
            // 
            // btnRevisionInforme
            // 
            this.btnRevisionInforme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRevisionInforme.Location = new System.Drawing.Point(15, 126);
            this.btnRevisionInforme.Name = "btnRevisionInforme";
            this.btnRevisionInforme.Size = new System.Drawing.Size(85, 37);
            this.btnRevisionInforme.TabIndex = 4;
            this.btnRevisionInforme.Text = "Revise informe ";
            this.btnRevisionInforme.UseVisualStyleBackColor = false;
            this.btnRevisionInforme.Click += new System.EventHandler(this.btnRevisionInforme_Click);
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(212, 39);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(130, 20);
            this.txtControl.TabIndex = 8;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(212, 74);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(130, 20);
            this.txtFecha.TabIndex = 9;
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAprobar.Location = new System.Drawing.Point(161, 126);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(85, 37);
            this.btnAprobar.TabIndex = 10;
            this.btnAprobar.Text = "Aprobar ";
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiguiente.Location = new System.Drawing.Point(295, 126);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(85, 37);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Salir";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CbxAlumno);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 111);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // CbxAlumno
            // 
            this.CbxAlumno.FormattingEnabled = true;
            this.CbxAlumno.Location = new System.Drawing.Point(212, 12);
            this.CbxAlumno.Name = "CbxAlumno";
            this.CbxAlumno.Size = new System.Drawing.Size(130, 21);
            this.CbxAlumno.TabIndex = 10;
            this.CbxAlumno.SelectedIndexChanged += new System.EventHandler(this.CbxAlumno_SelectedIndexChanged);
            // 
            // FrmDictamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnRevisionInforme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDictamenes";
            this.Text = "Dictamenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRevisionInforme;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxAlumno;
    }
}