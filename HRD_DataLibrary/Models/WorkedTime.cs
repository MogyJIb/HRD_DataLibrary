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
        public bool Deleted { get; set; }

        public Employee Employee { get; set; }
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            WorkedTime other = (WorkedTime) obj;
            return WorkedTimeId == other.WorkedTimeId 
                       && EmployeeId == other.EmployeeId 
                       && Date.Equals(other.Date) 
                       && ArrivalTime.Equals(other.ArrivalTime) 
                       && LeavingTime.Equals(other.LeavingTime)
                       && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = WorkedTimeId;
                hashCode = (hashCode * 397) ^ EmployeeId;
                hashCode = (hashCode * 397) ^ Date.GetHashCode();
                hashCode = (hashCode * 397) ^ ArrivalTime.GetHashCode();
                hashCode = (hashCode * 397) ^ LeavingTime.GetHashCode();
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(WorkedTimeId)}: {WorkedTimeId}, " +
                   $"{nameof(EmployeeId)}: {EmployeeId}, " +
                   $"{nameof(Date)}: {Date}, " +
                   $"{nameof(ArrivalTime)}: {ArrivalTime}, " +
                   $"{nameof(LeavingTime)}: {LeavingTime}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}
