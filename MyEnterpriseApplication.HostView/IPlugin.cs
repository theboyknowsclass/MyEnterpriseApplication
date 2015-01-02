namespace MyEnterpriseApplication.HostView
{
    public interface IPlugin
    {
        FrameworkElement Icon { get; }

        Brush IconBackground { get; }

        INativeHandleContract Control { get; }
    }
}
