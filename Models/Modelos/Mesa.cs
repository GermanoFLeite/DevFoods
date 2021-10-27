using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteUP.Modelos
{
    public class Mesa
    {
        public Mesa(int numero, bool disponivel, int qtdPessoas)
        {

        }
        //public bool FecharMesa()
        //{
        //    throw new Exception();
        //}
        public bool Disponivel { get; set; }
        public int Numero { get; set; }
        public List<Pedido> ListaPedidos { get; set; }
        public int QtdPessoas { get; set; }
        public decimal Conta { get; set; }

        
    }
}
