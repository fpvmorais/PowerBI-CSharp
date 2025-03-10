// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CapacitiesOperations.
    /// </summary>
    public static partial class CapacitiesOperationsExtensions
    {
            /// <summary>
            /// Returns a list of capacities that the user has access to.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Capacities GetCapacities(this ICapacitiesOperations operations)
            {
                return operations.GetCapacitiesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of capacities that the user has access to.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Capacities> GetCapacitiesAsync(this ICapacitiesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCapacitiesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the current state of the specified capacity workloads. If a
            /// workload is enabled, the percentage of maximum memory that the workload can
            /// consume is also returned.
            /// </summary>
            /// <remarks>
            ///
            /// Workload APIs aren't relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            public static Workloads GetWorkloads(this ICapacitiesOperations operations, System.Guid capacityId)
            {
                return operations.GetWorkloadsAsync(capacityId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the current state of the specified capacity workloads. If a
            /// workload is enabled, the percentage of maximum memory that the workload can
            /// consume is also returned.
            /// </summary>
            /// <remarks>
            ///
            /// Workload APIs aren't relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workloads> GetWorkloadsAsync(this ICapacitiesOperations operations, System.Guid capacityId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkloadsWithHttpMessagesAsync(capacityId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the current state of a workload. If the workload is enabled, the
            /// percentage of maximum memory that the workload can consume is also
            /// returned.
            /// </summary>
            /// <remarks>
            ///
            /// Workload APIs aren't relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            public static Workload GetWorkload(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName)
            {
                return operations.GetWorkloadAsync(capacityId, workloadName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the current state of a workload. If the workload is enabled, the
            /// percentage of maximum memory that the workload can consume is also
            /// returned.
            /// </summary>
            /// <remarks>
            ///
            /// Workload APIs aren't relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workload> GetWorkloadAsync(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkloadWithHttpMessagesAsync(capacityId, workloadName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Changes the state of a specific workload to *Enabled* or *Disabled*. When
            /// enabling a workload, specify the percentage of maximum memory that the
            /// workload can consume.
            /// </summary>
            /// <remarks>
            ///
            /// Workload APIs aren't relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.
            ///
            /// ## Required Scope
            ///
            /// Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            /// <param name='workload'>
            /// Patch workload parameters
            /// </param>
            public static void PatchWorkload(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName, PatchWorkloadRequest workload)
            {
                operations.PatchWorkloadAsync(capacityId, workloadName, workload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the state of a specific workload to *Enabled* or *Disabled*. When
            /// enabling a workload, specify the percentage of maximum memory that the
            /// workload can consume.
            /// </summary>
            /// <remarks>
            ///
            /// Workload APIs aren't relevant for [Embedded
            /// Gen2](/power-bi/developer/embedded/power-bi-embedded-generation-2)
            /// capacities.
            ///
            /// ## Required Scope
            ///
            /// Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='workloadName'>
            /// The name of the workload
            /// </param>
            /// <param name='workload'>
            /// Patch workload parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchWorkloadAsync(this ICapacitiesOperations operations, System.Guid capacityId, string workloadName, PatchWorkloadRequest workload, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PatchWorkloadWithHttpMessagesAsync(capacityId, workloadName, workload, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of refreshables for all capacities that the user has access
            /// to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            public static Refreshables GetRefreshables(this ICapacitiesOperations operations, int top, string expand = default(string), string filter = default(string), int? skip = default(int?))
            {
                return operations.GetRefreshablesAsync(top, expand, filter, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of refreshables for all capacities that the user has access
            /// to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshablesAsync(this ICapacitiesOperations operations, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshablesWithHttpMessagesAsync(top, expand, filter, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of refreshables for the specified capacity that the user has
            /// access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            public static Refreshables GetRefreshablesForCapacity(this ICapacitiesOperations operations, System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?))
            {
                return operations.GetRefreshablesForCapacityAsync(capacityId, top, expand, filter, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of refreshables for the specified capacity that the user has
            /// access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results. Use with top to fetch results beyond the first
            /// 1000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshablesForCapacityAsync(this ICapacitiesOperations operations, System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshablesForCapacityWithHttpMessagesAsync(capacityId, top, expand, filter, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified refreshable for the specified capacity that the user
            /// has access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='refreshableId'>
            /// The refreshable ID
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            public static Refreshables GetRefreshableForCapacity(this ICapacitiesOperations operations, System.Guid capacityId, string refreshableId, string expand = default(string))
            {
                return operations.GetRefreshableForCapacityAsync(capacityId, refreshableId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified refreshable for the specified capacity that the user
            /// has access to.
            /// </summary>
            /// <remarks>
            ///
            /// Power BI retains a seven-day refresh history for each dataset, up to a
            /// maximum of sixty refreshes.
            ///
            /// ## Required Scope
            ///
            /// Capacity.Read.All or Capacity.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='refreshableId'>
            /// The refreshable ID
            /// </param>
            /// <param name='expand'>
            /// Accepts a comma-separated list of data types, which will be expanded inline
            /// in the response. Supports `capacities` and `groups`.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Refreshables> GetRefreshableForCapacityAsync(this ICapacitiesOperations operations, System.Guid capacityId, string refreshableId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRefreshableForCapacityWithHttpMessagesAsync(capacityId, refreshableId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Assigns the specified workspaces to the specified Premium capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator).
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces capacity parameters
            /// </param>
            public static void AssignWorkspacesToCapacity(this ICapacitiesOperations operations, AssignWorkspacesToCapacityRequest requestParameters)
            {
                operations.AssignWorkspacesToCapacityAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Assigns the specified workspaces to the specified Premium capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator).
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AssignWorkspacesToCapacityAsync(this ICapacitiesOperations operations, AssignWorkspacesToCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AssignWorkspacesToCapacityWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Unassigns the specified workspaces from capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator).
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces to shared capacity parameters
            /// </param>
            public static void UnassignWorkspacesFromCapacity(this ICapacitiesOperations operations, UnassignWorkspacesCapacityRequest requestParameters)
            {
                operations.UnassignWorkspacesFromCapacityAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unassigns the specified workspaces from capacity.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator).
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Admin assign workspaces to shared capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UnassignWorkspacesFromCapacityAsync(this ICapacitiesOperations operations, UnassignWorkspacesCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UnassignWorkspacesFromCapacityWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a list of users that have access to the specified workspace.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator).
            /// - Delegated permissions are supported.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            public static CapacityUsers GetCapacityUsersAsAdmin(this ICapacitiesOperations operations, System.Guid capacityId)
            {
                return operations.GetCapacityUsersAsAdminAsync(capacityId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users that have access to the specified workspace.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator).
            /// - Delegated permissions are supported.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='capacityId'>
            /// The capacity ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityUsers> GetCapacityUsersAsAdminAsync(this ICapacitiesOperations operations, System.Guid capacityId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCapacityUsersAsAdminWithHttpMessagesAsync(capacityId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
