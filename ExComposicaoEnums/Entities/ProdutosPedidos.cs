using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicaoEnums
{
    class ProdutosPedidos
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ProdutosPedidos()
        {
        }

        public ProdutosPedidos(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
