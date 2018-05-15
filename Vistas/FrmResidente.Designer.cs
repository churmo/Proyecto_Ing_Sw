namespace Residencias.Vistas
{
    partial class FrmResidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResidente));
            this.BtnEntregaDocumentos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnHoja = new System.Windows.Forms.Button();
            this.LblEstatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEntregaDocumentos
            // 
            this.BtnEntregaDocumentos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEntregaDocumentos.Location = new System.Drawing.Point(19, 19);
            this.BtnEntregaDocumentos.Name = "BtnEntregaDocumentos";
            this.BtnEntregaDocumentos.Size = new System.Drawing.Size(197, 23);
            this.BtnEntregaDocumentos.TabIndex = 0;
            this.BtnEntregaDocumentos.Text = "Entrega de documentos";
            this.BtnEntregaDocumentos.UseVisualStyleBackColor = false;
            this.BtnEntregaDocumentos.Click += new System.EventHandler(this.BtnEntregaDocumentos_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(149, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnHoja);
            this.groupBox1.Controls.Add(this.BtnEntregaDocumentos);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            // 
            // BtnHoja
            // 
            this.BtnHoja.Location = new System.Drawing.Point(19, 48);
            this.BtnHoja.Name = "BtnHoja";
            this.BtnHoja.Size = new System.Drawing.Size(196, 23);
            this.BtnHoja.TabIndex = 2;
            this.BtnHoja.Text = "Hoja pra el coordi";
            this.BtnHoja.UseVisualStyleBackColor = true;
            // 
            // LblEstatus
            // 
            this.LblEstatus.AutoSize = true;
            this.LblEstatus.Location = new System.Drawing.Point(24, 130);
            this.LblEstatus.Name = "LblEstatus";
            this.LblEstatus.Size = new System.Drawing.Size(48, 13);
            this.LblEstatus.TabIndex = 4;
            this.LblEstatus.Text = "Estatus: ";
            // 
            // FrmResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(250, 152);
            this.Controls.Add(this.LblEstatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Residente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmResidente_FormClosing);
            this.Load += new System.EventHandler(this.FrmResidente_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEntregaDocumentos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnHoja;
        private System.Windows.Forms.Label LblEstatus;
    }
}