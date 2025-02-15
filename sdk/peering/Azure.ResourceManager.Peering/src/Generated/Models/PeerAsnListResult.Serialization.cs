// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    internal partial class PeerAsnListResult
    {
        internal static PeerAsnListResult DeserializePeerAsnListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PeerAsnData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PeerAsnData> array = new List<PeerAsnData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeerAsnData.DeserializePeerAsnData(item));
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
            return new PeerAsnListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
