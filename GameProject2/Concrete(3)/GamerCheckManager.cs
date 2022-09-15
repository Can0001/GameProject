using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if (Nationality(gamer.NationalityNumber))
            {
                Console.WriteLine("Oyuncu Var");
                return true;
            }
            else
            {
                Console.WriteLine("Oyuncu Bulanamdı");
                return false;
            }
        }

        private bool Nationality(string nanationalityNo)
        {
            if (nanationalityNo.Length==11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
