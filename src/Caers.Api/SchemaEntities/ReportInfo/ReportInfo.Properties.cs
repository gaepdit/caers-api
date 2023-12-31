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
public readonly partial struct ReportInfo
{
    /// <summary>
    /// JSON property name for <see cref = "AgencyFacilityIdentifier"/>.
    /// </summary>
    public static ReadOnlySpan<byte> AgencyFacilityIdentifierUtf8JsonPropertyName => "agencyFacilityIdentifier"u8;

    /// <summary>
    /// JSON property name for <see cref = "AgencyFacilityIdentifier"/>.
    /// </summary>
    public const string AgencyFacilityIdentifierJsonPropertyName = "agencyFacilityIdentifier";
    /// <summary>
    /// JSON property name for <see cref = "CertifiedDate"/>.
    /// </summary>
    public static ReadOnlySpan<byte> CertifiedDateUtf8JsonPropertyName => "certifiedDate"u8;

    /// <summary>
    /// JSON property name for <see cref = "CertifiedDate"/>.
    /// </summary>
    public const string CertifiedDateJsonPropertyName = "certifiedDate";
    /// <summary>
    /// JSON property name for <see cref = "ModifiedDate"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ModifiedDateUtf8JsonPropertyName => "modifiedDate"u8;

    /// <summary>
    /// JSON property name for <see cref = "ModifiedDate"/>.
    /// </summary>
    public const string ModifiedDateJsonPropertyName = "modifiedDate";
    /// <summary>
    /// JSON property name for <see cref = "ReportId"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ReportIdUtf8JsonPropertyName => "reportId"u8;

    /// <summary>
    /// JSON property name for <see cref = "ReportId"/>.
    /// </summary>
    public const string ReportIdJsonPropertyName = "reportId";
    /// <summary>
    /// JSON property name for <see cref = "Status"/>.
    /// </summary>
    public static ReadOnlySpan<byte> StatusUtf8JsonPropertyName => "status"u8;

    /// <summary>
    /// JSON property name for <see cref = "Status"/>.
    /// </summary>
    public const string StatusJsonPropertyName = "status";
    /// <summary>
    /// Gets AgencyFacilityIdentifier.
    /// </summary>
    public Corvus.Json.JsonString AgencyFacilityIdentifier
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AgencyFacilityIdentifierUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AgencyFacilityIdentifierJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets CertifiedDate.
    /// </summary>
    public Corvus.Json.JsonDateTime CertifiedDate
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(CertifiedDateUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonDateTime(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(CertifiedDateJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonDateTime>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ModifiedDate.
    /// </summary>
    public Corvus.Json.JsonDateTime ModifiedDate
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ModifiedDateUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonDateTime(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ModifiedDateJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonDateTime>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ReportId.
    /// </summary>
    public Corvus.Json.JsonInteger ReportId
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ReportIdUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonInteger(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ReportIdJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonInteger>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Status.
    /// </summary>
    public Caers.Api.SchemaEntities.ReportInfo.StatusEntity Status
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(StatusUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Caers.Api.SchemaEntities.ReportInfo.StatusEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(StatusJsonPropertyName, out JsonAny result))
                {
                    return result.As<Caers.Api.SchemaEntities.ReportInfo.StatusEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "ReportInfo"/>.
    /// </summary>
    public static ReportInfo Create(Corvus.Json.JsonString? agencyFacilityIdentifier = null, Corvus.Json.JsonDateTime? certifiedDate = null, Corvus.Json.JsonDateTime? modifiedDate = null, Corvus.Json.JsonInteger? reportId = null, Caers.Api.SchemaEntities.ReportInfo.StatusEntity? status = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (agencyFacilityIdentifier is Corvus.Json.JsonString agencyFacilityIdentifier__)
        {
            builder.Add(AgencyFacilityIdentifierJsonPropertyName, agencyFacilityIdentifier__.AsAny);
        }

        if (certifiedDate is Corvus.Json.JsonDateTime certifiedDate__)
        {
            builder.Add(CertifiedDateJsonPropertyName, certifiedDate__.AsAny);
        }

        if (modifiedDate is Corvus.Json.JsonDateTime modifiedDate__)
        {
            builder.Add(ModifiedDateJsonPropertyName, modifiedDate__.AsAny);
        }

        if (reportId is Corvus.Json.JsonInteger reportId__)
        {
            builder.Add(ReportIdJsonPropertyName, reportId__.AsAny);
        }

        if (status is Caers.Api.SchemaEntities.ReportInfo.StatusEntity status__)
        {
            builder.Add(StatusJsonPropertyName, status__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets agencyFacilityIdentifier.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReportInfo WithAgencyFacilityIdentifier(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(AgencyFacilityIdentifierJsonPropertyName, value);
    }

    /// <summary>
    /// Sets certifiedDate.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReportInfo WithCertifiedDate(in Corvus.Json.JsonDateTime value)
    {
        return this.SetProperty(CertifiedDateJsonPropertyName, value);
    }

    /// <summary>
    /// Sets modifiedDate.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReportInfo WithModifiedDate(in Corvus.Json.JsonDateTime value)
    {
        return this.SetProperty(ModifiedDateJsonPropertyName, value);
    }

    /// <summary>
    /// Sets reportId.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReportInfo WithReportId(in Corvus.Json.JsonInteger value)
    {
        return this.SetProperty(ReportIdJsonPropertyName, value);
    }

    /// <summary>
    /// Sets status.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ReportInfo WithStatus(in Caers.Api.SchemaEntities.ReportInfo.StatusEntity value)
    {
        return this.SetProperty(StatusJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateReportId(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonInteger>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAgencyFacilityIdentifier(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateStatus(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Caers.Api.SchemaEntities.ReportInfo.StatusEntity>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateModifiedDate(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonDateTime>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateCertifiedDate(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
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
            if (property.NameEquals(ReportIdUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateReportId;
                return true;
            }
            else if (property.NameEquals(AgencyFacilityIdentifierUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateAgencyFacilityIdentifier;
                return true;
            }
            else if (property.NameEquals(StatusUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateStatus;
                return true;
            }
            else if (property.NameEquals(ModifiedDateUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateModifiedDate;
                return true;
            }
            else if (property.NameEquals(CertifiedDateUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateCertifiedDate;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(ReportIdJsonPropertyName))
            {
                propertyValidator = __CorvusValidateReportId;
                return true;
            }
            else if (property.NameEquals(AgencyFacilityIdentifierJsonPropertyName))
            {
                propertyValidator = __CorvusValidateAgencyFacilityIdentifier;
                return true;
            }
            else if (property.NameEquals(StatusJsonPropertyName))
            {
                propertyValidator = __CorvusValidateStatus;
                return true;
            }
            else if (property.NameEquals(ModifiedDateJsonPropertyName))
            {
                propertyValidator = __CorvusValidateModifiedDate;
                return true;
            }
            else if (property.NameEquals(CertifiedDateJsonPropertyName))
            {
                propertyValidator = __CorvusValidateCertifiedDate;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}