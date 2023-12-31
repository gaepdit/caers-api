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

namespace Caers.Api.SchemaEntities;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct ControlPollutant
{
    /// <summary>
    /// JSON property name for <see cref = "PercentControlMeasuresReductionEfficiency"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PercentControlMeasuresReductionEfficiencyUtf8JsonPropertyName => "percentControlMeasuresReductionEfficiency"u8;

    /// <summary>
    /// JSON property name for <see cref = "PercentControlMeasuresReductionEfficiency"/>.
    /// </summary>
    public const string PercentControlMeasuresReductionEfficiencyJsonPropertyName = "percentControlMeasuresReductionEfficiency";
    /// <summary>
    /// JSON property name for <see cref = "PollutantCode"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PollutantCodeUtf8JsonPropertyName => "pollutantCode"u8;

    /// <summary>
    /// JSON property name for <see cref = "PollutantCode"/>.
    /// </summary>
    public const string PollutantCodeJsonPropertyName = "pollutantCode";
    /// <summary>
    /// Gets PercentControlMeasuresReductionEfficiency.
    /// </summary>
    public Caers.Api.SchemaEntities.ControlPollutant.PercentControlMeasuresReductionEfficiencyEntity PercentControlMeasuresReductionEfficiency
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PercentControlMeasuresReductionEfficiencyUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.ControlPollutant.PercentControlMeasuresReductionEfficiencyEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PercentControlMeasuresReductionEfficiencyJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.ControlPollutant.PercentControlMeasuresReductionEfficiencyEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PollutantCode.
    /// </summary>
    public Caers.Api.SchemaEntities.Pollutant PollutantCode
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PollutantCodeUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.Pollutant(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PollutantCodeJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.Pollutant>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "ControlPollutant"/>.
    /// </summary>
    public static ControlPollutant Create(Caers.Api.SchemaEntities.ControlPollutant.PercentControlMeasuresReductionEfficiencyEntity percentControlMeasuresReductionEfficiency, Caers.Api.SchemaEntities.Pollutant pollutantCode)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        builder.Add(PercentControlMeasuresReductionEfficiencyJsonPropertyName, percentControlMeasuresReductionEfficiency.AsAny);
        builder.Add(PollutantCodeJsonPropertyName, pollutantCode.AsAny);
        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets percentControlMeasuresReductionEfficiency.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPollutant WithPercentControlMeasuresReductionEfficiency(in Caers.Api.SchemaEntities.ControlPollutant.PercentControlMeasuresReductionEfficiencyEntity value)
    {
        return this.SetProperty(PercentControlMeasuresReductionEfficiencyJsonPropertyName, value);
    }

    /// <summary>
    /// Sets pollutantCode.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPollutant WithPollutantCode(in Caers.Api.SchemaEntities.Pollutant value)
    {
        return this.SetProperty(PollutantCodeJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidatePercentControlMeasuresReductionEfficiency(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.ControlPollutant.PercentControlMeasuresReductionEfficiencyEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePollutantCode(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.Pollutant>().Validate(validationContext, level);
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
            if (property.NameEquals(PercentControlMeasuresReductionEfficiencyUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentControlMeasuresReductionEfficiency;
                return true;
            }
            else if (property.NameEquals(PollutantCodeUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePollutantCode;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(PercentControlMeasuresReductionEfficiencyJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentControlMeasuresReductionEfficiency;
                return true;
            }
            else if (property.NameEquals(PollutantCodeJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePollutantCode;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}