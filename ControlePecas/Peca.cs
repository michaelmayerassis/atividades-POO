using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePecas
{
    public class Peca
    {
        public int IdPeca { get; set; }
        public string Nome { get; set; }
        public string Grupo { get; set; }
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public string UndMedida { get; set; }
        public decimal QtdMinima { get; set; }
        public decimal Estoque { get; set; }
        public decimal Valor { get; set; }
        public string Local { get; set; }
        public string Pratileira { get; set; }
        public string Caixa { get; set; }
        public string Descricao { get; set; }
        public string Aplicacao { get; set; }
        public string Fornecedor { get; set; }
    }
}
