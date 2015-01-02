namespace TheBoyKnowsClass.MyEnterpriseApplication.Plugins.PluginHost
{
    using System.AddIn.Hosting;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    public abstract class PluginHostBase
    {
        public static Collection<AddInToken> GetAddinTokens<T>(string root)
        { 
            string[] warnings = AddInStore.Update(root);
            foreach (string warning in warnings)
            {
                Debug.WriteLine(warning);
            }

            // Search for add-ins of type ICalculator (the host view of the add-in).
            Collection<AddInToken> tokens = AddInStore.FindAddIns(typeof(T), root);

            return tokens;
        }

        public static T Activate<T>(AddInToken addInToken)
        {
            var addInProcess = new AddInProcess();

            return addInToken.Activate<T>(addInProcess, AddInSecurityLevel.Internet);
        }
    }
}
