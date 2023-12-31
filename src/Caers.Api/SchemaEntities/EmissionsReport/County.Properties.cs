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
public readonly partial struct County
{
    /// <summary>
    /// JSON property name for <see cref = "Code"/>.
    /// </summary>
    public static ReadOnlySpan<byte> CodeUtf8JsonPropertyName => "code"u8;

    /// <summary>
    /// JSON property name for <see cref = "Code"/>.
    /// </summary>
    public const string CodeJsonPropertyName = "code";
    /// <summary>
    /// JSON property name for <see cref = "Name"/>.
    /// </summary>
    public static ReadOnlySpan<byte> NameUtf8JsonPropertyName => "name"u8;

    /// <summary>
    /// JSON property name for <see cref = "Name"/>.
    /// </summary>
    public const string NameJsonPropertyName = "name";
    /// <summary>
    /// Gets Code.
    /// </summary>
    public Caers.Api.SchemaEntities.County.CodeEntity Code
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(CodeUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.County.CodeEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(CodeJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.County.CodeEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Name.
    /// </summary>
    public Caers.Api.SchemaEntities.County.NameEntity Name
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
                    return new Caers.Api.SchemaEntities.County.NameEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(NameJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.County.NameEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "County"/>.
    /// </summary>
    public static County Create(Caers.Api.SchemaEntities.County.CodeEntity? code = null, Caers.Api.SchemaEntities.County.NameEntity? name = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (code is Caers.Api.SchemaEntities.County.CodeEntity code__)
        {
            builder.Add(CodeJsonPropertyName, code__.AsAny);
        }

        if (name is Caers.Api.SchemaEntities.County.NameEntity name__)
        {
            builder.Add(NameJsonPropertyName, name__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets code.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public County WithCode(in Caers.Api.SchemaEntities.County.CodeEntity value)
    {
        return this.SetProperty(CodeJsonPropertyName, value);
    }

    /// <summary>
    /// Sets name.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public County WithName(in Caers.Api.SchemaEntities.County.NameEntity value)
    {
        return this.SetProperty(NameJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateCode(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.County.CodeEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateName(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.County.NameEntity>().Validate(validationContext, level);
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
            if (property.NameEquals(CodeUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateCode;
                return true;
            }
            else if (property.NameEquals(NameUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateName;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(CodeJsonPropertyName))
            {
                propertyValidator = __CorvusValidateCode;
                return true;
            }
            else if (property.NameEquals(NameJsonPropertyName))
            {
                propertyValidator = __CorvusValidateName;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}