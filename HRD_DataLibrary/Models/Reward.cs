using System;

namespace HRD_DataLibrary.Models
{
    public class Reward
    {
        public int RewardId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Reason { get; set; }

        public Employee Employee { get; set; }
    }
}
