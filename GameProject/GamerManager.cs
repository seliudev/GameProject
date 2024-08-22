using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("User registered successful.");
            }
            else
            {
                Console.WriteLine("Validation unsuccessful, user registration failed.");

            }

        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException("User record deleted.");
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException("User record updated.");
        }
    }
}
