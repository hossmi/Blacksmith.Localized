using Blaxpro.Localized.Attributes;

namespace Translations.Tests.TranslationFromBaseClass
{
    [Culture("es-es")]
    public class MyEspStrings : MyStrings
    {
        public override string Are_you_sure_to_want_to_delete_the_entity_0 => "¿Está seguro de querer eliminar la entidad {0}?";
    }
}
