//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Runtime.CompilerServices;
using Corvus.Json;

namespace Caers.Api;
public readonly partial struct EmissionsProcess
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct RegulationDataTypeArray
    {
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RegulationDataTypeArray Remove(in JsonAny item1)
        {
            return new(this.GetImmutableListWithout(item1));
        }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RegulationDataTypeArray RemoveAt(int index)
        {
            return new(this.GetImmutableListWithoutRange(index, 1));
        }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RegulationDataTypeArray RemoveRange(int index, int count)
        {
            return new(this.GetImmutableListWithoutRange(index, count));
        }
    }
}