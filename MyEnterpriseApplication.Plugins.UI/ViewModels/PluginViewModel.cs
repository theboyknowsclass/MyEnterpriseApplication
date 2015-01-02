namespace MyEnterpriseApplication.Plugins.UI.ViewModels
{
    using System.AddIn.Hosting;
    using System.Windows.Input;

    public class PluginViewModel
    {
        private readonly AddInToken _addInToken;

        public PluginViewModel(AddInToken addInToken)
        {
            this._addInToken = addInToken;
        }

        public ICommand Launch { get; set; }

        public string Name
        {
            get
            {
                return _addInToken.Name;
            }
        }

        public string Version
        {
            get
            {
                return _addInToken.Version;
            }
        }

    }
}
