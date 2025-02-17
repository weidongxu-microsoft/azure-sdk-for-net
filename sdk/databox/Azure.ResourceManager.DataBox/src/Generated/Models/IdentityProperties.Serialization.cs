// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class IdentityProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityPropertiesType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(IdentityPropertiesType);
            }
            if (Optional.IsDefined(UserAssigned))
            {
                writer.WritePropertyName("userAssigned");
                writer.WriteObjectValue(UserAssigned);
            }
            writer.WriteEndObject();
        }

        internal static IdentityProperties DeserializeIdentityProperties(JsonElement element)
        {
            Optional<string> type = default;
            Optional<UserAssignedProperties> userAssigned = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssigned"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userAssigned = UserAssignedProperties.DeserializeUserAssignedProperties(property.Value);
                    continue;
                }
            }
            return new IdentityProperties(type.Value, userAssigned.Value);
        }
    }
}
