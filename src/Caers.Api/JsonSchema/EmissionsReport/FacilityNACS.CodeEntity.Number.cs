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
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Caers.Api;
public readonly partial struct FacilityNACS
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct CodeEntity : IJsonNumber<CodeEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "CodeEntity"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public CodeEntity(double value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.Number;
            this.numberBacking = value;
            this.stringBacking = string.Empty;
        }

        /// <summary>
        /// Conversion from JsonNumber.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator JsonNumber(CodeEntity value)
        {
            return value.AsNumber;
        }

        /// <summary>
        /// Conversion to JsonNumber.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator CodeEntity(JsonNumber value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return new((double)value);
        }

        /// <summary>
        /// Conversion from double.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(double value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to double.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a double.</exception>
        public static implicit operator double (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.GetDouble();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from float.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(float value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to double.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a float.</exception>
        public static implicit operator float (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.GetSingle();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < float.MinValue || value.numberBacking > float.MaxValue)
                {
                    throw new FormatException();
                }

                return (float)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from int.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(int value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to int.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a int.</exception>
        public static implicit operator int (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt32();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < int.MinValue || value.numberBacking > int.MaxValue)
                {
                    throw new FormatException();
                }

                return (int)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from long.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(long value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to long.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a long.</exception>
        public static implicit operator long (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt64();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < long.MinValue || value.numberBacking > long.MaxValue)
                {
                    throw new FormatException();
                }

                return (long)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from uint.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator CodeEntity(uint value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to uint.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a uint.</exception>
        public static implicit operator uint (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt32();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < uint.MinValue || value.numberBacking > uint.MaxValue)
                {
                    throw new FormatException();
                }

                return (uint)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from ushort.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(ushort value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to ushort.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a ushort.</exception>
        public static implicit operator ushort (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt16();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < ushort.MinValue || value.numberBacking > ushort.MaxValue)
                {
                    throw new FormatException();
                }

                return (ushort)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from ulong.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(ulong value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to ulong.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a ulong.</exception>
        public static implicit operator ulong (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt64();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < ulong.MinValue || value.numberBacking > ulong.MaxValue)
                {
                    throw new FormatException();
                }

                return (ulong)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from byte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(byte value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to byte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a byte.</exception>
        public static implicit operator byte (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetByte();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < byte.MinValue || value.numberBacking > byte.MaxValue)
                {
                    throw new FormatException();
                }

                return (byte)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from sbyte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static implicit operator CodeEntity(sbyte value)
        {
            return new(value);
        }

        /// <summary>
        /// Conversion to sbyte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an sbyte.</exception>
        public static implicit operator sbyte (CodeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetSByte();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                if (value.numberBacking < sbyte.MinValue || value.numberBacking > sbyte.MaxValue)
                {
                    throw new FormatException();
                }

                return (sbyte)value.numberBacking;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Less than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is less than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator <(in CodeEntity left, in CodeEntity right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && (double)left < (double)right;
        }

        /// <summary>
        /// Greater than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is greater than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator>(in CodeEntity left, in CodeEntity right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && (double)left > (double)right;
        }
    }
}