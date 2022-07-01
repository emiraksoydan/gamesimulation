using gamesimulation.Abstract;
using gamesimulation.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.concrete
{
    public class SaleManager : ISaleService
    {
        public void Save(Person person, Game game, Offer offer)
        {
            Console.WriteLine(person.Name + "oyunu Aldı" + offer.Name + "Kampanyası uygulandı" + game.Name + "Oyun Alındı");
        }
    }
}
