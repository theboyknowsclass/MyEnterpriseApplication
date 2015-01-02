namespace TheBoyKnowsClass.MyEnterpriseApplication.Plugins.AddInView
{
    using System;
    using System.AddIn.Contract;
    using System.AddIn.Pipeline;
    using System.Windows;

    [AddInBase]
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
