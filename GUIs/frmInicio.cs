using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using FirebirdSql.Data.FirebirdClient;
using AutolineasFacturas.Modelo;
using AutolineasFacturas.Utilerias;

namespace ArticulosMicrosip.GUI_s
{
    public partial class frmInicio : Form
    {
        #region Variables
        conexiones_servidores csMatriz; FirebirdDAL fb = new FirebirdDAL(); public conexiones_servidores csSeleccionada = new conexiones_servidores(); Sesion SesionActiva = new Sesion();
        //List<Articulos> lstArticulosMS;

        bool C = false;
        #endregion

        #region Constructor

        public frmInicio()
        {
            InitializeComponent();
            tpConectar.Hide();
        }

        public frmInicio(bool conectar, Sesion session = null)
        {
            InitializeComponent();
            C = conectar;
            SesionActiva = session;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            //conexion();
            CargarBasesDeDatos();  
        }

        #endregion

        #region Eventos

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private void btnOcultar_Click(object sender, EventArgs e)
        {
            try
            {
                new Generales().minimizar(this);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            try
            {
                pnDatosConn.Enabled = true;
                btnAceptarMS.Visible = true; btnActualizarC.Visible = false;
                new Generales().limpiaControles(pnDatosConn);
                txbSucursal.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnActualiza_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConexionesMS.CurrentRow != null)
                {
                    pnDatosConn.Enabled = btnActualizarC.Visible = true;
                    btnAceptarMS.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnActualizarC_Click(object sender, EventArgs e)
        {
            try
            {
                //conexiones_servidores conn = (conexiones_servidores)dgvConexionesMS.CurrentRow.DataBoundItem;

                //if (txbSucursal.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre de la sucursal."); }
                //if (txbServer.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre de Usuario del Servidor."); }
                //if (txbDatabase.Text.Trim() == "") { throw new Exception("No ha capturado la ruta de la Base de Datos."); }
                //if (txbUser.Text.Trim() == "") { throw new Exception("No ha capturado el nombre de Usuario de la Base de Datos."); }
                //if (txbPass.Text.Trim() == "") { throw new Exception("No ha capturado la contraseña de Usuario de la Base de Datos."); }
                //if (txbPort.Text.Trim() == "") { throw new Exception("No ha capturado el puerto de conexion a la base de datos."); }

                //int res = new Negocio().ActualizaConexionMS(conn.id_conexion, txbSucursal.Text, txbDatabase.Text, txbUser.Text, txbPass.Text.Trim(), Convert.ToInt32(txbPort.Text), txbServer.Text);
                //if (res > 0)
                //{
                //    MessageBox.Show("¡¡¡La configuración se ha Actualizado con exito!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    frmInicio_Load(null, null);
                //    pnDatosConn.Enabled = false;
                //}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void tmAccion_Tick(object sender, EventArgs e)
        {
            try
            {
                if (bgwConsultar.IsBusy == false)
                {
                    bgwConsultar.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwConsultar_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                csMatriz = new conexiones_servidores();
                csMatriz = new Consultas().obtenerMatriz();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bgwConsultar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try{
                if (csMatriz != null)
                {
                    //lstArticulosMS = new List<Articulos>();
                    //FirebirdDAL fb2 = new FirebirdDAL();
                    //lstArticulosMS = fb2.ObtenArticulos(csMatriz);

                    //MessageBox.Show("Se encontraron " + lstArticulosMS.Count);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvConexionesMS_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvConexionesMS.CurrentRow != null)
                {
                    conexiones_servidores conn = (conexiones_servidores)dgvConexionesMS.CurrentRow.DataBoundItem;
                    new Generales().limpiaControles(pnDatosConn);
                    conexiones_servidores AuxConn = new Consultas().ObtenerConn(conn.id_conexion);
                    if (AuxConn != null)
                    {
                        txbSucursal.Text = AuxConn.sucursal;
                        txbServer.Text = AuxConn.servidor;
                        txbDatabase.Text = AuxConn.base_datos;
                        txbPass.Text = AuxConn.contrasenia;
                        txbUser.Text = AuxConn.usuario;
                        txbPort.Text = AuxConn.puerto.ToString();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvConectar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvConectar.CurrentRow != null)
                {
                    csSeleccionada = (conexiones_servidores)dgvConectar.CurrentRow.DataBoundItem;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void btnGuardarMy_Click(object sender, EventArgs e)
        {
            try{

                //if (txbServidor.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre del Servidor."); }
                //if (txbUsuario.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre de Usuario de la conexión."); }
                //if (txbContraseña.Text.Trim() == "") { throw new Exception("No ha capturado la contraseña de Usuario del Servidor"); }
                //if (txtBDMy.Text.Trim() == "") { throw new Exception("No ha capturado la base de datos"); }

                //var Config = Properties.Settings.Default;

                //Config.Servidor = txbServidor.Text.Trim();
                //Config.Usuario = txbUsuario.Text.Trim();
                //Config.Contrasenia = new Seguridad().Base64Encode(txbContraseña.Text.Trim());
                //Config.BaseDatos = txtBDMy.Text.Trim();

                //Config.Save();
                //MessageBox.Show("Se han guardado correctamente los datos a MySQL", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ////objConsultas.ConexionModelo(Config.Servidor, Config.Usuario, new Seguridad().Base64Decode(Config.Contrasenia),Config.BaseDeDatos);
                //conexion();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsCancelarMy_Click(object sender, EventArgs e)
        {
            try{
                new Generales().limpiaControlesG(gbConexionMyS);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnGuardarMS_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbSucursal.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre de la sucursal."); }
                if (txbServer.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre de Usuario del Servidor."); }
                if (txbDatabase.Text.Trim() == "") { throw new Exception("No ha capturado la ruta de la Base de Datos."); }
                if (txbUser.Text.Trim() == "") { throw new Exception("No ha capturado el nombre de Usuario de la Base de Datos."); }
                if (txbPass.Text.Trim() == "") { throw new Exception("No ha capturado la contraseña de Usuario de la Base de Datos."); }
                if (txbPort.Text.Trim() == "") { throw new Exception("No ha capturado el puerto de conexion a la base de datos."); }

                GuardarConfiguraciones(txbSucursal.Text.Trim(), txbDatabase.Text.Trim(), txbUser.Text.Trim(), txbPass.Text.Trim(), Convert.ToInt32(txbPort.Text), txbServer.Text.Trim());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelarMS_Click(object sender, EventArgs e)
        {
            try
            {
                pnDatosConn.Enabled = false;
                frmInicio_Load(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConectar.CurrentRow != null)
                {
                    csSeleccionada = (conexiones_servidores)dgvConectar.CurrentRow.DataBoundItem;
                    if (SesionActiva != null)
                    {
                        csSeleccionada.usuario = SesionActiva.usuario;
                        csSeleccionada.contrasenia = SesionActiva.pass;

                        bool exito = new FirebirdDAL().ProbarConexion(csSeleccionada, SesionActiva.usuario, SesionActiva.pass);
                        if (exito)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    
                }
            }
            catch (Exception Ex)
            {
                if (Ex.InnerException.ToString() == "Your user name and password are not defined. Ask your database administrator to set up a Firebird login.")
                    MessageBox.Show("Su nombre de usuario y/o su contraseña no son Correctos. Favor de Verificar la Información.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Metodos

        private void conexion()
        {
            try
            {
                //var Config = Properties.Settings.Default;

                //txbServidor.Text = Config.Servidor;
                //txbUsuario.Text = Config.Usuario;
                //txbContraseña.Text = new Seguridad().Base64Decode(Config.Contrasenia);
                //txtBDMy.Text = Config.BaseDatos;
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void CargarBasesDeDatos()
        {
            try
            {
                //List<conexiones_servidores> lst = new Consultas().ObtenerConn();
                //if (lst.Count > 0)
                //{
                //    if (C)
                //    {
                //        formatoConn(dgvConectar, lst);
                //        tcConexiones.Visible = false;
                //        tcConectar.Visible = true;
                //    }
                //    else
                //    {
                //        formatoConn(dgvConexionesMS, lst);
                //        tcConexiones.Visible = true;
                //        tcConectar.Visible = false;
                //    }
                //}
                //else
                //{
                //    //formatoConn(dgvConexionesMS, lst);
                //    tcConexiones.Visible = true;
                //    tcConectar.Visible = false;
                //}
            }
            catch (Exception x)
            { throw x; }
        }

        private void GuardarConfiguraciones(string sucursal, string db, string user, string pass, int port, string server)
        {
            try
            {
                //conexiones_servidores obj_new = new conexiones_servidores();
                //obj_new.sucursal = sucursal.ToUpper();
                //obj_new.base_datos = db.Trim();
                //obj_new.usuario = user.Trim();
                //obj_new.contrasenia = new Seguridad().Base64Encode(pass);
                //obj_new.puerto = port;
                //obj_new.servidor = server.Trim();

                ////bool exito = fb.ProbarConexion(obj_new);

                //int res = new Negocio().NuevaConexionMS(txbSucursal.Text, txbDatabase.Text, txbUser.Text, txbPass.Text.Trim(), Convert.ToInt32(txbPort.Text), txbServer.Text);
                //if (res > 0)
                //{
                //    MessageBox.Show("¡¡¡La configuración se ha guardado con exito!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    frmInicio_Load(null, null);
                //    pnDatosConn.Enabled = false;
                //}            
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void formatoConn(DataGridView dgv, List<conexiones_servidores> lst)
        {
            try
            {
                dgv.DataSource = null; dgv.Columns.Clear();

                dgv.DataSource = lst;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Visible = false;
                    column.ReadOnly = true;
                }

                dgv.Columns["sucursal"].Visible = true;
                dgv.Columns["sucursal"].DisplayIndex = 0;
                dgv.Columns["sucursal"].HeaderText = "Sucursal";
                dgv.Columns["sucursal"].Width = 110;

                dgv.Columns["base_datos"].Visible = true;
                dgv.Columns["base_datos"].DisplayIndex = 2;
                dgv.Columns["base_datos"].HeaderText = "BD";
                dgv.Columns["base_datos"].Width = 200;
                //dgv.Columns["base_datos"].DefaultCellStyle.Format = "### ### ##0.00";

                //dgv.Columns["contrasenia"].Visible = true;
                //dgv.Columns["contrasenia"].DisplayIndex = 3;
                //dgv.Columns["contrasenia"].HeaderText = "Contraseña";
                //dgv.Columns["contrasenia"].Width = 120;

                dgv.Columns["puerto"].Visible = true;
                dgv.Columns["puerto"].DisplayIndex = 4;
                dgv.Columns["puerto"].HeaderText = "Puerto";
                dgv.Columns["puerto"].Width = 100;
                ////dgv.Columns["puerto"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgv.Columns["servidor"].Visible = true;
                dgv.Columns["servidor"].DisplayIndex = 1;
                dgv.Columns["servidor"].HeaderText = "Servidor";
                dgv.Columns["servidor"].Width = 210;

                dgv.CurrentCell = dgv.Rows[0].Cells["sucursal"];

            }
            catch (Exception x)
            { throw x; }
        }

        #endregion     

    }
}
