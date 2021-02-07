using GameProject.Entities;
using GameProject.Managers;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer=new Gamer{ 
                BirthYear=1994,
                FirstName="Serap"
            };
            gamerManager.Add(gamer);

            Console.WriteLine("************************");
            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignRate = 50;
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Console.WriteLine("************************");
            Games game = new Games { Id = 1, GameName = "FIFA21", GamePrice = 450 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Console.WriteLine("************************");
            SalesManager salesManager = new SalesManager();
            salesManager.Buy(game, gamer);

            
        }
    }
}
