using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteUP.Modelos
{
    public class Endereco
    {
       
        public int Id { get; set; }
        public int Numero { get; set; }

        public string Logradouro { get; set; }

        public string Observacoes { get; set; }
    }
}
