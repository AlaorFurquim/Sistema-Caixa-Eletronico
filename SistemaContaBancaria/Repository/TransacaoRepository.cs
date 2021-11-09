using SistemaContaBancaria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContaBancaria.Repository
{
    public class TransacaoRepository : RepositoryBase
    {
        public void Add(Transacoes transacoes)
        {
            using(var conexao = CreateConnection())
            {
                using (var cmd = new SqlCommand("INSERT INTO Transacaos (valor, idConta) VALUES(@valor,@idConta)", conexao))
                {
                    cmd.Parameters.AddWithValue("@valor", transacoes.Valor);
                    cmd.Parameters.AddWithValue("@idConta", transacoes.IdConta);

                    cmd.ExecuteNonQuery();
                }

                
            }
        }
    }
}
