namespace ArticulosMicrosip.GUI_s
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnOcultar = new System.Windows.Forms.ToolStripButton();
            this.tmAccion = new System.Windows.Forms.Timer(this.components);
            this.bgwConsultar = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbConexions = new System.Windows.Forms.TabPage();
            this.tsMenuCatalogos = new System.Windows.Forms.ToolStrip();
            this.btnAgrega = new System.Windows.Forms.ToolStripButton();
            this.btnActualiza = new System.Windows.Forms.ToolStripButton();
            this.pnDatosConn = new System.Windows.Forms.Panel();
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAceptarMS = new System.Windows.Forms.ToolStripButton();
            this.btnActualizarC = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelaMS = new System.Windows.Forms.ToolStrip();
            this.btnCancelaMS = new System.Windows.Forms.ToolStripButton();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txbSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.dgvConexionesMS = new System.Windows.Forms.DataGridView();
            this.tpMySQL = new System.Windows.Forms.TabPage();
            this.gbConexionMyS = new System.Windows.Forms.GroupBox();
            this.ts2 = new System.Windows.Forms.ToolStrip();
            this.tsCancelarMy = new System.Windows.Forms.ToolStripButton();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardarMy = new System.Windows.Forms.ToolStripButton();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.txtBDMy = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcConexiones = new System.Windows.Forms.TabControl();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnCerrarS = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConectar = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.tcConectar = new System.Windows.Forms.TabControl();
            this.tpConectar = new System.Windows.Forms.TabPage();
            this.tsControl.SuspendLayout();
            this.tbConexions.SuspendLayout();
            this.tsMenuCatalogos.SuspendLayout();
            this.pnDatosConn.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.CancelaMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexionesMS)).BeginInit();
            this.tpMySQL.SuspendLayout();
            this.gbConexionMyS.SuspendLayout();
            this.ts2.SuspendLayout();
            this.ts1.SuspendLayout();
            this.tcConexiones.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConectar)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tcConectar.SuspendLayout();
            this.tpConectar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsControl
            // 
            this.tsControl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tsControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar,
            this.btnOcultar});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Padding = new System.Windows.Forms.Padding(0);
            this.tsControl.Size = new System.Drawing.Size(605, 40);
            this.tsControl.TabIndex = 0;
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
            // tmAccion
            // 
            this.tmAccion.Interval = 1000;
            this.tmAccion.Tick += new System.EventHandler(this.tmAccion_Tick);
            // 
            // bgwConsultar
            // 
            this.bgwConsultar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsultar_DoWork);
            this.bgwConsultar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsultar_RunWorkerCompleted);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(104, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(467, 35);
            this.label11.TabIndex = 32;
            this.label11.Text = "Empresa";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbConexions
            // 
            this.tbConexions.Controls.Add(this.tsMenuCatalogos);
            this.tbConexions.Controls.Add(this.pnDatosConn);
            this.tbConexions.Controls.Add(this.dgvConexionesMS);
            this.tbConexions.Location = new System.Drawing.Point(4, 22);
            this.tbConexions.Name = "tbConexions";
            this.tbConexions.Size = new System.Drawing.Size(593, 329);
            this.tbConexions.TabIndex = 2;
            this.tbConexions.Text = "Conexiones";
            this.tbConexions.UseVisualStyleBackColor = true;
            // 
            // tsMenuCatalogos
            // 
            this.tsMenuCatalogos.BackColor = System.Drawing.Color.White;
            this.tsMenuCatalogos.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenuCatalogos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenuCatalogos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgrega,
            this.btnActualiza});
            this.tsMenuCatalogos.Location = new System.Drawing.Point(0, 0);
            this.tsMenuCatalogos.Name = "tsMenuCatalogos";
            this.tsMenuCatalogos.Padding = new System.Windows.Forms.Padding(0);
            this.tsMenuCatalogos.Size = new System.Drawing.Size(49, 329);
            this.tsMenuCatalogos.TabIndex = 40;
            this.tsMenuCatalogos.Text = "toolStrip1";
            // 
            // btnAgrega
            // 
            this.btnAgrega.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgrega.Image = ((System.Drawing.Image)(resources.GetObject("btnAgrega.Image")));
            this.btnAgrega.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgrega.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(48, 37);
            this.btnAgrega.Text = "Agrega Conexion";
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // btnActualiza
            // 
            this.btnActualiza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualiza.Image = ((System.Drawing.Image)(resources.GetObject("btnActualiza.Image")));
            this.btnActualiza.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnActualiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(48, 37);
            this.btnActualiza.Text = "Actualiza Conexion";
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // pnDatosConn
            // 
            this.pnDatosConn.Controls.Add(this.txbDatabase);
            this.pnDatosConn.Controls.Add(this.toolStrip1);
            this.pnDatosConn.Controls.Add(this.label3);
            this.pnDatosConn.Controls.Add(this.CancelaMS);
            this.pnDatosConn.Controls.Add(this.txbPort);
            this.pnDatosConn.Controls.Add(this.label9);
            this.pnDatosConn.Controls.Add(this.txbPass);
            this.pnDatosConn.Controls.Add(this.label10);
            this.pnDatosConn.Controls.Add(this.lblSucursal);
            this.pnDatosConn.Controls.Add(this.txbSucursal);
            this.pnDatosConn.Controls.Add(this.label2);
            this.pnDatosConn.Controls.Add(this.txbUser);
            this.pnDatosConn.Controls.Add(this.label4);
            this.pnDatosConn.Controls.Add(this.txbServer);
            this.pnDatosConn.Enabled = false;
            this.pnDatosConn.Location = new System.Drawing.Point(52, 142);
            this.pnDatosConn.Name = "pnDatosConn";
            this.pnDatosConn.Size = new System.Drawing.Size(533, 184);
            this.pnDatosConn.TabIndex = 33;
            // 
            // txbDatabase
            // 
            this.txbDatabase.Location = new System.Drawing.Point(91, 56);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(232, 20);
            this.txbDatabase.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAceptarMS,
            this.btnActualizarC});
            this.toolStrip1.Location = new System.Drawing.Point(150, 128);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(74, 50);
            this.toolStrip1.TabIndex = 39;
            // 
            // btnAceptarMS
            // 
            this.btnAceptarMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAceptarMS.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarMS.Image")));
            this.btnAceptarMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAceptarMS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptarMS.Name = "btnAceptarMS";
            this.btnAceptarMS.Size = new System.Drawing.Size(72, 47);
            this.btnAceptarMS.Text = "Aceptar";
            this.btnAceptarMS.Click += new System.EventHandler(this.btnGuardarMS_Click);
            // 
            // btnActualizarC
            // 
            this.btnActualizarC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizarC.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarC.Image")));
            this.btnActualizarC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnActualizarC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizarC.Name = "btnActualizarC";
            this.btnActualizarC.Size = new System.Drawing.Size(72, 47);
            this.btnActualizarC.Text = "Aceptar";
            this.btnActualizarC.Visible = false;
            this.btnActualizarC.Click += new System.EventHandler(this.btnActualizarC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Servidor:";
            // 
            // CancelaMS
            // 
            this.CancelaMS.Dock = System.Windows.Forms.DockStyle.None;
            this.CancelaMS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CancelaMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelaMS});
            this.CancelaMS.Location = new System.Drawing.Point(315, 129);
            this.CancelaMS.Name = "CancelaMS";
            this.CancelaMS.Padding = new System.Windows.Forms.Padding(0);
            this.CancelaMS.Size = new System.Drawing.Size(74, 50);
            this.CancelaMS.TabIndex = 38;
            // 
            // btnCancelaMS
            // 
            this.btnCancelaMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelaMS.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelaMS.Image")));
            this.btnCancelaMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelaMS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelaMS.Name = "btnCancelaMS";
            this.btnCancelaMS.Size = new System.Drawing.Size(72, 47);
            this.btnCancelaMS.Text = "Cancelar";
            this.btnCancelaMS.Click += new System.EventHandler(this.btnCancelarMS_Click);
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(428, 94);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(99, 20);
            this.txbPort.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Usuario:";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(428, 56);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(99, 20);
            this.txbPass.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Base datos:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(19, 21);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(63, 18);
            this.lblSucursal.TabIndex = 29;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // txbSucursal
            // 
            this.txbSucursal.Location = new System.Drawing.Point(91, 18);
            this.txbSucursal.Name = "txbSucursal";
            this.txbSucursal.Size = new System.Drawing.Size(130, 20);
            this.txbSucursal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Puerto:";
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(91, 94);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(232, 20);
            this.txbUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Contraseña:";
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(310, 18);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(217, 20);
            this.txbServer.TabIndex = 2;
            // 
            // dgvConexionesMS
            // 
            this.dgvConexionesMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConexionesMS.Location = new System.Drawing.Point(61, 16);
            this.dgvConexionesMS.Name = "dgvConexionesMS";
            this.dgvConexionesMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConexionesMS.Size = new System.Drawing.Size(516, 120);
            this.dgvConexionesMS.TabIndex = 0;
            this.dgvConexionesMS.SelectionChanged += new System.EventHandler(this.dgvConexionesMS_SelectionChanged);
            // 
            // tpMySQL
            // 
            this.tpMySQL.Controls.Add(this.gbConexionMyS);
            this.tpMySQL.Location = new System.Drawing.Point(4, 22);
            this.tpMySQL.Name = "tpMySQL";
            this.tpMySQL.Padding = new System.Windows.Forms.Padding(3);
            this.tpMySQL.Size = new System.Drawing.Size(593, 329);
            this.tpMySQL.TabIndex = 0;
            this.tpMySQL.Text = "MySQL";
            this.tpMySQL.UseVisualStyleBackColor = true;
            // 
            // gbConexionMyS
            // 
            this.gbConexionMyS.Controls.Add(this.ts2);
            this.gbConexionMyS.Controls.Add(this.ts1);
            this.gbConexionMyS.Controls.Add(this.txbServidor);
            this.gbConexionMyS.Controls.Add(this.txtBDMy);
            this.gbConexionMyS.Controls.Add(this.txbContraseña);
            this.gbConexionMyS.Controls.Add(this.label8);
            this.gbConexionMyS.Controls.Add(this.txbUsuario);
            this.gbConexionMyS.Controls.Add(this.label7);
            this.gbConexionMyS.Controls.Add(this.label5);
            this.gbConexionMyS.Controls.Add(this.label6);
            this.gbConexionMyS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConexionMyS.Location = new System.Drawing.Point(3, 3);
            this.gbConexionMyS.Name = "gbConexionMyS";
            this.gbConexionMyS.Size = new System.Drawing.Size(587, 323);
            this.gbConexionMyS.TabIndex = 25;
            this.gbConexionMyS.TabStop = false;
            // 
            // ts2
            // 
            this.ts2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCancelarMy});
            this.ts2.Location = new System.Drawing.Point(325, 243);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0);
            this.ts2.Size = new System.Drawing.Size(74, 50);
            this.ts2.TabIndex = 16;
            // 
            // tsCancelarMy
            // 
            this.tsCancelarMy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCancelarMy.Image = ((System.Drawing.Image)(resources.GetObject("tsCancelarMy.Image")));
            this.tsCancelarMy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCancelarMy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancelarMy.Name = "tsCancelarMy";
            this.tsCancelarMy.Size = new System.Drawing.Size(72, 47);
            this.tsCancelarMy.Text = "Cancelar";
            this.tsCancelarMy.Click += new System.EventHandler(this.tsCancelarMy_Click);
            // 
            // ts1
            // 
            this.ts1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardarMy});
            this.ts1.Location = new System.Drawing.Point(164, 243);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0);
            this.ts1.Size = new System.Drawing.Size(74, 50);
            this.ts1.TabIndex = 15;
            // 
            // btnGuardarMy
            // 
            this.btnGuardarMy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardarMy.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMy.Image")));
            this.btnGuardarMy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardarMy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarMy.Name = "btnGuardarMy";
            this.btnGuardarMy.Size = new System.Drawing.Size(72, 47);
            this.btnGuardarMy.Text = "Guardar";
            this.btnGuardarMy.Click += new System.EventHandler(this.btnGuardarMy_Click);
            // 
            // txbServidor
            // 
            this.txbServidor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServidor.Location = new System.Drawing.Point(113, 31);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(367, 26);
            this.txbServidor.TabIndex = 1;
            this.txbServidor.Text = "loscorrales.com.mx";
            // 
            // txtBDMy
            // 
            this.txtBDMy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDMy.Location = new System.Drawing.Point(113, 187);
            this.txtBDMy.Name = "txtBDMy";
            this.txtBDMy.Size = new System.Drawing.Size(367, 26);
            this.txtBDMy.TabIndex = 4;
            this.txtBDMy.Text = "loscorrales.com.mx";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Location = new System.Drawing.Point(113, 136);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(191, 26);
            this.txbContraseña.TabIndex = 3;
            this.txbContraseña.Text = "acceso.2016";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Base de datos:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(113, 83);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(191, 26);
            this.txbUsuario.TabIndex = 2;
            this.txbUsuario.Text = "corrales_tablero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Servidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Usuario:";
            // 
            // tcConexiones
            // 
            this.tcConexiones.Controls.Add(this.tpMySQL);
            this.tcConexiones.Controls.Add(this.tbConexions);
            this.tcConexiones.Location = new System.Drawing.Point(0, 40);
            this.tcConexiones.Name = "tcConexiones";
            this.tcConexiones.SelectedIndex = 0;
            this.tcConexiones.Size = new System.Drawing.Size(601, 355);
            this.tcConexiones.TabIndex = 31;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrarS});
            this.toolStrip3.Location = new System.Drawing.Point(356, 237);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip3.Size = new System.Drawing.Size(74, 50);
            this.toolStrip3.TabIndex = 43;
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrarS.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarS.Image")));
            this.btnCerrarS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrarS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.Size = new System.Drawing.Size(72, 47);
            this.btnCerrarS.Text = "Cancelar";
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Selecciona una Conexion:";
            // 
            // dgvConectar
            // 
            this.dgvConectar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConectar.Location = new System.Drawing.Point(14, 50);
            this.dgvConectar.Name = "dgvConectar";
            this.dgvConectar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConectar.Size = new System.Drawing.Size(568, 159);
            this.dgvConectar.TabIndex = 40;
            this.dgvConectar.SelectionChanged += new System.EventHandler(this.dgvConectar_SelectionChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSeleccionar});
            this.toolStrip2.Location = new System.Drawing.Point(153, 237);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(74, 50);
            this.toolStrip2.TabIndex = 41;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(72, 47);
            this.btnSeleccionar.Text = "Aceptar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // tcConectar
            // 
            this.tcConectar.Controls.Add(this.tpConectar);
            this.tcConectar.Location = new System.Drawing.Point(2, 41);
            this.tcConectar.Name = "tcConectar";
            this.tcConectar.SelectedIndex = 0;
            this.tcConectar.Size = new System.Drawing.Size(601, 355);
            this.tcConectar.TabIndex = 33;
            // 
            // tpConectar
            // 
            this.tpConectar.Controls.Add(this.toolStrip3);
            this.tpConectar.Controls.Add(this.label1);
            this.tpConectar.Controls.Add(this.toolStrip2);
            this.tpConectar.Controls.Add(this.dgvConectar);
            this.tpConectar.Location = new System.Drawing.Point(4, 22);
            this.tpConectar.Name = "tpConectar";
            this.tpConectar.Size = new System.Drawing.Size(593, 329);
            this.tpConectar.TabIndex = 3;
            this.tpConectar.Text = "Conectar";
            this.tpConectar.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 398);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tsControl);
            this.Controls.Add(this.tcConectar);
            this.Controls.Add(this.tcConexiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.tbConexions.ResumeLayout(false);
            this.tbConexions.PerformLayout();
            this.tsMenuCatalogos.ResumeLayout(false);
            this.tsMenuCatalogos.PerformLayout();
            this.pnDatosConn.ResumeLayout(false);
            this.pnDatosConn.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CancelaMS.ResumeLayout(false);
            this.CancelaMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexionesMS)).EndInit();
            this.tpMySQL.ResumeLayout(false);
            this.gbConexionMyS.ResumeLayout(false);
            this.gbConexionMyS.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.tcConexiones.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConectar)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tcConectar.ResumeLayout(false);
            this.tpConectar.ResumeLayout(false);
            this.tpConectar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripButton btnOcultar;
        public System.Windows.Forms.Timer tmAccion;
        private System.ComponentModel.BackgroundWorker bgwConsultar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tbConexions;
        private System.Windows.Forms.ToolStrip CancelaMS;
        private System.Windows.Forms.ToolStripButton btnCancelaMS;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.TextBox txbSucursal;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvConexionesMS;
        private System.Windows.Forms.TabPage tpMySQL;
        private System.Windows.Forms.GroupBox gbConexionMyS;
        private System.Windows.Forms.ToolStrip ts2;
        private System.Windows.Forms.ToolStripButton tsCancelarMy;
        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStripButton btnGuardarMy;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.TextBox txtBDMy;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tcConexiones;
        private System.Windows.Forms.Panel pnDatosConn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAceptarMS;
        private System.Windows.Forms.ToolStrip tsMenuCatalogos;
        private System.Windows.Forms.ToolStripButton btnAgrega;
        private System.Windows.Forms.ToolStripButton btnActualiza;
        private System.Windows.Forms.ToolStripButton btnActualizarC;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnCerrarS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConectar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSeleccionar;
        private System.Windows.Forms.TabControl tcConectar;
        private System.Windows.Forms.TabPage tpConectar;
    }
}