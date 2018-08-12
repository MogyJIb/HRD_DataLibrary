using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_DataLibrary.Errors
{
    public enum ErrorType { WrongPassword = 410, NonExistentLogin = 411 }

    public class Error
    {
        public ErrorType ErrorType { get; }

        public Error(ErrorType errorType)
        {
            ErrorType = errorType;
        }

        public override string ToString()
        {
            return $"{nameof(ErrorType)}: {ErrorType}";
        }

        protected bool Equals(Error other)
        {
            return ErrorType == other.ErrorType;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ErrorType) obj);
        }

        public override int GetHashCode()
        {
            return ErrorType.GetHashCode();
        }
    }
}
