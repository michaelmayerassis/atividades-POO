using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmes
{
    public partial class Form1 : Form
    {
        public FilmeDAO filmeDao;
        public Form1()
        {
            InitializeComponent();
            filmeDao = new FilmeDAO();
            dataGridView1.AutoSize = true;
            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns.Add("anolanc", "AnoLanc");
            dataGridView1.Columns.Add("nota", "Nota");
            dataGridView1.Columns.Add("descricao", "Descricao");
        }

        public void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";                      
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (Filme f in filmeDao.FindAll())
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow linha = dataGridView1.Rows[index];
                linha.Cells["nome"].Value = f.Nome;
                linha.Cells["anolanc"].Value = f.AnoLanc;
                linha.Cells["nota"].Value = f.Nota;
                linha.Cells["descricao"].Value = f.Descricao;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Filme f = new Filme();
            f.Nome = textBox1.Text;
            f.AnoLanc = Convert.ToDateTime(textBox2.Text);
            f.Nota = Convert.ToDecimal(textBox3.Text);
            f.Descricao = richTextBox1.Text;
            filmeDao.Adicionar(f);
            this.Limpar();
            MessageBox.Show("filme adicionado com sucesso");
        }
    }
}
