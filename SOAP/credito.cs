using System;
using System.Runtime.Serialization;

namespace SOAP
{
    [DataContract]
    public class Credito
    {
        [DataMember]
        public int Idcredito { get; set; }
        [DataMember]
        public int Tipodecredito { get; set; }
        [DataMember]
        public int Idcliente { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public Decimal Monto { get; set; }
        [DataMember]
        public DateTime Fechadepago { get; set; }
        [DataMember]
        public Decimal tasa { get; set; }
        [DataMember]
        public int comiciones;
    }
}