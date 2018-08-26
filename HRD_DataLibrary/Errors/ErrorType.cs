using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_DataLibrary.Errors
{
    public enum ErrorType
    {
        WrongPassword = 410,
        NonExistentLogin = 411,
        AuthanticationFaild = 412
    }
}
