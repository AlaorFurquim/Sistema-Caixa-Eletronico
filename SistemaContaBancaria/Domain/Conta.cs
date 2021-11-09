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
       public Conta(string nome, string cpf,string numero)
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

        internal void ValidarCpf()
        {
            throw new NotImplementedException();
        }

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

        public bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public override string ToString()
        {
            return $"Conta {Numero}";
        }


    }

   

}
