// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigurationServiceSettingsValidateResult
    {
        internal static AppPlatformConfigurationServiceSettingsValidateResult DeserializeAppPlatformConfigurationServiceSettingsValidateResult(JsonElement element)
        {
            Optional<AppPlatformConfigurationServiceGitValidateResult> gitPropertyValidationResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitPropertyValidationResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gitPropertyValidationResult = AppPlatformConfigurationServiceGitValidateResult.DeserializeAppPlatformConfigurationServiceGitValidateResult(property.Value);
                    continue;
                }
            }
            return new AppPlatformConfigurationServiceSettingsValidateResult(gitPropertyValidationResult.Value);
        }
    }
}
