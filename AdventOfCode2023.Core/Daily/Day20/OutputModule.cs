﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Core.Daily.Day20
{
    internal class OutputModule : Module
    {
        public OutputModule(string name) : base(name)
        {
        }

        public override List<(Pulse pulse, Module destModule)> ProcessIncomingPulse(Pulse pulse)
        {
            return new();
        }
    }
}
