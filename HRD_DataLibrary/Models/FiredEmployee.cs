using System;

namespace HRD_DataLibrary.Models
{
    public class FiredEmployee
    {
        public int FiredEmployeeId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public string Reason { get; set; }

        public Employee Employee { get; set; }
    }
}
