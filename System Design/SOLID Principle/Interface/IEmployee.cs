﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    internal interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
