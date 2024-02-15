using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aireport_Managment.Domain;

public class Staff : Passanger
{
 
    public DateTime EmployementDate { get; set; }
    public double Salary { get; set; }
    public string Function { get; set; }
    public override string ToString()
    {
        return base.ToString() + " , Staff info = EmployementDate: " + EmploymentDate +
            " , function: " + Function +
            "  , Salary: " + Salary; ;
    }
}
