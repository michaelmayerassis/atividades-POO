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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlePecas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSaidaPeca_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCadFornecedor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCadPeca_Click(object sender, RoutedEventArgs e)
        {
            var frmPecas = new rfmPecas();
            frmPecas.Show();
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
