namespace TheBoyKnowsClass.MyEnterpriseApplication.Plugins.HostView
{
    using System;
    using System.AddIn.Contract;
    using System.Windows;

    public interface IPlugin
    {
        FrameworkElement Icon { get; }

        INativeHandleContract Control { get; }

        bool AllowMultiple { get; }

        bool AutoLoad { get; }

        Guid GetSessionGuid();

        void SetSessionGuid(Guid sessionGuid);
    }
}
