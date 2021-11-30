using System;

namespace OOPSample.Sample7
{
    public class MyException : Exception
    {
        public int ErrorCode { get; set; }
        public MyException(int errorCode, string message, Exception innerException = null)
            : base(message, innerException)
        {
            ErrorCode = errorCode;
        }
    }
}