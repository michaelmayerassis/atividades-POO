using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Caixa
    {
        public decimal Saldos = 0;
        public decimal Vendas = 3.50m;
        public decimal Dinheiro;
        public decimal Quantia;
        public decimal Saldototal = 0;

        public decimal Saldo(decimal SaldoCaixas)
        {
            Saldos = SaldoCaixas;

            return SaldoCaixas;
        }

        public decimal Venda(decimal Vender)
        {
            Saldos = Saldos + Vender;

            return Saldos;
        }
        public decimal Din(decimal dimdim)
        {
            Dinheiro = dimdim;

            return Dinheiro;
        }

        public decimal Quantidade(decimal quantias)
        {
            Quantia = quantias;


            return Quantia;
        }
        public decimal Total(decimal totall)
        {
            Saldos = totall + Saldos;

            return totall;
        }

    }
}
