using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    public class BuyManager : IBuyService
    {
        public void Buy(Gamer gamer, Game game)
        {
            Console.WriteLine("Oyun: "+game.GameName+" Satın alan kişi: "+gamer.FirstName+" Ödediği Fiyat: "+game.Price);
        }
    }
}
