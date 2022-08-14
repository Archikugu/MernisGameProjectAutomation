using GameProjectAutomation.Abstract;
using GameProjectAutomation.Entities;
using GameProjectAutomation.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectAutomation.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        IGamerCheckService _gamerCheckService;
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            _gamerCheckService = new MernisServiceAdapter();
            return _gamerCheckService.CheckGamerIfRealPerson(gamer);
        }
    }
}
