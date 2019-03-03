using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleBar
{
    public partial class Form1 : Form
    {
        Conta conta = new Conta();
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valorUnitario = Convert.ToDecimal(tbxValorUnitario.Text);
            int qtd = Convert.ToInt32(tbxQuantidade.Text);
            int qtdPessoa = Convert.ToInt32(tbxQtdPessoa.Text);
            if (checkBox1.Checked == true)
            {
                conta.Porcentagem(qtd, valorUnitario);
                lblMostrarTotal.Text = Convert.ToString(conta.saldo);
                lblPrecoPessoa.Text = Convert.ToString(conta.saldo / qtdPessoa);
            }
            conta.Adicionar(qtd, valorUnitario);
            lblMostrarTotal.Text = Convert.ToString(conta.saldo);
            lblPrecoPessoa.Text = Convert.ToString(conta.saldo/qtdPessoa);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            decimal valorUnitario = Convert.ToDecimal(tbxValorUnitario.Text);
            int qtd = Convert.ToInt32(tbxQuantidade.Text);
            int qtdPessoa = Convert.ToInt32(tbxQtdPessoa.Text);
            conta.Porcentagem(qtd, valorUnitario);
            lblMostrarTotal.Text = Convert.ToString(conta.saldo);
            lblPrecoPessoa.Text = Convert.ToString(conta.saldo / qtdPessoa);
        }
    }
}
