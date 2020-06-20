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
    /// Defines values for MachineFolderDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MachineFolderDtoType
    {
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Template")]
        Template
    }
    internal static class MachineFolderDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this MachineFolderDtoType? value)
        {
            return value == null ? null : ((MachineFolderDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MachineFolderDtoType value)
        {
            switch( value )
            {
                case MachineFolderDtoType.Standard:
                    return "Standard";
                case MachineFolderDtoType.Template:
                    return "Template";
            }
            return null;
        }

        internal static MachineFolderDtoType? ParseMachineFolderDtoType(this string value)
        {
            switch( value )
            {
                case "Standard":
                    return MachineFolderDtoType.Standard;
                case "Template":
                    return MachineFolderDtoType.Template;
            }
            return null;
        }
    }
}
