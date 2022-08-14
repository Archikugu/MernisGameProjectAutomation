using GameProjectAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectAutomation.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckGamerIfRealPerson(Gamer gamer);
    }
}
