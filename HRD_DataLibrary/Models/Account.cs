using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_DataLibrary.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            Account other = (Account) obj;
            return AccountId == other.AccountId 
                       && string.Equals(Role, other.Role) 
                       && string.Equals(Login, other.Login) 
                       && string.Equals(Password, other.Password) 
                       && Deleted == other.Deleted;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = AccountId;
                hashCode = (hashCode * 397) ^ (Role != null ? Role.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Login != null ? Login.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Password != null ? Password.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Deleted.GetHashCode();
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(AccountId)}: {AccountId}, " +
                   $"{nameof(Role)}: {Role}, " +
                   $"{nameof(Login)}: {Login}, " +
                   $"{nameof(Password)}: {Password}, " +
                   $"{nameof(Deleted)}: {Deleted}";
        }
    }
}