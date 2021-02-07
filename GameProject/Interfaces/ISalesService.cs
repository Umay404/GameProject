using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interfaces
{
   public interface ISalesService
    {
        void Buy(Games game,Gamer gamer);
        void BuyWithCompaign(Games game,Gamer gamer, Campaign campaign);

    }
}
