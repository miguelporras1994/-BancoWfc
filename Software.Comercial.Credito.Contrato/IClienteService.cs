using System;
using Software.Comercial.Credito.Dominio1;
using System.Collections.Generic;
using System.ServiceModel;

namespace Software.Comercial.Credito.Contrato
{





    [ServiceContract]



    public interface IClienteService
    {


        [OperationContract]

        Cliente ObtenerCliente(string NumDocuemto);



        [OperationContract]


        IEnumerable<Cliente> ListaCliente();









    }
}