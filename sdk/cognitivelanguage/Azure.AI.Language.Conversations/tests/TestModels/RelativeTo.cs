// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The reference point that the ordinal number denotes. </summary>
    public readonly partial struct RelativeTo : IEquatable<RelativeTo>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelativeTo"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelativeTo(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "Current";
        private const string EndValue = "End";
        private const string StartValue = "Start";

        /// <summary> Current. </summary>
        public static RelativeTo Current { get; } = new RelativeTo(CurrentValue);
        /// <summary> End. </summary>
        public static RelativeTo End { get; } = new RelativeTo(EndValue);
        /// <summary> Start. </summary>
        public static RelativeTo Start { get; } = new RelativeTo(StartValue);
        /// <summary> Determines if two <see cref="RelativeTo"/> values are the same. </summary>
        public static bool operator ==(RelativeTo left, RelativeTo right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelativeTo"/> values are not the same. </summary>
        public static bool operator !=(RelativeTo left, RelativeTo right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RelativeTo"/>. </summary>
        public static implicit operator RelativeTo(string value) => new RelativeTo(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelativeTo other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelativeTo other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
