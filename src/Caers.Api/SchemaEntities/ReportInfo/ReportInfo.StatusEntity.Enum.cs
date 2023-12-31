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
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Caers.Api.SchemaEntities;
public readonly partial struct ReportInfo
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct StatusEntity
    {
        /// <summary>
        /// Permitted values.
        /// </summary>
        public static class EnumValues
        {
            /// <summary>
            /// NE.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity NE = StatusEntity.Parse("\"NEW\"");
            /// <summary>
            /// APROED.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity APROED = StatusEntity.Parse("\"APPROVED\"");
            /// <summary>
            /// INPOGES.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity INPOGES = StatusEntity.Parse("\"IN_PROGRESS\"");
            /// <summary>
            /// REURED.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity REURED = StatusEntity.Parse("\"RETURNED\"");
            /// <summary>
            /// SUMITE.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity SUMITE = StatusEntity.Parse("\"SUBMITTED\"");
            /// <summary>
            /// ADANEDQ.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity ADANEDQ = StatusEntity.Parse("\"ADVANCED_QA\"");
            /// <summary>
            /// VAIDTE.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity VAIDTE = StatusEntity.Parse("\"VALIDATED\"");
            /// <summary>
            /// NOSTRTD.
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            public static readonly StatusEntity NOSTRTD = StatusEntity.Parse("\"NOT_STARTED\"");
            /// <summary>
            /// [{Title} || Item 0] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item0 = StatusEntity.Parse("\"NEW\"");
            /// <summary>
            /// [{Title} || Item 1] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item1 = StatusEntity.Parse("\"APPROVED\"");
            /// <summary>
            /// [{Title} || Item 2] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item2 = StatusEntity.Parse("\"IN_PROGRESS\"");
            /// <summary>
            /// [{Title} || Item 3] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item3 = StatusEntity.Parse("\"RETURNED\"");
            /// <summary>
            /// [{Title} || Item 4] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item4 = StatusEntity.Parse("\"SUBMITTED\"");
            /// <summary>
            /// [{Title} || Item 5] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item5 = StatusEntity.Parse("\"ADVANCED_QA\"");
            /// <summary>
            /// [{Title} || Item 6] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item6 = StatusEntity.Parse("\"VALIDATED\"");
            /// <summary>
            /// [{Title} || Item 7] (with predictable naming).
            /// </summary>
            /// <remarks>
            /// {Description}.
            /// </remarks>
            internal static readonly StatusEntity Item7 = StatusEntity.Parse("\"NOT_STARTED\"");
        }
    }
}