// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class SourceControlCollection
    {
        internal static SourceControlCollection DeserializeSourceControlCollection(JsonElement element)
        {
            IReadOnlyList<ContainerAppSourceControlData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ContainerAppSourceControlData> array = new List<ContainerAppSourceControlData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppSourceControlData.DeserializeContainerAppSourceControlData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SourceControlCollection(value, nextLink.Value);
        }
    }
}
