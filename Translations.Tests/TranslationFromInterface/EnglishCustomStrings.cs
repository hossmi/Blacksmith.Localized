
using Blaxpro.Localizations.Attributes;

namespace Translations.Tests.TranslationFromInterface
{
    [Culture("en-us")]
    public class EnglishCustomStrings : ICustomStrings
    {
        public string SampleString => "Sample string";

        public string List_of_Pets => "List of pets";
    }
}