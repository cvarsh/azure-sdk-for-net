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
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Kusto.Models;

namespace Azure.ResourceManager.Kusto.Samples
{
    public partial class Sample_KustoDatabasePrincipalAssignmentResource
    {
        // KustoDatabasePrincipalAssignmentsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoDatabasePrincipalAssignmentsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-11-11/examples/KustoDatabasePrincipalAssignmentsGet.json
            // this example is just showing the usage of "DatabasePrincipalAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDatabasePrincipalAssignmentResource created on azure
            // for more information of creating KustoDatabasePrincipalAssignmentResource, please refer to the document of KustoDatabasePrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "Kustodatabase8";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier kustoDatabasePrincipalAssignmentResourceId = KustoDatabasePrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, principalAssignmentName);
            KustoDatabasePrincipalAssignmentResource kustoDatabasePrincipalAssignment = client.GetKustoDatabasePrincipalAssignmentResource(kustoDatabasePrincipalAssignmentResourceId);

            // invoke the operation
            KustoDatabasePrincipalAssignmentResource result = await kustoDatabasePrincipalAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDatabasePrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoDatabasePrincipalAssignmentsCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_KustoDatabasePrincipalAssignmentsCreateOrUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-11-11/examples/KustoDatabasePrincipalAssignmentsCreateOrUpdate.json
            // this example is just showing the usage of "DatabasePrincipalAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDatabasePrincipalAssignmentResource created on azure
            // for more information of creating KustoDatabasePrincipalAssignmentResource, please refer to the document of KustoDatabasePrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "Kustodatabase8";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier kustoDatabasePrincipalAssignmentResourceId = KustoDatabasePrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, principalAssignmentName);
            KustoDatabasePrincipalAssignmentResource kustoDatabasePrincipalAssignment = client.GetKustoDatabasePrincipalAssignmentResource(kustoDatabasePrincipalAssignmentResourceId);

            // invoke the operation
            KustoDatabasePrincipalAssignmentData data = new KustoDatabasePrincipalAssignmentData()
            {
                DatabasePrincipalId = "87654321-1234-1234-1234-123456789123",
                Role = KustoDatabasePrincipalRole.Admin,
                TenantId = Guid.Parse("12345678-1234-1234-1234-123456789123"),
                PrincipalType = KustoPrincipalAssignmentType.App,
            };
            ArmOperation<KustoDatabasePrincipalAssignmentResource> lro = await kustoDatabasePrincipalAssignment.UpdateAsync(WaitUntil.Completed, data);
            KustoDatabasePrincipalAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDatabasePrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoDatabasePrincipalAssignmentsDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_KustoDatabasePrincipalAssignmentsDelete()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-11-11/examples/KustoDatabasePrincipalAssignmentsDelete.json
            // this example is just showing the usage of "DatabasePrincipalAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDatabasePrincipalAssignmentResource created on azure
            // for more information of creating KustoDatabasePrincipalAssignmentResource, please refer to the document of KustoDatabasePrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "Kustodatabase8";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier kustoDatabasePrincipalAssignmentResourceId = KustoDatabasePrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, principalAssignmentName);
            KustoDatabasePrincipalAssignmentResource kustoDatabasePrincipalAssignment = client.GetKustoDatabasePrincipalAssignmentResource(kustoDatabasePrincipalAssignmentResourceId);

            // invoke the operation
            await kustoDatabasePrincipalAssignment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
