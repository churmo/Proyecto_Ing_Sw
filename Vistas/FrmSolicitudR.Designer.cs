namespace Residencias.Vistas
{
    partial class FrmSolicitudR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudR));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.Nocontrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceptar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rechazar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nocontrol,
            this.Residente,
            this.Aceptar,
            this.Rechazar});
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnActualizar.Location = new System.Drawing.Point(12, 291);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(841, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // Nocontrol
            // 
            this.Nocontrol.HeaderText = "NoControl";
            this.Nocontrol.Name = "Nocontrol";
            this.Nocontrol.ReadOnly = true;
            // 
            // Residente
            // 
            this.Residente.HeaderText = "Residente";
            this.Residente.Name = "Residente";
            this.Residente.ReadOnly = true;
            this.Residente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Aceptar
            // 
            this.Aceptar.HeaderText = "Aceptar";
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aceptar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Rechazar
            // 
            this.Rechazar.HeaderText = "Rechazar";
            this.Rechazar.Name = "Rechazar";
            // 
            // FrmSolicitudR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(865, 326);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSolicitudR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSolicitudR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nocontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aceptar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rechazar;
    }
}