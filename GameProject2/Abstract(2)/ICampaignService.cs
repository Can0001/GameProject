using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject2.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign,double discountRate);
        void Discount(Campaign campaign,Game game);
    }
}
