﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericClass
{
    public class GenericConcat<TiInpuut>
    {
        public string Concat(TiInpuut right, TiInpuut left)
        {
            string stringRight = right.ToString(); 
            string stringLeft = left.ToString();
            return stringRight + stringLeft;
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
