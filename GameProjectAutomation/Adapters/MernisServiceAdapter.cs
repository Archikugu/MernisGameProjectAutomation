using GameProjectAutomation.Abstract;
using GameProjectAutomation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace GameProjectAutomation.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.NationalId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
