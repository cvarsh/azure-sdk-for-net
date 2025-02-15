// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerVolumeMount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("mountPath");
            writer.WriteStringValue(MountPath);
            if (Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("readOnly");
                writer.WriteBooleanValue(IsReadOnly.Value);
            }
            writer.WriteEndObject();
        }

        internal static ContainerVolumeMount DeserializeContainerVolumeMount(JsonElement element)
        {
            string name = default;
            string mountPath = default;
            Optional<bool> readOnly = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountPath"))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ContainerVolumeMount(name, mountPath, Optional.ToNullable(readOnly));
        }
    }
}
