﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_EncapsulationProblem
{
    interface IDataAccessObject
    {
        List<string> GetFiles();
    }
}
