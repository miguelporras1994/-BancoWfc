using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Software.Comercial.Credito.SqlRepositorio
{
    class ConexionRepositorio
    {

        public static string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["CreditosDb"].ToString();
        }
    }
}
