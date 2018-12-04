using System;
using System.Runtime.Serialization;


namespace SOAP
{

            [DataContract]


    public class Cliente
    {
        [DataMember]
        public int id_cliente { get; set; }
        [DataMember]
        public string Apellidopaterno { get; set; }
        [DataMember]
        public string Apellidomaterno { get; set; }
        [DataMember]
        public string Tipodocumento { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Codigopostal { get; set; }
        [DataMember]
        public string Estadocivil { get; set; }


    }
}
