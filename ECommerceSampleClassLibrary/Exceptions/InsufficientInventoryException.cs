﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSampleClassLibrary.Exceptions
{
    public class InsufficientInventoryException : Exception
    {
        public InsufficientInventoryException(string message) : base(message) { }
    }
}
