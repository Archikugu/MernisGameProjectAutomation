using GameProjectAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectAutomation.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing campaign);
        void Update(Campaing campaign);
        void Delete(Campaing campaign);
    }
}
