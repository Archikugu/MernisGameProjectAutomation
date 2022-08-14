using GameProjectAutomation.Abstract;
using GameProjectAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectAutomation.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Sales(Gamer gamer, Game game, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + campaing.CampaingName + " with the campaign " + game.GameName + " this game " + game.UnitsPrice + " Tl instead of , he bought it for" + game.DiscountedPrice + " TL ");
        }
    }
}
