using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using AutolineasFacturas.Modelo;
using System.Data;
using System.Windows.Forms;

namespace AutolineasFacturas.Utilerias
{
    public class FirebirdDAL
    {
        FbConnection Conexion = new FbConnection();
        FbCommand Comando = new FbCommand();
        FbDataAdapter Adapter = new FbDataAdapter();

        public FirebirdDAL()
        {
            Conexion = new FbConnection();
            Comando = new FbCommand();
            Adapter = new FbDataAdapter();

            //Conexion.ConnectionString = getConnectionString();
        }

        public string getConnectionString2(conexiones_servidores cs, string user, string pass)
        {

            FbConnectionStringBuilder fbcsb = new FbConnectionStringBuilder();
            fbcsb.DataSource = cs.servidor;
            fbcsb.Database = cs.base_datos;
            fbcsb.UserID = user;
            fbcsb.Password = pass;
            fbcsb.Port = cs.puerto;
            fbcsb.Dialect = 3;
            fbcsb.Charset = "UTF8";

            return fbcsb.ConnectionString;
        }

        public string DatosConexion(conexiones_servidores cs, string usuario, string pass)
        {

            FbConnectionStringBuilder fbcsb = new FbConnectionStringBuilder();
            fbcsb.DataSource = cs.servidor;
            fbcsb.Database = cs.base_datos;
            fbcsb.UserID = usuario;
            fbcsb.Password = pass;
            fbcsb.Port = cs.puerto;
            fbcsb.Dialect = 3;
            fbcsb.Charset = "UTF8";

            return fbcsb.ConnectionString;
        }

        public bool ProbarConexion(conexiones_servidores conexion, string usuario, string pass)
        {
            try
            {
                bool exito = false;
                FbConnection conn = new FbConnection(DatosConexion(conexion, usuario, pass));

                conn.Open();
                exito = true;
                conn.Close();

                return exito;
            }
            catch (Exception x)
            { throw x; }
        }

        public BuscarDatos ObtenFactura(conexiones_servidores csMatriz, string user, string pass, string folio)
        {
            try
            {
                Conexion.ConnectionString = getConnectionString2(csMatriz, user, pass);
                string Consulta =
                    string.Format(@"SELECT A.FOLIO, A.DOCTO_VE_ID, B.NOMBRE cliente, A.FECHA, C.NOMBRE vendedor, D.NOMBRE almacen FROM DOCTOS_VE a INNER JOIN CLIENTES b on(a.CLIENTE_ID=b.CLIENTE_ID) INNER JOIN VENDEDORES c on(a.VENDEDOR_ID=c.VENDEDOR_ID) INNER JOIN ALMACENES d on(a.ALMACEN_ID=d.ALMACEN_ID) WHERE FOLIO='" + folio + "'");

                /* Acceso a base de datos */
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandText = Consulta;
                Adapter.SelectCommand = Comando;

                DataTable tablaResultado = new DataTable();
                Adapter.Fill(tablaResultado);

                BuscarDatos obj_datos = new BuscarDatos();
                foreach (DataRow row in tablaResultado.Rows)
                {
                    obj_datos.docto_ve_id = Convert.ToInt32(row["DOCTO_VE_ID"].ToString());
                    obj_datos.folio = row["FOLIO"].ToString();
                    obj_datos.cliente = row["cliente"].ToString();
                    obj_datos.fecha = Convert.ToDateTime(row["FECHA"]);
                    obj_datos.vendedor = row["vendedor"].ToString();
                    obj_datos.almacen = row["almacen"].ToString();
                }

                Conexion.Close();
                /**************************/
                return obj_datos;
            }
            catch (Exception x)
            { throw x; }
        }

        public List<LIBRES_FAC_VE> Datos(string sql, Sesion SesionA, string tipo)
        {
            try
            {
                Conexion.ConnectionString = getConnectionString2(SesionA.conn, SesionA.usuario, SesionA.pass);
                string Consulta = sql;

                /* Acceso a base de datos */
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandText = Consulta;
                Adapter.SelectCommand = Comando;

                DataTable tablaResultado = new DataTable();
                Adapter.Fill(tablaResultado);
                List<LIBRES_FAC_VE> obj_datos = new List<LIBRES_FAC_VE>();
                foreach (DataRow row in tablaResultado.Rows)
                {
                    LIBRES_FAC_VE objdatos = new LIBRES_FAC_VE();

                    if(tipo == "O")
                        objdatos.ORIGEN = row["ORIGEN"].ToString();
                    else if(tipo == "R")
                        objdatos.REMITENTE = row["REMITENTE"].ToString();
                    else if (tipo == "D")
                        objdatos.DESTINO = row["DESTINO"].ToString();
                    else
                        objdatos.DESTINATARIO = row["DESTINATARIO"].ToString();

                    obj_datos.Add(objdatos);
                }

                Conexion.Close();
                /**************************/

                return obj_datos;
            }
            catch (Exception x)
            { throw x; }
        }

        public LIBRES_FAC_VE obtenOrigen(conexiones_servidores csMatriz, string user, string pass, int idd)
        {
            try
            {
                Conexion.ConnectionString = getConnectionString2(csMatriz, user, pass);
                string Consulta =
                    string.Format(@"SELECT DOCTO_VE_ID,ORIGEN,RFC_REM,REMITENTE,DOMICILIO_REM,RECOGERA,DESTINO,DESTINATARIO,RFC_DES,DOMICILIO_DES,ENTREGARA,CUOTA,CAJA,DOCUMENTO,RECORRIDO, DIESEL_CAMION,DIESEL_THERMO,GASTO 
FROM LIBRES_FAC_VE WHERE DOCTO_VE_ID=" + idd + ";");

                /* Acceso a base de datos */
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandText = Consulta;
                Adapter.SelectCommand = Comando;

                DataTable tablaResultado = new DataTable();
                Adapter.Fill(tablaResultado);

                LIBRES_FAC_VE obj_datos = new LIBRES_FAC_VE();
                foreach (DataRow row in tablaResultado.Rows)
                {
                    obj_datos.DOCTO_VE_ID = Convert.ToInt32(row["DOCTO_VE_ID"].ToString());
                    obj_datos.ORIGEN = row["ORIGEN"].ToString();
                    obj_datos.RFC_REM = row["RFC_REM"].ToString();
                    obj_datos.REMITENTE = row["REMITENTE"].ToString();
                    obj_datos.DOMICILIO_REM = row["DOMICILIO_REM"].ToString();
                    obj_datos.RECOGERA = row["RECOGERA"].ToString();
                    obj_datos.DESTINO = row["DESTINO"].ToString();
                    obj_datos.DESTINATARIO = row["DESTINATARIO"].ToString();
                    obj_datos.RFC_DES = row["RFC_DES"].ToString();
                    obj_datos.DOMICILIO_DES = row["DOMICILIO_DES"].ToString();
                    obj_datos.ENTREGARA = row["ENTREGARA"].ToString();
                    obj_datos.CUOTA = row["CUOTA"].ToString();
                    obj_datos.CAJA = row["CAJA"].ToString();
                    obj_datos.DOCUMENTO = row["DOCUMENTO"].ToString();
                    obj_datos.RECORRIDO = row["RECORRIDO"].ToString();
                    obj_datos.DIESEL_CAMION = Convert.ToDecimal(row["DIESEL_CAMION"].ToString());
                    obj_datos.DIESEL_THERMO = Convert.ToDecimal(row["DIESEL_THERMO"].ToString());
                    obj_datos.GASTO = Convert.ToDecimal(row["GASTO"].ToString());
                }

                Conexion.Close();
                /**************************/
                return obj_datos;
            }
            catch (Exception x)
            { throw x; }
        }

        public LIBRES_FAC_VE InsertaFactura(Sesion Session, LIBRES_FAC_VE obj_insert)
        {
            try
            {
                Conexion = new FbConnection(getConnectionString2(Session.conn, Session.usuario, Session.pass));
                Conexion.Open();

                FbCommand cmd;
                String sql;

                sql = "insert into LIBRES_FAC_VE (DOCTO_VE_ID,ORIGEN,RFC_REM,REMITENTE,DOMICILIO_REM,RECOGERA,DESTINO,DESTINATARIO,RFC_DES,DOMICILIO_DES,ENTREGARA,CUOTA,CAJA,DOCUMENTO,RECORRIDO,DIESEL_CAMION,DIESEL_THERMO,GASTO) values(" + obj_insert.DOCTO_VE_ID + " ,'" + obj_insert.ORIGEN + "','" + obj_insert.RFC_REM + "','" + obj_insert.REMITENTE + "','" + obj_insert.DOMICILIO_REM + "','" + obj_insert.RECOGERA + "','" + obj_insert.DESTINO + "','" + obj_insert.DESTINATARIO + "','" + obj_insert.RFC_DES + "','" + obj_insert.DOMICILIO_DES + "','" + obj_insert.ENTREGARA + "','" + obj_insert.CUOTA + "','" + obj_insert.CAJA + "','" + obj_insert.DOCUMENTO + "'," + obj_insert.RECORRIDO + "," + obj_insert.DIESEL_CAMION + "," + obj_insert.DIESEL_THERMO + "," + obj_insert.GASTO + ")";

                cmd = new FbCommand(sql, Conexion);
                cmd.ExecuteNonQuery();

                Conexion.Close();

                LIBRES_FAC_VE obj_Art = new LIBRES_FAC_VE();
                return obj_Art = obtenOrigen(Session.conn, Session.usuario, Session.pass, obj_insert.DOCTO_VE_ID);

            }
            catch(Exception x)
            { throw x; }
        }

        public LIBRES_FAC_VE UpdateFactura(Sesion Session, LIBRES_FAC_VE obj_insert)
        {
            try
            {
                Conexion = new FbConnection(getConnectionString2(Session.conn, Session.usuario, Session.pass));
                Conexion.Open();

                FbCommand cmd;
                String sql;

                sql = "update LIBRES_FAC_VE set ORIGEN='" + obj_insert.ORIGEN + "',RFC_REM='" + obj_insert.RFC_REM + "',REMITENTE='" + obj_insert.REMITENTE + "',DOMICILIO_REM='" + obj_insert.DOMICILIO_REM + "',RECOGERA='" + obj_insert.RECOGERA + "',DESTINO='" + obj_insert.DESTINO + "',DESTINATARIO='" + obj_insert.DESTINATARIO + "',RFC_DES='" + obj_insert.RFC_DES + "',DOMICILIO_DES='" + obj_insert.DOMICILIO_DES + "',ENTREGARA='" + obj_insert.ENTREGARA + "',CUOTA='" + obj_insert.CUOTA + "',CAJA='" + obj_insert.CAJA + "',DOCUMENTO='" + obj_insert.DOCUMENTO + "',RECORRIDO=" + obj_insert.RECORRIDO + ",DIESEL_CAMION=" + obj_insert.DIESEL_CAMION + ",DIESEL_THERMO=" + obj_insert.DIESEL_THERMO + ",GASTO=" + obj_insert.GASTO + " where DOCTO_VE_ID=" + obj_insert.DOCTO_VE_ID + "";

                cmd = new FbCommand(sql, Conexion);
                cmd.ExecuteNonQuery();

                Conexion.Close();

                LIBRES_FAC_VE obj_Art = new LIBRES_FAC_VE();
                return obj_Art = obtenOrigen(Session.conn, Session.usuario, Session.pass, obj_insert.DOCTO_VE_ID);

            }
            catch (Exception x)
            { throw x; }
        }

        public void ActualizaDoctoVe(Sesion SessionUser, int idd)
        {
            try
            {
                Conexion.ConnectionString = getConnectionString2(SessionUser.conn, "SYSDBA", "ABSINTH");
                Conexion.Open();

                FbCommand cmd;
                String sql;

                sql = "UPDATE DOCTOS_VE SET FECHA_HORA_ULT_MODIF='NOW', USUARIO_ULT_MODIF='" + SessionUser.usuario + "' where DOCTO_VE_ID=" + idd + "";

                cmd = new FbCommand(sql, Conexion);
                cmd.ExecuteNonQuery();

                Conexion.Close();
            }
            catch(Exception x)
            { throw x; }
        }

    }
}
