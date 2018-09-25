using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutolineasFacturas.Utilerias
{
    public class Datos
    {
    }

    public class BuscarDatos
    {
        public string folio { get; set; }
        public int docto_ve_id { get; set; }
        public string cliente { get; set; }
        public DateTime fecha { get; set; }
        public string vendedor { get; set; }
        public string almacen { get; set; }
    }

    public class LIBRES_FAC_VE
    {
        public int DOCTO_VE_ID { get; set; }
        public string ORIGEN { get; set; } 
        public string RFC_REM { get; set; }
        public string REMITENTE { get; set; } 
        public string DOMICILIO_REM { get; set; } 
        public string RECOGERA { get; set; } 
        public string DESTINO { get; set; } 
        public string DESTINATARIO { get; set; } 
        public string RFC_DES { get; set; } 
        public string DOMICILIO_DES { get; set; } 
        public string ENTREGARA { get; set; } 
        public string CUOTA { get; set; } 
        public string CAJA { get; set; }
        public string DOCUMENTO { get; set; }
        public string RECORRIDO { get; set; }
        public decimal DIESEL_CAMION { get; set; } 
        public decimal DIESEL_THERMO { get; set; }
        public decimal GASTO { get; set; }
    }

}
