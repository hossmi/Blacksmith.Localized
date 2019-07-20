using System.Globalization;

namespace Blaxpro.LocalizedStrings.Services
{
    public interface ILocalizationService
    {
        CultureInfo CurrentCulture { get; set; }

        T get<T>() where T: class;
    }
}