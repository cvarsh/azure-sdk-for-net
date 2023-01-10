namespace Azure.Security.SDKReleasePlannerTest
{
    public partial class SDKReleasePlannerTestClient
    {
        protected SDKReleasePlannerTestClient() { }
        public SDKReleasePlannerTestClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Security.SDKReleasePlannerTest.SDKReleasePlannerTestClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class SDKReleasePlannerTestClientOptions : Azure.Core.ClientOptions
    {
        public SDKReleasePlannerTestClientOptions(Azure.Security.SDKReleasePlannerTest.Generated.SDKReleasePlannerTestClientOptions.ServiceVersion version = Azure.Security.SDKReleasePlannerTest.Generated.SDKReleasePlannerTestClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}