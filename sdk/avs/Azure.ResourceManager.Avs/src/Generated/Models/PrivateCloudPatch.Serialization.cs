// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class PrivateCloudPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagementCluster))
            {
                writer.WritePropertyName("managementCluster");
                writer.WriteObjectValue(ManagementCluster);
            }
            if (Optional.IsDefined(Internet))
            {
                writer.WritePropertyName("internet");
                writer.WriteStringValue(Internet.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IdentitySources))
            {
                writer.WritePropertyName("identitySources");
                writer.WriteStartArray();
                foreach (var item in IdentitySources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability");
                writer.WriteObjectValue(Availability);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
