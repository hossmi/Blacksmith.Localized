using Blaxpro.Localized.Attributes;

namespace Blaxpro.Localized.Tests.TranslationFromHibridInterfaceAndBaseClass
{
    [Culture("en-us")]
    public class EnSomeStrings : ISomeStrings
    {
        public string SomeString1 => "Some String 1";
    }

}
