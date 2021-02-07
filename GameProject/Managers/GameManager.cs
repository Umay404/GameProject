using GameProject.Entities;
using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Managers
{
    class GameManager : IGameService
    {
        public void Add(Games games)
        {
            Console.WriteLine("Game Added: "+games.GameName);       
        }

        public void Delete(Games games)
        {
            Console.WriteLine("Game Deleted: " + games.GameName);
        }

        public void Update(Games games)
        {
            Console.WriteLine("Game Update: " + games.GameName);
        }
    }
}
