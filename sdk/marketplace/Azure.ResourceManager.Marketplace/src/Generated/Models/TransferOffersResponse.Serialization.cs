// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class TransferOffersResponse
    {
        internal static TransferOffersResponse DeserializeTransferOffersResponse(JsonElement element)
        {
            Optional<IReadOnlyList<CollectionsDetails>> succeeded = default;
            Optional<IReadOnlyList<CollectionsDetails>> failed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeeded"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CollectionsDetails> array = new List<CollectionsDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CollectionsDetails.DeserializeCollectionsDetails(item));
                    }
                    succeeded = array;
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CollectionsDetails> array = new List<CollectionsDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CollectionsDetails.DeserializeCollectionsDetails(item));
                    }
                    failed = array;
                    continue;
                }
            }
            return new TransferOffersResponse(Optional.ToList(succeeded), Optional.ToList(failed));
        }
    }
}
