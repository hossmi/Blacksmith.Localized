using Blacksmith.Localized.Attributes;

namespace Blacksmith.Localized.Tests.TranslationFromHibridInterfaceAndBaseClass
{
    [Culture("en-us")]
    public class EnSomeStrings : ISomeStrings
    {
        public string SomeString1 => "Some String 1";
    }

}
