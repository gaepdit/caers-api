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
public readonly partial struct LocationDataType
{
    /// <summary>
    /// JSON property name for <see cref = "CensusBlockIdentifier"/>.
    /// </summary>
    public static ReadOnlySpan<byte> CensusBlockIdentifierUtf8JsonPropertyName => "censusBlockIdentifier"u8;

    /// <summary>
    /// JSON property name for <see cref = "CensusBlockIdentifier"/>.
    /// </summary>
    public const string CensusBlockIdentifierJsonPropertyName = "censusBlockIdentifier";
    /// <summary>
    /// JSON property name for <see cref = "CensusTractIdentifier"/>.
    /// </summary>
    public static ReadOnlySpan<byte> CensusTractIdentifierUtf8JsonPropertyName => "censusTractIdentifier"u8;

    /// <summary>
    /// JSON property name for <see cref = "CensusTractIdentifier"/>.
    /// </summary>
    public const string CensusTractIdentifierJsonPropertyName = "censusTractIdentifier";
    /// <summary>
    /// JSON property name for <see cref = "LocationComment"/>.
    /// </summary>
    public static ReadOnlySpan<byte> LocationCommentUtf8JsonPropertyName => "locationComment"u8;

    /// <summary>
    /// JSON property name for <see cref = "LocationComment"/>.
    /// </summary>
    public const string LocationCommentJsonPropertyName = "locationComment";
    /// <summary>
    /// JSON property name for <see cref = "LocationEmissionsProcess"/>.
    /// </summary>
    public static ReadOnlySpan<byte> LocationEmissionsProcessUtf8JsonPropertyName => "locationEmissionsProcess"u8;

    /// <summary>
    /// JSON property name for <see cref = "LocationEmissionsProcess"/>.
    /// </summary>
    public const string LocationEmissionsProcessJsonPropertyName = "locationEmissionsProcess";
    /// <summary>
    /// JSON property name for <see cref = "ShapeIdentifier"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ShapeIdentifierUtf8JsonPropertyName => "shapeIdentifier"u8;

    /// <summary>
    /// JSON property name for <see cref = "ShapeIdentifier"/>.
    /// </summary>
    public const string ShapeIdentifierJsonPropertyName = "shapeIdentifier";
    /// <summary>
    /// JSON property name for <see cref = "StateAndCountryFISCode"/>.
    /// </summary>
    public static ReadOnlySpan<byte> StateAndCountryFISCodeUtf8JsonPropertyName => "stateAndCountryFIPSCode"u8;

    /// <summary>
    /// JSON property name for <see cref = "StateAndCountryFISCode"/>.
    /// </summary>
    public const string StateAndCountryFISCodeJsonPropertyName = "stateAndCountryFIPSCode";
    /// <summary>
    /// JSON property name for <see cref = "StateAndCountyFISCode"/>.
    /// </summary>
    public static ReadOnlySpan<byte> StateAndCountyFISCodeUtf8JsonPropertyName => "stateAndCountyFIPSCode"u8;

    /// <summary>
    /// JSON property name for <see cref = "StateAndCountyFISCode"/>.
    /// </summary>
    public const string StateAndCountyFISCodeJsonPropertyName = "stateAndCountyFIPSCode";
    /// <summary>
    /// JSON property name for <see cref = "TribalCode"/>.
    /// </summary>
    public static ReadOnlySpan<byte> TribalCodeUtf8JsonPropertyName => "tribalCode"u8;

    /// <summary>
    /// JSON property name for <see cref = "TribalCode"/>.
    /// </summary>
    public const string TribalCodeJsonPropertyName = "tribalCode";
    /// <summary>
    /// Gets CensusBlockIdentifier.
    /// </summary>
    public Corvus.Json.JsonString CensusBlockIdentifier
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(CensusBlockIdentifierUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(CensusBlockIdentifierJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets CensusTractIdentifier.
    /// </summary>
    public Corvus.Json.JsonString CensusTractIdentifier
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(CensusTractIdentifierUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(CensusTractIdentifierJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets LocationComment.
    /// </summary>
    public Corvus.Json.JsonString LocationComment
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(LocationCommentUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(LocationCommentJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets LocationEmissionsProcess.
    /// </summary>
    public Caers.Api.SchemaEntities.LocationDataType.ProcessDataTypeArray LocationEmissionsProcess
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(LocationEmissionsProcessUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.LocationDataType.ProcessDataTypeArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(LocationEmissionsProcessJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.LocationDataType.ProcessDataTypeArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ShapeIdentifier.
    /// </summary>
    public Corvus.Json.JsonString ShapeIdentifier
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ShapeIdentifierUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ShapeIdentifierJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets StateAndCountryFISCode.
    /// </summary>
    public Corvus.Json.JsonString StateAndCountryFISCode
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(StateAndCountryFISCodeUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(StateAndCountryFISCodeJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets StateAndCountyFISCode.
    /// </summary>
    public Corvus.Json.JsonString StateAndCountyFISCode
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(StateAndCountyFISCodeUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(StateAndCountyFISCodeJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets TribalCode.
    /// </summary>
    public Corvus.Json.JsonString TribalCode
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(TribalCodeUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(TribalCodeJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "LocationDataType"/>.
    /// </summary>
    public static LocationDataType Create(Corvus.Json.JsonString? censusBlockIdentifier = null, Corvus.Json.JsonString? censusTractIdentifier = null, Corvus.Json.JsonString? locationComment = null, Caers.Api.SchemaEntities.LocationDataType.ProcessDataTypeArray? locationEmissionsProcess = null, Corvus.Json.JsonString? shapeIdentifier = null, Corvus.Json.JsonString? stateAndCountryFICode = null, Corvus.Json.JsonString? stateAndCountyFICode = null, Corvus.Json.JsonString? tribalCode = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (censusBlockIdentifier is Corvus.Json.JsonString censusBlockIdentifier__)
        {
            builder.Add(CensusBlockIdentifierJsonPropertyName, censusBlockIdentifier__.AsAny);
        }

        if (censusTractIdentifier is Corvus.Json.JsonString censusTractIdentifier__)
        {
            builder.Add(CensusTractIdentifierJsonPropertyName, censusTractIdentifier__.AsAny);
        }

        if (locationComment is Corvus.Json.JsonString locationComment__)
        {
            builder.Add(LocationCommentJsonPropertyName, locationComment__.AsAny);
        }

        if (locationEmissionsProcess is Caers.Api.SchemaEntities.LocationDataType.ProcessDataTypeArray locationEmissionsProcess__)
        {
            builder.Add(LocationEmissionsProcessJsonPropertyName, locationEmissionsProcess__.AsAny);
        }

        if (shapeIdentifier is Corvus.Json.JsonString shapeIdentifier__)
        {
            builder.Add(ShapeIdentifierJsonPropertyName, shapeIdentifier__.AsAny);
        }

        if (stateAndCountryFICode is Corvus.Json.JsonString stateAndCountryFICode__)
        {
            builder.Add(StateAndCountryFISCodeJsonPropertyName, stateAndCountryFICode__.AsAny);
        }

        if (stateAndCountyFICode is Corvus.Json.JsonString stateAndCountyFICode__)
        {
            builder.Add(StateAndCountyFISCodeJsonPropertyName, stateAndCountyFICode__.AsAny);
        }

        if (tribalCode is Corvus.Json.JsonString tribalCode__)
        {
            builder.Add(TribalCodeJsonPropertyName, tribalCode__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets censusBlockIdentifier.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithCensusBlockIdentifier(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(CensusBlockIdentifierJsonPropertyName, value);
    }

    /// <summary>
    /// Sets censusTractIdentifier.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithCensusTractIdentifier(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(CensusTractIdentifierJsonPropertyName, value);
    }

    /// <summary>
    /// Sets locationComment.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithLocationComment(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(LocationCommentJsonPropertyName, value);
    }

    /// <summary>
    /// Sets locationEmissionsProcess.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithLocationEmissionsProcess(in Caers.Api.SchemaEntities.LocationDataType.ProcessDataTypeArray value)
    {
        return this.SetProperty(LocationEmissionsProcessJsonPropertyName, value);
    }

    /// <summary>
    /// Sets shapeIdentifier.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithShapeIdentifier(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(ShapeIdentifierJsonPropertyName, value);
    }

    /// <summary>
    /// Sets stateAndCountryFIPSCode.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithStateAndCountryFISCode(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(StateAndCountryFISCodeJsonPropertyName, value);
    }

    /// <summary>
    /// Sets stateAndCountyFIPSCode.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithStateAndCountyFISCode(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(StateAndCountyFISCodeJsonPropertyName, value);
    }

    /// <summary>
    /// Sets tribalCode.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public LocationDataType WithTribalCode(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(TribalCodeJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateStateAndCountyFISCode(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateTribalCode(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateStateAndCountryFISCode(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateCensusBlockIdentifier(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateCensusTractIdentifier(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateShapeIdentifier(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateLocationComment(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateLocationEmissionsProcess(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.LocationDataType.ProcessDataTypeArray>().Validate(validationContext, level);
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
            if (property.NameEquals(StateAndCountyFISCodeUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateStateAndCountyFISCode;
                return true;
            }
            else if (property.NameEquals(TribalCodeUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateTribalCode;
                return true;
            }
            else if (property.NameEquals(StateAndCountryFISCodeUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateStateAndCountryFISCode;
                return true;
            }
            else if (property.NameEquals(CensusBlockIdentifierUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateCensusBlockIdentifier;
                return true;
            }
            else if (property.NameEquals(CensusTractIdentifierUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateCensusTractIdentifier;
                return true;
            }
            else if (property.NameEquals(ShapeIdentifierUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateShapeIdentifier;
                return true;
            }
            else if (property.NameEquals(LocationCommentUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateLocationComment;
                return true;
            }
            else if (property.NameEquals(LocationEmissionsProcessUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateLocationEmissionsProcess;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(StateAndCountyFISCodeJsonPropertyName))
            {
                propertyValidator = __CorvusValidateStateAndCountyFISCode;
                return true;
            }
            else if (property.NameEquals(TribalCodeJsonPropertyName))
            {
                propertyValidator = __CorvusValidateTribalCode;
                return true;
            }
            else if (property.NameEquals(StateAndCountryFISCodeJsonPropertyName))
            {
                propertyValidator = __CorvusValidateStateAndCountryFISCode;
                return true;
            }
            else if (property.NameEquals(CensusBlockIdentifierJsonPropertyName))
            {
                propertyValidator = __CorvusValidateCensusBlockIdentifier;
                return true;
            }
            else if (property.NameEquals(CensusTractIdentifierJsonPropertyName))
            {
                propertyValidator = __CorvusValidateCensusTractIdentifier;
                return true;
            }
            else if (property.NameEquals(ShapeIdentifierJsonPropertyName))
            {
                propertyValidator = __CorvusValidateShapeIdentifier;
                return true;
            }
            else if (property.NameEquals(LocationCommentJsonPropertyName))
            {
                propertyValidator = __CorvusValidateLocationComment;
                return true;
            }
            else if (property.NameEquals(LocationEmissionsProcessJsonPropertyName))
            {
                propertyValidator = __CorvusValidateLocationEmissionsProcess;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}