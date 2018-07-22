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
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Reward other = (Reward) obj;
            return RewardId == other.RewardId 
                   && EmployeeId == other.EmployeeId 
                   && Date.Equals(other.Date) 
                   && Amount.Equals(other.Amount) 
                   && string.Equals(Reason, other.Reason);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = RewardId;
                hashCode = (hashCode * 397) ^ EmployeeId;
                hashCode = (hashCode * 397) ^ Date.GetHashCode();
                hashCode = (hashCode * 397) ^ Amount.GetHashCode();
                hashCode = (hashCode * 397) ^ (Reason != null ? Reason.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(RewardId)}: {RewardId}, " +
                   $"{nameof(EmployeeId)}: {EmployeeId}, " +
                   $"{nameof(Date)}: {Date}, " +
                   $"{nameof(Amount)}: {Amount}, " +
                   $"{nameof(Reason)}: {Reason}";
        }
    }
}
