﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationAPI
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set ; }
        public string Firstname { get ; set; }
        public string Lastname { get ; set ; }
        public virtual decimal Salary { get ; set ; }
    }
}
