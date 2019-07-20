using System;
using System.Globalization;

namespace Blaxpro.Localizations.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class CultureAttribute : Attribute
    {
        public CultureAttribute(string culture)
        {
            this.Culture = CultureInfo.GetCultureInfo(culture) ?? throw new ArgumentException("Invalid culture code");
        }

        public CultureInfo Culture { get; }
    }
}