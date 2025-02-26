// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A Class representing a ContainerServiceMaintenanceConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ContainerServiceMaintenanceConfigurationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetContainerServiceMaintenanceConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerServiceManagedClusterResource" /> using the GetContainerServiceMaintenanceConfiguration method.
    /// </summary>
    public partial class ContainerServiceMaintenanceConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerServiceMaintenanceConfigurationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string configName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics;
        private readonly MaintenanceConfigurationsRestOperations _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient;
        private readonly ContainerServiceMaintenanceConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceMaintenanceConfigurationResource"/> class for mocking. </summary>
        protected ContainerServiceMaintenanceConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ContainerServiceMaintenanceConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerServiceMaintenanceConfigurationResource(ArmClient client, ContainerServiceMaintenanceConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceMaintenanceConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerServiceMaintenanceConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerServiceMaintenanceConfigurationMaintenanceConfigurationsApiVersion);
            _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient = new MaintenanceConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceMaintenanceConfigurationMaintenanceConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/managedClusters/maintenanceConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerServiceMaintenanceConfigurationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified maintenance configuration of a managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerServiceMaintenanceConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics.CreateScope("ContainerServiceMaintenanceConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceMaintenanceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified maintenance configuration of a managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerServiceMaintenanceConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics.CreateScope("ContainerServiceMaintenanceConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceMaintenanceConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a maintenance configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceConfigurations_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics.CreateScope("ContainerServiceMaintenanceConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = await _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a maintenance configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceConfigurations_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics.CreateScope("ContainerServiceMaintenanceConfigurationResource.Delete");
            scope.Start();
            try
            {
                var response = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ContainerServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a maintenance configuration in the specified managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The maintenance configuration to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceMaintenanceConfigurationResource>> UpdateAsync(WaitUntil waitUntil, ContainerServiceMaintenanceConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics.CreateScope("ContainerServiceMaintenanceConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = await _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceArmOperation<ContainerServiceMaintenanceConfigurationResource>(Response.FromValue(new ContainerServiceMaintenanceConfigurationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a maintenance configuration in the specified managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MaintenanceConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The maintenance configuration to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceMaintenanceConfigurationResource> Update(WaitUntil waitUntil, ContainerServiceMaintenanceConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsClientDiagnostics.CreateScope("ContainerServiceMaintenanceConfigurationResource.Update");
            scope.Start();
            try
            {
                var response = _containerServiceMaintenanceConfigurationMaintenanceConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ContainerServiceArmOperation<ContainerServiceMaintenanceConfigurationResource>(Response.FromValue(new ContainerServiceMaintenanceConfigurationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
