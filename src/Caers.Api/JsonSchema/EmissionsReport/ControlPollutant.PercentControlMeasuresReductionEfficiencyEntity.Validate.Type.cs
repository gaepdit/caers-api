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
public readonly partial struct ControlPollutant
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct PercentControlMeasuresReductionEfficiencyEntity
    {
        private ValidationContext ValidateType(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            bool isValid = false;
            ValidationContext localResultNumber = Corvus.Json.Validate.TypeNumber(valueKind, result.CreateChildContext(), level);
            if (level == ValidationLevel.Flag && localResultNumber.IsValid)
            {
                return validationContext;
            }

            if (localResultNumber.IsValid)
            {
                isValid = true;
            }

            result = result.MergeResults(isValid, level, localResultNumber);
            return result;
        }
    }
}