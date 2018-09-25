using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutolineasFacturas.Utilerias;

namespace AutolineasFacturas.GUIs
{
    public partial class frmFactura : Form
    {
        #region Variables
        Generales obj_generales = new Generales(); Consultas obj_consultas = new Consultas(); FirebirdDAL FBDatos = new FirebirdDAL();
        Sesion SessionUser = new Sesion(); BuscarDatos obj_datos = new BuscarDatos(); LIBRES_FAC_VE obj_Origen = new LIBRES_FAC_VE();
        int cnt = 0;
        #endregion

        #region Constructor
        public frmFactura()
        {
            InitializeComponent();
        }

        public frmFactura(Sesion SesionActiva)
        {
            InitializeComponent();
            SessionUser = SesionActiva;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            try
            {
                txtNoFactura.Focus();
                informacion();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Eventos

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAcceso().Show();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_generales.minimizar(this);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtNoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    btnBuscar_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoFactura.Text.Trim() == "")
                {
                    MessageBox.Show("No se ha capturado ningun No. de factura.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoFactura.Focus();
                    return;                    
                }

                obj_datos = FBDatos.ObtenFactura(SessionUser.conn, SessionUser.usuario, SessionUser.pass, txtNoFactura.Text.Trim());
                if (obj_datos.docto_ve_id > 0)
                {
                    lblCliente.Text = obj_datos.cliente;
                    lblFecha.Text = obj_datos.fecha.ToShortDateString();
                    lblChofer.Text = obj_datos.vendedor;
                    lblCamion.Text = obj_datos.almacen;

                    obj_Origen = FBDatos.obtenOrigen(SessionUser.conn, SessionUser.usuario, SessionUser.pass, obj_datos.docto_ve_id);
                    mnuEditar.Enabled = true;

                    if (obj_Origen != null)
                    {
                        cnt = 0;
                        CargaDatos(obj_Origen);
                    }
                    //else
                    //{
                    //    MessageBox.Show("No se encontraron datos en la busqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    txtNoFactura.Focus();
                    //}
                }
                else
                {
                    MessageBox.Show("No se encontraron datos en la busqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNoFactura.Focus();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void mnuEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (obj_datos.docto_ve_id <= 0)
                    return;
                pnOrigen.Enabled = true;
                pnDestino.Enabled = true;
                pnDocs.Enabled = true;
                pnDiesel.Enabled = true;
                cmbOrigen.Focus();
                mnuGuardar.Enabled = true;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                LIBRES_FAC_VE objInsert = new LIBRES_FAC_VE();
                objInsert.DOCTO_VE_ID = obj_Origen.DOCTO_VE_ID;
                objInsert.ORIGEN = cmbOrigen.Text;
                objInsert.RFC_REM = txtrfcO.Text;
                objInsert.REMITENTE = cmbRemitente.Text;
                objInsert.DOMICILIO_REM = txtDomicilio.Text;
                objInsert.RECOGERA = txtRecogera.Text;
                objInsert.DESTINO = cmbDestino.Text;
                objInsert.DESTINATARIO = cmbDestinatario.Text;
                objInsert.RFC_DES = txtrfcDes.Text;
                objInsert.DOMICILIO_DES = txtDomicilioDes.Text;
                objInsert.ENTREGARA = txtEntregara.Text;
                objInsert.CUOTA = txtCouta.Text;
                objInsert.CAJA = txtCaja.Text;
                objInsert.DOCUMENTO = txtDocumento.Text;
                objInsert.RECORRIDO = txtRecorrido.Text;
                objInsert.DIESEL_CAMION = Convert.ToDecimal(txtdieselC.Text);
                objInsert.DIESEL_THERMO = Convert.ToDecimal(txtdieselT.Text);
                objInsert.GASTO = Convert.ToDecimal(txtGastos.Text);

                if (obj_Origen.DOCTO_VE_ID > 0 && cnt == 0)
                {                  
                    LIBRES_FAC_VE newOrigen = FBDatos.InsertaFactura(SessionUser, objInsert);
                    FBDatos.ActualizaDoctoVe(SessionUser, newOrigen.DOCTO_VE_ID);

                    MessageBox.Show("Información Insertada Correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    LIBRES_FAC_VE UpdateObj = FBDatos.UpdateFactura(SessionUser, objInsert);
                    FBDatos.ActualizaDoctoVe(SessionUser, UpdateObj.DOCTO_VE_ID);

                    MessageBox.Show("Información Actualizada Correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                mnuCerrar_Click(null, null);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void mnuCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_generales.limpiaControles(pnDestino);
                obj_generales.limpiaControlesG(gbDatos);
                obj_generales.limpiaControles(pnOrigen);
                obj_generales.limpiaControles(pnDiesel);
                obj_generales.limpiaControles(pnDocs);
                lblCamion.Text = lblChofer.Text = lblCliente.Text = lblFecha.Text = "";
                mnuEditar.Enabled = mnuGuardar.Enabled = pnDestino.Enabled = pnOrigen.Enabled = pnDiesel.Enabled = pnDocs.Enabled = false;
                cmbOrigen.SelectedIndex = -1; cmbRemitente.Text = ""; cmbRemitente.SelectedIndex = -1; cmbDestino.Text = ""; cmbDestino.SelectedIndex = -1; cmbDestinatario.Text = ""; cmbDestinatario.SelectedIndex = -1; cmbOrigen.Text = "";
                txtNoFactura.Focus();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtRecorrido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = obj_generales.NumeroDecimal(e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Metodos

        private void informacion()
        {
            List<LIBRES_FAC_VE> lstDatos = new List<LIBRES_FAC_VE>();

            lstDatos = FBDatos.Datos("select DISTINCT(ORIGEN) from LIBRES_FAC_VE where ORIGEN<>'' order by ORIGEN", SessionUser, "O");
            foreach (LIBRES_FAC_VE l in lstDatos)
            {
                cmbOrigen.Items.Add(l.ORIGEN);
                cmbOrigen.SelectedIndex = -1;
            }

            lstDatos.Clear();
            lstDatos = FBDatos.Datos("select DISTINCT(REMITENTE) from LIBRES_FAC_VE where REMITENTE<>'' order by REMITENTE", SessionUser, "R");
            foreach (LIBRES_FAC_VE l in lstDatos)
            {
                cmbRemitente.Items.Add(l.REMITENTE);
                cmbRemitente.SelectedIndex = -1;
            }

            lstDatos.Clear();
            lstDatos = FBDatos.Datos("select DISTINCT(DESTINO) from LIBRES_FAC_VE where DESTINO<>'' order by DESTINO", SessionUser, "D");
            foreach (LIBRES_FAC_VE l in lstDatos)
            {
                cmbDestino.Items.Add(l.DESTINO);
                cmbDestino.SelectedIndex = -1;
            }

            lstDatos.Clear();
            lstDatos = FBDatos.Datos("select DISTINCT(DESTINATARIO) from LIBRES_FAC_VE where DESTINATARIO<>'' order by DESTINATARIO", SessionUser, "DES");
            foreach (LIBRES_FAC_VE l in lstDatos)
            {
                cmbDestinatario.Items.Add(l.DESTINATARIO);
                cmbDestinatario.SelectedIndex = -1;
            }
        }

        private void CargaDatos(LIBRES_FAC_VE obj_origen)
        {
            try
            {
                cnt++;
                cmbOrigen.Text = obj_Origen.ORIGEN;
                txtrfcO.Text = obj_Origen.RFC_REM;
                cmbRemitente.Text = obj_Origen.REMITENTE;
                txtDomicilio.Text = obj_Origen.DOMICILIO_REM;
                txtRecogera.Text = obj_Origen.RECOGERA;
                cmbDestino.Text = obj_Origen.DESTINO;
                cmbDestinatario.Text = obj_Origen.DESTINATARIO;
                txtrfcDes.Text = obj_Origen.RFC_DES;
                txtDomicilioDes.Text = obj_Origen.DOMICILIO_DES;
                txtEntregara.Text = obj_Origen.ENTREGARA;
                txtCouta.Text = obj_Origen.CUOTA;
                txtCaja.Text = obj_Origen.CAJA;
                txtDocumento.Text = obj_Origen.DOCUMENTO;
                txtRecorrido.Text = obj_Origen.RECORRIDO;
                txtGastos.Text = obj_Origen.GASTO.ToString();
                txtdieselC.Text = obj_Origen.DIESEL_CAMION.ToString();
                txtdieselT.Text = obj_Origen.DIESEL_THERMO.ToString();
            }
            catch (Exception x)
            { throw x; }
        }

        public void CargaCombo(ComboBox cmd, string tipo)
        {
            try
            {

            }
            catch (Exception x)
            { throw x; }
        }
        #endregion     

    }
}
