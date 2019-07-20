using System.Globalization;

namespace Blaxpro.Localizations.Services
{
    public interface ILocalizationService
    {
        CultureInfo CurrentCulture { get; set; }

        T get<T>() where T: class;
    }
}