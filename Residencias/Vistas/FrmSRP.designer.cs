namespace Residencias
{
    partial class FrmSRP
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
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabProyecto = new System.Windows.Forms.TabPage();
            this.cbxOpcionesDP = new System.Windows.Forms.ComboBox();
            this.txtNumResidencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeriodoProyecto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDatosEmpresa = new System.Windows.Forms.TabPage();
            this.LblOtro = new System.Windows.Forms.Label();
            this.TxtOtro = new System.Windows.Forms.TextBox();
            this.cbxGiroRamaSector = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPersonaFirma = new System.Windows.Forms.TextBox();
            this.txtNombreFirma = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPuestoAE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPuestoTE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAsesorExterno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTitularEmpresa = new System.Windows.Forms.TextBox();
            this.txtMisionEmpresa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDomicilioE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFaxE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefonoE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColoniaE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRFCE = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabResidente = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxSeguridadSocial = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.txtTelefonoR = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCiudadR = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNoSS = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtEmailR = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDomicilioR = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNoControlR = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCarreraR = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNombreResidente = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.tabProyecto.SuspendLayout();
            this.tabDatosEmpresa.SuspendLayout();
            this.tabResidente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabProyecto);
            this.Menu.Controls.Add(this.tabDatosEmpresa);
            this.Menu.Controls.Add(this.tabResidente);
            this.Menu.Location = new System.Drawing.Point(14, 12);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(749, 653);
            this.Menu.TabIndex = 0;
            // 
            // tabProyecto
            // 
            this.tabProyecto.Controls.Add(this.cbxOpcionesDP);
            this.tabProyecto.Controls.Add(this.txtNumResidencias);
            this.tabProyecto.Controls.Add(this.label4);
            this.tabProyecto.Controls.Add(this.txtPeriodoProyecto);
            this.tabProyecto.Controls.Add(this.label3);
            this.tabProyecto.Controls.Add(this.label2);
            this.tabProyecto.Controls.Add(this.txtNombreProyecto);
            this.tabProyecto.Controls.Add(this.label1);
            this.tabProyecto.Location = new System.Drawing.Point(4, 22);
            this.tabProyecto.Name = "tabProyecto";
            this.tabProyecto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProyecto.Size = new System.Drawing.Size(741, 627);
            this.tabProyecto.TabIndex = 0;
            this.tabProyecto.Text = "Datos del Proyecto";
            this.tabProyecto.UseVisualStyleBackColor = true;
            this.tabProyecto.Click += new System.EventHandler(this.tabProyecto_Click);
            // 
            // cbxOpcionesDP
            // 
            this.cbxOpcionesDP.FormattingEnabled = true;
            this.cbxOpcionesDP.Items.AddRange(new object[] {
            "Banco de Proyectos",
            "Propuesta Propia",
            "Trabajador"});
            this.cbxOpcionesDP.Location = new System.Drawing.Point(340, 237);
            this.cbxOpcionesDP.Name = "cbxOpcionesDP";
            this.cbxOpcionesDP.Size = new System.Drawing.Size(121, 21);
            this.cbxOpcionesDP.TabIndex = 20;
            // 
            // txtNumResidencias
            // 
            this.txtNumResidencias.Location = new System.Drawing.Point(357, 523);
            this.txtNumResidencias.Name = "txtNumResidencias";
            this.txtNumResidencias.Size = new System.Drawing.Size(147, 20);
            this.txtNumResidencias.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Numero de Residencias";
            // 
            // txtPeriodoProyecto
            // 
            this.txtPeriodoProyecto.Location = new System.Drawing.Point(340, 378);
            this.txtPeriodoProyecto.Name = "txtPeriodoProyecto";
            this.txtPeriodoProyecto.Size = new System.Drawing.Size(164, 20);
            this.txtPeriodoProyecto.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Periodo Proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione una de las siguientes Opciones";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(299, 108);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(306, 20);
            this.txtNombreProyecto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del Proyecto";
            // 
            // tabDatosEmpresa
            // 
            this.tabDatosEmpresa.Controls.Add(this.LblOtro);
            this.tabDatosEmpresa.Controls.Add(this.TxtOtro);
            this.tabDatosEmpresa.Controls.Add(this.cbxGiroRamaSector);
            this.tabDatosEmpresa.Controls.Add(this.label17);
            this.tabDatosEmpresa.Controls.Add(this.txtPersonaFirma);
            this.tabDatosEmpresa.Controls.Add(this.txtNombreFirma);
            this.tabDatosEmpresa.Controls.Add(this.label16);
            this.tabDatosEmpresa.Controls.Add(this.label15);
            this.tabDatosEmpresa.Controls.Add(this.txtPuestoAE);
            this.tabDatosEmpresa.Controls.Add(this.label14);
            this.tabDatosEmpresa.Controls.Add(this.txtPuestoTE);
            this.tabDatosEmpresa.Controls.Add(this.label13);
            this.tabDatosEmpresa.Controls.Add(this.txtAsesorExterno);
            this.tabDatosEmpresa.Controls.Add(this.label12);
            this.tabDatosEmpresa.Controls.Add(this.txtTitularEmpresa);
            this.tabDatosEmpresa.Controls.Add(this.txtMisionEmpresa);
            this.tabDatosEmpresa.Controls.Add(this.label11);
            this.tabDatosEmpresa.Controls.Add(this.label10);
            this.tabDatosEmpresa.Controls.Add(this.txtDomicilioE);
            this.tabDatosEmpresa.Controls.Add(this.label9);
            this.tabDatosEmpresa.Controls.Add(this.txtFaxE);
            this.tabDatosEmpresa.Controls.Add(this.label8);
            this.tabDatosEmpresa.Controls.Add(this.txtTelefonoE);
            this.tabDatosEmpresa.Controls.Add(this.label7);
            this.tabDatosEmpresa.Controls.Add(this.txtColoniaE);
            this.tabDatosEmpresa.Controls.Add(this.label6);
            this.tabDatosEmpresa.Controls.Add(this.txtCPE);
            this.tabDatosEmpresa.Controls.Add(this.label5);
            this.tabDatosEmpresa.Controls.Add(this.txtRFCE);
            this.tabDatosEmpresa.Controls.Add(this.label19);
            this.tabDatosEmpresa.Controls.Add(this.txtNombreE);
            this.tabDatosEmpresa.Controls.Add(this.label20);
            this.tabDatosEmpresa.Controls.Add(this.label21);
            this.tabDatosEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabDatosEmpresa.Name = "tabDatosEmpresa";
            this.tabDatosEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosEmpresa.Size = new System.Drawing.Size(741, 627);
            this.tabDatosEmpresa.TabIndex = 1;
            this.tabDatosEmpresa.Text = "Datos de la Empresa";
            this.tabDatosEmpresa.UseVisualStyleBackColor = true;
            this.tabDatosEmpresa.Click += new System.EventHandler(this.tabDatosEmpresa_Click);
            // 
            // LblOtro
            // 
            this.LblOtro.AutoSize = true;
            this.LblOtro.Location = new System.Drawing.Point(288, 60);
            this.LblOtro.Name = "LblOtro";
            this.LblOtro.Size = new System.Drawing.Size(164, 13);
            this.LblOtro.TabIndex = 74;
            this.LblOtro.Text = "Especifique que tipo de sector es";
            // 
            // TxtOtro
            // 
            this.TxtOtro.Location = new System.Drawing.Point(288, 88);
            this.TxtOtro.Name = "TxtOtro";
            this.TxtOtro.Size = new System.Drawing.Size(344, 20);
            this.TxtOtro.TabIndex = 73;
            // 
            // cbxGiroRamaSector
            // 
            this.cbxGiroRamaSector.FormattingEnabled = true;
            this.cbxGiroRamaSector.Items.AddRange(new object[] {
            "Industrial",
            "Público",
            "Servicios",
            "Privado",
            "Otro"});
            this.cbxGiroRamaSector.Location = new System.Drawing.Point(139, 88);
            this.cbxGiroRamaSector.Name = "cbxGiroRamaSector";
            this.cbxGiroRamaSector.Size = new System.Drawing.Size(121, 21);
            this.cbxGiroRamaSector.TabIndex = 72;
            this.cbxGiroRamaSector.SelectedIndexChanged += new System.EventHandler(this.cbxGiroRamaSector_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(242, 594);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "Puesto";
            // 
            // txtPersonaFirma
            // 
            this.txtPersonaFirma.Location = new System.Drawing.Point(288, 591);
            this.txtPersonaFirma.Name = "txtPersonaFirma";
            this.txtPersonaFirma.Size = new System.Drawing.Size(150, 20);
            this.txtPersonaFirma.TabIndex = 70;
            // 
            // txtNombreFirma
            // 
            this.txtNombreFirma.Location = new System.Drawing.Point(224, 565);
            this.txtNombreFirma.Name = "txtNombreFirma";
            this.txtNombreFirma.Size = new System.Drawing.Size(273, 20);
            this.txtNombreFirma.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(156, 549);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(395, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Nombre de la persona que firmara el acuerdo de trabajo. Alumno-Escuela-Empresa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(445, 510);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Puesto";
            // 
            // txtPuestoAE
            // 
            this.txtPuestoAE.Location = new System.Drawing.Point(491, 507);
            this.txtPuestoAE.Name = "txtPuestoAE";
            this.txtPuestoAE.Size = new System.Drawing.Size(150, 20);
            this.txtPuestoAE.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Puesto";
            // 
            // txtPuestoTE
            // 
            this.txtPuestoTE.Location = new System.Drawing.Point(491, 481);
            this.txtPuestoTE.Name = "txtPuestoTE";
            this.txtPuestoTE.Size = new System.Drawing.Size(150, 20);
            this.txtPuestoTE.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 510);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Nombre del asesor externo";
            // 
            // txtAsesorExterno
            // 
            this.txtAsesorExterno.Location = new System.Drawing.Point(254, 510);
            this.txtAsesorExterno.Name = "txtAsesorExterno";
            this.txtAsesorExterno.Size = new System.Drawing.Size(185, 20);
            this.txtAsesorExterno.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Nombre del tiular de la empresa";
            // 
            // txtTitularEmpresa
            // 
            this.txtTitularEmpresa.Location = new System.Drawing.Point(254, 484);
            this.txtTitularEmpresa.Name = "txtTitularEmpresa";
            this.txtTitularEmpresa.Size = new System.Drawing.Size(185, 20);
            this.txtTitularEmpresa.TabIndex = 60;
            // 
            // txtMisionEmpresa
            // 
            this.txtMisionEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMisionEmpresa.Location = new System.Drawing.Point(65, 260);
            this.txtMisionEmpresa.Multiline = true;
            this.txtMisionEmpresa.Name = "txtMisionEmpresa";
            this.txtMisionEmpresa.Size = new System.Drawing.Size(576, 202);
            this.txtMisionEmpresa.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Mision de la Empresa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Domicilio";
            // 
            // txtDomicilioE
            // 
            this.txtDomicilioE.Location = new System.Drawing.Point(139, 167);
            this.txtDomicilioE.Name = "txtDomicilioE";
            this.txtDomicilioE.Size = new System.Drawing.Size(178, 20);
            this.txtDomicilioE.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Telefono";
            // 
            // txtFaxE
            // 
            this.txtFaxE.Location = new System.Drawing.Point(453, 167);
            this.txtFaxE.Name = "txtFaxE";
            this.txtFaxE.Size = new System.Drawing.Size(179, 20);
            this.txtFaxE.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Colonia";
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.Location = new System.Drawing.Point(453, 213);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(179, 20);
            this.txtTelefonoE.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Fax";
            // 
            // txtColoniaE
            // 
            this.txtColoniaE.Location = new System.Drawing.Point(139, 213);
            this.txtColoniaE.Name = "txtColoniaE";
            this.txtColoniaE.Size = new System.Drawing.Size(178, 20);
            this.txtColoniaE.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "CP";
            // 
            // txtCPE
            // 
            this.txtCPE.Location = new System.Drawing.Point(453, 126);
            this.txtCPE.Name = "txtCPE";
            this.txtCPE.Size = new System.Drawing.Size(179, 20);
            this.txtCPE.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "RFC";
            // 
            // txtRFCE
            // 
            this.txtRFCE.Location = new System.Drawing.Point(139, 126);
            this.txtRFCE.Name = "txtRFCE";
            this.txtRFCE.Size = new System.Drawing.Size(178, 20);
            this.txtRFCE.TabIndex = 46;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(136, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Giro, rama, sector";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(151, 17);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(481, 20);
            this.txtNombreE.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(101, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Nombre";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(312, -14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Datos de la Empresa";
            // 
            // tabResidente
            // 
            this.tabResidente.Controls.Add(this.label18);
            this.tabResidente.Controls.Add(this.cbxSeguridadSocial);
            this.tabResidente.Controls.Add(this.btnCancelar);
            this.tabResidente.Controls.Add(this.btnEntregar);
            this.tabResidente.Controls.Add(this.txtTelefonoR);
            this.tabResidente.Controls.Add(this.label29);
            this.tabResidente.Controls.Add(this.txtCiudadR);
            this.tabResidente.Controls.Add(this.label28);
            this.tabResidente.Controls.Add(this.txtNoSS);
            this.tabResidente.Controls.Add(this.label27);
            this.tabResidente.Controls.Add(this.label26);
            this.tabResidente.Controls.Add(this.txtEmailR);
            this.tabResidente.Controls.Add(this.label25);
            this.tabResidente.Controls.Add(this.txtDomicilioR);
            this.tabResidente.Controls.Add(this.label24);
            this.tabResidente.Controls.Add(this.txtNoControlR);
            this.tabResidente.Controls.Add(this.label23);
            this.tabResidente.Controls.Add(this.txtCarreraR);
            this.tabResidente.Controls.Add(this.label22);
            this.tabResidente.Controls.Add(this.txtNombreResidente);
            this.tabResidente.Controls.Add(this.Nombre);
            this.tabResidente.Location = new System.Drawing.Point(4, 22);
            this.tabResidente.Name = "tabResidente";
            this.tabResidente.Padding = new System.Windows.Forms.Padding(3);
            this.tabResidente.Size = new System.Drawing.Size(741, 627);
            this.tabResidente.TabIndex = 2;
            this.tabResidente.Text = "Datos del Residente";
            this.tabResidente.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Revise que sus datos esten correctos";
            // 
            // cbxSeguridadSocial
            // 
            this.cbxSeguridadSocial.FormattingEnabled = true;
            this.cbxSeguridadSocial.Items.AddRange(new object[] {
            "IMSS",
            "ISSSTE",
            "OTROS"});
            this.cbxSeguridadSocial.Location = new System.Drawing.Point(218, 347);
            this.cbxSeguridadSocial.Name = "cbxSeguridadSocial";
            this.cbxSeguridadSocial.Size = new System.Drawing.Size(121, 21);
            this.cbxSeguridadSocial.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(354, 561);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.Location = new System.Drawing.Point(315, 507);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(147, 23);
            this.btnEntregar.TabIndex = 20;
            this.btnEntregar.Text = "Entregar Solicitud";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // txtTelefonoR
            // 
            this.txtTelefonoR.Location = new System.Drawing.Point(446, 409);
            this.txtTelefonoR.Name = "txtTelefonoR";
            this.txtTelefonoR.Size = new System.Drawing.Size(187, 20);
            this.txtTelefonoR.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(391, 412);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 18;
            this.label29.Text = "Teléfono";
            // 
            // txtCiudadR
            // 
            this.txtCiudadR.Location = new System.Drawing.Point(176, 409);
            this.txtCiudadR.Name = "txtCiudadR";
            this.txtCiudadR.Size = new System.Drawing.Size(209, 20);
            this.txtCiudadR.TabIndex = 17;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(130, 412);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "Ciudad";
            // 
            // txtNoSS
            // 
            this.txtNoSS.Location = new System.Drawing.Point(446, 347);
            this.txtNoSS.Name = "txtNoSS";
            this.txtNoSS.Size = new System.Drawing.Size(187, 20);
            this.txtNoSS.TabIndex = 15;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(413, 349);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 13);
            this.label27.TabIndex = 14;
            this.label27.Text = "No.:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(322, 304);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(140, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Para seguridad social acudir";
            // 
            // txtEmailR
            // 
            this.txtEmailR.Location = new System.Drawing.Point(190, 237);
            this.txtEmailR.Name = "txtEmailR";
            this.txtEmailR.Size = new System.Drawing.Size(443, 20);
            this.txtEmailR.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(130, 240);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "E-mail";
            // 
            // txtDomicilioR
            // 
            this.txtDomicilioR.Location = new System.Drawing.Point(190, 194);
            this.txtDomicilioR.Name = "txtDomicilioR";
            this.txtDomicilioR.Size = new System.Drawing.Size(443, 20);
            this.txtDomicilioR.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(130, 197);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Domicilio";
            // 
            // txtNoControlR
            // 
            this.txtNoControlR.Location = new System.Drawing.Point(196, 150);
            this.txtNoControlR.Name = "txtNoControlR";
            this.txtNoControlR.Size = new System.Drawing.Size(292, 20);
            this.txtNoControlR.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(130, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "No. Control";
            // 
            // txtCarreraR
            // 
            this.txtCarreraR.Location = new System.Drawing.Point(190, 105);
            this.txtCarreraR.Name = "txtCarreraR";
            this.txtCarreraR.Size = new System.Drawing.Size(443, 20);
            this.txtCarreraR.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(130, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Carrrera";
            // 
            // txtNombreResidente
            // 
            this.txtNombreResidente.Location = new System.Drawing.Point(190, 60);
            this.txtNombreResidente.Name = "txtNombreResidente";
            this.txtNombreResidente.Size = new System.Drawing.Size(443, 20);
            this.txtNombreResidente.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(130, 63);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // FrmSRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 690);
            this.Controls.Add(this.Menu);
            this.Name = "FrmSRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Residencias Profesionales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSRP_FormClosing);
            this.Menu.ResumeLayout(false);
            this.tabProyecto.ResumeLayout(false);
            this.tabProyecto.PerformLayout();
            this.tabDatosEmpresa.ResumeLayout(false);
            this.tabDatosEmpresa.PerformLayout();
            this.tabResidente.ResumeLayout(false);
            this.tabResidente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabProyecto;
        private System.Windows.Forms.TextBox txtNumResidencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeriodoProyecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDatosEmpresa;
        private System.Windows.Forms.TabPage tabResidente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPersonaFirma;
        private System.Windows.Forms.TextBox txtNombreFirma;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPuestoAE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPuestoTE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAsesorExterno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTitularEmpresa;
        private System.Windows.Forms.TextBox txtMisionEmpresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDomicilioE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFaxE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefonoE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColoniaE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCPE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRFCE;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.TextBox txtTelefonoR;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtCiudadR;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNoSS;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtEmailR;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtDomicilioR;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNoControlR;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCarreraR;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNombreResidente;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox cbxOpcionesDP;
        private System.Windows.Forms.ComboBox cbxGiroRamaSector;
        private System.Windows.Forms.ComboBox cbxSeguridadSocial;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LblOtro;
        private System.Windows.Forms.TextBox TxtOtro;
    }
}

