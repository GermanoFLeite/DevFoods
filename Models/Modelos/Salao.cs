
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteUP.Modelos
{
    public class Salao
    {
        public List<Mesa> ListaMesas { get; set; }

        public Salao()
        {
            ListaMesas =
            new List<Mesa>()
            {
                new Mesa(1, true, 0),
                new Mesa(2, true, 0),
                new Mesa(3, true, 0),
                new Mesa(4, true, 0),
                new Mesa(5, true, 0),
                new Mesa(6, true, 0),

            };

            
        }
        public void MostrarMesasDisponiveis()
        {
            
            foreach (var item in ListaMesas)
            {
                Console.WriteLine(item);
                
            }
            
        }

    }
}
