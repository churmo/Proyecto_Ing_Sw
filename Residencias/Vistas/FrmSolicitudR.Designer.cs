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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Residente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceptar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Residente,
            this.Aceptar});
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // Residente
            // 
            this.Residente.Frozen = true;
            this.Residente.HeaderText = "Residente";
            this.Residente.Name = "Residente";
            this.Residente.ReadOnly = true;
            this.Residente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Aceptar
            // 
            this.Aceptar.HeaderText = "Aceptar?";
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aceptar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(12, 291);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(841, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmSolicitudR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 326);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSolicitudR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSolicitudR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aceptar;
        private System.Windows.Forms.Button BtnActualizar;
    }
}