using System;
using System.Collections.Generic;
using System.Text;

namespace Age_Verification
{
    public class RangeException : Exception
    {
        public RangeException()
            : base() { }
        public RangeException(string message)
            : base(message) { }

    }
}
