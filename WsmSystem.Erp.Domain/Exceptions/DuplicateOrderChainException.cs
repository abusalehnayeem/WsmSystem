namespace WsmSystem.Erp.Domain.Exceptions
{
    [Serializable]
    public class DuplicateOrderChainException : Exception
    {
        private const string message = "The specification contains more than one Order chain!";

        public DuplicateOrderChainException()
            : base(message)
        {
        }

        public DuplicateOrderChainException(Exception innerException)
            : base(message, innerException)
        {
        }

        public DuplicateOrderChainException(string? message) : base(message)
        {
        }

        public DuplicateOrderChainException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicateOrderChainException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
