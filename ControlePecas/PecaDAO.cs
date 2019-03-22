using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePecas
{
    public class PecaDAO
    {
        public List<Peca> Pecas;

        public PecaDAO()
        {
            Pecas = new List<Peca>();
        }

        public void Adicionar(Peca pecas)
        {
            Pecas.Add(pecas);
        }

        public List<Peca> FindAll()
        {
            return Pecas;
        }
    }
}
