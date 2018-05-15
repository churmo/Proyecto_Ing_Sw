namespace Residencias.Vistas
{
    partial class FrmCalificacionDelDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalificacionDelDocumento));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnNoAprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desea aprobar el informe?";
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAprobar.Location = new System.Drawing.Point(35, 97);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(85, 29);
            this.btnAprobar.TabIndex = 1;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = false;
            // 
            // btnNoAprobar
            // 
            this.btnNoAprobar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoAprobar.Location = new System.Drawing.Point(226, 97);
            this.btnNoAprobar.Name = "btnNoAprobar";
            this.btnNoAprobar.Size = new System.Drawing.Size(85, 29);
            this.btnNoAprobar.TabIndex = 2;
            this.btnNoAprobar.Text = "No Aprobar";
            this.btnNoAprobar.UseVisualStyleBackColor = false;
            this.btnNoAprobar.Click += new System.EventHandler(this.btnNoAprobar_Click);
            // 
            // FrmCalificacionDelDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 161);
            this.Controls.Add(this.btnNoAprobar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCalificacionDelDocumento";
            this.Text = "Calificacion Del Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnNoAprobar;
    }
}