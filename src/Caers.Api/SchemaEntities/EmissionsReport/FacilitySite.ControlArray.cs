//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Buffers;
using System.ComponentModel;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Caers.Api.SchemaEntities;
public readonly partial struct FacilitySite
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    [System.Text.Json.Serialization.JsonConverter(typeof(Corvus.Json.Internal.JsonValueConverter<ControlArray>))]
    public readonly partial struct ControlArray
    {
        private readonly Backing backing;
        private readonly JsonElement jsonElementBacking;
        private readonly ImmutableList<JsonAny> arrayBacking;
        /// <summary>
        /// Initializes a new instance of the <see cref = "ControlArray"/> struct.
        /// </summary>
        public ControlArray()
        {
            this.jsonElementBacking = default;
            this.backing = Backing.JsonElement;
            this.arrayBacking = ImmutableList<JsonAny>.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ControlArray"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public ControlArray(in JsonElement value)
        {
            this.jsonElementBacking = value;
            this.backing = Backing.JsonElement;
            this.arrayBacking = ImmutableList<JsonAny>.Empty;
        }

        /// <summary>
        /// Gets a Null instance.
        /// </summary>
        public static ControlArray Null { get; } = new(JsonValueHelpers.NullElement);
        /// <summary>
        /// Gets an Undefined instance.
        /// </summary>
        public static ControlArray Undefined { get; }
        /// <summary>
        /// Gets the default instance of the type.
        /// </summary>
        public static ControlArray DefaultInstance { get; }

        /// <inheritdoc/>
        public JsonAny AsAny
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                if ((this.backing & Backing.Array) != 0)
                {
                    return new(this.arrayBacking);
                }

                if ((this.backing & Backing.Null) != 0)
                {
                    return JsonAny.Null;
                }

                return JsonAny.Undefined;
            }
        }

        /// <inheritdoc/>
        public JsonElement AsJsonElement
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return this.jsonElementBacking;
                }

                if ((this.backing & Backing.Array) != 0)
                {
                    return JsonValueHelpers.ArrayToJsonElement(this.arrayBacking);
                }

                if ((this.backing & Backing.Null) != 0)
                {
                    return JsonValueHelpers.NullElement;
                }

                return default;
            }
        }

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public JsonString AsString
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public JsonBoolean AsBoolean
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public JsonNumber AsNumber
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public JsonObject AsObject
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        public JsonArray AsArray
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return new(this.jsonElementBacking);
                }

                if ((this.backing & Backing.Array) != 0)
                {
                    return new(this.arrayBacking);
                }

                throw new InvalidOperationException();
            }
        }

        /// <inheritdoc/>
        public bool HasJsonElementBacking
        {
            get
            {
                return (this.backing & Backing.JsonElement) != 0;
            }
        }

        /// <inheritdoc/>
        public bool HasDotnetBacking
        {
            get
            {
                return (this.backing & Backing.Dotnet) != 0;
            }
        }

        /// <inheritdoc/>
        public JsonValueKind ValueKind
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    return this.jsonElementBacking.ValueKind;
                }

                if ((this.backing & Backing.Array) != 0)
                {
                    return JsonValueKind.Array;
                }

                if ((this.backing & Backing.Null) != 0)
                {
                    return JsonValueKind.Null;
                }

                return JsonValueKind.Undefined;
            }
        }

        /// <summary>
        /// Conversion from JsonAny.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator ControlArray(JsonAny value)
        {
            return ControlArray.FromAny(value);
        }

        /// <summary>
        /// Conversion to JsonAny.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not compatible with this type.</exception>
        public static implicit operator JsonAny(in ControlArray value)
        {
            return value.AsAny;
        }

        /// <summary>
        /// Equality operator.
        /// </summary>
        /// <param name = "left">The lhs.</param>
        /// <param name = "right">The rhs.</param>
        /// <returns><c>True</c> if the values are equal.</returns>
        public static bool operator ==(in ControlArray left, in ControlArray right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Inequality operator.
        /// </summary>
        /// <param name = "left">The lhs.</param>
        /// <param name = "right">The rhs.</param>
        /// <returns><c>True</c> if the values are equal.</returns>
        public static bool operator !=(in ControlArray left, in ControlArray right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Gets an instance of the JSON value from a JsonAny value.
        /// </summary>
        /// <param name = "value">The <see cref = "JsonAny"/> value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the <see cref = "JsonAny"/>.</returns>
        /// <remarks>The returned value will have a <see cref = "IJsonValue.ValueKind"/> of <see cref = "JsonValueKind.Undefined"/> if the
        /// value cannot be constructed from the given instance (e.g. because they have an incompatible dotnet backing type.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ControlArray FromAny(in JsonAny value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            JsonValueKind valueKind = value.ValueKind;
            return valueKind switch
            {
                JsonValueKind.Array => new((ImmutableList<JsonAny>)value),
                JsonValueKind.Null => Null,
                _ => Undefined,
            };
        }

        /// <summary>
        /// Gets an instance of the JSON value from a <see cref = "JsonElement"/> value.
        /// </summary>
        /// <param name = "value">The <see cref = "JsonElement"/> value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the <see cref = "JsonElement"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ControlArray FromJson(in JsonElement value)
        {
            return new(value);
        }

        /// <summary>
        /// Gets an instance of the JSON value from a boolean value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be ControlArray.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ControlArray FromBoolean<TValue>(in TValue value)
            where TValue : struct, IJsonBoolean<TValue>
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from a string value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be ControlArray.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ControlArray FromString<TValue>(in TValue value)
            where TValue : struct, IJsonString<TValue>
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from a number value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be ControlArray.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ControlArray FromNumber<TValue>(in TValue value)
            where TValue : struct, IJsonNumber<TValue>
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from an array value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be ControlArray.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ControlArray FromArray<TValue>(in TValue value)
            where TValue : struct, IJsonArray<TValue>
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            if (value.ValueKind == JsonValueKind.Array)
            {
                return new((ImmutableList<JsonAny>)value);
            }

            return Undefined;
        }

        /// <summary>
        /// Gets an instance of the JSON value from an object value.
        /// </summary>
        /// <typeparam name = "TValue">The type of the value.</typeparam>
        /// <param name = "value">The value from which to instantiate the instance.</param>
        /// <returns>An instance of this type, initialized from the value.</returns>
        /// <remarks>This will be ControlArray.Undefined if the type is not compatible.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ControlArray FromObject<TValue>(in TValue value)
            where TValue : struct, IJsonObject<TValue>
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return Undefined;
        }

        /// <summary>
        /// Parses a JSON string into a ControlArray.
        /// </summary>
        /// <param name = "json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "ControlArray"/> instance built from the JSON string.</returns>
        public static ControlArray Parse(string json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(json, options);
            return new ControlArray(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a ControlArray.
        /// </summary>
        /// <param name = "utf8Json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "ControlArray"/> instance built from the JSON string.</returns>
        public static ControlArray Parse(Stream utf8Json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(utf8Json, options);
            return new ControlArray(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a ControlArray.
        /// </summary>
        /// <param name = "utf8Json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "ControlArray"/> instance built from the JSON string.</returns>
        public static ControlArray Parse(ReadOnlyMemory<byte> utf8Json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(utf8Json, options);
            return new ControlArray(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a ControlArray.
        /// </summary>
        /// <param name = "json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "ControlArray"/> instance built from the JSON string.</returns>
        public static ControlArray Parse(ReadOnlyMemory<char> json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(json, options);
            return new ControlArray(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON string into a ControlArray.
        /// </summary>
        /// <param name = "utf8Json">The json string to parse.</param>
        /// <param name = "options">The (optional) JsonDocumentOptions.</param>
        /// <returns>A <see cref = "ControlArray"/> instance built from the JSON string.</returns>
        public static ControlArray Parse(ReadOnlySequence<byte> utf8Json, JsonDocumentOptions options = default)
        {
            using var jsonDocument = JsonDocument.Parse(utf8Json, options);
            return new ControlArray(jsonDocument.RootElement.Clone());
        }

        /// <summary>
        /// Parses a JSON value from a buffer.
        /// </summary>
        /// <param name = "buffer">The buffer from which to parse the value.</param>
        /// <returns>The parsed value.</returns>
        static ControlArray ParseValue(ReadOnlySpan<char> buffer)
        {
            return IJsonValue<ControlArray>.ParseValue(buffer);
        }

        /// <summary>
        /// Parses a JSON value from a buffer.
        /// </summary>
        /// <param name = "buffer">The buffer from which to parse the value.</param>
        /// <returns>The parsed value.</returns>
        static ControlArray ParseValue(ReadOnlySpan<byte> buffer)
        {
            return IJsonValue<ControlArray>.ParseValue(buffer);
        }

        /// <summary>
        /// Parses a JSON value from a buffer.
        /// </summary>
        /// <param name = "reader">The reader from which to parse the value.</param>
        /// <returns>The parsed value.</returns>
        static ControlArray ParseValue(ref Utf8JsonReader reader)
        {
            return IJsonValue<ControlArray>.ParseValue(ref reader);
        }

        /// <summary>
        /// Gets the value as the target value.
        /// </summary>
        /// <typeparam name = "TTarget">The type of the target.</typeparam>
        /// <returns>An instance of the target type.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TTarget As<TTarget>()
            where TTarget : struct, IJsonValue<TTarget>
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return TTarget.FromJson(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Array) != 0)
            {
                return TTarget.FromArray(this);
            }

            if ((this.backing & Backing.Null) != 0)
            {
                return TTarget.Null;
            }

            return TTarget.Undefined;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return (obj is IJsonValue jv && this.Equals(jv.AsAny)) || (obj is null && this.IsNull());
        }

        /// <inheritdoc/>
        public bool Equals<T>(T other)
            where T : struct, IJsonValue<T>
        {
            return JsonValueHelpers.CompareValues(this, other);
        }

        /// <inheritdoc/>
        public bool Equals(ControlArray other)
        {
            return JsonValueHelpers.CompareValues(this, other);
        }

        /// <inheritdoc/>
        public void WriteTo(Utf8JsonWriter writer)
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Undefined)
                {
                    this.jsonElementBacking.WriteTo(writer);
                }

                return;
            }

            if ((this.backing & Backing.Array) != 0)
            {
                JsonValueHelpers.WriteItems(this.arrayBacking, writer);
                return;
            }

            if ((this.backing & Backing.Null) != 0)
            {
                writer.WriteNullValue();
                return;
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return JsonValueHelpers.GetHashCode(this);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Serialize();
        }
    }
}