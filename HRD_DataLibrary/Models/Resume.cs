using System;

namespace HRD_DataLibrary.Models
{
    public class Resume
    {
        public int ResumeId { get; set; }
        public int VacancyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string Institution { get; set; }
        public string Specialty { get; set; }
        public bool Deleted { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Resume other = (Resume) obj;
            return ResumeId == other.ResumeId 
                       && VacancyId == other.VacancyId
                       && string.Equals(FirstName, other.FirstName) 
                       && string.Equals(LastName, other.LastName) 
                       && string.Equals(Patronymic, other.Patronymic) 
                       && BirthDate.Equals(other.BirthDate) 
                       && string.Equals(Phone, other.Phone) 
                       && string.Equals(Email, other.Email) 
                       && string.Equals(Education, other.Education) 
                       && string.Equals(Institution, other.Institution) 
                       && string.Equals(Specialty, other.Specialty) 
                       && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = ResumeId;
                hashCode = (hashCode * 397) ^ VacancyId;
                hashCode = (hashCode * 397) ^ (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Patronymic != null ? Patronymic.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ BirthDate.GetHashCode();
                hashCode = (hashCode * 397) ^ (Phone != null ? Phone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Email != null ? Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Education != null ? Education.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Institution != null ? Institution.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Specialty != null ? Specialty.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(ResumeId)}: {ResumeId}, " +
                   $"{nameof(VacancyId)}: {VacancyId}, " +
                   $"{nameof(FirstName)}: {FirstName}, " +
                   $"{nameof(LastName)}: {LastName}, " +
                   $"{nameof(Patronymic)}: {Patronymic}, " +
                   $"{nameof(BirthDate)}: {BirthDate}, " +
                   $"{nameof(Phone)}: {Phone}, " +
                   $"{nameof(Email)}: {Email}, " +
                   $"{nameof(Education)}: {Education}, " +
                   $"{nameof(Institution)}: {Institution}, " +
                   $"{nameof(Specialty)}: {Specialty}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}