using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Blacksmith.Localized.Attributes;
using Blacksmith.Localized.Exceptions;

namespace Blacksmith.Localized.Services
{
    public class LocalizationService : ILocalizationService
    {
        private CultureInfo _currentCulture;

        public LocalizationService()
        {
            this.CurrentCulture = CultureInfo.CurrentCulture;
        }

        public CultureInfo CurrentCulture
        {
            get => this._currentCulture;
            set => this._currentCulture = value ?? throw new ArgumentNullException(nameof(this.CurrentCulture));
        }

        public T get<T>() where T : class
        {
            Type interfaceType, targetType;
            T instance;

            interfaceType = typeof(T);

            targetType = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(ass => ass.IsDynamic == false)
                .SelectMany(ass => ass.GetExportedTypes())
                .Where(t => t.IsInterface == false)
                .Where(t => interfaceType.IsAssignableFrom(t))
                .SingleOrDefault(t => t
                    .GetCustomAttributes<CultureAttribute>(true)
                    .Any(a => a.Culture.Name == this.CurrentCulture.Name));

            if(targetType == null)
                throw new MissingLocalizationException($"Cannot find localization class for '{interfaceType.Name}' in '{this.CurrentCulture.Name}'.");

            instance = (T)Activator.CreateInstance(targetType);

            return instance;
        }
    }
}