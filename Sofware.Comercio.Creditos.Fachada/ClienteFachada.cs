using System;
using System.Collections.Generic;
using Software.Comercial.Credito.Dominio1;


namespace Sofware.Comercio.Creditos.Fachada
{
    public class ClienteFachada :IDisposable
    {

        public Cliente ObtenerCliente(string NumDocuemto)
        {


            return null;

        }





        public IEnumerable<Cliente> ListaCliente()
        {


            return null;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
