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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCadastroConta();
            form.ShowDialog();
        }

        private void transaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTransacao();
            form.ShowDialog();
        }
    }
}
