using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEnterpriseApplication.Plugins.Downloader
{
    public class PluginDownload
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public Status Status { get; set; }
    }
}
