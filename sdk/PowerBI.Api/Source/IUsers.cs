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
    /// Users operations.
    /// </summary>
    public partial interface IUsers
    {
        /// <summary>
        /// Refreshes user permissions in Power BI.
        /// </summary>
        /// <remarks>
        ///
        /// When a user is granted permissions to a workspace, app, or Power BI
        /// item (such as a report or a dashboard), the new permissions might
        /// not be immediately available through API calls. This operation
        /// refreshes user permissions to ensure they're fully updated.
        ///
        /// &gt; [!IMPORTANT]
        /// &gt;
        /// &gt; - Call **Refresh User Permissions** before making other API
        /// calls.
        /// &gt; - Since it takes about two minutes for the permissions to get
        /// refreshed, wait for two minutes before making other API calls.
        ///
        /// ## Required Scope
        ///
        /// Workspace.Read.All or Workspace.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum one call per hour.
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
        Task<HttpOperationResponse> RefreshUserPermissionsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of Power BI items (such as reports or dashboards)
        /// that the specified user has access to.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='userId'>
        /// The graph ID or user principal name (UPN) of the user
        /// </param>
        /// <param name='continuationToken'>
        /// Token required to get the next chunk of the result set
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
        Task<HttpOperationResponse<ArtifactAccessResponse>> GetUserArtifactAccessAsAdminWithHttpMessagesAsync(string userId, string continuationToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of subscriptions for the specified user. This is a
        /// preview API call.
        /// </summary>
        /// <remarks>
        ///
        /// ### Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='userId'>
        /// The graph ID or user principal name (UPN) of the user
        /// </param>
        /// <param name='continuationToken'>
        /// Token required to get the next chunk of the result set
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
        Task<HttpOperationResponse<SubscriptionsByUserResponse>> GetUserSubscriptionsAsAdminWithHttpMessagesAsync(string userId, string continuationToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
