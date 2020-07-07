using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMPDB
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public Department Department { get; set; }
    }
}
