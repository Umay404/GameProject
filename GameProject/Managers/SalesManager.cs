using GameProject.Entities;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Managers
{
    public class SalesManager : ISalesService
    {
        public void Buy(Games game, Gamer gamer)
        {
            Console.WriteLine("{0} Gamer buyed the {1} Game with {2} Price",gamer.FirstName,game.GameName,game.GamePrice);        }

        public void BuyWithCompaign(Games game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("{0} Gamer buyed the {1} Game with {2} Price and {3} Campaign Rate ", gamer.FirstName, game.GameName, game.GamePrice,campaign.CampaignRate);
        }
    }
}
