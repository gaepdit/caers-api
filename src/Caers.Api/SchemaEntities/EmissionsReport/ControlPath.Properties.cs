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
public readonly partial struct ControlPath
{
    /// <summary>
    /// JSON property name for <see cref = "ControlPathDefinition"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ControlPathDefinitionUtf8JsonPropertyName => "controlPathDefinition"u8;

    /// <summary>
    /// JSON property name for <see cref = "ControlPathDefinition"/>.
    /// </summary>
    public const string ControlPathDefinitionJsonPropertyName = "controlPathDefinition";
    /// <summary>
    /// JSON property name for <see cref = "ControlPathPollutants"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ControlPathPollutantsUtf8JsonPropertyName => "controlPathPollutants"u8;

    /// <summary>
    /// JSON property name for <see cref = "ControlPathPollutants"/>.
    /// </summary>
    public const string ControlPathPollutantsJsonPropertyName = "controlPathPollutants";
    /// <summary>
    /// JSON property name for <see cref = "Description"/>.
    /// </summary>
    public static ReadOnlySpan<byte> DescriptionUtf8JsonPropertyName => "description"u8;

    /// <summary>
    /// JSON property name for <see cref = "Description"/>.
    /// </summary>
    public const string DescriptionJsonPropertyName = "description";
    /// <summary>
    /// JSON property name for <see cref = "Identification"/>.
    /// </summary>
    public static ReadOnlySpan<byte> IdentificationUtf8JsonPropertyName => "identification"u8;

    /// <summary>
    /// JSON property name for <see cref = "Identification"/>.
    /// </summary>
    public const string IdentificationJsonPropertyName = "identification";
    /// <summary>
    /// JSON property name for <see cref = "MainIdentification"/>.
    /// </summary>
    public static ReadOnlySpan<byte> MainIdentificationUtf8JsonPropertyName => "mainIdentification"u8;

    /// <summary>
    /// JSON property name for <see cref = "MainIdentification"/>.
    /// </summary>
    public const string MainIdentificationJsonPropertyName = "mainIdentification";
    /// <summary>
    /// JSON property name for <see cref = "Name"/>.
    /// </summary>
    public static ReadOnlySpan<byte> NameUtf8JsonPropertyName => "name"u8;

    /// <summary>
    /// JSON property name for <see cref = "Name"/>.
    /// </summary>
    public const string NameJsonPropertyName = "name";
    /// <summary>
    /// JSON property name for <see cref = "PathIsReadOnly"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PathIsReadOnlyUtf8JsonPropertyName => "pathIsReadOnly"u8;

    /// <summary>
    /// JSON property name for <see cref = "PathIsReadOnly"/>.
    /// </summary>
    public const string PathIsReadOnlyJsonPropertyName = "pathIsReadOnly";
    /// <summary>
    /// JSON property name for <see cref = "PercentPathEffectiveness"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PercentPathEffectivenessUtf8JsonPropertyName => "percentPathEffectiveness"u8;

    /// <summary>
    /// JSON property name for <see cref = "PercentPathEffectiveness"/>.
    /// </summary>
    public const string PercentPathEffectivenessJsonPropertyName = "percentPathEffectiveness";
    /// <summary>
    /// Gets ControlPathDefinition.
    /// </summary>
    public Caers.Api.SchemaEntities.ControlPath.ControlAssignmentArray ControlPathDefinition
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ControlPathDefinitionUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.ControlPath.ControlAssignmentArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ControlPathDefinitionJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.ControlPath.ControlAssignmentArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ControlPathPollutants.
    /// </summary>
    public Caers.Api.SchemaEntities.ControlPath.ControlPollutantArray ControlPathPollutants
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ControlPathPollutantsUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.ControlPath.ControlPollutantArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ControlPathPollutantsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.ControlPath.ControlPollutantArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Description.
    /// </summary>
    public Caers.Api.SchemaEntities.ControlPath.DescriptionEntity Description
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DescriptionUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.ControlPath.DescriptionEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DescriptionJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.ControlPath.DescriptionEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Identification.
    /// </summary>
    public Caers.Api.SchemaEntities.ControlPath.IdentificationIdentificationArray Identification
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(IdentificationUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.ControlPath.IdentificationIdentificationArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(IdentificationJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.ControlPath.IdentificationIdentificationArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets MainIdentification.
    /// </summary>
    public Caers.Api.SchemaEntities.Identification MainIdentification
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(MainIdentificationUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.Identification(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(MainIdentificationJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.Identification>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Name.
    /// </summary>
    public Corvus.Json.JsonString Name
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(NameUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(NameJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PathIsReadOnly.
    /// </summary>
    public Corvus.Json.JsonString PathIsReadOnly
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PathIsReadOnlyUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PathIsReadOnlyJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PercentPathEffectiveness.
    /// </summary>
    public Caers.Api.SchemaEntities.ControlPath.PercentPathEffectivenessEntity PercentPathEffectiveness
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PercentPathEffectivenessUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.ControlPath.PercentPathEffectivenessEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PercentPathEffectivenessJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.ControlPath.PercentPathEffectivenessEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "ControlPath"/>.
    /// </summary>
    public static ControlPath Create(Caers.Api.SchemaEntities.ControlPath.ControlAssignmentArray? controlPathDefinition = null, Caers.Api.SchemaEntities.ControlPath.ControlPollutantArray? controlPathPollutants = null, Caers.Api.SchemaEntities.ControlPath.DescriptionEntity? description = null, Caers.Api.SchemaEntities.ControlPath.IdentificationIdentificationArray? identification = null, Caers.Api.SchemaEntities.Identification? mainIdentification = null, Corvus.Json.JsonString? name = null, Corvus.Json.JsonString? pathIsReadOnly = null, Caers.Api.SchemaEntities.ControlPath.PercentPathEffectivenessEntity? percentPathEffectiveness = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (controlPathDefinition is Caers.Api.SchemaEntities.ControlPath.ControlAssignmentArray controlPathDefinition__)
        {
            builder.Add(ControlPathDefinitionJsonPropertyName, controlPathDefinition__.AsAny);
        }

        if (controlPathPollutants is Caers.Api.SchemaEntities.ControlPath.ControlPollutantArray controlPathPollutants__)
        {
            builder.Add(ControlPathPollutantsJsonPropertyName, controlPathPollutants__.AsAny);
        }

        if (description is Caers.Api.SchemaEntities.ControlPath.DescriptionEntity description__)
        {
            builder.Add(DescriptionJsonPropertyName, description__.AsAny);
        }

        if (identification is Caers.Api.SchemaEntities.ControlPath.IdentificationIdentificationArray identification__)
        {
            builder.Add(IdentificationJsonPropertyName, identification__.AsAny);
        }

        if (mainIdentification is Caers.Api.SchemaEntities.Identification mainIdentification__)
        {
            builder.Add(MainIdentificationJsonPropertyName, mainIdentification__.AsAny);
        }

        if (name is Corvus.Json.JsonString name__)
        {
            builder.Add(NameJsonPropertyName, name__.AsAny);
        }

        if (pathIsReadOnly is Corvus.Json.JsonString pathIsReadOnly__)
        {
            builder.Add(PathIsReadOnlyJsonPropertyName, pathIsReadOnly__.AsAny);
        }

        if (percentPathEffectiveness is Caers.Api.SchemaEntities.ControlPath.PercentPathEffectivenessEntity percentPathEffectiveness__)
        {
            builder.Add(PercentPathEffectivenessJsonPropertyName, percentPathEffectiveness__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets controlPathDefinition.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithControlPathDefinition(in Caers.Api.SchemaEntities.ControlPath.ControlAssignmentArray value)
    {
        return this.SetProperty(ControlPathDefinitionJsonPropertyName, value);
    }

    /// <summary>
    /// Sets controlPathPollutants.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithControlPathPollutants(in Caers.Api.SchemaEntities.ControlPath.ControlPollutantArray value)
    {
        return this.SetProperty(ControlPathPollutantsJsonPropertyName, value);
    }

    /// <summary>
    /// Sets description.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithDescription(in Caers.Api.SchemaEntities.ControlPath.DescriptionEntity value)
    {
        return this.SetProperty(DescriptionJsonPropertyName, value);
    }

    /// <summary>
    /// Sets identification.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithIdentification(in Caers.Api.SchemaEntities.ControlPath.IdentificationIdentificationArray value)
    {
        return this.SetProperty(IdentificationJsonPropertyName, value);
    }

    /// <summary>
    /// Sets mainIdentification.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithMainIdentification(in Caers.Api.SchemaEntities.Identification value)
    {
        return this.SetProperty(MainIdentificationJsonPropertyName, value);
    }

    /// <summary>
    /// Sets name.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithName(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(NameJsonPropertyName, value);
    }

    /// <summary>
    /// Sets pathIsReadOnly.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithPathIsReadOnly(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(PathIsReadOnlyJsonPropertyName, value);
    }

    /// <summary>
    /// Sets percentPathEffectiveness.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ControlPath WithPercentPathEffectiveness(in Caers.Api.SchemaEntities.ControlPath.PercentPathEffectivenessEntity value)
    {
        return this.SetProperty(PercentPathEffectivenessJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateIdentification(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.ControlPath.IdentificationIdentificationArray>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDescription(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.ControlPath.DescriptionEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePercentPathEffectiveness(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.ControlPath.PercentPathEffectivenessEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateControlPathDefinition(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.ControlPath.ControlAssignmentArray>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateControlPathPollutants(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.ControlPath.ControlPollutantArray>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateName(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePathIsReadOnly(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateMainIdentification(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.Identification>().Validate(validationContext, level);
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
            if (property.NameEquals(IdentificationUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateIdentification;
                return true;
            }
            else if (property.NameEquals(DescriptionUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateDescription;
                return true;
            }
            else if (property.NameEquals(PercentPathEffectivenessUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentPathEffectiveness;
                return true;
            }
            else if (property.NameEquals(ControlPathDefinitionUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateControlPathDefinition;
                return true;
            }
            else if (property.NameEquals(ControlPathPollutantsUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateControlPathPollutants;
                return true;
            }
            else if (property.NameEquals(NameUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateName;
                return true;
            }
            else if (property.NameEquals(PathIsReadOnlyUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePathIsReadOnly;
                return true;
            }
            else if (property.NameEquals(MainIdentificationUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateMainIdentification;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(IdentificationJsonPropertyName))
            {
                propertyValidator = __CorvusValidateIdentification;
                return true;
            }
            else if (property.NameEquals(DescriptionJsonPropertyName))
            {
                propertyValidator = __CorvusValidateDescription;
                return true;
            }
            else if (property.NameEquals(PercentPathEffectivenessJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentPathEffectiveness;
                return true;
            }
            else if (property.NameEquals(ControlPathDefinitionJsonPropertyName))
            {
                propertyValidator = __CorvusValidateControlPathDefinition;
                return true;
            }
            else if (property.NameEquals(ControlPathPollutantsJsonPropertyName))
            {
                propertyValidator = __CorvusValidateControlPathPollutants;
                return true;
            }
            else if (property.NameEquals(NameJsonPropertyName))
            {
                propertyValidator = __CorvusValidateName;
                return true;
            }
            else if (property.NameEquals(PathIsReadOnlyJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePathIsReadOnly;
                return true;
            }
            else if (property.NameEquals(MainIdentificationJsonPropertyName))
            {
                propertyValidator = __CorvusValidateMainIdentification;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}