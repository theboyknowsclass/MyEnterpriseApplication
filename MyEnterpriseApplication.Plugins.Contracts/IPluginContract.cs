namespace TheBoyKnowsClass.MyEnterpriseApplication.Plugins.Contracts
{
    using System;
    using System.AddIn.Contract;
    using System.AddIn.Pipeline;
    using System.Windows;

    [AddInContract]
    public interface IPluginContract : IContract
    {
        FrameworkElement Icon { get; }

        INativeHandleContract Control { get; }

        bool AllowMultiple { get; }

        bool AutoLoad { get; }

        Guid GetSessionGuid();

        void SetSessionGuid(Guid sessionGuid);
    }
}
