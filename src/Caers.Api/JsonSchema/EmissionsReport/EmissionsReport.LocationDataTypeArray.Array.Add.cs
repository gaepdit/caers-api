//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using Corvus.Json;

namespace Caers.Api;
public readonly partial struct EmissionsReport
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct LocationDataTypeArray
    {
        /// <inheritdoc/>
        public LocationDataTypeArray Add(in JsonAny item1)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.Add(item1);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public LocationDataTypeArray Add(params JsonAny[] items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.AddRange(items);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public LocationDataTypeArray AddRange<TArray>(in TArray items)
            where TArray : struct, IJsonArray<TArray>
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            foreach (JsonAny item in items.EnumerateArray())
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public LocationDataTypeArray AddRange<TItem>(IEnumerable<TItem> items)
            where TItem : struct, IJsonValue<TItem>
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            foreach (TItem item in items)
            {
                builder.Add(item.AsAny);
            }

            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public LocationDataTypeArray AddRange(IEnumerable<JsonAny> items)
        {
            ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
            builder.AddRange(items);
            return new(builder.ToImmutable());
        }

        /// <inheritdoc/>
        public LocationDataTypeArray Insert(int index, in JsonAny item1)
        {
            return new(this.GetImmutableListWith(index, item1));
        }

        /// <inheritdoc/>
        public LocationDataTypeArray InsertRange<TArray>(int index, in TArray items)
            where TArray : struct, IJsonArray<TArray>
        {
            return new(this.GetImmutableListWith(index, items.EnumerateArray()));
        }

        /// <inheritdoc/>
        public LocationDataTypeArray InsertRange<TItem>(int index, IEnumerable<TItem> items)
            where TItem : struct, IJsonValue<TItem>
        {
            return new(this.GetImmutableListWith(index, items.Select(item => item.AsAny)));
        }

        /// <inheritdoc/>
        public LocationDataTypeArray InsertRange(int index, IEnumerable<JsonAny> items)
        {
            return new(this.GetImmutableListWith(index, items));
        }

        /// <inheritdoc/>
        public LocationDataTypeArray Replace(in JsonAny oldValue, in JsonAny newValue)
        {
            return this.GetImmutableListReplacing(oldValue.AsAny, newValue.AsAny);
        }

        /// <inheritdoc/>
        public LocationDataTypeArray SetItem(int index, in JsonAny value)
        {
            return this.GetImmutableListSetting(index, value.AsAny);
        }
    }
}