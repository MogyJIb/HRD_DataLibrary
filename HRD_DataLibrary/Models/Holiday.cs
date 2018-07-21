using System;

namespace HRD_DataLibrary.Models
{
    public class Holiday
    {
        public int HolidayId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
        public string Type { get; set; }
        public double Salary { get; set; }
    }
}
