﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Overfl: OverflowException
    {
        public Overfl(string message) : base(message) { }
    }
}
