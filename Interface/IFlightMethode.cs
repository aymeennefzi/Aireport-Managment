using Aireport_Managment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Interface
{
    public interface IFlightMethode
    {
        IList<DateTime> GetFlightDates(string destination);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IEnumerable<Flight> OrderedDurationFlights();
        void DestinationGroupedFlights();
    }
}
