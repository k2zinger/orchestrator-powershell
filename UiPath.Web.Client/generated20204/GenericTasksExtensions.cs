// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GenericTasks.
    /// </summary>
    public static partial class GenericTasksExtensions
    {
            /// <summary>
            /// Returns task data dto
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TaskDataDto GetTaskDataById(this IGenericTasks operations, long taskId, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetTaskDataByIdAsync(taskId, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns task data dto
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskDataDto> GetTaskDataByIdAsync(this IGenericTasks operations, long taskId, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetTaskDataByIdWithHttpMessagesAsync(taskId, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Generic Task.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskCreateRequest'>
            /// The task to be created.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TaskDataDto CreateTask(this IGenericTasks operations, TaskCreateRequest taskCreateRequest, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.CreateTaskAsync(taskCreateRequest, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Generic Task.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskCreateRequest'>
            /// The task to be created.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskDataDto> CreateTaskAsync(this IGenericTasks operations, TaskCreateRequest taskCreateRequest, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateTaskWithHttpMessagesAsync(taskCreateRequest, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Complete the task by saving task data and action taken
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskCompletionRequest'>
            /// TaskCompletionRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void CompleteTask(this IGenericTasks operations, TaskCompletionRequest taskCompletionRequest, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.CompleteTaskAsync(taskCompletionRequest, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Complete the task by saving task data and action taken
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskCompletionRequest'>
            /// TaskCompletionRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CompleteTaskAsync(this IGenericTasks operations, TaskCompletionRequest taskCompletionRequest, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.CompleteTaskWithHttpMessagesAsync(taskCompletionRequest, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
