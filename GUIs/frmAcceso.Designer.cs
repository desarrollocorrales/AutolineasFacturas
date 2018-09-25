namespace AutolineasFacturas.GUIs
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.btnOcultar = new System.Windows.Forms.ToolStripButton();
            this.ts2 = new System.Windows.Forms.ToolStrip();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.btnAcceder = new System.Windows.Forms.ToolStripButton();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConectar = new System.Windows.Forms.ToolStripButton();
            this.lblConexion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tsControl.SuspendLayout();
            this.ts2.SuspendLayout();
            this.ts1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsControl
            // 
            this.tsControl.BackColor = System.Drawing.Color.DodgerBlue;
            this.tsControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOcultar});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Padding = new System.Windows.Forms.Padding(0);
            this.tsControl.Size = new System.Drawing.Size(337, 40);
            this.tsControl.TabIndex = 25;
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
            // ts2
            // 
            this.ts2.BackColor = System.Drawing.Color.White;
            this.ts2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrar});
            this.ts2.Location = new System.Drawing.Point(204, 188);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0);
            this.ts2.Size = new System.Drawing.Size(74, 50);
            this.ts2.TabIndex = 65;
            this.ts2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts2_ItemClicked);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 47);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ts1
            // 
            this.ts1.BackColor = System.Drawing.Color.White;
            this.ts1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAcceder});
            this.ts1.Location = new System.Drawing.Point(77, 188);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0);
            this.ts1.Size = new System.Drawing.Size(74, 50);
            this.ts1.TabIndex = 64;
            this.ts1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts1_ItemClicked);
            // 
            // btnAcceder
            // 
            this.btnAcceder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAcceder.Image = ((System.Drawing.Image)(resources.GetObject("btnAcceder.Image")));
            this.btnAcceder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAcceder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(72, 47);
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txbPass
            // 
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPass.Location = new System.Drawing.Point(99, 143);
            this.txbPass.MaxLength = 20;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(230, 20);
            this.txbPass.TabIndex = 2;
            this.txbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(51, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 35);
            this.label6.TabIndex = 66;
            this.label6.Text = "Autolineas Facturas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbUser
            // 
            this.txbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbUser.Location = new System.Drawing.Point(99, 98);
            this.txbUser.MaxLength = 20;
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(230, 20);
            this.txbUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Usuario:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConectar});
            this.toolStrip1.Location = new System.Drawing.Point(27, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(42, 43);
            this.toolStrip1.TabIndex = 69;
            this.toolStrip1.Visible = false;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConectar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConectar.Image = ((System.Drawing.Image)(resources.GetObject("btnConectar.Image")));
            this.btnConectar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConectar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(40, 40);
            this.btnConectar.Text = "Conexion";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblConexion
            // 
            this.lblConexion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.Location = new System.Drawing.Point(48, 53);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(260, 30);
            this.lblConexion.TabIndex = 70;
            this.lblConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblVersion.Location = new System.Drawing.Point(1, 250);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(93, 13);
            this.lblVersion.TabIndex = 71;
            this.lblVersion.Text = "Copyright ©  2018";
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(337, 266);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ts2);
            this.Controls.Add(this.ts1);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton btnOcultar;
        private System.Windows.Forms.ToolStrip ts2;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStripButton btnAcceder;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConectar;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Label lblVersion;
    }
}