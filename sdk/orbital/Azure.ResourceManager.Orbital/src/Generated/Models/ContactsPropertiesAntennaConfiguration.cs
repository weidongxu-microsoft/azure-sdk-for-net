// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> The configuration associated with the allocated antenna. </summary>
    public partial class ContactsPropertiesAntennaConfiguration
    {
        /// <summary> Initializes a new instance of ContactsPropertiesAntennaConfiguration. </summary>
        internal ContactsPropertiesAntennaConfiguration()
        {
            SourceIPs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ContactsPropertiesAntennaConfiguration. </summary>
        /// <param name="destinationIP"> The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to. </param>
        /// <param name="sourceIPs"> List of Source IP. </param>
        internal ContactsPropertiesAntennaConfiguration(string destinationIP, IReadOnlyList<string> sourceIPs)
        {
            DestinationIP = destinationIP;
            SourceIPs = sourceIPs;
        }

        /// <summary> The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to. </summary>
        public string DestinationIP { get; }
        /// <summary> List of Source IP. </summary>
        public IReadOnlyList<string> SourceIPs { get; }
    }
}
