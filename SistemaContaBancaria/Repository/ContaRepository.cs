using SistemaContaBancaria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContaBancaria.Repository
{
    public class ContaRepository : RepositoryBase
    {
        public List<Conta> GetContas()
        {
            using (var conexao = CreateConnection())
            {
                using (var cmd = new SqlCommand(" SELECT * FROM Contas", conexao))
                {
                    var dr = cmd.ExecuteReader();
                    var contas = new List<Conta>();
                    while (dr.Read())
                    {
                        contas.Add(new Conta(dr));
                    }
                    return contas;
                }
            }
        }

        public Conta Get(int idConta)
        {
            using (var conexao = CreateConnection())
            {
                using (var cmd = new SqlCommand("SELECT * FROM Contas WHERE idConta = @idConta", conexao))
                {
                    cmd.Parameters.AddWithValue("@idConta", idConta);
                    var dr = cmd.ExecuteReader();

                    if (dr.Read())
                        return new Conta(dr);
                }
            }
            return null;
        }
        
        public void Add(Conta conta)
        {
            using (var conexao = CreateConnection())
            {
                using (var cmd = new SqlCommand("INSERT INTO Contas(nome, cpf,numero,saldo) VALUES (@nome,@cpf,@numero,@saldo)", conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", conta.Nome);
                    cmd.Parameters.AddWithValue("@cpf", conta.CPF);
                    cmd.Parameters.AddWithValue("@numero", conta.Numero);
                    cmd.Parameters.AddWithValue("@saldo", conta.Saldo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSaldo(Conta conta)
        {
            using (var conexao = CreateConnection())
            {
                using (var cmd = new SqlCommand("UPDATE Contas SET saldo = @saldo WHERE idConta = @idConta", conexao))
                {
                    cmd.Parameters.AddWithValue("@idConta", conta.IdConta);
                    cmd.Parameters.AddWithValue("@saldo", conta.Saldo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int idConta)
        {
            using (var conexao = CreateConnection())
            {
                using(var cmd = new SqlCommand("DELETE Contas WHERE idConta = @idConta", conexao))
                {
                    cmd.Parameters.AddWithValue("@idConta", idConta);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
