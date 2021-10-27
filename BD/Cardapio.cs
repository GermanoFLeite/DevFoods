using RestauranteUP.Modelos;
using System;
using System.Collections.Generic;

namespace RestauranteUP.BD
{
    public class Cardapio
    {
        public static List<Produto> ListaProdutos = new List<Produto>()
        {
            //SANDUICHES
            new Produto(
                1, Categoria.Sanduiche, new decimal(12.9), "Choripán",
                "Um pão choroso"),
            new Produto(
                2, Categoria.Sanduiche, new decimal(12.9), "Medianoche",
                "Medio mas mata a fome."),
            new Produto(
                3, Categoria.Sanduiche, new decimal(15.2), "Chacarero",
                "O nome é feio mas é bom"),
            new Produto(
                4, Categoria.Sanduiche, new decimal(15.44), "Cemita",
                "Sanduiche das arabeas"),
            //PIZZAS
            new Produto(
                5, Categoria.Pizzas, new decimal(12.9), "Portuguesa",
                "Um pão choroso"),
            new Produto(
                6, Categoria.Pizzas, new decimal(12.9), "Marguerita",
                "Medio mas mata a fome."),
            new Produto(
                7, Categoria.Pizzas, new decimal(15.2), "Napolitana",
                "O nome é feio mas é bom"),
            new Produto(
                8, Categoria.Pizzas, new decimal(15.44), "Calabresa",
                "Sanduiche das arabeas")
            //ENTRADAS
            //BEBIDAS
            //SOBREMESAS
        };


        // Método que irá retornar o produto a partir de um código
        public static Produto pegaProdutoPorCodigo(int codProduto)
        {
            return ListaProdutos.Find(produto => produto.IdProduto == codProduto); ;
        }
       

        public static void mostraCardapio()
        {
            //Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------Cardápio--------------------");
            //Console.WriteLine("-------------------------------------");

            Console.WriteLine("Nº\tCategoria\tPreço(R$)\tNome\t\tDescrição");

            foreach (var item in ListaProdutos)
            {
                Console.WriteLine(
                    $"{item.IdProduto}\t" +
                    $"{item.Categoria}\t" +
                    $"{item.Preco:C}\t\t" +
                    $"{item.Nome}\t\t" +
                    $"{item.Descricao}");
            }
        }
        
    }
}
