﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Interfaces
{
    public interface ISpeed
    {
        double AvgSpeed { get; }
        string GetSpeed();
    }
}