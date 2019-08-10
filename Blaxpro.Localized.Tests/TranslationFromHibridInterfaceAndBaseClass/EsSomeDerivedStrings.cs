using Blaxpro.Localized.Attributes;

namespace Blaxpro.Localized.Tests.TranslationFromHibridInterfaceAndBaseClass
{
    [Culture("es-es")]
    public class EsSomeDerivedStrings : EnSomeStrings, ISomeDerivedStrings
    {
        public string SomeDerivedString => "Cadena traducida y derivada.";
    }

}
