using System;
using Microsoft.Extensions.Localization;

namespace ECS.PR.Extra.Services
{
    public class StringLocalizerFactory : IStringLocalizerFactory
    {
        private readonly IStringLocalizer _stringLocalizer;

        public StringLocalizerFactory(IStringLocalizer stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            return _stringLocalizer;
        }

        public IStringLocalizer Create(Type resourceSource)
        {
            return _stringLocalizer;
        }
    }
}
