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
    /// Defines values for SimpleUserDtoProvisionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SimpleUserDtoProvisionType
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Automatic")]
        Automatic
    }
    internal static class SimpleUserDtoProvisionTypeEnumExtension
    {
        internal static string ToSerializedValue(this SimpleUserDtoProvisionType? value)
        {
            return value == null ? null : ((SimpleUserDtoProvisionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SimpleUserDtoProvisionType value)
        {
            switch( value )
            {
                case SimpleUserDtoProvisionType.Manual:
                    return "Manual";
                case SimpleUserDtoProvisionType.Automatic:
                    return "Automatic";
            }
            return null;
        }

        internal static SimpleUserDtoProvisionType? ParseSimpleUserDtoProvisionType(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return SimpleUserDtoProvisionType.Manual;
                case "Automatic":
                    return SimpleUserDtoProvisionType.Automatic;
            }
            return null;
        }
    }
}
