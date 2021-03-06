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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Settings operations.
    /// </summary>
    public partial interface ISettings
    {
        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
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
        Task<HttpOperationResponse<ODataValueIEnumerableSettingsDto>> GetWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a settings value based on its key.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ODataValueString>> GetByIdWithHttpMessagesAsync(string id, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Edits a setting.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Edit.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='settingsDto'>
        /// The entity to put
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
        Task<HttpOperationResponse<SettingsDto>> PutByIdWithHttpMessagesAsync(string id, SettingsDto settingsDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns a collection of key value pairs representing all service
        /// settings used by a robot. A valid robot license key is required in
        /// the request headers.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
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
        Task<HttpOperationResponse<ResponseDictionaryDto>> GetServicesSettingsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns a collection of key value pairs representing settings used
        /// by Orchestrator web client.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Requires authentication.
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
        Task<HttpOperationResponse<ResponseDictionaryDto>> GetWebSettingsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the authentication settings
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
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
        Task<HttpOperationResponse<ResponseDictionaryDto>> GetAuthenticationSettingsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the execution settings configuration (display name, value
        /// type, etc.).
        /// If scope is 0 (Global), the default values will be the initial
        /// ones. If scope is 1 (Robot), then
        /// the default values will be the actual values set globally.
        /// e.g., Resolution width
        /// Assume it was set globally to 720.
        /// Then within the config returned by this function, the default value
        /// for this setting will be:
        /// - 0 for scope = 0 and
        /// - 720 for scope = 1.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.Edit or Robots.Create or
        /// Robots.Edit.
        /// </remarks>
        /// <param name='scope'>
        /// Scope of the configuration; 0 for Global, 1 for Robot
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
        Task<HttpOperationResponse<ExecutionSettingsConfiguration>> GetExecutionSettingsConfigurationByScopeWithHttpMessagesAsync(int scope, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the configuration format for a Secure store
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
        /// </remarks>
        /// <param name='storeTypeName'>
        /// name of the secure store type
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
        Task<HttpOperationResponse<ODataValueIEnumerableConfigurationEntry>> GetSecureStoreConfigurationByStoretypenameWithHttpMessagesAsync(string storeTypeName, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets the connection string
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
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
        Task<HttpOperationResponse<ODataValueString>> GetConnectionStringWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieves the current license information.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Requires authentication.
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
        Task<HttpOperationResponse<LicenseDto>> GetLicenseWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Uploads a new license file that was previously generated with
        /// Regutil. The content of the license is sent as a file embedded in
        /// the HTTP request.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Create or License.Edit.
        /// </remarks>
        /// <param name='file'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UploadLicenseWithHttpMessagesAsync(Stream file, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Removes the license
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Delete.
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
        Task<HttpOperationResponse> DeleteLicenseWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets timezones.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
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
        Task<HttpOperationResponse<ListResultDtoNameValueDto>> GetTimezonesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the current settings.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Edit.
        /// </remarks>
        /// <param name='updateBulkParameters'>
        /// Settings - The collection of settings to be updated.
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
        Task<HttpOperationResponse> UpdateBulkWithHttpMessagesAsync(UpdateBulkParameters updateBulkParameters = default(UpdateBulkParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets supported languages
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
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
        Task<HttpOperationResponse<ListResultDtoLanguageInfo>> GetLanguagesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets custom calendar, with excluded dates in UTC, for current
        /// tenant
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<CalendarDto>> GetCalendarWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Sets custom calendar, with excluded dates in UTC, for current
        /// tenant
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Edit.
        /// </remarks>
        /// <param name='calendar'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse> SetCalendarWithHttpMessagesAsync(CalendarDto calendar, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Verify whether the given SMTP settings are correct or not by
        /// sending an email to a recipient.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Edit.
        /// </remarks>
        /// <param name='smtpParameters'>
        /// SMTP setting parameters
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
        Task<HttpOperationResponse> VerifySmtpSettingWithHttpMessagesAsync(SmtpParameters smtpParameters = default(SmtpParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Activate the license for a specific tenant
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Create or License.Edit.
        /// </remarks>
        /// <param name='activateLicenseParameters'>
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
        Task<HttpOperationResponse> ActivateLicenseOnlineWithHttpMessagesAsync(ActivateLicenseParameters activateLicenseParameters = default(ActivateLicenseParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create the offline activation request for a specific tenant
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Create or License.Edit.
        /// </remarks>
        /// <param name='activateLicenseParameters'>
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
        Task<HttpOperationResponse<ODataValueString>> GetLicenseOfflineWithHttpMessagesAsync(ActivateLicenseParameters activateLicenseParameters = default(ActivateLicenseParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update the license for a specific tenant
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Edit.
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
        Task<HttpOperationResponse> UpdateLicenseOnlineWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Uploads a new offline license activation.
        /// The content of the license is sent as a file embedded in the HTTP
        /// request.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Create or License.Edit.
        /// </remarks>
        /// <param name='file'>
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> ActivateLicenseOfflineWithHttpMessagesAsync(Stream file, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deactivate the license for a specific tenant
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Delete.
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
        Task<HttpOperationResponse> DeactivateLicenseOnlineWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deactivate the license offline for a specific tenant
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: License.Delete.
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
        Task<HttpOperationResponse<ODataValueString>> GetDeactivateLicenseOfflineWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
