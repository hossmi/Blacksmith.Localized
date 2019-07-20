using System;
using System.Globalization;

namespace Blaxpro.LocalizedStrings.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class CultureAttribute : Attribute
    {
        public CultureAttribute(string culture)
        {
            if(string.IsNullOrWhiteSpace(culture))
                throw new ArgumentException("Culture code cannot be empty.");

            this.Culture = CultureInfo.GetCultureInfo(culture) 
                ?? throw new ArgumentException("Invalid culture code");
        }

        public CultureInfo Culture { get; }
    }
}