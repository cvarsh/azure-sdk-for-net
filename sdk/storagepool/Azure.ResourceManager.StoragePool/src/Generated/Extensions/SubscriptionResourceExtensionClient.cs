// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _diskPoolClientDiagnostics;
        private DiskPoolsRestOperations _diskPoolRestClient;
        private ClientDiagnostics _diskPoolZonesClientDiagnostics;
        private DiskPoolZonesRestOperations _diskPoolZonesRestClient;
        private ClientDiagnostics _resourceSkusClientDiagnostics;
        private ResourceSkusRestOperations _resourceSkusRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DiskPoolClientDiagnostics => _diskPoolClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StoragePool", DiskPoolResource.ResourceType.Namespace, Diagnostics);
        private DiskPoolsRestOperations DiskPoolRestClient => _diskPoolRestClient ??= new DiskPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DiskPoolResource.ResourceType));
        private ClientDiagnostics DiskPoolZonesClientDiagnostics => _diskPoolZonesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StoragePool", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DiskPoolZonesRestOperations DiskPoolZonesRestClient => _diskPoolZonesRestClient ??= new DiskPoolZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ResourceSkusClientDiagnostics => _resourceSkusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StoragePool", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceSkusRestOperations ResourceSkusRestClient => _resourceSkusRestClient ??= new ResourceSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskPoolResource> GetDiskPoolsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskPoolRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskPoolRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskPoolResource(Client, DiskPoolData.DeserializeDiskPoolData(e)), DiskPoolClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDiskPools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskPoolResource> GetDiskPools(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskPoolRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskPoolRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskPoolResource(Client, DiskPoolData.DeserializeDiskPoolData(e)), DiskPoolClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDiskPools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPoolZones_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPoolZoneInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskPoolZoneInfo> GetDiskPoolZonesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskPoolZonesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskPoolZonesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DiskPoolZoneInfo.DeserializeDiskPoolZoneInfo, DiskPoolZonesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDiskPoolZones", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPoolZones_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPoolZoneInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskPoolZoneInfo> GetDiskPoolZones(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskPoolZonesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskPoolZonesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DiskPoolZoneInfo.DeserializeDiskPoolZoneInfo, DiskPoolZonesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDiskPoolZones", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StoragePoolSkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StoragePoolSkuInfo> GetResourceSkusAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceSkusRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, StoragePoolSkuInfo.DeserializeStoragePoolSkuInfo, ResourceSkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourceSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceSkus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StoragePoolSkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StoragePoolSkuInfo> GetResourceSkus(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourceSkusRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourceSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, StoragePoolSkuInfo.DeserializeStoragePoolSkuInfo, ResourceSkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourceSkus", "value", "nextLink", cancellationToken);
        }
    }
}
