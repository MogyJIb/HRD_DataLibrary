using System;
using System.Collections.Generic;

namespace HRD_DataLibrary.Models
{
    public class Employee
    {
        public Employee()
        {
            FiredEmployees = new HashSet<FiredEmployee>();
            Rewards = new HashSet<Reward>();
            WorkedTime = new HashSet<WorkedTime>();
        }

        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Education { get; set; }
        public DateTime EmploymentDate { get; set; }
        public bool Deleted { get; set; }

        public Position Position { get; set; }
        public ICollection<FiredEmployee> FiredEmployees { get; set; }
        public ICollection<Reward> Rewards { get; set; }
        public ICollection<WorkedTime> WorkedTime { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Employee other = (Employee) obj;
            return EmployeeId == other.EmployeeId
                       && PositionId == other.PositionId
                       && string.Equals(FirstName, other.FirstName)
                       && string.Equals(LastName, other.LastName)
                       && string.Equals(Patronymic, other.Patronymic)
                       && BirthDate.Equals(other.BirthDate)
                       && string.Equals(Address, other.Address)
                       && string.Equals(Phone, other.Phone)
                       && string.Equals(Education, other.Education)
                       && EmploymentDate.Equals(other.EmploymentDate) 
                       && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = EmployeeId;
                hashCode = (hashCode * 397) ^ PositionId;
                hashCode = (hashCode * 397) ^ (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Patronymic != null ? Patronymic.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ BirthDate.GetHashCode();
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Education != null ? Education.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ EmploymentDate.GetHashCode();
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(EmployeeId)}: {EmployeeId}, " +
                   $"{nameof(PositionId)}: {PositionId}, " +
                   $"{nameof(FirstName)}: {FirstName}, " +
                   $"{nameof(LastName)}: {LastName}, " +
                   $"{nameof(Patronymic)}: {Patronymic}, " +
                   $"{nameof(BirthDate)}: {BirthDate}, " +
                   $"{nameof(Address)}: {Address}, " +
                   $"{nameof(Phone)}: {Phone}, " +
                   $"{nameof(Education)}: {Education}, " +
                   $"{nameof(EmploymentDate)}: {EmploymentDate}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}