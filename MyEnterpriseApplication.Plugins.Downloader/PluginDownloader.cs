namespace MyEnterpriseApplication.Plugins.Downloader
{
    using System.IO;
    using System.Threading.Tasks;

    using Microsoft.Synchronization;
    using Microsoft.Synchronization.Files;

    public class PluginDownloader
    {
        private readonly string _sourceFolder;
        private readonly string _targetFolder;

        private FileSyncProvider _sourceFileSyncProvider;
        private FileSyncProvider _targetFileSyncProvider;

        private SyncOrchestrator _synchOrchestrator;

        private string[] _sourceDirectories;
        private string[] _targetDirectories;

        public PluginDownloader(string sourceFolder, string targetFolder)
        {
            this._sourceFolder = sourceFolder;
            this._targetFolder = targetFolder;
            _sourceDirectories = Directory.GetDirectories(sourceFolder);
            _targetDirectories = Directory.GetDirectories(targetFolder);

            this._sourceFileSyncProvider = new FileSyncProvider(sourceFolder);
            this._targetFileSyncProvider = new FileSyncProvider(targetFolder);



            _synchOrchestrator = new SyncOrchestrator
                                     {
                                         Direction = SyncDirectionOrder.Download,
                                         RemoteProvider = this._sourceFileSyncProvider,
                                         LocalProvider = this._targetFileSyncProvider
                                     };
        }

        public void Refresh()
        {
            
        }

        public Task<SyncOperationStatistics> StartAsync()
        {
            return Task.Factory.StartNew(() => this._synchOrchestrator.Synchronize());
        }
    }
}
