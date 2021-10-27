using RestauranteUP.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteUP.Modelos
{
    public class Pedido : Cardapio
    {
        public Pedido (uint idPedido, Produto produto, int qtdProduto)
        {
            IdPedido = idPedido;
            Produto = produto;
            QtdProduto = qtdProduto;
        }
        public Produto Produto { get; set; }
        public int QtdProduto { get; set; }
        public uint IdPedido { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime DataHoraFinal { get; set; }
        public string Observacao { get; set; }
        public decimal TaxaEntrega { get; set; }
        public List<Produto> ListaProdutos { get; set; }
        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public Mesa Mesa { get; set; }

        // garçom (para o futuro)

        //------------------
        public static Pedido FazerPedido()
        {
            
            
            Console.WriteLine("\n\nInforme o nº da mesa: ");
            int numMesa = int.Parse(Console.ReadLine());

            Produto produto = null;

            while (produto == null)
            {
                Cardapio.mostraCardapio();
                Console.WriteLine("Informe o nº do produto: ");
                int numProduto = int.Parse(Console.ReadLine());
                produto = Cardapio.pegaProdutoPorCodigo(numProduto);
                if (produto == null) Console.WriteLine("Código do produto não existe. Favor informe o código correto.");
                
            }
            
            Console.WriteLine("Informe a qtd do produto: ");
            int qtdProduto = int.Parse(Console.ReadLine());

            Console.WriteLine(produto.Preco * qtdProduto);
            return new Pedido((uint)numMesa, produto, qtdProduto);
            
            
        }
        public void MostraDetalhesPedido()
        {
            throw new Exception("Não implementado");
        }



    }
}
