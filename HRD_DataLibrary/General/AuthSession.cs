using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_DataLibrary.General
{
    public class AuthSession
    {
        public string Id { get; }

        public AuthSession()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}";
        }

        protected bool Equals(AuthSession other)
        {
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((AuthSession) obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}
