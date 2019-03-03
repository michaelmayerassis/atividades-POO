using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar
{
    class Conta
    {
        public decimal saldo;
        public void Adicionar(int quantidade, decimal valor)
        {
            saldo += (valor*quantidade);
        }
        public void Porcentagem(int quantidade, decimal valor)
        {
            saldo += (valor * quantidade / 10);
        }
    }
}
