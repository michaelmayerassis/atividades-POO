using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes
{
   public class FilmeDAO
    {
       
        public List<Filme> Filmes;

        public FilmeDAO()
        {
            Filmes = new List<Filme>();
        }

        public void Adicionar(Filme contato)
        {
            Filmes.Add(contato);
        }

        public List<Filme> FindAll()
        {
            return Filmes;
        }

    }
}
