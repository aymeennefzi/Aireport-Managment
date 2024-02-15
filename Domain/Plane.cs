using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Domain;

public class Plane
{
    public int Capacity { get; set; }
    public DateTime ManufactureDate { get; set; }
    public int PlaneId { get; set; }
    public PlaneType PlaneType { get; set; }
    public virtual ICollection<Flight> Flights { get; set; }
   
    public override string ToString()
    {
        return " Plane info : Capacity : " + Capacity +
            " ,ManufactureDate : " + ManufactureDate +
            " ,PlaneId : " + PlaneId +
            " ,PlaneType : " + PlaneType;
    }
    public Plane() //ctor +2tab
    {
    
    }

    public Plane(int capacity, DateTime manufactureDate, int planeId, PlaneType planeType)
    {
        Capacity = capacity;
        ManufactureDate = manufactureDate;
        PlaneId = planeId;
        PlaneType = planeType;
    }





}
