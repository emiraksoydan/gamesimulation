using gamesimulation.Abstract;
using gamesimulation.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.Name + "Eklendi");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine(offer.Name + "Silindi");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine(offer.Name + "Güncellendi");
        }
    }
}
