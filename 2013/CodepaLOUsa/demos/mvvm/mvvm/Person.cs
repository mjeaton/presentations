﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get;set; }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }
        public DateTime HireDate { get; set; }
    }
  
    public class Address
    {
    }
}
