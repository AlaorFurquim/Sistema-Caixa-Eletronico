using SistemaContaBancaria.Domain;
using SistemaContaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContaBancaria.Services
{
    public class TransacaoServices
    {
        private readonly ContaRepository contasRepository;
        private readonly TransacaoRepository transacaoRepository;

        public TransacaoServices()
        {
            this.transacaoRepository = new TransacaoRepository();
            this.contasRepository = new ContaRepository();
        }

        public void CriarDeposito(Transacoes transacoes)
        {
            transacoes.Validar();
            var conta = this.contasRepository.Get(transacoes.IdConta);
            if (conta == null)
                throw new Exception("Informe uma conta valida");

            conta.Deposito(transacoes.Valor);

            this.transacaoRepository.Add(transacoes);
            this.contasRepository.UpdateSaldo(conta);

        }

        public void CriarSaque(Transacoes transacoes)
        {
            transacoes.Validar();
            var conta = this.contasRepository.Get(transacoes.IdConta);
            if (conta == null)
                throw new Exception("Informe uma conta valida");

            conta.Sacar(transacoes.Valor);

            this.transacaoRepository.Add(transacoes);
            this.contasRepository.UpdateSaldo(conta);
        }
    }
}
