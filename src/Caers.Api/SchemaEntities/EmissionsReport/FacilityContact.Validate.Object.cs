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
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Caers.Api.SchemaEntities;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct FacilityContact
{
    private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;
        if (valueKind != JsonValueKind.Object)
        {
            return result;
        }

        int propertyCount = 0;
        bool foundEmail = false;
        bool foundFirstName = false;
        bool foundLastName = false;
        bool foundPhone = false;
        bool foundStreetAddress = false;
        bool foundType = false;
        foreach (JsonObjectProperty property in this.EnumerateObject())
        {
            if (__TryGetCorvusLocalPropertiesValidator(property, this.HasJsonElementBacking, out ObjectPropertyValidator? propertyValidator))
            {
                result = result.WithLocalProperty(propertyCount);
                if (level > ValidationLevel.Basic)
                {
                    result = result.PushDocumentProperty("properties", property.Name);
                }

                var propertyResult = propertyValidator(property, result.CreateChildContext(), level);
                result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // property name
                }

                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                if ((this.HasJsonElementBacking && property.NameEquals(EmailUtf8JsonPropertyName)) || (!this.HasJsonElementBacking && property.NameEquals(EmailJsonPropertyName)))
                {
                    foundEmail = true;
                }
                else if ((this.HasJsonElementBacking && property.NameEquals(FirstNameUtf8JsonPropertyName)) || (!this.HasJsonElementBacking && property.NameEquals(FirstNameJsonPropertyName)))
                {
                    foundFirstName = true;
                }
                else if ((this.HasJsonElementBacking && property.NameEquals(LastNameUtf8JsonPropertyName)) || (!this.HasJsonElementBacking && property.NameEquals(LastNameJsonPropertyName)))
                {
                    foundLastName = true;
                }
                else if ((this.HasJsonElementBacking && property.NameEquals(PhoneUtf8JsonPropertyName)) || (!this.HasJsonElementBacking && property.NameEquals(PhoneJsonPropertyName)))
                {
                    foundPhone = true;
                }
                else if ((this.HasJsonElementBacking && property.NameEquals(StreetAddressUtf8JsonPropertyName)) || (!this.HasJsonElementBacking && property.NameEquals(StreetAddressJsonPropertyName)))
                {
                    foundStreetAddress = true;
                }
                else if ((this.HasJsonElementBacking && property.NameEquals(TypeUtf8JsonPropertyName)) || (!this.HasJsonElementBacking && property.NameEquals(TypeJsonPropertyName)))
                {
                    foundType = true;
                }
            }

            propertyCount++;
        }

        if (!foundEmail)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"email\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        if (!foundFirstName)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"firstName\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        if (!foundLastName)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"lastName\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        if (!foundPhone)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"phone\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        if (!foundStreetAddress)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"streetAddress\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        if (!foundType)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"type\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        return result;
    }
}