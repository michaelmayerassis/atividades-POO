using ControleDeTimes.DAO;
using ControleDeTimes.Models;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace ControleDeTimes
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Time time;
        private OpenFileDialog openFileDialog;
        private readonly TimeDAO timedao;
        public MainWindow()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            time = new Time();
            timedao = new TimeDAO();
            dgListar.ItemsSource = timedao.ListarTime();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Principal":
                    fechar.Foreground = Brushes.White;
                    if (ButtonCloseMenu.Visibility == Visibility.Visible)
                    {
                        ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                    break;

                case "cadastrar":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    if (Campovazio())
                    {
                        MessageBox.Show("preencha os campos para prosseguir!");
                    }
                    else
                    {
                        CadPecas();
                        timedao.Cadastrartime(time);
                        Limpar();
                        dgListar.ItemsSource = null;
                        dgListar.ItemsSource = timedao.ListarTime();
                        MessageBox.Show("Cadastrado");
                    }
                    break;

                case "alterar":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    if (Campovazio())
                    {
                        MessageBox.Show("preencha os campos para prosseguir!");
                    }
                    else
                    {

                        if (MessageBox.Show("Deseja realmente alterar o time ?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            CadPecas();
                            timedao.AlterarTime(time);
                            Limpar();
                            dgListar.ItemsSource = null;
                            dgListar.ItemsSource = timedao.ListarTime();
                            MessageBox.Show("Alterado");
                        }
                    }
                    break;

                case "excluir":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    if (MessageBox.Show("Deseja realmente alterar o time ?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        time = dgListar.SelectedItem as Time;
                        timedao.Excluirtime(time);
                        dgListar.ItemsSource = null;
                        dgListar.ItemsSource = timedao.ListarTime();
                        MessageBox.Show("Excluido");
                    }
                    break;
            }
        }

        private void CadPecas()
        {
            time.nome = txtNome.Text;
            time.qtdTitulo = Convert.ToInt32(txtTitulo.Text);
        }

        private void BtnFecharAplicacao_MouseLeave(object sender, MouseEventArgs e)
        {
            btnFecharAplicacao.Background = Brushes.Transparent;
        }

        private void BtnFecharAplicacao_MouseEnter(object sender, MouseEventArgs e)
        {
            btnFecharAplicacao.Background = Brushes.Red;
        }

        private void BtnFecharAplicacao_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo...", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "CloseApplication":
                    if (MessageBox.Show("Deseja realmente sair?", "Saindo...", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        Application.Current.Shutdown();
                    break;
            }
        }

        private void DgListar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            time = dgListar.SelectedItem as Time;
            txtNome.Text = time.nome;
            txtTitulo.Text = time.qtdTitulo.ToString();
            //id = time.id;
        }

        private void Limpar()
        {
            txtTitulo.Text = "";
            txtNome.Text = "";
        }

        private bool Campovazio()
        {
            if ((txtNome.Text == "") && (txtTitulo.Text == ""))
            {
                return true;
            }
            return false;
        }

        private void DgListar_AutoGeneratedColumns(object sender, EventArgs e)
        {
            dgListar.Columns[0].Header = "Nome do Time";
            dgListar.Columns[1].Header = "Titulos do Time";
            dgListar.Columns[2].Visibility = Visibility.Collapsed;
            dgListar.Columns[0].Width = 700;
            dgListar.Columns[1].Width = 388;
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Principal":
                    fechar.Foreground = Brushes.White;
                    if (ButtonCloseMenu.Visibility == Visibility.Visible)
                    {
                        ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    }
                    break;

                case "cadastrar":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    if (Campovazio())
                    {
                        MessageBox.Show("preencha os campos para prosseguir!");
                    }
                    else
                    {
                        CadPecas();
                        timedao.Cadastrartime(time);
                        Limpar();
                        dgListar.ItemsSource = null;
                        dgListar.ItemsSource = timedao.ListarTime();
                        MessageBox.Show("Cadastrado");
                    }
                    break;

                case "alterar":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    if (Campovazio())
                    {
                        MessageBox.Show("preencha os campos para prosseguir!");
                    }
                    else
                    {

                        if (MessageBox.Show("Deseja realmente alterar o time ?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            CadPecas();
                            timedao.AlterarTime(time);
                            Limpar();
                            dgListar.ItemsSource = null;
                            dgListar.ItemsSource = timedao.ListarTime();
                            MessageBox.Show("Alterado");
                        }
                    }
                    break;

                case "excluir":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    if (MessageBox.Show("Deseja realmente alterar o time ?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        time = dgListar.SelectedItem as Time;
                        timedao.Excluirtime(time);
                        dgListar.ItemsSource = null;
                        dgListar.ItemsSource = timedao.ListarTime();
                        MessageBox.Show("Excluido");
                    }
                    break;
            }
        }

        private void ListView_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "salvar":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Salvar Arquivo Texto";
                    saveFileDialog.Filter = "Text File|.txt";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.DefaultExt = ".txt";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == true)
                    {
                        FileStream stream1 = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                        StreamWriter writer = new StreamWriter(stream1);
                        writer.Write(txtArquivo.Text);
                        writer.Close();
                        stream1.Close();
                        MessageBox.Show("salvo");
                    }
                    break;

                case "abrir":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {                      
                            txtArquivo.Text = "";
                            Stream stream = File.Open(openFileDialog.FileName, FileMode.Open);
                            StreamReader reader = new StreamReader(stream);
                            string linha;
                            while ((linha = reader.ReadLine()) != null)
                            {
                                txtArquivo.AppendText(linha);
                                txtArquivo.AppendText(Environment.NewLine);
                            }
                            reader.Close();
                            stream.Close();                        
                    }
                    break;
            }
        }

        private void ListView_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "salvar":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Salvar Arquivo Texto";
                    saveFileDialog.Filter = "Text File|.txt";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.DefaultExt = ".txt";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == true)
                    {
                        FileStream stream1 = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                        StreamWriter writer = new StreamWriter(stream1);
                        writer.Write(txtArquivo.Text);
                        writer.Close();
                        stream1.Close();
                        MessageBox.Show("salvo");
                    }
                    break;

                case "abrir":
                    ButtonCloseMenu.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        txtArquivo.Text = "";
                        Stream stream = File.Open(openFileDialog.FileName, FileMode.Open);
                        StreamReader reader = new StreamReader(stream);
                        string linha;
                        while ((linha = reader.ReadLine()) != null)
                        {
                            txtArquivo.AppendText(linha);
                            txtArquivo.AppendText(Environment.NewLine);
                        }
                        reader.Close();
                        stream.Close();
                    }
                    break;
            }
        }
    }
}
