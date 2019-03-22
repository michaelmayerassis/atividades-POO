using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePecas
{
    public class FornecedorDAO
    {
        public List<Fornecedor> Fornecedores;

        public FornecedorDAO()
        {
            Fornecedores = new List<Fornecedor>();
        }

        public void Adicionar(Fornecedor fornecedores)
        {
            Fornecedores.Add(fornecedores);
        }

        public List<Fornecedor> FindAll()
        {
            return Fornecedores;
        }
    }
}
