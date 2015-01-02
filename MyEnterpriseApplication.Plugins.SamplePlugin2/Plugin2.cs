namespace MyEnterpriseApplication.Plugins.SamplePlugin2
{
    using System;
    using System.AddIn;
    using System.AddIn.Contract;
    using System.Windows;

    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.AddInView;

    // The AddInAttribute identifies this pipeline segment as an add-in.
    [AddIn("Sample AddIn", Version = "1.0.0.0")]
    public class Plugin2 : IPlugin
    {
        private Guid _sessionGuid;

        public FrameworkElement Icon { get; private set; }

        public INativeHandleContract Control 
        {
            get
            {
                return (INativeHandleContract)new Plugin2Control();
            }
        }

        public bool AllowMultiple
        {
            get
            {
                return false;
            }
        }

        public bool AutoLoad
        {
            get
            {
                return false;
            }
        }

        public Guid GetSessionGuid()
        {
            return _sessionGuid == Guid.Empty ? Guid.NewGuid() : _sessionGuid;
        }

        public void SetSessionGuid(Guid sessionGuid)
        {
            _sessionGuid = sessionGuid;
        }
    }
}
