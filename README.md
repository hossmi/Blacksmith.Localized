# Blacksmith.Localized

## Purpose
To have all localization strings in compiled classes and interface.
Having an interface defining localized strings, we can force any concrete class that follows interface to implement any string we add to the interface avoiding to forget to add new string properties at concrete classes.

## How it works
- Step 1: Define the strings interface:
```cs
public interface ICustomStrings
{
    string SampleString { get; }
    string List_of_Pets { get; }
}
```

- Step 2: Add concrete classes denoting its culture
```cs
[Culture("en-us")]
public class EnglishCustomStrings : ICustomStrings
{
    public string SampleString => "Sample string";
    public string List_of_Pets => "List of pets";
}

[Culture("es-es")]
public class SpanishCustomStrings : ICustomStrings
{
    public string SampleString => "Cadena de ejemplo";
    public string List_of_Pets => "Lista de mascotas";
}
```

- Step 3: Add `LocalizationService` to dependency constructor
```cs
ILocalizationService localizationService;
ICustomStrings customStrings;

localizationService = new LocalizationService();
localizationService.CurrentCulture = CultureInfo.GetCultureInfo("es-es") /* optional! */;

customStrings = localizationService.get<ICustomStrings>();
```
