namespace TheBoyKnowsClass.MyEnterpriseApplication.Plugins.PluginHost
{
    using System;
    using System.AddIn.Hosting;
    using System.Collections.ObjectModel;

    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.HostView;

    public class PluginHost : PluginHostBase
    {
        private readonly string _addInRoot;

        public PluginHost(string addInRoot = null)
        {
            if (string.IsNullOrEmpty(addInRoot))
            {
                _addInRoot = Environment.CurrentDirectory + "\\Pipeline";
            }
            else
            {
                _addInRoot = addInRoot;
            }
        }

        public Collection<AddInToken> GetAddins()
        {
            return GetAddinTokens<IPlugin>(_addInRoot);
        }


    }
}
