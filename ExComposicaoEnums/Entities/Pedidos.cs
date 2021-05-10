using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExComposicaoEnums.Enums;

namespace ExComposicaoEnums
{
    class Pedido
    {
        public DateTime MomentoDoPedido { get; set; }
        public EStatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ProdutosPedidos> Produtos { get; set; } = new List<ProdutosPedidos>();

        public Pedido()
        {
        }

        public Pedido(DateTime momentoDoPedido, EStatusPedido status, Cliente cliente)
        {
            MomentoDoPedido = momentoDoPedido;
            Status = status;
            Cliente = cliente;
        }

        public void AddProduto(ProdutosPedidos produtos)
        {
            Produtos.Add(produtos);
        }
        public void RemoveProduto(ProdutosPedidos produtos)
        {
            Produtos.Remove(produtos);
        }

        public double Total()
        {
            double sum = 0;
            foreach (ProdutosPedidos produtos in Produtos)
            {
                sum = sum + produtos.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido : " + MomentoDoPedido.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("");
            sb.AppendLine("Status do pedido : " + Status);
            sb.AppendLine("");
            sb.AppendLine("Dados do cliente: " + Cliente);
            sb.AppendLine("");
            sb.AppendLine("Produtos:");
            sb.AppendLine("");
            foreach (ProdutosPedidos item in Produtos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Valor total : $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
