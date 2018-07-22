using System.Collections.Generic;

namespace HRD_DataLibrary.Models
{
    public class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
            Vacancies = new HashSet<Vacancy>();
        }

        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Duties { get; set; }
        public string Requirements { get; set; }

        public Department Department { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            Position other = (Position) obj;
            return PositionId == other.PositionId
                   && DepartmentId == other.DepartmentId
                   && string.Equals(Name, other.Name)
                   && Salary.Equals(other.Salary)
                   && string.Equals(Duties, other.Duties)
                   && string.Equals(Requirements, other.Requirements);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = PositionId;
                hashCode = (hashCode * 397) ^ DepartmentId;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Salary.GetHashCode();
                hashCode = (hashCode * 397) ^ (Duties != null ? Duties.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Requirements != null ? Requirements.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(PositionId)}: {PositionId}, " +
                   $"{nameof(DepartmentId)}: {DepartmentId}, " +
                   $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Salary)}: {Salary}, " +
                   $"{nameof(Duties)}: {Duties}, " +
                   $"{nameof(Requirements)}: {Requirements}, " +
                   $"{nameof(Department)}: {Department}";
        }
    }
    }