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
public readonly partial struct EmissionsUnit
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct EmissionsProcessArray
    {
        private ValidationContext ValidateArray(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Array)
            {
                return result;
            }

            int arrayLength = 0;
            using JsonArrayEnumerator<Caers.Api.EmissionsProcess> arrayEnumerator = this.EnumerateArray();
            while (arrayEnumerator.MoveNext())
            {
                if (level > ValidationLevel.Basic)
                {
                    result = result.PushDocumentArrayIndex(arrayLength);
                }

                if (level > ValidationLevel.Basic)
                {
                    result = result.PushValidationLocationProperty("items");
                }

                result = arrayEnumerator.Current.Validate(result, level);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // items
                }

                result = result.WithLocalItemIndex(arrayLength);
                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // array index
                }

                arrayLength++;
            }

            return result;
        }
    }
}