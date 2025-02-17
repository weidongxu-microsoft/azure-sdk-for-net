// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class KustoPrivateLinkResourceListResult
    {
        internal static KustoPrivateLinkResourceListResult DeserializeKustoPrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<KustoPrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KustoPrivateLinkResourceData> array = new List<KustoPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoPrivateLinkResourceData.DeserializeKustoPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new KustoPrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
