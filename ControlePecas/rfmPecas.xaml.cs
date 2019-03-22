using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControlePecas
{
    /// <summary>
    /// Lógica interna para rfmPecas.xaml
    /// </summary>
    public partial class rfmPecas : Window
    {
        public PecaDAO pecaDAO;
        public rfmPecas()
        {
            InitializeComponent();
            pecaDAO = new PecaDAO();
        }
        private void BtnCadFornecedor_Click(object sender, RoutedEventArgs e)
        {
            var frmFornecedor = new MainWindow();
            frmFornecedor.Show();
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            dgListar.ItemsSource = pecaDAO.Pecas;   
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Peca p = new Peca();
            p.Codigo = Convert.ToInt32(tbxCodigo.Text);
            p.Nome = tbxNome.Text;
            p.Grupo = cbxGrupo.Text;
            p.Data = Convert.ToDateTime(tbxData.Text);
            p.Fornecedor = cbxFornecedor.Text;
            p.UndMedida = tbxUndMedida.Text;
            p.QtdMinima = Convert.ToInt32(tbxQtdMin.Text);
            p.Estoque = Convert.ToInt32(tbxEstoque.Text);
            p.Valor = Convert.ToDecimal(tbxValor.Text);
            p.Local = tbxLocal.Text;
            p.Pratileira = tbxPratileira.Text;
            p.Caixa = tbxCaixa.Text;
            // p.Descricao = Convert.ToString( rtbDescricao.TextInput);
            //p.Aplicacao = rtbAplicacao.ToString;
            pecaDAO.Adicionar(p);
            MessageBox.Show("peça adicionada com sucesso");
        }
    }
}
