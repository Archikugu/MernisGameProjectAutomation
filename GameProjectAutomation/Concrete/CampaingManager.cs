using GameProjectAutomation.Abstract;
using GameProjectAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectAutomation.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaign)
        {
            Console.WriteLine("A new campaign has been added");
        }

        public void Delete(Campaing campaign)
        {
            Console.WriteLine("the campaign has been deleted");
        }

        public void Update(Campaing campaign)
        {
            Console.WriteLine("the campaign has been updated");
        }
    }
}
