// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class RefreshDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InProgressRefreshJobId))
            {
                writer.WritePropertyName("inProgressRefreshJobId");
                writer.WriteStringValue(InProgressRefreshJobId);
            }
            if (Optional.IsDefined(LastCompletedRefreshJobTimeInUTC))
            {
                writer.WritePropertyName("lastCompletedRefreshJobTimeInUTC");
                writer.WriteStringValue(LastCompletedRefreshJobTimeInUTC.Value, "O");
            }
            if (Optional.IsDefined(ErrorManifestFile))
            {
                writer.WritePropertyName("errorManifestFile");
                writer.WriteStringValue(ErrorManifestFile);
            }
            if (Optional.IsDefined(LastJob))
            {
                writer.WritePropertyName("lastJob");
                writer.WriteStringValue(LastJob);
            }
            writer.WriteEndObject();
        }

        internal static RefreshDetails DeserializeRefreshDetails(JsonElement element)
        {
            Optional<string> inProgressRefreshJobId = default;
            Optional<DateTimeOffset> lastCompletedRefreshJobTimeInUTC = default;
            Optional<string> errorManifestFile = default;
            Optional<string> lastJob = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inProgressRefreshJobId"))
                {
                    inProgressRefreshJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCompletedRefreshJobTimeInUTC"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastCompletedRefreshJobTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorManifestFile"))
                {
                    errorManifestFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastJob"))
                {
                    lastJob = property.Value.GetString();
                    continue;
                }
            }
            return new RefreshDetails(inProgressRefreshJobId.Value, Optional.ToNullable(lastCompletedRefreshJobTimeInUTC), errorManifestFile.Value, lastJob.Value);
        }
    }
}
