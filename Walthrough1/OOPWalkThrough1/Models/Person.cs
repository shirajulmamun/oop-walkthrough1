﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.Models
{
    public class Person
    {
        public string firstName;
        public string middleName;
        public string lastName ;

        public string GetFullName()
        {
            return firstName+ " "+middleName+" "+lastName;
        }
    }
}
