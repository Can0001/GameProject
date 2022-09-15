using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi: "+gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi: " + gamer.FirstName);
        }
    }
}
