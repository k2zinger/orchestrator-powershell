// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MaintenanceSetting
    {
        /// <summary>
        /// Initializes a new instance of the MaintenanceSetting class.
        /// </summary>
        public MaintenanceSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaintenanceSetting class.
        /// </summary>
        /// <param name="state">Possible values include: 'None', 'Draining',
        /// 'Suspended'</param>
        public MaintenanceSetting(MaintenanceSettingState? state = default(MaintenanceSettingState?), IList<MaintenanceStateLog> maintenanceLogs = default(IList<MaintenanceStateLog>), int? jobStopsAttempted = default(int?), int? jobKillsAttempted = default(int?), int? triggersSkipped = default(int?), int? systemTriggersSkipped = default(int?))
        {
            State = state;
            MaintenanceLogs = maintenanceLogs;
            JobStopsAttempted = jobStopsAttempted;
            JobKillsAttempted = jobKillsAttempted;
            TriggersSkipped = triggersSkipped;
            SystemTriggersSkipped = systemTriggersSkipped;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Draining',
        /// 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public MaintenanceSettingState? State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maintenanceLogs")]
        public IList<MaintenanceStateLog> MaintenanceLogs { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobStopsAttempted")]
        public int? JobStopsAttempted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobKillsAttempted")]
        public int? JobKillsAttempted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "triggersSkipped")]
        public int? TriggersSkipped { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemTriggersSkipped")]
        public int? SystemTriggersSkipped { get; set; }

    }
}
