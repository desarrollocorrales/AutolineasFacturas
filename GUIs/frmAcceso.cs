using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutolineasFacturas.Utilerias;
using AutolineasFacturas.Modelo;

namespace AutolineasFacturas.GUIs
{
    public partial class frmAcceso : Form
    {
        #region Variables
        conexiones_servidores csSeleccionada = new conexiones_servidores();
        FirebirdDAL fbDatos = new FirebirdDAL();
        #endregion

        #region Constructor

        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            csSeleccionada = new Consultas().ObtenerConn();
            lblConexion.Text = csSeleccionada.sucursal;
        }
        #endregion

        #region Eventos
        private void btnOcultar_Click(object sender, EventArgs e)
        {
            try
            {
                new Generales().minimizar(this);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                bool exito = false;
                if (txbPass.Text == "" || txbUser.Text == "")
                {
                    MessageBox.Show("Se debe introducir un usuario y una Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                exito = fbDatos.ProbarConexion(csSeleccionada, txbUser.Text.Trim(), txbPass.Text.Trim());
                if (exito)
                {
                    this.Hide();
                    new frmFactura(new Generales().creaSesion(csSeleccionada, txbUser.Text.Trim(), txbPass.Text.Trim())).ShowDialog();

                    //new frnPrincipal(creaSesion(csSeleccionada, txbUser.Text.Trim(), txbPass.Text.Trim())).ShowDialog();
                }

            }
            catch (Exception ex)
            {
                if (ex.InnerException.ToString() == "Your user name and password are not defined. Ask your database administrator to set up a Firebird login.")
                    MessageBox.Show("Su nombre de usuario y/o su contraseña no son Correctos. Favor de Verificar la Información.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAcceder_Click(null, null);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //frmIni = new frmInicio(true);
                //frmIni.FormClosed += new FormClosedEventHandler(frmIni_FormClosed);
                //frmIni.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Application.Exit();
            }
            catch (Exception x)
            { MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        private void ts2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ts1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #region Metodos
        #endregion              

    }
}
