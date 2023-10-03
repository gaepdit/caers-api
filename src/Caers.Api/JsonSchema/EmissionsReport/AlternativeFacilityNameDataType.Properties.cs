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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Caers.Api;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct AlternativeFacilityNameDataType
{
    /// <summary>
    /// JSON property name for <see cref = "AlternativeName"/>.
    /// </summary>
    public static ReadOnlySpan<byte> AlternativeNameUtf8JsonPropertyName => "alternativeName"u8;

    /// <summary>
    /// JSON property name for <see cref = "AlternativeName"/>.
    /// </summary>
    public const string AlternativeNameJsonPropertyName = "alternativeName";
    /// <summary>
    /// JSON property name for <see cref = "AlternativeNameTypeText"/>.
    /// </summary>
    public static ReadOnlySpan<byte> AlternativeNameTypeTextUtf8JsonPropertyName => "alternativeNameTypeText"u8;

    /// <summary>
    /// JSON property name for <see cref = "AlternativeNameTypeText"/>.
    /// </summary>
    public const string AlternativeNameTypeTextJsonPropertyName = "alternativeNameTypeText";
    /// <summary>
    /// JSON property name for <see cref = "EffectiveDate"/>.
    /// </summary>
    public static ReadOnlySpan<byte> EffectiveDateUtf8JsonPropertyName => "effectiveDate"u8;

    /// <summary>
    /// JSON property name for <see cref = "EffectiveDate"/>.
    /// </summary>
    public const string EffectiveDateJsonPropertyName = "effectiveDate";
    /// <summary>
    /// JSON property name for <see cref = "ProgramSystemCode"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ProgramSystemCodeUtf8JsonPropertyName => "programSystemCode"u8;

    /// <summary>
    /// JSON property name for <see cref = "ProgramSystemCode"/>.
    /// </summary>
    public const string ProgramSystemCodeJsonPropertyName = "programSystemCode";
    /// <summary>
    /// Gets AlternativeName.
    /// </summary>
    public Corvus.Json.JsonString AlternativeName
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AlternativeNameUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AlternativeNameJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets AlternativeNameTypeText.
    /// </summary>
    public Corvus.Json.JsonString AlternativeNameTypeText
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AlternativeNameTypeTextUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AlternativeNameTypeTextJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets EffectiveDate.
    /// </summary>
    public Corvus.Json.JsonDateTime EffectiveDate
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(EffectiveDateUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonDateTime(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(EffectiveDateJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonDateTime>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ProgramSystemCode.
    /// </summary>
    public Corvus.Json.JsonString ProgramSystemCode
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ProgramSystemCodeUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ProgramSystemCodeJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "AlternativeFacilityNameDataType"/>.
    /// </summary>
    public static AlternativeFacilityNameDataType Create(Corvus.Json.JsonString alternativeName, Corvus.Json.JsonString programSystemCode, Corvus.Json.JsonString? alternativeNameTypeText = null, Corvus.Json.JsonDateTime? effectiveDate = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        builder.Add(AlternativeNameJsonPropertyName, alternativeName.AsAny);
        builder.Add(ProgramSystemCodeJsonPropertyName, programSystemCode.AsAny);
        if (alternativeNameTypeText is Corvus.Json.JsonString alternativeNameTypeText__)
        {
            builder.Add(AlternativeNameTypeTextJsonPropertyName, alternativeNameTypeText__.AsAny);
        }

        if (effectiveDate is Corvus.Json.JsonDateTime effectiveDate__)
        {
            builder.Add(EffectiveDateJsonPropertyName, effectiveDate__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets alternativeName.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public AlternativeFacilityNameDataType WithAlternativeName(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(AlternativeNameJsonPropertyName, value);
    }

    /// <summary>
    /// Sets alternativeNameTypeText.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public AlternativeFacilityNameDataType WithAlternativeNameTypeText(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(AlternativeNameTypeTextJsonPropertyName, value);
    }

    /// <summary>
    /// Sets effectiveDate.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public AlternativeFacilityNameDataType WithEffectiveDate(in Corvus.Json.JsonDateTime value)
    {
        return this.SetProperty(EffectiveDateJsonPropertyName, value);
    }

    /// <summary>
    /// Sets programSystemCode.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public AlternativeFacilityNameDataType WithProgramSystemCode(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(ProgramSystemCodeJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateAlternativeName(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateProgramSystemCode(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAlternativeNameTypeText(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateEffectiveDate(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonDateTime>().Validate(validationContext, level);
    }

    /// <summary>
    /// Tries to get the validator for the given property.
    /// </summary>
    /// <param name = "property">The property for which to get the validator.</param>
    /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
    /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
    /// <returns><c>True</c> if the validator was found.</returns>
    private bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
    {
        if (hasJsonElementBacking)
        {
            if (property.NameEquals(AlternativeNameUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateAlternativeName;
                return true;
            }
            else if (property.NameEquals(ProgramSystemCodeUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateProgramSystemCode;
                return true;
            }
            else if (property.NameEquals(AlternativeNameTypeTextUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateAlternativeNameTypeText;
                return true;
            }
            else if (property.NameEquals(EffectiveDateUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateEffectiveDate;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(AlternativeNameJsonPropertyName))
            {
                propertyValidator = __CorvusValidateAlternativeName;
                return true;
            }
            else if (property.NameEquals(ProgramSystemCodeJsonPropertyName))
            {
                propertyValidator = __CorvusValidateProgramSystemCode;
                return true;
            }
            else if (property.NameEquals(AlternativeNameTypeTextJsonPropertyName))
            {
                propertyValidator = __CorvusValidateAlternativeNameTypeText;
                return true;
            }
            else if (property.NameEquals(EffectiveDateJsonPropertyName))
            {
                propertyValidator = __CorvusValidateEffectiveDate;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}