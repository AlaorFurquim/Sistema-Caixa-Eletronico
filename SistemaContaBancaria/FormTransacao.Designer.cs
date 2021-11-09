
namespace SistemaContaBancaria
{
    partial class FormTransacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.bntDeposito = new System.Windows.Forms.Button();
            this.gvContas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntSaque = new System.Windows.Forms.Button();
            this.dbContas = new System.Windows.Forms.DataGridView();
            this.idConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbContas)).BeginInit();
            this.SuspendLayout();
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(88, 156);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 1;
            // 
            // bntDeposito
            // 
            this.bntDeposito.Location = new System.Drawing.Point(88, 222);
            this.bntDeposito.Name = "bntDeposito";
            this.bntDeposito.Size = new System.Drawing.Size(75, 23);
            this.bntDeposito.TabIndex = 2;
            this.bntDeposito.Text = "Deposito";
            this.bntDeposito.UseVisualStyleBackColor = true;
            this.bntDeposito.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvContas
            // 
            this.gvContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gvContas.FormattingEnabled = true;
            this.gvContas.Location = new System.Drawing.Point(88, 102);
            this.gvContas.Name = "gvContas";
            this.gvContas.Size = new System.Drawing.Size(176, 21);
            this.gvContas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transações";
            // 
            // bntSaque
            // 
            this.bntSaque.Location = new System.Drawing.Point(189, 222);
            this.bntSaque.Name = "bntSaque";
            this.bntSaque.Size = new System.Drawing.Size(75, 23);
            this.bntSaque.TabIndex = 7;
            this.bntSaque.Text = "Saque";
            this.bntSaque.UseVisualStyleBackColor = true;
            this.bntSaque.Click += new System.EventHandler(this.bntSaque_Click);
            // 
            // dbContas
            // 
            this.dbContas.AllowUserToAddRows = false;
            this.dbContas.AllowUserToDeleteRows = false;
            this.dbContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConta,
            this.nome,
            this.cpf,
            this.numero,
            this.saldo});
            this.dbContas.Location = new System.Drawing.Point(281, 84);
            this.dbContas.Name = "dbContas";
            this.dbContas.Size = new System.Drawing.Size(434, 116);
            this.dbContas.TabIndex = 8;
            // 
            // idConta
            // 
            this.idConta.DataPropertyName = "idConta";
            this.idConta.HeaderText = "ID";
            this.idConta.Name = "idConta";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            // 
            // FormTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 320);
            this.Controls.Add(this.dbContas);
            this.Controls.Add(this.bntSaque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvContas);
            this.Controls.Add(this.bntDeposito);
            this.Controls.Add(this.textSaldo);
            this.Name = "FormTransacao";
            this.Text = "Transacao";
            this.Shown += new System.EventHandler(this.FormTransacao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dbContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Button bntDeposito;
        private System.Windows.Forms.ComboBox gvContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntSaque;
        private System.Windows.Forms.DataGridView dbContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
    }
}