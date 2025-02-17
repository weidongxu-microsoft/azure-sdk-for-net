// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class ScaleStreamingJobContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StreamingUnits))
            {
                writer.WritePropertyName("streamingUnits");
                writer.WriteNumberValue(StreamingUnits.Value);
            }
            writer.WriteEndObject();
        }
    }
}
