using System.Globalization;

namespace Blacksmith.Localized.Services
{
    public interface ILocalizationService
    {
        CultureInfo CurrentCulture { get; set; }

        T get<T>() where T: class;
    }
}