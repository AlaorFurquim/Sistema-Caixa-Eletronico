using SistemaContaBancaria.Domain;
using SistemaContaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContaBancaria
{
    public partial class FormCadastroConta : Form
    {
        public FormCadastroConta()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var contaRepository = new ContaRepository();
                var conta = new Conta(textName.Text, textCPF.Text, textNumero.Text);

                conta.ValidarConta();
                contaRepository.Add(conta);
                conta.ValidarCpf();

                CarregarContas();


                MessageBox.Show("Operação realizada com sucesso", "Mensagem do sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarContas()
        {
            gvContas.DataSource = new ContaRepository().GetContas();
            gvContas.Refresh();
        }

        private void LimparForm()
        {
            textName.Text = "";
            textCPF.Text = "";
            textNumero.Text = "";
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            var rows = gvContas.SelectedRows;
            if(rows.Count == 0)
            {
                MessageBox.Show("Selecione uma conta para editar", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(MessageBox.Show("Excluir a conta?", "Mensagem do Sistema", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var row = rows[0];
                var idConta = (int)row.Cells["idConta"].Value;

                var contaRepository = new ContaRepository();
                contaRepository.Delete(idConta);

                CarregarContas();

                MessageBox.Show("Conta excluída com sucesso","Mensagem do Sistema");
            }


        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            CarregarContas();
        }

        private void FormCadastroConta_Shown_1(object sender, EventArgs e)
        {
            CarregarContas();
            LimparForm();
        }
    }
}
