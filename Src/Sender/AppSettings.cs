using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Ajf.Nuget.Logging;

namespace Ajf.Ms.MailService.Sender
{
    public class AppSettings : ServiceSettingsFromConfigFile, IAppSettings
    {
        public AppSettings()
        {
        }

    }
}