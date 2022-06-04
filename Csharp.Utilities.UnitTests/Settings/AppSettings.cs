using Csharp.Utilities.Base.Settings;
using Csharp.Utilities.Base.Settings.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Utilities.Tests.Settings
{
    public class AppSettings : AppSettingsBase
    {
        public AppSettings(IGlobalSettings global, IWorkerSettings worker) : base(global, worker)
        {
        }
    }
}
