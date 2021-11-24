namespace OOPSample.Sample7
{
    public class MethodResult
    {
        public MethodResult() { }

        public MethodResult(int errorCode, string errorMsg)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMsg;
        }

        public int ErrorCode { get; protected set; }
        public string ErrorMessage { get; protected set; }
        public bool HasError => ErrorCode != 0;
    }

    public class MethodResult<T> : MethodResult
    {
        public MethodResult(int errorCode, string errorMsg)
            : base(errorCode, errorMsg) { }

        public MethodResult(T data)
        {
            Data = data;
        }

        public T Data { get; protected set; }
    }
}