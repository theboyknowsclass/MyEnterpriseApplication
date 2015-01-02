namespace MyEnterpriseApplication.Plugins.SamplePlugin1
{
    using System;
    using System.AddIn;
    using System.AddIn.Contract;
    using System.Windows;

    using TheBoyKnowsClass.MyEnterpriseApplication.Plugins.AddInView;

    // The AddInAttribute identifies this pipeline segment as an add-in.
    [AddIn("Sample AddIn", Version = "1.0.0.0")]
    public class Plugin1 : IPlugin
    {
        public FrameworkElement Icon { get; private set; }

        public INativeHandleContract Control 
        {
            get
            {
                return (INativeHandleContract)new Plugin1Control();
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
            return Guid.NewGuid();
        }

        public void SetSessionGuid(Guid sessionGuid)
        {
            
        }
    }
}
