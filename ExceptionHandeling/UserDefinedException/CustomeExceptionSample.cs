﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling.UserDefinedException
{
    public class CustomeExceptionSample : Exception
    {
        public CustomeExceptionSample(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public DateOnly MyDate { get; set; }
        public TimeOnly MyTime { get; set; }
    }
}
 