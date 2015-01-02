namespace TheBoyKnowsClass.MyEnterpriseApplication.Plugins.HostSideAdapter
{
    using System;
    using System.AddIn.Contract;
    using System.AddIn.Pipeline;
    using System.Windows;

    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.Contracts;
    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.HostView;

    [HostAdapter]
    public class PluginContractToViewHostSideAdapter : IPlugin
    {
        private readonly IPluginContract _contract;
        private ContractHandle _handle;

        public PluginContractToViewHostSideAdapter(IPluginContract contract)
        {
            this._contract = contract;
            // Prevent the reference to the contract from being released while the 
            // host application uses the add-in 
            _handle = new ContractHandle(contract);
        }

        public FrameworkElement Icon
        {
            get
            {
                return _contract.Icon;
            }
        }

        public INativeHandleContract Control
        {
            get
            {
                return _contract.Control;
            }
        }

        public bool AllowMultiple
        {
            get
            {
                return this._contract.AllowMultiple;
            }
        }

        public bool AutoLoad
        {
            get
            {
                return this._contract.AutoLoad;
            }
        }

        public Guid GetSessionGuid()
        {
            return this._contract.GetSessionGuid();
        }

        public void SetSessionGuid(Guid sessionGuid)
        {
            this._contract.SetSessionGuid(sessionGuid);
        }
    }
}
