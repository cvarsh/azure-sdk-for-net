// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> A list of deployments resource ids. </summary>
    internal partial class DeploymentList
    {
        /// <summary> Initializes a new instance of DeploymentList. </summary>
        internal DeploymentList()
        {
            Deployments = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of DeploymentList. </summary>
        /// <param name="deployments"> A list of deployment resource ids. </param>
        internal DeploymentList(IReadOnlyList<ResourceIdentifier> deployments)
        {
            Deployments = deployments;
        }

        /// <summary> A list of deployment resource ids. </summary>
        public IReadOnlyList<ResourceIdentifier> Deployments { get; }
    }
}
