// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> The response from the List namespace operation. </summary>
    public partial class NWRuleSetIPRules
    {
        /// <summary> Initializes a new instance of NWRuleSetIPRules. </summary>
        public NWRuleSetIPRules()
        {
        }

        /// <summary> Initializes a new instance of NWRuleSetIPRules. </summary>
        /// <param name="ipMask"> IP Mask. </param>
        /// <param name="action"> The IP Filter Action. </param>
        internal NWRuleSetIPRules(string ipMask, NetworkRuleIPAction? action)
        {
            IPMask = ipMask;
            Action = action;
        }

        /// <summary> IP Mask. </summary>
        public string IPMask { get; set; }
        /// <summary> The IP Filter Action. </summary>
        public NetworkRuleIPAction? Action { get; set; }
    }
}
