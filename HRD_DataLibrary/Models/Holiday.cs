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
        public bool Deleted { get; set; }
       
        public Employee Employee { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Holiday other = (Holiday) obj;
            return HolidayId == other.HolidayId
                       && EmployeeId == other.EmployeeId
                       && StartDate.Equals(other.StartDate)
                       && FinalDate.Equals(other.FinalDate)
                       && string.Equals(Type, other.Type)
                       && Salary.Equals(other.Salary)
                       && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = HolidayId;
                hashCode = (hashCode * 397) ^ EmployeeId;
                hashCode = (hashCode * 397) ^ StartDate.GetHashCode();
                hashCode = (hashCode * 397) ^ FinalDate.GetHashCode();
                hashCode = (hashCode * 397) ^ (Type != null ? Type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Salary.GetHashCode();
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(HolidayId)}: {HolidayId}, " +
                   $"{nameof(EmployeeId)}: {EmployeeId}, " +
                   $"{nameof(StartDate)}: {StartDate}, " +
                   $"{nameof(FinalDate)}: {FinalDate}, " +
                   $"{nameof(Type)}: {Type}, " +
                   $"{nameof(Salary)}: {Salary}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}
