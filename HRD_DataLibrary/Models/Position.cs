using System.Collections.Generic;

namespace HRD_DataLibrary.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Duties { get; set; }
        public string Requirements { get; set; }
        public bool Deleted { get; set; }

        public Department Department { get; set; }
        public string DepartmentName { get { return Department == null ? null : Department.Name; } }

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
                       && string.Equals(Requirements, other.Requirements)
                       && Deleted == other.Deleted;
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
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
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
                   $"{nameof(Department)}: {Department}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
    }