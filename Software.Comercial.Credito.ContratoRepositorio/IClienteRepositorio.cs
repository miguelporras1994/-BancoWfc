using System;
using System.Collections.Generic;
using Software.Comercial.Credito.Dominio1;

namespace Software.Comercial.Credito.ContratoRepositorio
{
     public  interface IClienteRepositorio
    {

     Cliente ObtenerCliente(string NumDocuemto);





        IEnumerable<Cliente> ListaCliente();
       


    }
}
