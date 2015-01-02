namespace MyEnterpriseApplication.Plugins.UI.Models
{
    using System.AddIn.Contract;
    using System.AddIn.Pipeline;
    using System.Windows;

    public static class NativeHandleContractHelper
    {
        public static FrameworkElement GetFrameworkElement(this INativeHandleContract contract)
        {
            // Convert the INativeHandleContract for the add-in UI that was passed  
            // from the add-in side of the isolation boundary to a FrameworkElement 
            string assemblyQualifiedName = typeof(INativeHandleContract).AssemblyQualifiedName;
            var nativeHandleContract = (INativeHandleContract)contract.QueryContract(assemblyQualifiedName);
            return FrameworkElementAdapters.ContractToViewAdapter(nativeHandleContract);
        }
    }
}
