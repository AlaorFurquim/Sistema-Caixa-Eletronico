using SistemaContaBancaria.Domain;
using SistemaContaBancaria.Repository;
using SistemaContaBancaria.Services;
using System;

using System.Windows.Forms;

namespace SistemaContaBancaria
{
    public partial class FormTransacao : Form
    {
        public FormTransacao()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var conta = (Conta)gvContas.SelectedItem;
                if (conta == null)
                    throw new Exception("Selecione uma conta!");
                if (!decimal.TryParse(textSaldo.Text, out decimal valorDeposito))
                    throw new Exception("O campo valor deve ser preenchido");

                var transacao = new Transacoes(valorDeposito, conta.IdConta);

                var transacaoServices = new TransacaoServices();
                transacaoServices.CriarDeposito(transacao);

                MessageBox.Show("Deposito efetuado com sucesso");

                gvContas.Refresh();

                CarregarContas();
            }
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void FormTransacao_Shown(object sender, EventArgs e)
        {
            var contaRepository = new ContaRepository();
            gvContas.DataSource = contaRepository.GetContas();
            gvContas.Refresh();

            CarregarContas();
        }

       

        private void CarregarContas()
        {
            dbContas.DataSource = new ContaRepository().GetContas();
            dbContas.Refresh();
        }

        private void bntSaque_Click(object sender, EventArgs e)
        {
            try
            {
                var conta = (Conta)gvContas.SelectedItem;
                if (conta == null)
                    throw new Exception("Selecione uma conta!");
                if (!decimal.TryParse(textSaldo.Text, out decimal valorDeposito))
                    throw new Exception("O campo valor deve ser preenchido");

                var transacao = new Transacoes(valorDeposito, conta.IdConta);

                var transacaoServices = new TransacaoServices();
                transacaoServices.CriarSaque(transacao);

                MessageBox.Show("Saque efetuado com sucesso");

                gvContas.Refresh();

                CarregarContas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
