using GameProject2.Concrete;
using GameProject2.Entities;
using System;

namespace GameProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Can";
            gamer1.LastName = "Tüer";
            DateTime dateTime1 = new DateTime(2005,06,07);
            gamer1.BirthDate = dateTime1;
            gamer1.NationalityNumber = "12345678910";

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            while (gamerCheckManager.CheckIfRealGamer(gamer1)==false)
            {
                return;
            }
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "R6";
            game1.Price=89.99;

            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.DiscountRate = 20;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Discount(campaign1, game1);

            BuyManager buyManager = new BuyManager();
            buyManager.Buy(gamer1,game1);


        }
    }
}
