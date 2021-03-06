// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Token operations.
    /// </summary>
    public partial interface IToken
    {
        /// <summary>
        /// Gets Id Token - used for SSO with Kibana
        /// </summary>
        /// <param name='responseType'>
        /// </param>
        /// <param name='redirectUri'>
        /// </param>
        /// <param name='clientId'>
        /// </param>
        /// <param name='loginHint'>
        /// </param>
        /// <param name='nonce'>
        /// </param>
        /// <param name='state'>
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
        Task<HttpOperationResponse> GetWithHttpMessagesAsync(string responseType = default(string), string redirectUri = default(string), string clientId = default(string), string loginHint = default(string), string nonce = default(string), string state = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets access token
        /// </summary>
        /// <param name='clientId'>
        /// </param>
        /// <param name='clientSecret'>
        /// </param>
        /// <param name='grantType'>
        /// </param>
        /// <param name='scope'>
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
        Task<HttpOperationResponse<AccessToken>> PostWithHttpMessagesAsync(string clientId = default(string), string clientSecret = default(string), string grantType = default(string), string scope = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
