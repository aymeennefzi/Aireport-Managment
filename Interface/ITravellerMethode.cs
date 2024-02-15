using Aireport_Managment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Interface
{
    public interface ITravellerMethode
    {
        IEnumerable<Traveller> SeniorTravellers(Flight flight);

    }
}
