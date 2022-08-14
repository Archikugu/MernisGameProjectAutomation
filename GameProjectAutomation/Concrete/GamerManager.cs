using GameProjectAutomation.Abstract;
using GameProjectAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectAutomation.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerIfRealPerson(gamer) == true)
            {
                Console.WriteLine(" Gamer added " + "Welcome : " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Verification failed . user registration failed ! ");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration has been deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registration has been updated");
        }
    }
}
