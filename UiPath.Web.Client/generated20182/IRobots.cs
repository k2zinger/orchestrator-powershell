// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Robots operations.
    /// </summary>
    public partial interface IRobots
    {
        /// <summary>
        /// Gets robots.
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.View.
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a Boolean condition.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='orderby'>
        /// Sorts the results.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results.
        /// </param>
        /// <param name='count'>
        /// Includes a count of the matching results in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListRobotDto>> GetRobotsWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates a new robot.
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.Create.
        /// </remarks>
        /// <param name='robotDto'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<RobotDto>> PostWithHttpMessagesAsync(RobotDto robotDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a single robot based on its key.
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.View.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<RobotDto>> GetByIdWithHttpMessagesAsync(long id, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Edits a robot based on its key.
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.Edit.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='robotDto'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<RobotDto>> PutByIdWithHttpMessagesAsync(long id, RobotDto robotDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a robot based on its key.
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.Delete.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='ifMatch'>
        /// If-Match header
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(long id, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets machine name to license key mapping.
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.Create.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListKeyValuePairStringString>> GetMachineNameToLicenseKeyMappingsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets usernames.
        /// </summary>
        /// <remarks>
        /// Required permissions: Robots.View.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListKeyValuePairStringString>> GetUsernamesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
