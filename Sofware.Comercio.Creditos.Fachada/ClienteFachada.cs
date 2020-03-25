using System;
using System.Collections.Generic;
using Software.Comercial.Credito.Dominio1;
using Software.Comercial.Credito.ContratoRepositorio;
using Software.Comercial.Credito.SqlRepositorio;

namespace Sofware.Comercio.Creditos.Fachada
{
    public class ClienteFachada :IDisposable
    {

        public Cliente ObtenerCliente(string NumDocuemto)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();

              return instancia.ObtenerCliente(NumDocuemto);
        }





        public IEnumerable<Cliente> ListaCliente()
        {
            IClienteRepositorio instancia = new ClienteRepositorio();

            return instancia.ListaCliente();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
