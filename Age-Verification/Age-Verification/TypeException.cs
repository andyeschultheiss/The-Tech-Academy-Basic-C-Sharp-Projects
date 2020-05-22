using System;
using System.Collections.Generic;
using System.Text;

namespace Age_Verification
{
    public class TypeException : Exception
    {
        public TypeException()
            : base() { }
        public TypeException(string message)
            : base(message) { }

    }
}
