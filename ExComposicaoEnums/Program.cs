using System;
using ExComposicaoEnums.Enums;
using System.Globalization;

namespace ExComposicaoEnums
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira os dados do cliente abaixo.");
            Console.WriteLine("");
            Console.Write("Nome :");
            string nome = Console.ReadLine();
            Console.Write("Email :");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/YYYY) :");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Qual número do status atual do seu pedido : ");
            Console.WriteLine("1 - Pendente");
            Console.WriteLine("2 - Processando");
            Console.WriteLine("3 - Enviado");
            Console.Write("Responda com o número correspondente : ");
            EStatusPedido status = (EStatusPedido)int.Parse(Console.ReadLine());

            var cliente = new Cliente(nome, email, dataNascimento);
            var pedido = new Pedido(DateTime.Now, status, cliente);


            Console.Write("Quantos produtos possui em seu pedido : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Insira os dados do " + i + "° Produto");

                Console.Write("Nome do produto :");
                string nomeProduto = Console.ReadLine();

                Console.Write("Valor do produto :");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                

                Console.Write("Quantos produtos :");
                int quantidade = int.Parse(Console.ReadLine());


                var ProdutosPedidos = new ProdutosPedidos(quantidade, valor, (new Produto (nomeProduto,valor)));

                pedido.AddProduto(ProdutosPedidos);

            }

            Console.WriteLine("");
            Console.WriteLine("RESUMO DO PEDIDO !!");
            Console.WriteLine("");
            Console.WriteLine(pedido);

        }

    }
}
