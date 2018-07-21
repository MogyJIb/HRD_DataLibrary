using System;

namespace HRD_DataLibrary.Models
{
    public class WorkedTime
    {
        public int WorkedTimeId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan LeavingTime { get; set; }

        public Employee Employee { get; set; }
    }
}
