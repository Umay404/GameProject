using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        //Manager class içerisinde başka bir manager class kullanmak için new leme yapmadan nesne oluşturup constructer kullanırız.
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService=userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer Added.");
            }
            else
            {
                Console.WriteLine("Not Gamer Added !");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated.");
        }
    }
}
