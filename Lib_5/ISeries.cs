using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_5
{
    interface ISeries
    {
        int Next { get; }
        int GetNext();
        void Reset();
        void SetStart(int start);
    }
}
