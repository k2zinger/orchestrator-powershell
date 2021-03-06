// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebhookRobotDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookRobotDtoType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Studio")]
        Studio,
        [EnumMember(Value = "Development")]
        Development,
        [EnumMember(Value = "StudioX")]
        StudioX
    }
    internal static class WebhookRobotDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookRobotDtoType? value)
        {
            return value == null ? null : ((WebhookRobotDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookRobotDtoType value)
        {
            switch( value )
            {
                case WebhookRobotDtoType.NonProduction:
                    return "NonProduction";
                case WebhookRobotDtoType.Attended:
                    return "Attended";
                case WebhookRobotDtoType.Unattended:
                    return "Unattended";
                case WebhookRobotDtoType.Studio:
                    return "Studio";
                case WebhookRobotDtoType.Development:
                    return "Development";
                case WebhookRobotDtoType.StudioX:
                    return "StudioX";
            }
            return null;
        }

        internal static WebhookRobotDtoType? ParseWebhookRobotDtoType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return WebhookRobotDtoType.NonProduction;
                case "Attended":
                    return WebhookRobotDtoType.Attended;
                case "Unattended":
                    return WebhookRobotDtoType.Unattended;
                case "Studio":
                    return WebhookRobotDtoType.Studio;
                case "Development":
                    return WebhookRobotDtoType.Development;
                case "StudioX":
                    return WebhookRobotDtoType.StudioX;
            }
            return null;
        }
    }
}
