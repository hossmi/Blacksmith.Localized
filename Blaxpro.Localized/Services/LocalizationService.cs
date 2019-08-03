using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Blaxpro.Localized.Attributes;

namespace Blaxpro.Localized.Services
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
                .Where(t => interfaceType.IsAssignableFrom(t))
                .FirstOrDefault(t => t.GetCustomAttribute<CultureAttribute>(true)?.Culture == this.CurrentCulture)
                ?? throw new ArgumentNullException($"Cannot find type derived from {interfaceType.Name} for culture {this.CurrentCulture}");

            instance = (T)Activator.CreateInstance(targetType);

            return instance;
        }
    }
}