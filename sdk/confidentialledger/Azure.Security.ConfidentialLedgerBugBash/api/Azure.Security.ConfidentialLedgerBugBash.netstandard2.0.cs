namespace Azure.Security.ConfidentialLedgerBugBash
{
    public partial class ConfidentialLedgerBugBashClient
    {
        protected ConfidentialLedgerBugBashClient() { }
        public ConfidentialLedgerBugBashClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Security.ConfidentialLedgerBugBash.ConfidentialLedgerBugBashClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class ConfidentialLedgerBugBashClientOptions : Azure.Core.ClientOptions
    {
        public ConfidentialLedgerBugBashClientOptions(Azure.Security.ConfidentialLedgerBugBash.Generated.ConfidentialLedgerBugBashClientOptions.ServiceVersion version = Azure.Security.ConfidentialLedgerBugBash.Generated.ConfidentialLedgerBugBashClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}