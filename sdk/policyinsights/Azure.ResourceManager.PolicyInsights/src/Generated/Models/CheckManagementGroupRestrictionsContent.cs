// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The check policy restrictions parameters describing the resource that is being evaluated. </summary>
    public partial class CheckManagementGroupRestrictionsContent
    {
        /// <summary> Initializes a new instance of CheckManagementGroupRestrictionsContent. </summary>
        public CheckManagementGroupRestrictionsContent()
        {
            PendingFields = new ChangeTrackingList<PendingField>();
        }

        /// <summary> The information about the resource that will be evaluated. </summary>
        public CheckRestrictionsResourceDetails ResourceDetails { get; set; }
        /// <summary> The list of fields and values that should be evaluated for potential restrictions. </summary>
        public IList<PendingField> PendingFields { get; }
    }
}
