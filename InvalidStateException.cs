using System;
using System.Runtime.Serialization;

namespace DoorStatePattern
{
    [Serializable]
    internal class InvalidStateException : Exception //Custom exception class for handling a case where the door goes into an invalid state
    {
        public InvalidStateException()
        {
        }

        public InvalidStateException(string message) : base(message)
        {
        }

        public InvalidStateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidStateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}