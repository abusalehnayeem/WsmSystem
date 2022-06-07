namespace WsmSystem.Erp.Domain.Exceptions
{
    [Serializable]
    public class InvalidSearchPatternException : Exception
    {
        private const string message = "Invalid search pattern: ";

        public InvalidSearchPatternException()
        {
        }

        public InvalidSearchPatternException(string searchPattern)
            : base($"{message}{searchPattern}")
        {
        }

        public InvalidSearchPatternException(string searchPattern, Exception innerException)
            : base($"{message}{searchPattern}", innerException)
        {
        }

        protected InvalidSearchPatternException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
