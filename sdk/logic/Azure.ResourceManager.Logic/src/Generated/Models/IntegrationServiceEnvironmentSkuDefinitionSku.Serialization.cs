// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentSkuDefinitionSku
    {
        internal static IntegrationServiceEnvironmentSkuDefinitionSku DeserializeIntegrationServiceEnvironmentSkuDefinitionSku(JsonElement element)
        {
            Optional<IntegrationServiceEnvironmentSkuName> name = default;
            Optional<string> tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = new IntegrationServiceEnvironmentSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentSkuDefinitionSku(Optional.ToNullable(name), tier.Value);
        }
    }
}
