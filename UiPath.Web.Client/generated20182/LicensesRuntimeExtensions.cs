// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LicensesRuntime.
    /// </summary>
    public static partial class LicensesRuntimeExtensions
    {
            /// <summary>
            /// Gets runtime licenses.
            /// </summary>
            /// <remarks>
            /// Required permissions: Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='robotType'>
            /// Possible values include: 'NonProduction', 'Attended', 'Unattended',
            /// 'Development'
            /// </param>
            public static ODataResponseListLicenseRuntimeDto GetLicensesRuntimeByRobottype(this ILicensesRuntime operations, string robotType)
            {
                return operations.GetLicensesRuntimeByRobottypeAsync(robotType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets runtime licenses.
            /// </summary>
            /// <remarks>
            /// Required permissions: Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='robotType'>
            /// Possible values include: 'NonProduction', 'Attended', 'Unattended',
            /// 'Development'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListLicenseRuntimeDto> GetLicensesRuntimeByRobottypeAsync(this ILicensesRuntime operations, string robotType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetLicensesRuntimeByRobottypeWithHttpMessagesAsync(robotType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
