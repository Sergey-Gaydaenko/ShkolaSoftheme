using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Validator : IValidator
    {
        bool IValidator.ValidateUser(IUser value)
        {
            
            return true;
        }
    }
}
