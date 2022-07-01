using gamesimulation.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.Abstract
{
    public interface ISaleService
    {
        void Save(Person person, Game game, Offer offer);
    }
}
