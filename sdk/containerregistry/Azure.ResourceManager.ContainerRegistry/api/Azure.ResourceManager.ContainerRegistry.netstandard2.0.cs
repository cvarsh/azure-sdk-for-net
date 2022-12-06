namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ContainerRegistryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>, System.Collections.IEnumerable
    {
        protected ContainerRegistryCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string registryName, Azure.ResourceManager.ContainerRegistry.ContainerRegistryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string registryName, Azure.ResourceManager.ContainerRegistry.ContainerRegistryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string registryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string registryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> Get(string registryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> GetAsync(string registryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerRegistryData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ContainerRegistryData(Azure.Core.AzureLocation location, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySku sku) : base (default(Azure.Core.AzureLocation)) { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> DataEndpointHostNames { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryption Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public bool? IsAdminUserEnabled { get { throw null; } set { } }
        public bool? IsDataEndpointEnabled { get { throw null; } set { } }
        public string LoginServer { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption? NetworkRuleBypassOptions { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleSet NetworkRuleSet { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicies Policies { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySku Sku { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceStatus Status { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy? ZoneRedundancy { get { throw null; } set { } }
    }
    public static partial class ContainerRegistryExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNameAvailableResult> CheckContainerRegistryNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNameAvailableResult>> CheckContainerRegistryNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.ContainerRegistryCollection GetContainerRegistries(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> GetContainerRegistries(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> GetContainerRegistriesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> GetContainerRegistry(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string registryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> GetContainerRegistryAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string registryName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource GetContainerRegistryPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource GetContainerRegistryPrivateLinkResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource GetContainerRegistryReplicationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource GetContainerRegistryResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource GetContainerRegistryWebhookResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class ContainerRegistryPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected ContainerRegistryPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerRegistryPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData
    {
        public ContainerRegistryPrivateEndpointConnectionData() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionState ConnectionState { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class ContainerRegistryPrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerRegistryPrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerRegistryPrivateLinkResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerRegistryPrivateLinkResource() { }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string groupName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerRegistryPrivateLinkResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource>, System.Collections.IEnumerable
    {
        protected ContainerRegistryPrivateLinkResourceCollection() { }
        public virtual Azure.Response<bool> Exists(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource> Get(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource>> GetAsync(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerRegistryPrivateLinkResourceData : Azure.ResourceManager.Models.ResourceData
    {
        internal ContainerRegistryPrivateLinkResourceData() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
    }
    public partial class ContainerRegistryReplicationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>, System.Collections.IEnumerable
    {
        protected ContainerRegistryReplicationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string replicationName, Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string replicationName, Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string replicationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string replicationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> Get(string replicationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> GetAsync(string replicationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerRegistryReplicationData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ContainerRegistryReplicationData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public bool? IsRegionEndpointEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceStatus Status { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy? ZoneRedundancy { get { throw null; } set { } }
    }
    public partial class ContainerRegistryReplicationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerRegistryReplicationResource() { }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string replicationName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryReplicationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryReplicationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerRegistryResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerRegistryResource() { }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource> GetContainerRegistryPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionResource>> GetContainerRegistryPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateEndpointConnectionCollection GetContainerRegistryPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource> GetContainerRegistryPrivateLinkResource(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResource>> GetContainerRegistryPrivateLinkResourceAsync(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryPrivateLinkResourceCollection GetContainerRegistryPrivateLinkResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource> GetContainerRegistryReplication(string replicationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationResource>> GetContainerRegistryReplicationAsync(string replicationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryReplicationCollection GetContainerRegistryReplications() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> GetContainerRegistryWebhook(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> GetContainerRegistryWebhookAsync(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookCollection GetContainerRegistryWebhooks() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryListCredentialsResult> GetCredentials(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryListCredentialsResult>> GetCredentialsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsage> GetUsages(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsage> GetUsagesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation ImportImage(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportImageContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> ImportImageAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportImageContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryListCredentialsResult> RegenerateCredential(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryCredentialRegenerateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryListCredentialsResult>> RegenerateCredentialAsync(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryCredentialRegenerateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerRegistryWebhookCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>, System.Collections.IEnumerable
    {
        protected ContainerRegistryWebhookCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string webhookName, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string webhookName, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> Get(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> GetAsync(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerRegistryWebhookData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ContainerRegistryWebhookData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction> Actions { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState? ProvisioningState { get { throw null; } }
        public string Scope { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus? Status { get { throw null; } set { } }
    }
    public partial class ContainerRegistryWebhookResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerRegistryWebhookResource() { }
        public virtual Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string registryName, string webhookName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookCallbackConfig> GetCallbackConfig(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookCallbackConfig>> GetCallbackConfigAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEvent> GetEvents(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEvent> GetEventsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventInfo> Ping(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventInfo>> PingAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerRegistry.ContainerRegistryWebhookResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ContainerRegistry.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionsRequiredForPrivateLinkServiceConsumer : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionsRequiredForPrivateLinkServiceConsumer(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer None { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer Recreate { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer left, Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer left, Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryCredentialRegenerateContent
    {
        public ContainerRegistryCredentialRegenerateContent(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPasswordName name) { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPasswordName Name { get { throw null; } }
    }
    public partial class ContainerRegistryEncryption
    {
        public ContainerRegistryEncryption() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryKeyVaultProperties KeyVaultProperties { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus? Status { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryEncryptionStatus : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryEncryptionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryptionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryExportPolicyStatus : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryExportPolicyStatus(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryImportImageContent
    {
        public ContainerRegistryImportImageContent(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportSource source) { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode? Mode { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportSource Source { get { throw null; } }
        public System.Collections.Generic.IList<string> TargetTags { get { throw null; } }
        public System.Collections.Generic.IList<string> UntaggedTargetRepositories { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryImportMode : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryImportMode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode Force { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode NoForce { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryImportSource
    {
        public ContainerRegistryImportSource(string sourceImage) { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryImportSourceCredentials Credentials { get { throw null; } set { } }
        public string RegistryAddress { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("RegistryUri is deprecated, use RegistryAddress instead")]
        public System.Uri RegistryUri { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } set { } }
        public string SourceImage { get { throw null; } }
    }
    public partial class ContainerRegistryImportSourceCredentials
    {
        public ContainerRegistryImportSourceCredentials(string password) { }
        public string Password { get { throw null; } }
        public string Username { get { throw null; } set { } }
    }
    public partial class ContainerRegistryIPRule
    {
        public ContainerRegistryIPRule(string ipAddressOrRange) { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction? Action { get { throw null; } set { } }
        public string IPAddressOrRange { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryIPRuleAction : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryIPRuleAction(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction Allow { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRuleAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryKeyVaultProperties
    {
        public ContainerRegistryKeyVaultProperties() { }
        public string Identity { get { throw null; } set { } }
        public bool? IsKeyRotationEnabled { get { throw null; } }
        public string KeyIdentifier { get { throw null; } set { } }
        public System.DateTimeOffset? LastKeyRotationTimestamp { get { throw null; } }
        public string VersionedKeyIdentifier { get { throw null; } }
    }
    public partial class ContainerRegistryListCredentialsResult
    {
        internal ContainerRegistryListCredentialsResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPassword> Passwords { get { throw null; } }
        public string Username { get { throw null; } }
    }
    public partial class ContainerRegistryNameAvailabilityContent
    {
        public ContainerRegistryNameAvailabilityContent(string name) { }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType ResourceType { get { throw null; } }
    }
    public partial class ContainerRegistryNameAvailableResult
    {
        internal ContainerRegistryNameAvailableResult() { }
        public bool? IsNameAvailable { get { throw null; } }
        public string Message { get { throw null; } }
        public string Reason { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryNetworkRuleBypassOption : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryNetworkRuleBypassOption(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption AzureServices { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryNetworkRuleDefaultAction : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryNetworkRuleDefaultAction(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction Allow { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction Deny { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryNetworkRuleSet
    {
        public ContainerRegistryNetworkRuleSet(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction defaultAction) { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleDefaultAction DefaultAction { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryIPRule> IPRules { get { throw null; } }
    }
    public partial class ContainerRegistryPassword
    {
        internal ContainerRegistryPassword() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPasswordName? Name { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public enum ContainerRegistryPasswordName
    {
        Password = 0,
        Password2 = 1,
    }
    public partial class ContainerRegistryPatch
    {
        public ContainerRegistryPatch() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncryption Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public bool? IsAdminUserEnabled { get { throw null; } set { } }
        public bool? IsDataEndpointEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleBypassOption? NetworkRuleBypassOptions { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryNetworkRuleSet NetworkRuleSet { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicies Policies { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySku Sku { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class ContainerRegistryPolicies
    {
        public ContainerRegistryPolicies() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryExportPolicyStatus? ExportStatus { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus? QuarantineStatus { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryRetentionPolicy RetentionPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicy TrustPolicy { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryPolicyStatus : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryPolicyStatus(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryPrivateLinkServiceConnectionState
    {
        public ContainerRegistryPrivateLinkServiceConnectionState() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ActionsRequiredForPrivateLinkServiceConsumer? ActionsRequired { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus? Status { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryPrivateLinkServiceConnectionStatus : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryPrivateLinkServiceConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPrivateLinkServiceConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryPublicNetworkAccess : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryPublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryReplicationPatch
    {
        public ContainerRegistryReplicationPatch() { }
        public bool? IsRegionEndpointEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class ContainerRegistryResourceStatus
    {
        internal ContainerRegistryResourceStatus() { }
        public string DisplayStatus { get { throw null; } }
        public string Message { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryResourceType : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryResourceType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType MicrosoftContainerRegistryRegistries { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryResourceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryRetentionPolicy
    {
        public ContainerRegistryRetentionPolicy() { }
        public int? Days { get { throw null; } set { } }
        public System.DateTimeOffset? LastUpdatedOn { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus? Status { get { throw null; } set { } }
    }
    public partial class ContainerRegistrySku
    {
        public ContainerRegistrySku(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName name) { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName Name { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier? Tier { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistrySkuName : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistrySkuName(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName Basic { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName Classic { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName Premium { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistrySkuTier : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistrySkuTier(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier Basic { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier Classic { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier Premium { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistrySkuTier right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryTrustPolicy
    {
        public ContainerRegistryTrustPolicy() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType? PolicyType { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryPolicyStatus? Status { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryTrustPolicyType : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryTrustPolicyType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType Notary { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTrustPolicyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryUsage
    {
        internal ContainerRegistryUsage() { }
        public long? CurrentValue { get { throw null; } }
        public long? Limit { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit? Unit { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryUsageUnit : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryUsageUnit(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit Bytes { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit Count { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryUsageUnit right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryWebhookAction : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryWebhookAction(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction ChartDelete { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction ChartPush { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction Delete { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction Push { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction Quarantine { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerRegistryWebhookCallbackConfig
    {
        internal ContainerRegistryWebhookCallbackConfig() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> CustomHeaders { get { throw null; } }
        public System.Uri ServiceUri { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookCreateOrUpdateContent
    {
        public ContainerRegistryWebhookCreateOrUpdateContent(Azure.Core.AzureLocation location) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction> Actions { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> CustomHeaders { get { throw null; } }
        public Azure.Core.AzureLocation Location { get { throw null; } }
        public string Scope { get { throw null; } set { } }
        public System.Uri ServiceUri { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus? Status { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEvent : Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventInfo
    {
        internal ContainerRegistryWebhookEvent() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventRequestMessage EventRequestMessage { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventResponseMessage EventResponseMessage { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEventContent
    {
        internal ContainerRegistryWebhookEventContent() { }
        public string Action { get { throw null; } }
        public string ActorName { get { throw null; } }
        public System.Guid? Id { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventRequestContent Request { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventSource Source { get { throw null; } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventTarget Target { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEventInfo
    {
        internal ContainerRegistryWebhookEventInfo() { }
        public System.Guid? Id { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEventRequestContent
    {
        internal ContainerRegistryWebhookEventRequestContent() { }
        public string Addr { get { throw null; } }
        public string Host { get { throw null; } }
        public System.Guid? Id { get { throw null; } }
        public string Method { get { throw null; } }
        public string UserAgent { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEventRequestMessage
    {
        internal ContainerRegistryWebhookEventRequestMessage() { }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookEventContent Content { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Headers { get { throw null; } }
        public string Method { get { throw null; } }
        public System.Uri RequestUri { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEventResponseMessage
    {
        internal ContainerRegistryWebhookEventResponseMessage() { }
        public string Content { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Headers { get { throw null; } }
        public string ReasonPhrase { get { throw null; } }
        public string StatusCode { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEventSource
    {
        internal ContainerRegistryWebhookEventSource() { }
        public string Addr { get { throw null; } }
        public string InstanceId { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookEventTarget
    {
        internal ContainerRegistryWebhookEventTarget() { }
        public string Digest { get { throw null; } }
        public long? Length { get { throw null; } }
        public string MediaType { get { throw null; } }
        public string Name { get { throw null; } }
        public string Repository { get { throw null; } }
        public long? Size { get { throw null; } }
        public string Tag { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class ContainerRegistryWebhookPatch
    {
        public ContainerRegistryWebhookPatch() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookAction> Actions { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> CustomHeaders { get { throw null; } }
        public string Scope { get { throw null; } set { } }
        public System.Uri ServiceUri { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus? Status { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryWebhookStatus : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryWebhookStatus(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryWebhookStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerRegistryZoneRedundancy : System.IEquatable<Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerRegistryZoneRedundancy(string value) { throw null; }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy Disabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy left, Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryZoneRedundancy right) { throw null; }
        public override string ToString() { throw null; }
    }
}
