// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> The set of available keys for this server. </summary>
    public partial class FluidRelayServerKeys
    {
        /// <summary> Initializes a new instance of FluidRelayServerKeys. </summary>
        internal FluidRelayServerKeys()
        {
        }

        /// <summary> Initializes a new instance of FluidRelayServerKeys. </summary>
        /// <param name="key1"> The primary key for this server. </param>
        /// <param name="key2"> The secondary key for this server. </param>
        internal FluidRelayServerKeys(string key1, string key2)
        {
            Key1 = key1;
            Key2 = key2;
        }

        /// <summary> The primary key for this server. </summary>
        public string Key1 { get; }
        /// <summary> The secondary key for this server. </summary>
        public string Key2 { get; }
    }
}
