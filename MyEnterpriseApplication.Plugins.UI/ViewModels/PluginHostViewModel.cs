using System.Linq;

namespace MyEnterpriseApplication.Plugins.UI.ViewModels
{
    using System.Collections.ObjectModel;

    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.PluginHost;

    public class PluginHostViewModel
    {
        private readonly PluginHost _pluginHost;

        public ObservableCollection<PluginViewModel> AvailablePlugins { get; set; }

        public ObservableCollection<ActivePluginViewModel> ActivePlugins { get; set; } 

        public PluginHostViewModel(string pluginRootDirectory = null) : this(new PluginHost(pluginRootDirectory))
        {
            
        }

        public PluginHostViewModel(PluginHost pluginHost)
        {
            this._pluginHost = pluginHost;
            AvailablePlugins = new ObservableCollection<PluginViewModel>(from a in _pluginHost.GetAddins() select new PluginViewModel(a));
        }
    }
}
