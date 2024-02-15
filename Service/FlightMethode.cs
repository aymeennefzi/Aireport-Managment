using Aireport_Managment.Domain;
using Aireport_Managment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Service
{
    public class FlightMethode : IFlightMethode
    {
        IList<Flight> flights = new List<Flight>();
        public void DestinationGroupedFlights()
        {
                                 
        }

        public double DurationAverage(string destination)
        {
            var query = from f in flights 
                        where f.Destination == destination 
                        select f.EstimatedDuration; 
            return query.Average();
        }

        public IList<DateTime> GetFlightDates(string destination)
        {
            var query = from f in flights
                        where f.Destination == destination
                        select f.FlightDate;
            return query.ToList();
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from f in flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query;
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            DateTime endDate = startDate.AddDays(7);

            var query = from f in flights
                        where f.FlightDate >= startDate && f.FlightDate < endDate
                        select f;

            return query.Count();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in plane.Flights
                        select new { f.Destination, f.FlightDate };
            foreach (var f in query)
            {
                Console.WriteLine("Destination : " + f.Destination + "Flight Date : " + f.FlightDate);
            }
        }
    }
}
