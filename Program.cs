using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa conta = new Caixa();
            Produto produto = new Produto();
            int op;
            char s = 's';
            do
            {

                Console.WriteLine("***** Menu Caixa **********");
                Console.WriteLine("-----------------");
                Console.WriteLine("Saldo Caixa R${0} Reais", conta.Saldos);
                Console.WriteLine("-----------------");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("-----------------");
                Console.WriteLine("1 - Abri Caixa");
                Console.WriteLine("-----------------");
                Console.WriteLine("2 - Realizar Venda");
                Console.WriteLine("-----------------");
                Console.WriteLine("3 - Cadastrar Produtos");
                Console.WriteLine("-----------------");
                Console.WriteLine();


                Console.WriteLine("Entre com a Opçao");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0:

                        Console.WriteLine("Ate Logo"); break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("***********Produtos Cadastrados*************");
                        Console.WriteLine("Produto: {0} | Valor: R${1} Reais", produto.nome, produto.Valor);
                        Console.WriteLine();
                        Console.WriteLine("Deseja Comprar Produto: {0} | Valor: R${1} Reais ? s / n", produto.nome, produto.Valor);
                        s = Convert.ToChar(Console.ReadLine());


                        if ('s' == s)
                        {
                            Console.Clear();
                            Console.WriteLine("Quantidade de Produto");
                            conta.Quantidade(Convert.ToInt32(Console.ReadLine()));
                            produto.Valor = produto.Valor * conta.Quantia;




                            conta.Dinheiro = conta.Dinheiro - produto.Valor;
                            Console.WriteLine();
                            Console.WriteLine("Sua Venda ficou :{0}", produto.Valor);
                            Console.WriteLine();
                            Console.WriteLine("Entre com Dinheiro");
                            conta.Din(Convert.ToDecimal(Console.ReadLine()));
                            conta.Dinheiro = conta.Dinheiro - produto.Valor;



                            Console.WriteLine();

                            Console.WriteLine("Seu Troco é {0}", conta.Dinheiro);
                            Console.WriteLine();
                            Console.WriteLine("Venda Realizada com sucesso");
                            Console.ReadKey();
                            Console.Clear();

                            conta.Saldos = conta.Saldos + produto.Valor;
                            produto.Valor = produto.Valor * conta.Quantia;

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ate Logo");


                        }; break;

                        Console.Clear();

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Entre com Valor para Abrir o Caixa");
                        conta.Saldos = conta.Saldos + conta.Saldos;

                        conta.Saldo(Convert.ToDecimal(Console.ReadLine()));

                        break;

                    case 3:
                        Console.Clear();

                        //Declaração da lista
                        List<Produto> lista = new List<Produto>();

                        string opcao = "1";

                        while (opcao == "1")
                        {
                            Console.WriteLine("Digite um nome para inserir na lista:");
                            produto.nome = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Digite o Valor do Produto:");
                            produto.Valor = Convert.ToDecimal(Console.ReadLine());
                            Console.Clear();
                            //Adiciona o item à lista
                            lista.Add(produto);
                            // lista.Add(valor);
                            Console.WriteLine("Deseja inserir outro nome e preço? 1-SIM | 2-NÃO");
                            opcao = Console.ReadLine();
                            Console.Clear();
                        }
                        //Ordena a lista 
                        lista.Sort();
                        Console.WriteLine("Lista Cadastada");
                        Console.WriteLine();
                        Console.WriteLine("A lista tem 1 iten:");
                        Console.WriteLine();
                        //Imprime cada item da lista
                        lista.ForEach(i => Console.WriteLine("Produto: " + i.nome));
                        Console.WriteLine("-----------------");
                        lista.ForEach(i => Console.WriteLine("Valor R$ " + i.Valor + " Reais"));

                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (op != 0);
            Console.ReadKey();
        }
    }
}
