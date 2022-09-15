using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni İndirim: "+campaign.CampaignName+" İndirim Oranı: "+campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("İndirim Bitti: "+campaign.CampaignName);
        }

        public void Discount(Campaign campaign, Game game)
        {
            //İndirim Tutarı
            double discountAmount = (game.Price * campaign.DiscountRate) / 100;
            //İndirim Fiyatı
            double discountedPrice = game.Price - discountAmount;
            game.Price = discountedPrice;
            Console.WriteLine("Oyunun İndirimli Fiyatı: "+ game.GameName +" Fiyat: "+game.Price);
        }

        public void Update(Campaign campaign, double discountRate)
        {
            campaign.DiscountRate = discountRate;
            Console.WriteLine("İndirim: " + campaign.CampaignName + " İndirim Oranı Güncellendi: " + campaign.DiscountRate);
        }
    }
}
