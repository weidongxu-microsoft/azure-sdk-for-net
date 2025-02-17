// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc. </summary>
    public readonly partial struct RoleEligibilityScheduleRequestType : IEquatable<RoleEligibilityScheduleRequestType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleEligibilityScheduleRequestType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleEligibilityScheduleRequestType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AdminAssignValue = "AdminAssign";
        private const string AdminRemoveValue = "AdminRemove";
        private const string AdminUpdateValue = "AdminUpdate";
        private const string AdminExtendValue = "AdminExtend";
        private const string AdminRenewValue = "AdminRenew";
        private const string SelfActivateValue = "SelfActivate";
        private const string SelfDeactivateValue = "SelfDeactivate";
        private const string SelfExtendValue = "SelfExtend";
        private const string SelfRenewValue = "SelfRenew";

        /// <summary> AdminAssign. </summary>
        public static RoleEligibilityScheduleRequestType AdminAssign { get; } = new RoleEligibilityScheduleRequestType(AdminAssignValue);
        /// <summary> AdminRemove. </summary>
        public static RoleEligibilityScheduleRequestType AdminRemove { get; } = new RoleEligibilityScheduleRequestType(AdminRemoveValue);
        /// <summary> AdminUpdate. </summary>
        public static RoleEligibilityScheduleRequestType AdminUpdate { get; } = new RoleEligibilityScheduleRequestType(AdminUpdateValue);
        /// <summary> AdminExtend. </summary>
        public static RoleEligibilityScheduleRequestType AdminExtend { get; } = new RoleEligibilityScheduleRequestType(AdminExtendValue);
        /// <summary> AdminRenew. </summary>
        public static RoleEligibilityScheduleRequestType AdminRenew { get; } = new RoleEligibilityScheduleRequestType(AdminRenewValue);
        /// <summary> SelfActivate. </summary>
        public static RoleEligibilityScheduleRequestType SelfActivate { get; } = new RoleEligibilityScheduleRequestType(SelfActivateValue);
        /// <summary> SelfDeactivate. </summary>
        public static RoleEligibilityScheduleRequestType SelfDeactivate { get; } = new RoleEligibilityScheduleRequestType(SelfDeactivateValue);
        /// <summary> SelfExtend. </summary>
        public static RoleEligibilityScheduleRequestType SelfExtend { get; } = new RoleEligibilityScheduleRequestType(SelfExtendValue);
        /// <summary> SelfRenew. </summary>
        public static RoleEligibilityScheduleRequestType SelfRenew { get; } = new RoleEligibilityScheduleRequestType(SelfRenewValue);
        /// <summary> Determines if two <see cref="RoleEligibilityScheduleRequestType"/> values are the same. </summary>
        public static bool operator ==(RoleEligibilityScheduleRequestType left, RoleEligibilityScheduleRequestType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleEligibilityScheduleRequestType"/> values are not the same. </summary>
        public static bool operator !=(RoleEligibilityScheduleRequestType left, RoleEligibilityScheduleRequestType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoleEligibilityScheduleRequestType"/>. </summary>
        public static implicit operator RoleEligibilityScheduleRequestType(string value) => new RoleEligibilityScheduleRequestType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleEligibilityScheduleRequestType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleEligibilityScheduleRequestType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
