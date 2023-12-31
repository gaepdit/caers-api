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
public readonly partial struct OperatingDetailsDataType
{
    /// <summary>
    /// JSON property name for <see cref = "ActualHoursPerPeriod"/>.
    /// </summary>
    public static ReadOnlySpan<byte> ActualHoursPerPeriodUtf8JsonPropertyName => "actualHoursPerPeriod"u8;

    /// <summary>
    /// JSON property name for <see cref = "ActualHoursPerPeriod"/>.
    /// </summary>
    public const string ActualHoursPerPeriodJsonPropertyName = "actualHoursPerPeriod";
    /// <summary>
    /// JSON property name for <see cref = "AverageDaysPerWeek"/>.
    /// </summary>
    public static ReadOnlySpan<byte> AverageDaysPerWeekUtf8JsonPropertyName => "averageDaysPerWeek"u8;

    /// <summary>
    /// JSON property name for <see cref = "AverageDaysPerWeek"/>.
    /// </summary>
    public const string AverageDaysPerWeekJsonPropertyName = "averageDaysPerWeek";
    /// <summary>
    /// JSON property name for <see cref = "AverageHoursPerDay"/>.
    /// </summary>
    public static ReadOnlySpan<byte> AverageHoursPerDayUtf8JsonPropertyName => "averageHoursPerDay"u8;

    /// <summary>
    /// JSON property name for <see cref = "AverageHoursPerDay"/>.
    /// </summary>
    public const string AverageHoursPerDayJsonPropertyName = "averageHoursPerDay";
    /// <summary>
    /// JSON property name for <see cref = "AverageWeeksPerPeriod"/>.
    /// </summary>
    public static ReadOnlySpan<byte> AverageWeeksPerPeriodUtf8JsonPropertyName => "averageWeeksPerPeriod"u8;

    /// <summary>
    /// JSON property name for <see cref = "AverageWeeksPerPeriod"/>.
    /// </summary>
    public const string AverageWeeksPerPeriodJsonPropertyName = "averageWeeksPerPeriod";
    /// <summary>
    /// JSON property name for <see cref = "PercentFallActivity"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PercentFallActivityUtf8JsonPropertyName => "percentFallActivity"u8;

    /// <summary>
    /// JSON property name for <see cref = "PercentFallActivity"/>.
    /// </summary>
    public const string PercentFallActivityJsonPropertyName = "percentFallActivity";
    /// <summary>
    /// JSON property name for <see cref = "PercentSpringActivity"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PercentSpringActivityUtf8JsonPropertyName => "percentSpringActivity"u8;

    /// <summary>
    /// JSON property name for <see cref = "PercentSpringActivity"/>.
    /// </summary>
    public const string PercentSpringActivityJsonPropertyName = "percentSpringActivity";
    /// <summary>
    /// JSON property name for <see cref = "PercentSummerActivity"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PercentSummerActivityUtf8JsonPropertyName => "percentSummerActivity"u8;

    /// <summary>
    /// JSON property name for <see cref = "PercentSummerActivity"/>.
    /// </summary>
    public const string PercentSummerActivityJsonPropertyName = "percentSummerActivity";
    /// <summary>
    /// JSON property name for <see cref = "PercentWinterActivity"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PercentWinterActivityUtf8JsonPropertyName => "percentWinterActivity"u8;

    /// <summary>
    /// JSON property name for <see cref = "PercentWinterActivity"/>.
    /// </summary>
    public const string PercentWinterActivityJsonPropertyName = "percentWinterActivity";
    /// <summary>
    /// Gets ActualHoursPerPeriod.
    /// </summary>
    public Corvus.Json.JsonString ActualHoursPerPeriod
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ActualHoursPerPeriodUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ActualHoursPerPeriodJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets AverageDaysPerWeek.
    /// </summary>
    public Corvus.Json.JsonString AverageDaysPerWeek
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AverageDaysPerWeekUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AverageDaysPerWeekJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets AverageHoursPerDay.
    /// </summary>
    public Corvus.Json.JsonString AverageHoursPerDay
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AverageHoursPerDayUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AverageHoursPerDayJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets AverageWeeksPerPeriod.
    /// </summary>
    public Corvus.Json.JsonString AverageWeeksPerPeriod
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AverageWeeksPerPeriodUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AverageWeeksPerPeriodJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PercentFallActivity.
    /// </summary>
    public Corvus.Json.JsonString PercentFallActivity
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PercentFallActivityUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PercentFallActivityJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PercentSpringActivity.
    /// </summary>
    public Corvus.Json.JsonString PercentSpringActivity
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PercentSpringActivityUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PercentSpringActivityJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PercentSummerActivity.
    /// </summary>
    public Corvus.Json.JsonString PercentSummerActivity
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PercentSummerActivityUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PercentSummerActivityJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PercentWinterActivity.
    /// </summary>
    public Corvus.Json.JsonString PercentWinterActivity
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PercentWinterActivityUtf8JsonPropertyName, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PercentWinterActivityJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "OperatingDetailsDataType"/>.
    /// </summary>
    public static OperatingDetailsDataType Create(Corvus.Json.JsonString? actualHoursPerPeriod = null, Corvus.Json.JsonString? averageDaysPerWeek = null, Corvus.Json.JsonString? averageHoursPerDay = null, Corvus.Json.JsonString? averageWeeksPerPeriod = null, Corvus.Json.JsonString? percentFallActivity = null, Corvus.Json.JsonString? percentSpringActivity = null, Corvus.Json.JsonString? percentSummerActivity = null, Corvus.Json.JsonString? percentWinterActivity = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (actualHoursPerPeriod is Corvus.Json.JsonString actualHoursPerPeriod__)
        {
            builder.Add(ActualHoursPerPeriodJsonPropertyName, actualHoursPerPeriod__.AsAny);
        }

        if (averageDaysPerWeek is Corvus.Json.JsonString averageDaysPerWeek__)
        {
            builder.Add(AverageDaysPerWeekJsonPropertyName, averageDaysPerWeek__.AsAny);
        }

        if (averageHoursPerDay is Corvus.Json.JsonString averageHoursPerDay__)
        {
            builder.Add(AverageHoursPerDayJsonPropertyName, averageHoursPerDay__.AsAny);
        }

        if (averageWeeksPerPeriod is Corvus.Json.JsonString averageWeeksPerPeriod__)
        {
            builder.Add(AverageWeeksPerPeriodJsonPropertyName, averageWeeksPerPeriod__.AsAny);
        }

        if (percentFallActivity is Corvus.Json.JsonString percentFallActivity__)
        {
            builder.Add(PercentFallActivityJsonPropertyName, percentFallActivity__.AsAny);
        }

        if (percentSpringActivity is Corvus.Json.JsonString percentSpringActivity__)
        {
            builder.Add(PercentSpringActivityJsonPropertyName, percentSpringActivity__.AsAny);
        }

        if (percentSummerActivity is Corvus.Json.JsonString percentSummerActivity__)
        {
            builder.Add(PercentSummerActivityJsonPropertyName, percentSummerActivity__.AsAny);
        }

        if (percentWinterActivity is Corvus.Json.JsonString percentWinterActivity__)
        {
            builder.Add(PercentWinterActivityJsonPropertyName, percentWinterActivity__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets actualHoursPerPeriod.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithActualHoursPerPeriod(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(ActualHoursPerPeriodJsonPropertyName, value);
    }

    /// <summary>
    /// Sets averageDaysPerWeek.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithAverageDaysPerWeek(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(AverageDaysPerWeekJsonPropertyName, value);
    }

    /// <summary>
    /// Sets averageHoursPerDay.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithAverageHoursPerDay(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(AverageHoursPerDayJsonPropertyName, value);
    }

    /// <summary>
    /// Sets averageWeeksPerPeriod.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithAverageWeeksPerPeriod(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(AverageWeeksPerPeriodJsonPropertyName, value);
    }

    /// <summary>
    /// Sets percentFallActivity.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithPercentFallActivity(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(PercentFallActivityJsonPropertyName, value);
    }

    /// <summary>
    /// Sets percentSpringActivity.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithPercentSpringActivity(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(PercentSpringActivityJsonPropertyName, value);
    }

    /// <summary>
    /// Sets percentSummerActivity.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithPercentSummerActivity(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(PercentSummerActivityJsonPropertyName, value);
    }

    /// <summary>
    /// Sets percentWinterActivity.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public OperatingDetailsDataType WithPercentWinterActivity(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(PercentWinterActivityJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateActualHoursPerPeriod(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAverageDaysPerWeek(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAverageHoursPerDay(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAverageWeeksPerPeriod(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePercentWinterActivity(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePercentSpringActivity(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePercentSummerActivity(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePercentFallActivity(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
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
            if (property.NameEquals(ActualHoursPerPeriodUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateActualHoursPerPeriod;
                return true;
            }
            else if (property.NameEquals(AverageDaysPerWeekUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateAverageDaysPerWeek;
                return true;
            }
            else if (property.NameEquals(AverageHoursPerDayUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateAverageHoursPerDay;
                return true;
            }
            else if (property.NameEquals(AverageWeeksPerPeriodUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidateAverageWeeksPerPeriod;
                return true;
            }
            else if (property.NameEquals(PercentWinterActivityUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentWinterActivity;
                return true;
            }
            else if (property.NameEquals(PercentSpringActivityUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentSpringActivity;
                return true;
            }
            else if (property.NameEquals(PercentSummerActivityUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentSummerActivity;
                return true;
            }
            else if (property.NameEquals(PercentFallActivityUtf8JsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentFallActivity;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(ActualHoursPerPeriodJsonPropertyName))
            {
                propertyValidator = __CorvusValidateActualHoursPerPeriod;
                return true;
            }
            else if (property.NameEquals(AverageDaysPerWeekJsonPropertyName))
            {
                propertyValidator = __CorvusValidateAverageDaysPerWeek;
                return true;
            }
            else if (property.NameEquals(AverageHoursPerDayJsonPropertyName))
            {
                propertyValidator = __CorvusValidateAverageHoursPerDay;
                return true;
            }
            else if (property.NameEquals(AverageWeeksPerPeriodJsonPropertyName))
            {
                propertyValidator = __CorvusValidateAverageWeeksPerPeriod;
                return true;
            }
            else if (property.NameEquals(PercentWinterActivityJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentWinterActivity;
                return true;
            }
            else if (property.NameEquals(PercentSpringActivityJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentSpringActivity;
                return true;
            }
            else if (property.NameEquals(PercentSummerActivityJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentSummerActivity;
                return true;
            }
            else if (property.NameEquals(PercentFallActivityJsonPropertyName))
            {
                propertyValidator = __CorvusValidatePercentFallActivity;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }
}