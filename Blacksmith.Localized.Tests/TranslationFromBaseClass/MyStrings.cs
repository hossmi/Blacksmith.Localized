
using Blacksmith.Localized.Attributes;

namespace Translations.Tests.TranslationFromBaseClass
{
    [Culture("en-us")]
    public class MyStrings
    {
        public virtual string Are_you_sure_to_want_to_delete_the_entity_0 => "Are you sure to want to delete the entity {0}?";
        public virtual string ShopBasket => "Shopping basket";
    }
}
