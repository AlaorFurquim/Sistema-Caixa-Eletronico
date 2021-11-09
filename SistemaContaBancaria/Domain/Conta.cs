using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContaBancaria.Domain
{
    public class Conta
    {
        public Conta(string nome, string cpf, string numero)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Numero = numero;
        }
        public Conta(IDataReader dr)
        {
            IdConta = (int)dr["idConta"];
            Nome = dr["nome"].ToString();
            CPF = dr["cpf"].ToString();
            Numero = dr["numero"].ToString();
            Saldo = (decimal)dr["saldo"];

        }


        public int IdConta { get; set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }

       public void Deposito(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor para de deposito deve ser maior que ZERO!");
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor do saque não pode ser menor ou igual a ZERO");
            if (valor > Saldo)
                throw new Exception("Saldo insuficente");
            Saldo -= valor;
        }

        public void ValidarConta()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("O campo Nome deve ser preenchido");
            if (string.IsNullOrEmpty(Numero))
                throw new Exception("O campo numero deve ser preenchido");
        }

        

        public override string ToString()
        {
            return $"Conta {Numero}";
        }


    }

   

}
