// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The state of the IPv4 session. </summary>
    public readonly partial struct SessionStateV4 : IEquatable<SessionStateV4>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SessionStateV4"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SessionStateV4(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string IdleValue = "Idle";
        private const string ConnectValue = "Connect";
        private const string ActiveValue = "Active";
        private const string OpenSentValue = "OpenSent";
        private const string OpenConfirmValue = "OpenConfirm";
        private const string OpenReceivedValue = "OpenReceived";
        private const string EstablishedValue = "Established";
        private const string PendingAddValue = "PendingAdd";
        private const string PendingUpdateValue = "PendingUpdate";
        private const string PendingRemoveValue = "PendingRemove";

        /// <summary> None. </summary>
        public static SessionStateV4 None { get; } = new SessionStateV4(NoneValue);
        /// <summary> Idle. </summary>
        public static SessionStateV4 Idle { get; } = new SessionStateV4(IdleValue);
        /// <summary> Connect. </summary>
        public static SessionStateV4 Connect { get; } = new SessionStateV4(ConnectValue);
        /// <summary> Active. </summary>
        public static SessionStateV4 Active { get; } = new SessionStateV4(ActiveValue);
        /// <summary> OpenSent. </summary>
        public static SessionStateV4 OpenSent { get; } = new SessionStateV4(OpenSentValue);
        /// <summary> OpenConfirm. </summary>
        public static SessionStateV4 OpenConfirm { get; } = new SessionStateV4(OpenConfirmValue);
        /// <summary> OpenReceived. </summary>
        public static SessionStateV4 OpenReceived { get; } = new SessionStateV4(OpenReceivedValue);
        /// <summary> Established. </summary>
        public static SessionStateV4 Established { get; } = new SessionStateV4(EstablishedValue);
        /// <summary> PendingAdd. </summary>
        public static SessionStateV4 PendingAdd { get; } = new SessionStateV4(PendingAddValue);
        /// <summary> PendingUpdate. </summary>
        public static SessionStateV4 PendingUpdate { get; } = new SessionStateV4(PendingUpdateValue);
        /// <summary> PendingRemove. </summary>
        public static SessionStateV4 PendingRemove { get; } = new SessionStateV4(PendingRemoveValue);
        /// <summary> Determines if two <see cref="SessionStateV4"/> values are the same. </summary>
        public static bool operator ==(SessionStateV4 left, SessionStateV4 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SessionStateV4"/> values are not the same. </summary>
        public static bool operator !=(SessionStateV4 left, SessionStateV4 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SessionStateV4"/>. </summary>
        public static implicit operator SessionStateV4(string value) => new SessionStateV4(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SessionStateV4 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SessionStateV4 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
