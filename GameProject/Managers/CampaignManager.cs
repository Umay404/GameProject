using GameProject.Entities;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Managers
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added");     
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated");
        }
    }
}
