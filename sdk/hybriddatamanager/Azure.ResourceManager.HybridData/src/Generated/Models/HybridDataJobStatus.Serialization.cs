// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridData.Models
{
    internal static partial class HybridDataJobStatusExtensions
    {
        public static string ToSerialString(this HybridDataJobStatus value) => value switch
        {
            HybridDataJobStatus.None => "None",
            HybridDataJobStatus.InProgress => "InProgress",
            HybridDataJobStatus.Succeeded => "Succeeded",
            HybridDataJobStatus.WaitingForAction => "WaitingForAction",
            HybridDataJobStatus.Failed => "Failed",
            HybridDataJobStatus.Cancelled => "Cancelled",
            HybridDataJobStatus.Cancelling => "Cancelling",
            HybridDataJobStatus.PartiallySucceeded => "PartiallySucceeded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HybridDataJobStatus value.")
        };

        public static HybridDataJobStatus ToHybridDataJobStatus(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.None;
            if (string.Equals(value, "InProgress", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.InProgress;
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.Succeeded;
            if (string.Equals(value, "WaitingForAction", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.WaitingForAction;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.Failed;
            if (string.Equals(value, "Cancelled", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.Cancelled;
            if (string.Equals(value, "Cancelling", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.Cancelling;
            if (string.Equals(value, "PartiallySucceeded", StringComparison.InvariantCultureIgnoreCase)) return HybridDataJobStatus.PartiallySucceeded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HybridDataJobStatus value.");
        }
    }
}
