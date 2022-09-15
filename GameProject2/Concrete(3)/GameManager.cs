using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi: " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi: " + game.GameName);

        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi: " + game.GameName);

        }
    }
}
