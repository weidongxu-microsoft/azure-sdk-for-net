// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary>
    /// Request body to get the availability for scheduling orders.
    /// Please note <see cref="ScheduleAvailabilityRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataBoxScheduleAvailabilityRequest"/>, <see cref="DiskScheduleAvailabilityRequest"/> and <see cref="HeavyScheduleAvailabilityRequest"/>.
    /// </summary>
    public partial class ScheduleAvailabilityRequest
    {
        /// <summary> Initializes a new instance of ScheduleAvailabilityRequest. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageLocation"/> is null. </exception>
        public ScheduleAvailabilityRequest(string storageLocation)
        {
            if (storageLocation == null)
            {
                throw new ArgumentNullException(nameof(storageLocation));
            }

            StorageLocation = storageLocation;
        }

        /// <summary> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </summary>
        public string StorageLocation { get; }
        /// <summary> Sku Name for which the order is to be scheduled. </summary>
        internal DataBoxSkuName SkuName { get; set; }
        /// <summary> Country in which storage location should be supported. </summary>
        public string Country { get; set; }
    }
}
