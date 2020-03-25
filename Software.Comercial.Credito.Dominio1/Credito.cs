using System;
using System.Runtime.Serialization;


namespace Software.Comercial.Credito.Dominio1
{
    [DataContract]
    class Credito
    {
        [DataMember]
        public int IdCredito { get; set; }
        [DataMember]
        public int TipoCredito { get; set; }
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public decimal Monto { get; set; }
        [DataMember]
        public DateTime FechaPago { get; set; }
        [DataMember]
        public decimal Tasa { get; set; }



    }

}
