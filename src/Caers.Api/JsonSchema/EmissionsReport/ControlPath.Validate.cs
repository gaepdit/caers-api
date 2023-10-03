//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Text.Json;
using Corvus.Json;

namespace Caers.Api;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct ControlPath
{
    /// <inheritdoc/>
    public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
    {
        ValidationContext result = validationContext;
        if (level > ValidationLevel.Flag)
        {
            result = result.UsingResults();
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.UsingStack();
            result = result.PushSchemaLocation("D:/projects/Caers.Api/Caers.Api/JsonSchema/caers-report-openapi.json#/components/schemas/ControlPath");
        }

        JsonValueKind valueKind = this.ValueKind;
        result = this.ValidateType(valueKind, result, level);
        if (level == ValidationLevel.Flag && !result.IsValid)
        {
            return result;
        }

        result = this.ValidateObject(valueKind, result, level);
        if (level == ValidationLevel.Flag && !result.IsValid)
        {
            return result;
        }

        if (level != ValidationLevel.Flag)
        {
            result = result.PopLocation();
        }

        return result;
    }
}
