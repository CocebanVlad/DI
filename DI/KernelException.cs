using System;

namespace DI
{
    public class KernelException : Exception
    {
        public KernelException(string msg)
            : base(msg)
        {
        }

        public KernelException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }
    }
}
