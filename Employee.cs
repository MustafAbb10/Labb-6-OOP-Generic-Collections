using Labb_6_OOP_Generic_Collections;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Labb_6_OOP_Generic_Collections
{
    internal class Employee
    {

        // Mall
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public decimal Salary { get; set; }

        // Employee som får sitt värde Id namn gender osv

        public Employee(int id, string name, string gender , decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}


