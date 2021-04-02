using System;

namespace WorkingWithReflection.Shared
{
    [
        AttributeUsage(
            AttributeTargets.Class | AttributeTargets.Method,
            AllowMultiple = true)
    ]
    public class CoderAttribute : Attribute
    {
        public string Coder { get; set; }

        public DateTime LastModified { get; set; }

        public CoderAttribute(string coder, DateTime lastModified)
        {
            Coder = coder;
            LastModified = lastModified;
        }
    }
}
