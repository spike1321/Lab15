﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
}
