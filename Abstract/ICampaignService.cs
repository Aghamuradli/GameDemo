using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Delete(Campaigns campaign);
        void Update(Campaigns campaign, double discountRate);
        void CalculateDiscount(Campaigns campaign, Products product);
    }
}
