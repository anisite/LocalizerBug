using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace ECS.PR.Extra.Services
{
    public class StringLocalizer : IStringLocalizer
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public StringLocalizer(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            return new[] { new LocalizedString("demo", "crash value <strong>{0}</strong> demo") };
        }

        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            return new StringLocalizer(_httpContextAccessor);
        }

        public LocalizedString this[string idTexteEdite]
        {
            get
            {
                var texteEdite = GetAllStrings(false).FirstOrDefault(e=>e.Name == idTexteEdite);
                return new LocalizedString(idTexteEdite, texteEdite);
            }
        }

        public LocalizedString this[string idTexteEdite, params object[] arguments]
        {
            get
            {
                var texteEdite = GetAllStrings(false).FirstOrDefault(e => e.Name == idTexteEdite);
                return new LocalizedString(idTexteEdite, string.Format(texteEdite, arguments));
            }
        }
    }
}
