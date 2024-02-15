using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Domain;

public class Passanger
{
    public string PassportNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int TelNumber { get; set; }
    public int EmailAddress { get; set; }
    public int Id { get; set; }
    public virtual ICollection<Flight> Flights { get; set; }
    
    public override string ToString()
    {
        return "Passenger info = BirthDate:" + BirthDate +
            ", PassportNumber:" + PassportNumber +
            ",EmailAddress:" + EmailAddress +
            ",FirstName:" + FirstName +
            ",LastName:" + LastName +
            ",TelNumber:" + TelNumber;
    }
    public bool checkProfile(string firstName , string lastName)
    {
        return FirstName.Equals(firstName) && LastName.Equals(lastName);
    }

}
