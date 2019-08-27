using System;
using System.Runtime.Serialization;

namespace Blaxpro.Localized.Exceptions
{
    [Serializable]
    public class MissingLocalizationException : Exception
    {
        public MissingLocalizationException(string message) : base(message)
        {
        }

        protected MissingLocalizationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}