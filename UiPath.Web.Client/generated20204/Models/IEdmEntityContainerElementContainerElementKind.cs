// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IEdmEntityContainerElementContainerElementKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmEntityContainerElementContainerElementKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "EntitySet")]
        EntitySet,
        [EnumMember(Value = "ActionImport")]
        ActionImport,
        [EnumMember(Value = "FunctionImport")]
        FunctionImport,
        [EnumMember(Value = "Singleton")]
        Singleton
    }
    internal static class IEdmEntityContainerElementContainerElementKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmEntityContainerElementContainerElementKind? value)
        {
            return value == null ? null : ((IEdmEntityContainerElementContainerElementKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmEntityContainerElementContainerElementKind value)
        {
            switch( value )
            {
                case IEdmEntityContainerElementContainerElementKind.None:
                    return "None";
                case IEdmEntityContainerElementContainerElementKind.EntitySet:
                    return "EntitySet";
                case IEdmEntityContainerElementContainerElementKind.ActionImport:
                    return "ActionImport";
                case IEdmEntityContainerElementContainerElementKind.FunctionImport:
                    return "FunctionImport";
                case IEdmEntityContainerElementContainerElementKind.Singleton:
                    return "Singleton";
            }
            return null;
        }

        internal static IEdmEntityContainerElementContainerElementKind? ParseIEdmEntityContainerElementContainerElementKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmEntityContainerElementContainerElementKind.None;
                case "EntitySet":
                    return IEdmEntityContainerElementContainerElementKind.EntitySet;
                case "ActionImport":
                    return IEdmEntityContainerElementContainerElementKind.ActionImport;
                case "FunctionImport":
                    return IEdmEntityContainerElementContainerElementKind.FunctionImport;
                case "Singleton":
                    return IEdmEntityContainerElementContainerElementKind.Singleton;
            }
            return null;
        }
    }
}
