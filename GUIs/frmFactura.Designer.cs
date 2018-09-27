namespace AutolineasFacturas.GUIs
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnOcultar = new System.Windows.Forms.ToolStripButton();
            this.label11 = new System.Windows.Forms.Label();
            this.mnuFacturas = new System.Windows.Forms.ToolStrip();
            this.mnuGuardar = new System.Windows.Forms.ToolStripButton();
            this.mnuEditar = new System.Windows.Forms.ToolStripButton();
            this.mnuCerrar = new System.Windows.Forms.ToolStripButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.mnuBuscar = new System.Windows.Forms.ToolStrip();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblCamion = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.pnOrigen = new System.Windows.Forms.Panel();
            this.txtRecogera = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtrfcO = new System.Windows.Forms.TextBox();
            this.cmbRemitente = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.pnDestino = new System.Windows.Forms.Panel();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbDestinatario = new System.Windows.Forms.ComboBox();
            this.txtDomicilioDes = new System.Windows.Forms.TextBox();
            this.txtEntregara = new System.Windows.Forms.TextBox();
            this.txtrfcDes = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.pnDocs = new System.Windows.Forms.Panel();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtCouta = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.pnDiesel = new System.Windows.Forms.Panel();
            this.txtdieselT = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.txtdieselC = new System.Windows.Forms.TextBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.tsControl.SuspendLayout();
            this.mnuFacturas.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.mnuBuscar.SuspendLayout();
            this.pnOrigen.SuspendLayout();
            this.pnDestino.SuspendLayout();
            this.pnDocs.SuspendLayout();
            this.pnDiesel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsControl
            // 
            this.tsControl.BackColor = System.Drawing.Color.DodgerBlue;
            this.tsControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar,
            this.btnOcultar});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Padding = new System.Windows.Forms.Padding(0);
            this.tsControl.Size = new System.Drawing.Size(953, 40);
            this.tsControl.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 37);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultar.Image")));
            this.btnOcultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOcultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(49, 37);
            this.btnOcultar.Text = "Ocultar";
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DodgerBlue;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(115, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(791, 35);
            this.label11.TabIndex = 33;
            this.label11.Text = "Origen - Destino";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuFacturas
            // 
            this.mnuFacturas.BackColor = System.Drawing.Color.White;
            this.mnuFacturas.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuFacturas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnuFacturas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGuardar,
            this.mnuEditar,
            this.mnuCerrar});
            this.mnuFacturas.Location = new System.Drawing.Point(0, 40);
            this.mnuFacturas.Name = "mnuFacturas";
            this.mnuFacturas.Size = new System.Drawing.Size(52, 579);
            this.mnuFacturas.TabIndex = 34;
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuGuardar.Enabled = false;
            this.mnuGuardar.Image = ((System.Drawing.Image)(resources.GetObject("mnuGuardar.Image")));
            this.mnuGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.Size = new System.Drawing.Size(49, 47);
            this.mnuGuardar.Text = "Guardar";
            this.mnuGuardar.Click += new System.EventHandler(this.mnuGuardar_Click);
            // 
            // mnuEditar
            // 
            this.mnuEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuEditar.Enabled = false;
            this.mnuEditar.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditar.Image")));
            this.mnuEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Size = new System.Drawing.Size(49, 47);
            this.mnuEditar.Text = "Editar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuCerrar
            // 
            this.mnuCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCerrar.Image = ((System.Drawing.Image)(resources.GetObject("mnuCerrar.Image")));
            this.mnuCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCerrar.Name = "mnuCerrar";
            this.mnuCerrar.Size = new System.Drawing.Size(49, 47);
            this.mnuCerrar.Text = "Cancelar";
            this.mnuCerrar.Click += new System.EventHandler(this.mnuCerrar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.mnuBuscar);
            this.gbDatos.Controls.Add(this.lblCliente);
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Controls.Add(this.lblChofer);
            this.gbDatos.Controls.Add(this.lblCamion);
            this.gbDatos.Controls.Add(this.Label6);
            this.gbDatos.Controls.Add(this.Label5);
            this.gbDatos.Controls.Add(this.Label4);
            this.gbDatos.Controls.Add(this.txtNoFactura);
            this.gbDatos.Controls.Add(this.Label2);
            this.gbDatos.Controls.Add(this.Label3);
            this.gbDatos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(58, 40);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(884, 139);
            this.gbDatos.TabIndex = 35;
            this.gbDatos.TabStop = false;
            // 
            // mnuBuscar
            // 
            this.mnuBuscar.BackColor = System.Drawing.Color.White;
            this.mnuBuscar.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnuBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar});
            this.mnuBuscar.Location = new System.Drawing.Point(233, 12);
            this.mnuBuscar.Name = "mnuBuscar";
            this.mnuBuscar.Size = new System.Drawing.Size(54, 50);
            this.mnuBuscar.TabIndex = 18;
            this.mnuBuscar.Text = "toolStrip1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 47);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(95, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 19);
            this.lblCliente.TabIndex = 13;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(633, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 19);
            this.lblFecha.TabIndex = 14;
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(94, 110);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(0, 19);
            this.lblChofer.TabIndex = 16;
            // 
            // lblCamion
            // 
            this.lblCamion.AutoSize = true;
            this.lblCamion.Location = new System.Drawing.Point(633, 110);
            this.lblCamion.Name = "lblCamion";
            this.lblCamion.Size = new System.Drawing.Size(0, 19);
            this.lblCamion.TabIndex = 15;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(560, 110);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 19);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Camión:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(30, 110);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 19);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Chofer:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(560, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 19);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Fecha:";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoFactura.Location = new System.Drawing.Point(98, 26);
            this.txtNoFactura.MaxLength = 9;
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(132, 27);
            this.txtNoFactura.TabIndex = 1;
            this.txtNoFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNoFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoFactura_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 19);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Factura:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(29, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 19);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Cliente:";
            // 
            // pnOrigen
            // 
            this.pnOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOrigen.Controls.Add(this.txtRecogera);
            this.pnOrigen.Controls.Add(this.txtDomicilio);
            this.pnOrigen.Controls.Add(this.txtrfcO);
            this.pnOrigen.Controls.Add(this.cmbRemitente);
            this.pnOrigen.Controls.Add(this.cmbOrigen);
            this.pnOrigen.Controls.Add(this.Label7);
            this.pnOrigen.Controls.Add(this.Label9);
            this.pnOrigen.Controls.Add(this.Label12);
            this.pnOrigen.Controls.Add(this.label1);
            this.pnOrigen.Controls.Add(this.Label8);
            this.pnOrigen.Controls.Add(this.Label10);
            this.pnOrigen.Enabled = false;
            this.pnOrigen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOrigen.Location = new System.Drawing.Point(58, 185);
            this.pnOrigen.Name = "pnOrigen";
            this.pnOrigen.Size = new System.Drawing.Size(434, 304);
            this.pnOrigen.TabIndex = 36;
            // 
            // txtRecogera
            // 
            this.txtRecogera.Location = new System.Drawing.Point(75, 232);
            this.txtRecogera.MaxLength = 99;
            this.txtRecogera.Multiline = true;
            this.txtRecogera.Name = "txtRecogera";
            this.txtRecogera.Size = new System.Drawing.Size(339, 55);
            this.txtRecogera.TabIndex = 7;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(75, 156);
            this.txtDomicilio.MaxLength = 99;
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(339, 58);
            this.txtDomicilio.TabIndex = 7;
            // 
            // txtrfcO
            // 
            this.txtrfcO.Location = new System.Drawing.Point(75, 118);
            this.txtrfcO.MaxLength = 13;
            this.txtrfcO.Name = "txtrfcO";
            this.txtrfcO.Size = new System.Drawing.Size(100, 23);
            this.txtrfcO.TabIndex = 7;
            // 
            // cmbRemitente
            // 
            this.cmbRemitente.FormattingEnabled = true;
            this.cmbRemitente.Location = new System.Drawing.Point(75, 81);
            this.cmbRemitente.MaxLength = 99;
            this.cmbRemitente.Name = "cmbRemitente";
            this.cmbRemitente.Size = new System.Drawing.Size(339, 23);
            this.cmbRemitente.TabIndex = 1;
            this.cmbRemitente.SelectionChangeCommitted += new System.EventHandler(this.cmbRemitente_SelectionChangeCommitted);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(75, 47);
            this.cmbOrigen.MaxLength = 99;
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(339, 23);
            this.cmbOrigen.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(151, 6);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(113, 29);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "ORIGEN";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(5, 84);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(70, 15);
            this.Label9.TabIndex = 3;
            this.Label9.Text = "Remitente:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(5, 235);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(72, 15);
            this.Label12.TabIndex = 3;
            this.Label12.Text = "Recoger en:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Domicilio:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(27, 50);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(48, 15);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Origen:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(43, 121);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(31, 15);
            this.Label10.TabIndex = 3;
            this.Label10.Text = "RFC:";
            // 
            // pnDestino
            // 
            this.pnDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDestino.Controls.Add(this.cmbDestino);
            this.pnDestino.Controls.Add(this.cmbDestinatario);
            this.pnDestino.Controls.Add(this.txtDomicilioDes);
            this.pnDestino.Controls.Add(this.txtEntregara);
            this.pnDestino.Controls.Add(this.txtrfcDes);
            this.pnDestino.Controls.Add(this.Label18);
            this.pnDestino.Controls.Add(this.Label15);
            this.pnDestino.Controls.Add(this.Label16);
            this.pnDestino.Controls.Add(this.Label17);
            this.pnDestino.Controls.Add(this.Label13);
            this.pnDestino.Controls.Add(this.Label14);
            this.pnDestino.Enabled = false;
            this.pnDestino.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDestino.Location = new System.Drawing.Point(498, 185);
            this.pnDestino.Name = "pnDestino";
            this.pnDestino.Size = new System.Drawing.Size(444, 304);
            this.pnDestino.TabIndex = 37;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(84, 47);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(339, 23);
            this.cmbDestino.TabIndex = 1;
            // 
            // cmbDestinatario
            // 
            this.cmbDestinatario.FormattingEnabled = true;
            this.cmbDestinatario.Location = new System.Drawing.Point(84, 81);
            this.cmbDestinatario.MaxLength = 99;
            this.cmbDestinatario.Name = "cmbDestinatario";
            this.cmbDestinatario.Size = new System.Drawing.Size(339, 23);
            this.cmbDestinatario.TabIndex = 1;
            this.cmbDestinatario.SelectionChangeCommitted += new System.EventHandler(this.cmbDestinatario_SelectionChangeCommitted);
            // 
            // txtDomicilioDes
            // 
            this.txtDomicilioDes.Location = new System.Drawing.Point(84, 156);
            this.txtDomicilioDes.MaxLength = 99;
            this.txtDomicilioDes.Multiline = true;
            this.txtDomicilioDes.Name = "txtDomicilioDes";
            this.txtDomicilioDes.Size = new System.Drawing.Size(339, 58);
            this.txtDomicilioDes.TabIndex = 7;
            // 
            // txtEntregara
            // 
            this.txtEntregara.Location = new System.Drawing.Point(84, 232);
            this.txtEntregara.MaxLength = 99;
            this.txtEntregara.Multiline = true;
            this.txtEntregara.Name = "txtEntregara";
            this.txtEntregara.Size = new System.Drawing.Size(339, 55);
            this.txtEntregara.TabIndex = 7;
            // 
            // txtrfcDes
            // 
            this.txtrfcDes.Location = new System.Drawing.Point(84, 118);
            this.txtrfcDes.MaxLength = 13;
            this.txtrfcDes.Name = "txtrfcDes";
            this.txtrfcDes.Size = new System.Drawing.Size(100, 23);
            this.txtrfcDes.TabIndex = 7;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(3, 235);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(75, 15);
            this.Label18.TabIndex = 3;
            this.Label18.Text = "Entregar en:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(0, 84);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(78, 15);
            this.Label15.TabIndex = 3;
            this.Label15.Text = "Destinatario:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(47, 121);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(31, 15);
            this.Label16.TabIndex = 3;
            this.Label16.Text = "RFC:";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(17, 159);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(61, 15);
            this.Label17.TabIndex = 3;
            this.Label17.Text = "Domicilio:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(156, 6);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(128, 29);
            this.Label13.TabIndex = 3;
            this.Label13.Text = "DESTINO";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(25, 50);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(53, 15);
            this.Label14.TabIndex = 3;
            this.Label14.Text = "Destino:";
            // 
            // pnDocs
            // 
            this.pnDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDocs.Controls.Add(this.txtDocumento);
            this.pnDocs.Controls.Add(this.txtCaja);
            this.pnDocs.Controls.Add(this.txtCouta);
            this.pnDocs.Controls.Add(this.Label19);
            this.pnDocs.Controls.Add(this.Label20);
            this.pnDocs.Controls.Add(this.Label21);
            this.pnDocs.Enabled = false;
            this.pnDocs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDocs.Location = new System.Drawing.Point(58, 495);
            this.pnDocs.Name = "pnDocs";
            this.pnDocs.Size = new System.Drawing.Size(884, 54);
            this.pnDocs.TabIndex = 38;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(81, 16);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(271, 23);
            this.txtDocumento.TabIndex = 8;
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(754, 16);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(100, 23);
            this.txtCaja.TabIndex = 7;
            this.txtCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCouta
            // 
            this.txtCouta.Location = new System.Drawing.Point(506, 16);
            this.txtCouta.Name = "txtCouta";
            this.txtCouta.Size = new System.Drawing.Size(100, 23);
            this.txtCouta.TabIndex = 7;
            this.txtCouta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(465, 19);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(43, 15);
            this.Label19.TabIndex = 7;
            this.Label19.Text = "Cuota:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(720, 19);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(33, 15);
            this.Label20.TabIndex = 7;
            this.Label20.Text = "Caja:";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(6, 19);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(75, 15);
            this.Label21.TabIndex = 7;
            this.Label21.Text = "Documento:";
            // 
            // pnDiesel
            // 
            this.pnDiesel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDiesel.Controls.Add(this.txtdieselT);
            this.pnDiesel.Controls.Add(this.Label29);
            this.pnDiesel.Controls.Add(this.txtdieselC);
            this.pnDiesel.Controls.Add(this.Label28);
            this.pnDiesel.Controls.Add(this.txtGastos);
            this.pnDiesel.Controls.Add(this.Label27);
            this.pnDiesel.Controls.Add(this.txtRecorrido);
            this.pnDiesel.Controls.Add(this.Label26);
            this.pnDiesel.Enabled = false;
            this.pnDiesel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDiesel.Location = new System.Drawing.Point(58, 559);
            this.pnDiesel.Name = "pnDiesel";
            this.pnDiesel.Size = new System.Drawing.Size(884, 54);
            this.pnDiesel.TabIndex = 39;
            // 
            // txtdieselT
            // 
            this.txtdieselT.Location = new System.Drawing.Point(782, 15);
            this.txtdieselT.MaxLength = 50;
            this.txtdieselT.Name = "txtdieselT";
            this.txtdieselT.Size = new System.Drawing.Size(72, 23);
            this.txtdieselT.TabIndex = 0;
            this.txtdieselT.Text = "0";
            this.txtdieselT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdieselT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecorrido_KeyPress);
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(246, 18);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(47, 15);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "Gastos:";
            // 
            // txtdieselC
            // 
            this.txtdieselC.Location = new System.Drawing.Point(534, 15);
            this.txtdieselC.MaxLength = 50;
            this.txtdieselC.Name = "txtdieselC";
            this.txtdieselC.Size = new System.Drawing.Size(72, 23);
            this.txtdieselC.TabIndex = 2;
            this.txtdieselC.Text = "0";
            this.txtdieselC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdieselC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecorrido_KeyPress);
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(690, 19);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(90, 15);
            this.Label28.TabIndex = 3;
            this.Label28.Text = "Diesel Thermo:";
            // 
            // txtGastos
            // 
            this.txtGastos.Location = new System.Drawing.Point(295, 15);
            this.txtGastos.MaxLength = 50;
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.Size = new System.Drawing.Size(73, 23);
            this.txtGastos.TabIndex = 4;
            this.txtGastos.Text = "0";
            this.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGastos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecorrido_KeyPress);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(444, 19);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(88, 15);
            this.Label27.TabIndex = 5;
            this.Label27.Text = "Diesel Camión:";
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(81, 15);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(72, 23);
            this.txtRecorrido.TabIndex = 6;
            this.txtRecorrido.Text = "0";
            this.txtRecorrido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecorrido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecorrido_KeyPress);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(16, 18);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(64, 15);
            this.Label26.TabIndex = 7;
            this.Label26.Text = "Recorrido:";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(953, 619);
            this.Controls.Add(this.pnDiesel);
            this.Controls.Add(this.pnDocs);
            this.Controls.Add(this.pnDestino);
            this.Controls.Add(this.pnOrigen);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.mnuFacturas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.mnuFacturas.ResumeLayout(false);
            this.mnuFacturas.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.mnuBuscar.ResumeLayout(false);
            this.mnuBuscar.PerformLayout();
            this.pnOrigen.ResumeLayout(false);
            this.pnOrigen.PerformLayout();
            this.pnDestino.ResumeLayout(false);
            this.pnDestino.PerformLayout();
            this.pnDocs.ResumeLayout(false);
            this.pnDocs.PerformLayout();
            this.pnDiesel.ResumeLayout(false);
            this.pnDiesel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripButton btnOcultar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip mnuFacturas;
        private System.Windows.Forms.ToolStripButton mnuGuardar;
        private System.Windows.Forms.ToolStripButton mnuEditar;
        private System.Windows.Forms.ToolStripButton mnuCerrar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblCamion;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ToolStrip mnuBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Panel pnOrigen;
        private System.Windows.Forms.TextBox txtRecogera;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtrfcO;
        private System.Windows.Forms.ComboBox cmbRemitente;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Panel pnDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbDestinatario;
        private System.Windows.Forms.TextBox txtDomicilioDes;
        private System.Windows.Forms.TextBox txtEntregara;
        private System.Windows.Forms.TextBox txtrfcDes;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Panel pnDocs;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtCouta;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.Panel pnDiesel;
        private System.Windows.Forms.TextBox txtdieselT;
        private System.Windows.Forms.Label Label29;
        private System.Windows.Forms.TextBox txtdieselC;
        private System.Windows.Forms.Label Label28;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.Label Label27;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label Label26;
    }
}