using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    [Flags]
    public enum FileAccessEnum
    {
        Read = 0x1,
        Write = 0x2
    }
}
