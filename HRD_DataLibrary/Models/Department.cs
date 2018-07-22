using System.Collections.Generic;

namespace HRD_DataLibrary.Models
{
    public class Department
    {
        public Department()
        {
            Positions = new HashSet<Position>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Cabinet { get; set; }
        public string Phone { get; set; }
        public bool Deleted { get; set; }
        
        public ICollection<Position> Positions { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Department other = (Department) obj;
            return DepartmentId == other.DepartmentId
                        && string.Equals(Name, other.Name)
                        && Cabinet == other.Cabinet
                        && string.Equals(Phone, other.Phone)
                        && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = DepartmentId;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Cabinet;
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(DepartmentId)}: {DepartmentId}, " +
                   $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Cabinet)}: {Cabinet}, " +
                   $"{nameof(Phone)}: {Phone}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}
