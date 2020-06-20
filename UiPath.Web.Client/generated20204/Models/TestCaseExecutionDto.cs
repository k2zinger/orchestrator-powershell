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

    public partial class TestCaseExecutionDto
    {
        /// <summary>
        /// Initializes a new instance of the TestCaseExecutionDto class.
        /// </summary>
        public TestCaseExecutionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestCaseExecutionDto class.
        /// </summary>
        /// <param name="status">Possible values include: 'Pending', 'Running',
        /// 'Cancelling', 'Passed', 'Failed', 'Cancelled'</param>
        public TestCaseExecutionDto(long? jobId = default(long?), System.Guid? jobKey = default(System.Guid?), TestJobDto job = default(TestJobDto), long? testSetExecutionId = default(long?), TestSetExecutionDto testSetExecution = default(TestSetExecutionDto), long? testCaseId = default(long?), TestCaseDto testCase = default(TestCaseDto), long? releaseVersionId = default(long?), string versionNumber = default(string), string entryPointPath = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), TestCaseExecutionDtoStatus? status = default(TestCaseExecutionDtoStatus?), IList<TestCaseAssertionDto> testCaseAssertions = default(IList<TestCaseAssertionDto>), string dataVariationIdentifier = default(string), long? id = default(long?))
        {
            JobId = jobId;
            JobKey = jobKey;
            Job = job;
            TestSetExecutionId = testSetExecutionId;
            TestSetExecution = testSetExecution;
            TestCaseId = testCaseId;
            TestCase = testCase;
            ReleaseVersionId = releaseVersionId;
            VersionNumber = versionNumber;
            EntryPointPath = entryPointPath;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
            TestCaseAssertions = testCaseAssertions;
            DataVariationIdentifier = dataVariationIdentifier;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JobId")]
        public long? JobId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JobKey")]
        public System.Guid? JobKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Job")]
        public TestJobDto Job { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestSetExecutionId")]
        public long? TestSetExecutionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestSetExecution")]
        public TestSetExecutionDto TestSetExecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestCaseId")]
        public long? TestCaseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestCase")]
        public TestCaseDto TestCase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseVersionId")]
        public long? ReleaseVersionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VersionNumber")]
        public string VersionNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntryPointPath")]
        public string EntryPointPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pending', 'Running',
        /// 'Cancelling', 'Passed', 'Failed', 'Cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public TestCaseExecutionDtoStatus? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestCaseAssertions")]
        public IList<TestCaseAssertionDto> TestCaseAssertions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataVariationIdentifier")]
        public string DataVariationIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TestSetExecution != null)
            {
                TestSetExecution.Validate();
            }
            if (TestCase != null)
            {
                TestCase.Validate();
            }
        }
    }
}
