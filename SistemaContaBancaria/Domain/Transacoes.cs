using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContaBancaria.Domain
{
    public class Transacoes
    {
        public Transacoes(decimal valor, int idConta)
        {
            this.Valor = valor;
            this.IdConta = idConta;
        }

        public int IdTrancacoes { get; set; }
        public decimal Valor { get; set; }
        public int IdConta { get; set; }

        public void Validar()
        {
            if (Valor <= 0)
                throw new Exception("O valor não pode ser menor ou igual a 0!");
        }
    }
}
