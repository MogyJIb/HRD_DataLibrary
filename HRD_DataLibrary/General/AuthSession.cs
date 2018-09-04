using System;
using System.Collections.Generic;

namespace HRD_DataLibrary.General
{
    public class AuthSession
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }

        public AuthSession()
        {
            
        }

        public AuthSession(string id, DateTime startDate)
        {
            Id = id;
            StartDate = startDate;
        }

        public static AuthSession GetInstance()
        {
            string id = Guid.NewGuid().ToString();
            DateTime startDate = DateTime.Now;

            return new AuthSession(id, startDate);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            AuthSession other = (AuthSession)obj;
            return string.Equals(Id, other.Id)
                       && DateTime.Equals(StartDate, other.StartDate);
        }

        public override int GetHashCode()
        {
            var hashCode = 406510971;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + StartDate.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, " +
                   $"{nameof(StartDate)}: {StartDate}";
        }
    }
}
