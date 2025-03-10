// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI user access right entry for a dashboard
    /// </summary>
    public partial class DashboardUser : User
    {
        /// <summary>
        /// Initializes a new instance of the DashboardUser class.
        /// </summary>
        public DashboardUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DashboardUser class.
        /// </summary>
        /// <param name="identifier">Identifier of the principal</param>
        /// <param name="principalType">Possible values include: 'None',
        /// 'User', 'Group', 'App'</param>
        /// <param name="dashboardUserAccessRight">The access right that the
        /// user has for the dashboard (permission level). Possible values
        /// include: 'None', 'Read', 'ReadWrite', 'ReadReshare', 'ReadCopy',
        /// 'Owner'</param>
        /// <param name="emailAddress">Email address of the user</param>
        /// <param name="displayName">Display name of the principal</param>
        /// <param name="graphId">Identifier of the principal in Microsoft
        /// Graph. Only available for admin APIs.</param>
        public DashboardUser(string identifier, PrincipalType principalType, DashboardUserAccessRight dashboardUserAccessRight, string emailAddress = default(string), string displayName = default(string), string graphId = default(string))
            : base(identifier, principalType, emailAddress, displayName, graphId)
        {
            DashboardUserAccessRight = dashboardUserAccessRight;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access right that the user has for the dashboard
        /// (permission level). Possible values include: 'None', 'Read',
        /// 'ReadWrite', 'ReadReshare', 'ReadCopy', 'Owner'
        /// </summary>
        [JsonProperty(PropertyName = "dashboardUserAccessRight")]
        public DashboardUserAccessRight DashboardUserAccessRight { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
