﻿namespace HRD_DataLibrary.Models
{
    public class Vacancy
    {
        public int VacancyId { get; set; }
        public int PositionId { get; set; }
        public int Number { get; set; }
        public bool Deleted { get; set; }

        public Position Position { get; set; }
        public string PositionName { get { return Position == null ? null : Position.Name; } }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Vacancy other = (Vacancy) obj;
            return VacancyId == other.VacancyId 
                       && PositionId == other.PositionId 
                       && Number == other.Number
                       && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = VacancyId;
                hashCode = (hashCode * 397) ^ PositionId;
                hashCode = (hashCode * 397) ^ Number;
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(VacancyId)}: {VacancyId}, " +
                   $"{nameof(PositionId)}: {PositionId}, " +
                   $"{nameof(Number)}: {Number}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}