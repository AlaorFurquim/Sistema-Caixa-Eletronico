using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContaBancaria.Repository
{
    public class RepositoryBase
    {
        public string GetStrConnection { get => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; }
        public SqlConnection CreateConnection()
        {
            var conexao = new SqlConnection(GetStrConnection);
            conexao.Open();

            return conexao;
        }
    }
}
