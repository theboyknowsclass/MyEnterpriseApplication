namespace TheBoyKnowsClass.MyEnterpriseApplication.Plugins.AddInSideAdapter
{
    using System;
    using System.AddIn.Contract;
    using System.AddIn.Pipeline;
    using System.Windows;

    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.AddInView;
    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.Contracts;

    [AddInAdapter]
    public class PluginViewToContractAddInSideAdapter : ContractBase, IPluginContract
    {
        private readonly IPlugin _view;

        public PluginViewToContractAddInSideAdapter(IPlugin view)
        {
            this._view = view;
        }

        public FrameworkElement Icon
        {
            get
            {
                return this._view.Icon;
            }
        }

        public INativeHandleContract Control
        {
            get
            {
                return this._view.Control;
            }
        }

        public bool AllowMultiple 
        {
            get
            {
                return this._view.AllowMultiple;
            }
        }

        public bool AutoLoad
        {
            get
            {
                return this._view.AutoLoad;
            }
        }

        public Guid GetSessionGuid()
        {
            return this._view.GetSessionGuid();
        }

        public void SetSessionGuid(Guid sessionGuid)
        {
            this._view.SetSessionGuid(sessionGuid);
        }
    }
}
