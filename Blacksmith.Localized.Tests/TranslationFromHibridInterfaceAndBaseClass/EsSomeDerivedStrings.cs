using Blacksmith.Localized.Attributes;

namespace Blacksmith.Localized.Tests.TranslationFromHibridInterfaceAndBaseClass
{
    [Culture("es-es")]
    public class EsSomeDerivedStrings : EnSomeStrings, ISomeDerivedStrings
    {
        public string SomeDerivedString => "Cadena traducida y derivada.";
    }

}
