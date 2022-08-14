using GameProjectAutomation.Concrete;
using GameProjectAutomation.Entities;
using System;

namespace GameProjectAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { Id=1,DateOfBirth=1999,FirstName="Gökhan",LastName="Gök",NationalId=123456789};

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer);

            Game game = new Game { Id=1,GameName="Cs Go",UnitsPrice=35,DiscountedPrice=25};

            Campaing campaing = new Campaing { Id=1,CampaingName="%25",DiscountRate=25};

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing);
            OrderManager orderManager = new OrderManager();
            orderManager.Sales(gamer,game,campaing);
            
        }
    }
}
