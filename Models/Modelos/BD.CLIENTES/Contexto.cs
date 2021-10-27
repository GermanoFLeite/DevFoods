using Microsoft.EntityFrameworkCore;
using RestauranteUP.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFoods.Models.Modelos.BD.CLIENTES
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
