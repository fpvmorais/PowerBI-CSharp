// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CapacitiesOperations operations.
    /// </summary>
    public partial interface ICapacitiesOperations
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
        Task<HttpOperationResponse<Capacities>> GetCapacitiesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the current state of the specified capacity workloads. If a
        /// workload is enabled, the percentage of maximum memory that the
        /// workload can consume is also returned.
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
        /// <param name='capacityId'>
        /// The capacity ID
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
        Task<HttpOperationResponse<Workloads>> GetWorkloadsWithHttpMessagesAsync(System.Guid capacityId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the current state of a workload. If the workload is
        /// enabled, the percentage of maximum memory that the workload can
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
        /// <param name='capacityId'>
        /// The capacity ID
        /// </param>
        /// <param name='workloadName'>
        /// The name of the workload
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
        Task<HttpOperationResponse<Workload>> GetWorkloadWithHttpMessagesAsync(System.Guid capacityId, string workloadName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Changes the state of a specific workload to *Enabled* or
        /// *Disabled*. When enabling a workload, specify the percentage of
        /// maximum memory that the workload can consume.
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
        /// <param name='capacityId'>
        /// The capacity ID
        /// </param>
        /// <param name='workloadName'>
        /// The name of the workload
        /// </param>
        /// <param name='workload'>
        /// Patch workload parameters
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
        Task<HttpOperationResponse> PatchWorkloadWithHttpMessagesAsync(System.Guid capacityId, string workloadName, PatchWorkloadRequest workload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of refreshables for all capacities that the user has
        /// access to.
        /// </summary>
        /// <remarks>
        ///
        /// Power BI retains a seven-day refresh history for each dataset, up
        /// to a maximum of sixty refreshes.
        ///
        /// ## Required Scope
        ///
        /// Capacity.Read.All or Capacity.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='expand'>
        /// Accepts a comma-separated list of data types, which will be
        /// expanded inline in the response. Supports `capacities` and
        /// `groups`.
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 1000.
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
        Task<HttpOperationResponse<Refreshables>> GetRefreshablesWithHttpMessagesAsync(int top, string expand = default(string), string filter = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of refreshables for the specified capacity that the
        /// user has access to.
        /// </summary>
        /// <remarks>
        ///
        /// Power BI retains a seven-day refresh history for each dataset, up
        /// to a maximum of sixty refreshes.
        ///
        /// ## Required Scope
        ///
        /// Capacity.Read.All or Capacity.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity ID
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='expand'>
        /// Accepts a comma-separated list of data types, which will be
        /// expanded inline in the response. Supports `capacities` and
        /// `groups`.
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 1000.
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
        Task<HttpOperationResponse<Refreshables>> GetRefreshablesForCapacityWithHttpMessagesAsync(System.Guid capacityId, int top, string expand = default(string), string filter = default(string), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified refreshable for the specified capacity that
        /// the user has access to.
        /// </summary>
        /// <remarks>
        ///
        /// Power BI retains a seven-day refresh history for each dataset, up
        /// to a maximum of sixty refreshes.
        ///
        /// ## Required Scope
        ///
        /// Capacity.Read.All or Capacity.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity ID
        /// </param>
        /// <param name='refreshableId'>
        /// The refreshable ID
        /// </param>
        /// <param name='expand'>
        /// Accepts a comma-separated list of data types, which will be
        /// expanded inline in the response. Supports `capacities` and
        /// `groups`.
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
        Task<HttpOperationResponse<Refreshables>> GetRefreshableForCapacityWithHttpMessagesAsync(System.Guid capacityId, string refreshableId, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
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
        /// <param name='requestParameters'>
        /// Admin assign workspaces capacity parameters
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
        Task<HttpOperationResponse> AssignWorkspacesToCapacityWithHttpMessagesAsync(AssignWorkspacesToCapacityRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
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
        /// <param name='requestParameters'>
        /// Admin assign workspaces to shared capacity parameters
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
        Task<HttpOperationResponse> UnassignWorkspacesFromCapacityWithHttpMessagesAsync(UnassignWorkspacesCapacityRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users that have access to the specified
        /// workspace.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator).
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='capacityId'>
        /// The capacity ID
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
        Task<HttpOperationResponse<CapacityUsers>> GetCapacityUsersAsAdminWithHttpMessagesAsync(System.Guid capacityId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
