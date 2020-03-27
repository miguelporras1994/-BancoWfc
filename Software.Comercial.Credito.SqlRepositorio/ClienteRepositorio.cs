using Software.Comercial.Credito.Dominio1;

using System.Collections.Generic;
using Software.Comercial.Credito.ContratoRepositorio;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Software.Comercial.Credito.SqlRepositorio
{
    public class ClienteRepositorio :  IClienteRepositorio  
    {

         public Cliente ObtenerCliente(string NumDocuemto)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("pNumeroDocumento",NumDocuemto);


                var cliente = conexion.QuerySingle<Cliente>("dbo.sp_cliente_obtener", param: parametros, commandType: CommandType.StoredProcedure);

                return cliente;






             
            }

                 
        }





        public IEnumerable<Cliente> ListaCliente()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();



                var cliente = conexion.Query<Cliente>("dbo.sp_cliente_listar", commandType: CommandType.StoredProcedure);

                return cliente;
            }

        }

    }
}
