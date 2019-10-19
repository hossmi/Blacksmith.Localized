namespace Blacksmith.Localized.Tests.TranslationFromHibridInterfaceAndBaseClass
{
    public interface ISomeDerivedStrings : ISomeStrings
    {
        string SomeDerivedString { get; }
    }
}
