using System;
using System.Runtime.Serialization;



namespace Software.Comercial.Credito.Dominio1
{



    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; }

        [DataMember]
        public string Nombre { get; set; }
        [DataMember]

        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno{ get; set; }
        [DataMember]
        public string TipoDocumento { get; set; }
        [DataMember]
        public string NumDocumento { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string CodigoPostal { get; set; }
        [DataMember]
        public string EstadoCivil { get; set; }





    }
}
  