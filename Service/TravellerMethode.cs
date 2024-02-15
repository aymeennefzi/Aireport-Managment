using Aireport_Managment.Domain;
using Aireport_Managment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Service
{
    public class TravellerMethode : ITravellerMethode
    {
        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = from t in flight.Passangers.OfType<Traveller>()
                        orderby t.BirthDate
                        select t;

            return query.Take(3);
        }
    }
}
