using System;

namespace HRD_DataLibrary.Models
{
    public class FiredEmployee
    {
        public int FiredEmployeeId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfDismissal { get; set; }
        public string Reason { get; set; }
        public bool Deleted { get; set; }

        public Employee Employee { get; set; }
        public string EmployeeName { get { return Employee == null ? null : Employee.FirstName; } }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            FiredEmployee other = (FiredEmployee) obj;
            return FiredEmployeeId == other.FiredEmployeeId
                       && EmployeeId == other.EmployeeId
                       && DateOfDismissal.Equals(other.DateOfDismissal)
                       && string.Equals(Reason, other.Reason)
                       && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = FiredEmployeeId;
                hashCode = (hashCode * 397) ^ EmployeeId;
                hashCode = (hashCode * 397) ^ DateOfDismissal.GetHashCode();
                hashCode = (hashCode * 397) ^ (Reason != null ? Reason.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(FiredEmployeeId)}: {FiredEmployeeId}, " +
                   $"{nameof(EmployeeId)}: {EmployeeId}, " +
                   $"{nameof(DateOfDismissal)}: {DateOfDismissal}, " +
                   $"{nameof(Reason)}: {Reason}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}
