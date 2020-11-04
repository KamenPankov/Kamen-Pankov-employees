using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Employee
    {
        public int EmpId { get; set; }

        public int ProjectId { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}
