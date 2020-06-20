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
    /// Defines values for WebhookQueueItemDtoStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookQueueItemDtoStatus
    {
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Successful")]
        Successful,
        [EnumMember(Value = "Abandoned")]
        Abandoned,
        [EnumMember(Value = "Retried")]
        Retried,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    internal static class WebhookQueueItemDtoStatusEnumExtension
    {
        internal static string ToSerializedValue(this WebhookQueueItemDtoStatus? value)
        {
            return value == null ? null : ((WebhookQueueItemDtoStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookQueueItemDtoStatus value)
        {
            switch( value )
            {
                case WebhookQueueItemDtoStatus.New:
                    return "New";
                case WebhookQueueItemDtoStatus.InProgress:
                    return "InProgress";
                case WebhookQueueItemDtoStatus.Failed:
                    return "Failed";
                case WebhookQueueItemDtoStatus.Successful:
                    return "Successful";
                case WebhookQueueItemDtoStatus.Abandoned:
                    return "Abandoned";
                case WebhookQueueItemDtoStatus.Retried:
                    return "Retried";
                case WebhookQueueItemDtoStatus.Deleted:
                    return "Deleted";
            }
            return null;
        }

        internal static WebhookQueueItemDtoStatus? ParseWebhookQueueItemDtoStatus(this string value)
        {
            switch( value )
            {
                case "New":
                    return WebhookQueueItemDtoStatus.New;
                case "InProgress":
                    return WebhookQueueItemDtoStatus.InProgress;
                case "Failed":
                    return WebhookQueueItemDtoStatus.Failed;
                case "Successful":
                    return WebhookQueueItemDtoStatus.Successful;
                case "Abandoned":
                    return WebhookQueueItemDtoStatus.Abandoned;
                case "Retried":
                    return WebhookQueueItemDtoStatus.Retried;
                case "Deleted":
                    return WebhookQueueItemDtoStatus.Deleted;
            }
            return null;
        }
    }
}
