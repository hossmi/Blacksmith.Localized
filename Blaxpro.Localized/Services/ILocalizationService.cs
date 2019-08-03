using System.Globalization;

namespace Blaxpro.Localized.Services
{
    public interface ILocalizationService
    {
        CultureInfo CurrentCulture { get; set; }

        T get<T>() where T: class;
    }
}