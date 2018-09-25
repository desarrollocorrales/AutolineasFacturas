using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using AutolineasFacturas.Modelo;

namespace AutolineasFacturas.Utilerias
{
    public class Generales
    {
        public void limpiaControles(Panel pn)
        {
            try
            {
                foreach (Control ctrl in pn.Controls)
                {
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox cmb = ((ComboBox)ctrl);
                        if (cmb.SelectedIndex <= 0)
                        {
                            cmb.SelectedIndex = -1;
                            cmb.Text = "";
                        }
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox texto = ((TextBox)ctrl);
                        texto.Text = "";
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                    {
                        DateTimePicker dtp = ((DateTimePicker)ctrl);
                        dtp.Value = DateTime.Now;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.GroupBox")
                    {
                        limpiaControlesG((GroupBox)ctrl);
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
                    {
                        DataGridView dgv = ((DataGridView)ctrl);
                        dgv.Columns.Clear();
                        dgv.DataSource = null;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.Label")
                    {
                        Label lbl = ((Label)ctrl);
                        if (lbl.Tag == "limpia")
                            lbl.Text = "";
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void limpiaControlesG(GroupBox gb)
        {
            try
            {
                foreach (Control ctrl in gb.Controls)
                {
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox cmb = ((ComboBox)ctrl);
                        if (cmb.SelectedIndex <= 0)
                        {
                            cmb.SelectedIndex = -1;
                            cmb.Text = "";
                        };
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox texto = ((TextBox)ctrl);
                        texto.Text = "";
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                    {
                        DateTimePicker dtp = ((DateTimePicker)ctrl);
                        dtp.Value = DateTime.Now;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
                    {
                        DataGridView dgv = ((DataGridView)ctrl);
                        dgv.Columns.Clear();
                        dgv.DataSource = null;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.GroupBox")
                    {
                        limpiaControlesG((GroupBox)ctrl);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void minimizar(Form frm)
        {
            try
            {
                frm.WindowState = FormWindowState.Minimized;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool teclaEnter(KeyPressEventArgs tecla)
        {
            try
            {
                bool resu = false;
                if ((int)tecla.KeyChar == (int)Keys.Enter)
                { resu = true; }

                return resu;
            }
            catch (Exception x)
            { throw x; }
        }

        //public void MouseLeaveEfectoPE(DevExpress.XtraEditors.PictureEdit pb, Bitmap imagen)
        //{
        //    try
        //    {
        //        pb.Image = imagen;
        //        pb.Properties.PictureAlignment = ContentAlignment.MiddleCenter;
        //    }
        //    catch (Exception x)
        //    { throw x; }
        //}

        public bool NumeroDecimal(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = true;
                if (Char.IsLetter(tecla.KeyChar))
                    resultado = true;
                if ((Char.IsNumber(tecla.KeyChar) || Char.IsPunctuation(tecla.KeyChar)) || tecla.KeyChar.ToString() == "\b")
                    resultado = false;

                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool NumeroEntero(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = true;
                if (Char.IsLetter(tecla.KeyChar) || Char.IsPunctuation(tecla.KeyChar))
                    resultado = true;
                if (Char.IsNumber(tecla.KeyChar) || tecla.KeyChar.ToString() == "\b")
                    resultado = false;

                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool Letra(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = false;
                if (Char.IsLetter(tecla.KeyChar) || tecla.KeyChar.ToString() == "\b")
                    resultado = false;
                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool EsNumerico(string strIn)
        {
            try
            {
                decimal.Parse(strIn);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void agregarDetalle(string mensaje, TextBox tbResultados)
        {
            try
            {
                tbResultados.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + mensaje + Environment.NewLine);

                Application.DoEvents();
            }
            catch (Exception x)
            { throw; }

        }

        public Sesion creaSesion(conexiones_servidores cs, string usuario, string pass)
        {
            try
            {
                Sesion obj_ses = new Sesion();

                obj_ses.conn = cs;
                obj_ses.usuario = usuario;
                obj_ses.pass = pass;

                return obj_ses;
            }
            catch (Exception x)
            { throw x; }
        }
    }

    public class Sesion
    {
        public Sesion()
        {
            usuario = "";
            pass = "";
            conexiones_servidores conn = new conexiones_servidores();
        }

        public string usuario { get; set; }
        public string pass { get; set; }
        public conexiones_servidores conn { get; set; }
    }
}
