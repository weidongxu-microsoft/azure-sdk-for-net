// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> The current state of the resource&apos;s creation, deletion, or modification. </summary>
    public readonly partial struct ContactsPropertiesProvisioningState : IEquatable<ContactsPropertiesProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContactsPropertiesProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContactsPropertiesProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";

        /// <summary> Creating. </summary>
        public static ContactsPropertiesProvisioningState Creating { get; } = new ContactsPropertiesProvisioningState(CreatingValue);
        /// <summary> Succeeded. </summary>
        public static ContactsPropertiesProvisioningState Succeeded { get; } = new ContactsPropertiesProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ContactsPropertiesProvisioningState Failed { get; } = new ContactsPropertiesProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ContactsPropertiesProvisioningState Canceled { get; } = new ContactsPropertiesProvisioningState(CanceledValue);
        /// <summary> Updating. </summary>
        public static ContactsPropertiesProvisioningState Updating { get; } = new ContactsPropertiesProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static ContactsPropertiesProvisioningState Deleting { get; } = new ContactsPropertiesProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="ContactsPropertiesProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContactsPropertiesProvisioningState left, ContactsPropertiesProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContactsPropertiesProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContactsPropertiesProvisioningState left, ContactsPropertiesProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContactsPropertiesProvisioningState"/>. </summary>
        public static implicit operator ContactsPropertiesProvisioningState(string value) => new ContactsPropertiesProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContactsPropertiesProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContactsPropertiesProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
