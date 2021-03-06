﻿namespace Residencias.Vistas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.ChbxConexion = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(85, 13);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(128, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(85, 48);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(128, 20);
            this.TxtContrasenia.TabIndex = 1;
            // 
            // CbxTipo
            // 
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "Residente",
            "Coordinador",
            "Asesor"});
            this.CbxTipo.Location = new System.Drawing.Point(146, 94);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(121, 21);
            this.CbxTipo.TabIndex = 2;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAceptar.Location = new System.Drawing.Point(15, 171);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(197, 171);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCrear.Location = new System.Drawing.Point(105, 171);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 7;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // ChbxConexion
            // 
            this.ChbxConexion.AutoSize = true;
            this.ChbxConexion.Location = new System.Drawing.Point(247, 19);
            this.ChbxConexion.Name = "ChbxConexion";
            this.ChbxConexion.Size = new System.Drawing.Size(15, 14);
            this.ChbxConexion.TabIndex = 8;
            this.ChbxConexion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.ChbxConexion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbxTipo);
            this.groupBox1.Controls.Add(this.TxtContrasenia);
            this.groupBox1.Controls.Add(this.TxtUsuario);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(289, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.CheckBox ChbxConexion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}