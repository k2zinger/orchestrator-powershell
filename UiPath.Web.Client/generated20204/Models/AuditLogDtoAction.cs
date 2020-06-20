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
    /// Defines values for AuditLogDtoAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditLogDtoAction
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Create")]
        Create,
        [EnumMember(Value = "Update")]
        Update,
        [EnumMember(Value = "Delete")]
        Delete,
        [EnumMember(Value = "StartJob")]
        StartJob,
        [EnumMember(Value = "StopJob")]
        StopJob,
        [EnumMember(Value = "Associate")]
        Associate,
        [EnumMember(Value = "Upload")]
        Upload,
        [EnumMember(Value = "ChangeStatus")]
        ChangeStatus,
        [EnumMember(Value = "Import")]
        Import,
        [EnumMember(Value = "ChangePassword")]
        ChangePassword,
        [EnumMember(Value = "Register")]
        Register,
        [EnumMember(Value = "Toggle")]
        Toggle,
        [EnumMember(Value = "ResetPassword")]
        ResetPassword,
        [EnumMember(Value = "PasswordResetAttempt")]
        PasswordResetAttempt,
        [EnumMember(Value = "Download")]
        Download,
        [EnumMember(Value = "Acknowledge")]
        Acknowledge,
        [EnumMember(Value = "Activate")]
        Activate,
        [EnumMember(Value = "Assign")]
        Assign,
        [EnumMember(Value = "BulkUpload")]
        BulkUpload,
        [EnumMember(Value = "UpdateFeature")]
        UpdateFeature,
        [EnumMember(Value = "ResumeJob")]
        ResumeJob,
        [EnumMember(Value = "Start")]
        Start,
        [EnumMember(Value = "End")]
        End,
        [EnumMember(Value = "Skip")]
        Skip,
        [EnumMember(Value = "Unassign")]
        Unassign,
        [EnumMember(Value = "Deactivate")]
        Deactivate,
        [EnumMember(Value = "CreateBlobFileSas")]
        CreateBlobFileSas,
        [EnumMember(Value = "DeleteBlobFile")]
        DeleteBlobFile
    }
    internal static class AuditLogDtoActionEnumExtension
    {
        internal static string ToSerializedValue(this AuditLogDtoAction? value)
        {
            return value == null ? null : ((AuditLogDtoAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuditLogDtoAction value)
        {
            switch( value )
            {
                case AuditLogDtoAction.Unknown:
                    return "Unknown";
                case AuditLogDtoAction.Create:
                    return "Create";
                case AuditLogDtoAction.Update:
                    return "Update";
                case AuditLogDtoAction.Delete:
                    return "Delete";
                case AuditLogDtoAction.StartJob:
                    return "StartJob";
                case AuditLogDtoAction.StopJob:
                    return "StopJob";
                case AuditLogDtoAction.Associate:
                    return "Associate";
                case AuditLogDtoAction.Upload:
                    return "Upload";
                case AuditLogDtoAction.ChangeStatus:
                    return "ChangeStatus";
                case AuditLogDtoAction.Import:
                    return "Import";
                case AuditLogDtoAction.ChangePassword:
                    return "ChangePassword";
                case AuditLogDtoAction.Register:
                    return "Register";
                case AuditLogDtoAction.Toggle:
                    return "Toggle";
                case AuditLogDtoAction.ResetPassword:
                    return "ResetPassword";
                case AuditLogDtoAction.PasswordResetAttempt:
                    return "PasswordResetAttempt";
                case AuditLogDtoAction.Download:
                    return "Download";
                case AuditLogDtoAction.Acknowledge:
                    return "Acknowledge";
                case AuditLogDtoAction.Activate:
                    return "Activate";
                case AuditLogDtoAction.Assign:
                    return "Assign";
                case AuditLogDtoAction.BulkUpload:
                    return "BulkUpload";
                case AuditLogDtoAction.UpdateFeature:
                    return "UpdateFeature";
                case AuditLogDtoAction.ResumeJob:
                    return "ResumeJob";
                case AuditLogDtoAction.Start:
                    return "Start";
                case AuditLogDtoAction.End:
                    return "End";
                case AuditLogDtoAction.Skip:
                    return "Skip";
                case AuditLogDtoAction.Unassign:
                    return "Unassign";
                case AuditLogDtoAction.Deactivate:
                    return "Deactivate";
                case AuditLogDtoAction.CreateBlobFileSas:
                    return "CreateBlobFileSas";
                case AuditLogDtoAction.DeleteBlobFile:
                    return "DeleteBlobFile";
            }
            return null;
        }

        internal static AuditLogDtoAction? ParseAuditLogDtoAction(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return AuditLogDtoAction.Unknown;
                case "Create":
                    return AuditLogDtoAction.Create;
                case "Update":
                    return AuditLogDtoAction.Update;
                case "Delete":
                    return AuditLogDtoAction.Delete;
                case "StartJob":
                    return AuditLogDtoAction.StartJob;
                case "StopJob":
                    return AuditLogDtoAction.StopJob;
                case "Associate":
                    return AuditLogDtoAction.Associate;
                case "Upload":
                    return AuditLogDtoAction.Upload;
                case "ChangeStatus":
                    return AuditLogDtoAction.ChangeStatus;
                case "Import":
                    return AuditLogDtoAction.Import;
                case "ChangePassword":
                    return AuditLogDtoAction.ChangePassword;
                case "Register":
                    return AuditLogDtoAction.Register;
                case "Toggle":
                    return AuditLogDtoAction.Toggle;
                case "ResetPassword":
                    return AuditLogDtoAction.ResetPassword;
                case "PasswordResetAttempt":
                    return AuditLogDtoAction.PasswordResetAttempt;
                case "Download":
                    return AuditLogDtoAction.Download;
                case "Acknowledge":
                    return AuditLogDtoAction.Acknowledge;
                case "Activate":
                    return AuditLogDtoAction.Activate;
                case "Assign":
                    return AuditLogDtoAction.Assign;
                case "BulkUpload":
                    return AuditLogDtoAction.BulkUpload;
                case "UpdateFeature":
                    return AuditLogDtoAction.UpdateFeature;
                case "ResumeJob":
                    return AuditLogDtoAction.ResumeJob;
                case "Start":
                    return AuditLogDtoAction.Start;
                case "End":
                    return AuditLogDtoAction.End;
                case "Skip":
                    return AuditLogDtoAction.Skip;
                case "Unassign":
                    return AuditLogDtoAction.Unassign;
                case "Deactivate":
                    return AuditLogDtoAction.Deactivate;
                case "CreateBlobFileSas":
                    return AuditLogDtoAction.CreateBlobFileSas;
                case "DeleteBlobFile":
                    return AuditLogDtoAction.DeleteBlobFile;
            }
            return null;
        }
    }
}
