
using Blaxpro.Localized.Attributes;

namespace Translations.Tests.TranslationFromInterface
{
    [Culture("es-es")]
    public class SpanishCustomStrings : ICustomStrings
    {
        public string SampleString => "Cadena de ejemplo";

        public string List_of_Pets => "Lista de mascotas";
    }
}