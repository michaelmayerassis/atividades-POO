using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePecas
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public int cnpj { get; set; }
        public DateTime Data { get; set; }
        public string InscEstadual { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Cep { get; set; }
        public string Endeeco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set; }
    }
}
