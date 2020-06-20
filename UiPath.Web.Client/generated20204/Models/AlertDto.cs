// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores notification data used to inform the users about specific
    /// application events.
    /// </summary>
    public partial class AlertDto
    {
        /// <summary>
        /// Initializes a new instance of the AlertDto class.
        /// </summary>
        public AlertDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertDto class.
        /// </summary>
        /// <param name="severity">The severity level of the alert. Possible
        /// values include: 'Info', 'Success', 'Warn', 'Error', 'Fatal'</param>
        /// <param name="notificationName">The name of a specific type of
        /// notification, e.g. Robot.StatusChanged.NotResponding.</param>
        /// <param name="data">Stores data about the context in which the event
        /// occurred, in JSON format.</param>
        /// <param name="component">The component that raised the alert.
        /// Possible values include: 'Robots', 'Transactions', 'Schedules',
        /// 'Jobs', 'Process', 'Tasks', 'Queues'</param>
        /// <param name="creationTime">The date and time when the alert was
        /// generated.</param>
        /// <param name="state">Defines if a specified notification has been
        /// read or not.
        /// &lt;para /&gt;Members: Unread (0) - the specified notification has
        /// not been marked as read; Read (1) - the specified notification has
        /// been marked as read. Possible values include: 'Unread',
        /// 'Read'</param>
        /// <param name="userNotificationId">The database unique identifier for
        /// the alert notification sent to the current user.</param>
        public AlertDto(AlertDtoSeverity severity, string notificationName = default(string), string data = default(string), AlertDtoComponent? component = default(AlertDtoComponent?), System.DateTime? creationTime = default(System.DateTime?), AlertDtoState? state = default(AlertDtoState?), System.Guid? userNotificationId = default(System.Guid?), System.Guid? id = default(System.Guid?))
        {
            NotificationName = notificationName;
            Data = data;
            Component = component;
            Severity = severity;
            CreationTime = creationTime;
            State = state;
            UserNotificationId = userNotificationId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of a specific type of notification, e.g.
        /// Robot.StatusChanged.NotResponding.
        /// </summary>
        [JsonProperty(PropertyName = "NotificationName")]
        public string NotificationName { get; set; }

        /// <summary>
        /// Gets or sets stores data about the context in which the event
        /// occurred, in JSON format.
        /// </summary>
        [JsonProperty(PropertyName = "Data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the component that raised the alert. Possible values
        /// include: 'Robots', 'Transactions', 'Schedules', 'Jobs', 'Process',
        /// 'Tasks', 'Queues'
        /// </summary>
        [JsonProperty(PropertyName = "Component")]
        public AlertDtoComponent? Component { get; set; }

        /// <summary>
        /// Gets or sets the severity level of the alert. Possible values
        /// include: 'Info', 'Success', 'Warn', 'Error', 'Fatal'
        /// </summary>
        [JsonProperty(PropertyName = "Severity")]
        public AlertDtoSeverity Severity { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the alert was generated.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets defines if a specified notification has been read or
        /// not.
        /// &amp;lt;para /&amp;gt;Members: Unread (0) - the specified
        /// notification has not been marked as read; Read (1) - the specified
        /// notification has been marked as read. Possible values include:
        /// 'Unread', 'Read'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public AlertDtoState? State { get; set; }

        /// <summary>
        /// Gets or sets the database unique identifier for the alert
        /// notification sent to the current user.
        /// </summary>
        [JsonProperty(PropertyName = "UserNotificationId")]
        public System.Guid? UserNotificationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
