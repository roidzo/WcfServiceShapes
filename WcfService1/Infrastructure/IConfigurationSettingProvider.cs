using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Infrastructure
{
    public interface IConfigurationSettingProvider
    {
        string DefaultCulture { get; }
        string LogFilePath { get; }
    }
}
