using System.Globalization;
using Blaxpro.Localized.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translations.Tests.TranslationFromBaseClass;
using Translations.Tests.TranslationFromInterface;

namespace Translations.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string someString;
            ILocalizationService localizationService;
            ICustomStrings customStrings;

            localizationService = new LocalizationService();
            localizationService.CurrentCulture = CultureInfo.GetCultureInfo("es-es");

            customStrings = localizationService.get<ICustomStrings>();
            someString = customStrings.SampleString;

            Assert.AreEqual("Cadena de ejemplo", someString);

            localizationService.CurrentCulture = CultureInfo.GetCultureInfo("en-us");

            customStrings = localizationService.get<ICustomStrings>();
            someString = customStrings.SampleString;

            Assert.AreEqual("Sample string", someString);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string someString;
            ILocalizationService localizationService;
            MyStrings strings;

            localizationService = new LocalizationService();

            localizationService.CurrentCulture = CultureInfo.GetCultureInfo("es-es");
            strings = localizationService.get<MyStrings>();

            someString = string.Format(strings.Are_you_sure_to_want_to_delete_the_entity_0, "pepe");
            Assert.AreEqual("¿Está seguro de querer eliminar la entidad pepe?", someString);

            someString = strings.ShopBasket;
            Assert.AreEqual("Shopping basket", someString);

            localizationService.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
            strings = localizationService.get<MyStrings>();

            someString = string.Format(strings.Are_you_sure_to_want_to_delete_the_entity_0, "tronco");
            Assert.AreEqual("Are you sure to want to delete the entity tronco?", someString);

            someString = strings.ShopBasket;
            Assert.AreEqual("Shopping basket", someString);
        }
    }
}
