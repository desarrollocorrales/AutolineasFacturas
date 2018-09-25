using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutolineasFacturas.Modelo;

namespace AutolineasFacturas.Utilerias
{
    public class Consultas
    {
        //Conexiones
        public conexiones_servidores obtenerMatriz()
        {
            try
            {
                using (ConexionEntities Ctx = new ConexionEntities())
                {
                    conexiones_servidores obj_cs = (from cs in Ctx.conexiones_servidores where cs.sucursal == "HEROICO" select cs).FirstOrDefault();

                    return obj_cs;
                }
            }
            catch (Exception x)
            { throw x; }
        }

        //Conexion a Autolineas
        public conexiones_servidores ObtenerConn()
        {
            try
            {
                using (ConexionEntities Ctx = new ConexionEntities())
                {
                    conexiones_servidores obj_cs = (from cs in Ctx.conexiones_servidores where cs.estatus == "0" && cs.sucursal == "AUTOLINEAS" select cs).FirstOrDefault();

                    return obj_cs;
                }
            }
            catch (Exception x)
            { throw x; }

        }
        public conexiones_servidores ObtenerConn(int idConn)
        {
            try
            {
                using (ConexionEntities Ctx = new ConexionEntities())
                {
                    conexiones_servidores obj_cs = (from cs in Ctx.conexiones_servidores where cs.id_conexion == idConn select cs).FirstOrDefault();

                    return obj_cs;
                }
            }
            catch (Exception x)
            { throw x; }

        }
    }
}
