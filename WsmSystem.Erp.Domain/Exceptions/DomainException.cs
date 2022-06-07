namespace WsmSystem.Erp.Domain.Exceptions
{
    [Serializable]
    public class DomainException : Exception
    {
        public DomainException()
        { }

        public DomainException(string message)
            : base(message)
        { }

        public DomainException(string message, Exception innerException)
            : base(message, innerException)
        { }

        // Without this constructor, deserialization will fail
        protected DomainException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
