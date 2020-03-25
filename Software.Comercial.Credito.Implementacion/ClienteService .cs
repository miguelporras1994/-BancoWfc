using System;
using System.Collections.Generic;
using Software.Comercial.Credito.Dominio1;
using Software.Comercial.Credito.Contrato;
using Sofware.Comercio.Creditos.Fachada;
using System.Runtime.Serialization;





namespace Software.Comercial.Credito.Implementacion
{
    public class ClienteService : IClienteService
    {


        public Cliente ObtenerCliente(string NumDocuemto)
        {

            using (ClienteFachada Instancia = new ClienteFachada())
            {
                return Instancia.ObtenerCliente(NumDocuemto);
            }

            
        }





        public IEnumerable<Cliente> ListaCliente()
        {


            using (ClienteFachada Instancia = new ClienteFachada())
            {
                return Instancia.ListaCliente();
            }
        }




    }
}