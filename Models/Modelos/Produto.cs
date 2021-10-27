using RestauranteUP.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteUP.Modelos
{
    public class Produto : Cardapio
    {
        public Produto(int idProduto, Categoria categoria,
            decimal preco, string nome, string descricao)
        {
            IdProduto = idProduto;
            Categoria = categoria;
            Preco = preco;
            Nome = nome;
            Descricao = descricao;

        }
       

        public int IdProduto { get; set; }
        public Categoria Categoria { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public string Nome { get; set; }

        
        //public static List<Produto> GetProdutos()
        //{
            
        //}
        

        
        


    }
}
