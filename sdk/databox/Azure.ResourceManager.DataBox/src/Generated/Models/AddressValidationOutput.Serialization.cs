// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class AddressValidationOutput
    {
        internal static AddressValidationOutput DeserializeAddressValidationOutput(JsonElement element)
        {
            Optional<ValidationInputDiscriminator> validationType = default;
            Optional<ResponseError> error = default;
            Optional<AddressValidationStatus> validationStatus = default;
            Optional<IReadOnlyList<ShippingAddress>> alternateAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("validationType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            validationType = property0.Value.GetString().ToValidationInputDiscriminator();
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = JsonSerializer.Deserialize<ResponseError>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("validationStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            validationStatus = property0.Value.GetString().ToAddressValidationStatus();
                            continue;
                        }
                        if (property0.NameEquals("alternateAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ShippingAddress> array = new List<ShippingAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ShippingAddress.DeserializeShippingAddress(item));
                            }
                            alternateAddresses = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AddressValidationOutput(Optional.ToNullable(validationType), error.Value, Optional.ToNullable(validationStatus), Optional.ToList(alternateAddresses));
        }
    }
}
