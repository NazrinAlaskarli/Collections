﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Student
    {
        public string  Name { get; set; }
        
        public string  Surname { get; set; }

        public int PIN { get; set; }

        public string GetDetails()
        {
            return Name;
        }

    }
}
