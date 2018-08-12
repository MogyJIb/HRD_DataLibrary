using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_DataLibrary.Errors
{
    public class ErrorType
    {
        public long ErrorCode { get; set; }

        public ErrorType(long errorCode)
        {
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return $"{nameof(ErrorCode)}: {ErrorCode}";
        }

        protected bool Equals(ErrorType other)
        {
            return ErrorCode == other.ErrorCode;
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
            return ErrorCode.GetHashCode();
        }
    }
}
