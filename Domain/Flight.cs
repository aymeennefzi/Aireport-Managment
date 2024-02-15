using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Domain; 

public class Flight
{
    public int FlightId { get; set; }
    public DateTime FlightDate { get; set; }
    public int EstimatedDuration { get; set; }
    public DateTime EffectiveArrival { get; set; }
    public String Departure { get; set; }
    public String Destination { get; set; }
    public virtual ICollection<Passanger> Passangers { get; set;}
    public Plane plane { get; set; }

    public override string ToString()
    {
        return " Flight info = Destination : " + Destination +
            " , Departure : " + Departure +
            " , FlightDate : " + FlightDate +
            " , FlightId : " + FlightId +
            " , EffectiveArrival : " + EffectiveArrival +
            " , EstimatedDuration : " + EstimatedDuration;
    }

}
