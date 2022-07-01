using gamesimulation.Abstract;
using gamesimulation.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamesimulation.concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + "Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + "Güncellendi");
        }
    }
}
