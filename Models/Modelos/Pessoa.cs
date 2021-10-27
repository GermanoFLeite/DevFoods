using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteUP.Modelos
{
    public class Pessoa
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }

        public string Nome { get; set; }

        public Endereco Endereco { get; set; }




    }
}
