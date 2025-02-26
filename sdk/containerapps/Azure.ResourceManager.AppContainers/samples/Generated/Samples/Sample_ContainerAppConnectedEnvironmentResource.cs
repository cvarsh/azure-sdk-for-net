// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppConnectedEnvironmentResource
    {
        // List connected environments by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContainerAppConnectedEnvironments_ListConnectedEnvironmentsBySubscription()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2022-10-01/examples/ConnectedEnvironments_ListBySubscription.json
            // this example is just showing the usage of "ConnectedEnvironments_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ContainerAppConnectedEnvironmentResource item in subscriptionResource.GetContainerAppConnectedEnvironmentsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppConnectedEnvironmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get connected environment by connectedEnvironmentName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetConnectedEnvironmentByConnectedEnvironmentName()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2022-10-01/examples/ConnectedEnvironments_Get.json
            // this example is just showing the usage of "ConnectedEnvironments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "examplekenv";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // invoke the operation
            ContainerAppConnectedEnvironmentResource result = await containerAppConnectedEnvironment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppConnectedEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete connected environment by connectedEnvironmentName
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteConnectedEnvironmentByConnectedEnvironmentName()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2022-10-01/examples/ConnectedEnvironments_Delete.json
            // this example is just showing the usage of "ConnectedEnvironments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "examplekenv";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // invoke the operation
            await containerAppConnectedEnvironment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch Managed Environment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchManagedEnvironment()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2022-10-01/examples/ConnectedEnvironments_Patch.json
            // this example is just showing the usage of "ConnectedEnvironments_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "testenv";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // invoke the operation
            ContainerAppConnectedEnvironmentResource result = await containerAppConnectedEnvironment.UpdateAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppConnectedEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Certificates_CheckNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckNameAvailability_CertificatesCheckNameAvailability()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2022-10-01/examples/ConnectedEnvironmentsCertificates_CheckNameAvailability.json
            // this example is just showing the usage of "ConnectedEnvironments_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "testcontainerenv";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // invoke the operation
            ContainerAppNameAvailabilityContent content = new ContainerAppNameAvailabilityContent()
            {
                Name = "testcertificatename",
                ResourceType = new ResourceType("Microsoft.App/connectedEnvironments/certificates"),
            };
            ContainerAppNameAvailabilityResult result = await containerAppConnectedEnvironment.CheckNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
