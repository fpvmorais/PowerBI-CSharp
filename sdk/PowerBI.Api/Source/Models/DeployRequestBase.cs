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
    /// Base request to deploy content from a deployment pipeline stage.
    /// </summary>
    public partial class DeployRequestBase
    {
        /// <summary>
        /// Initializes a new instance of the DeployRequestBase class.
        /// </summary>
        public DeployRequestBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeployRequestBase class.
        /// </summary>
        /// <param name="sourceStageOrder">The order of the pipeline stages
        /// that the content should be deployed from.</param>
        /// <param name="isBackwardDeployment">Whether the deployment should be
        /// done into the previous stage, if not provided treated as
        /// false.</param>
        /// <param name="newWorkspace">Required for creating a new workspace
        /// when deploying into a stage which has no assigned workspaces. If
        /// not provided when required, deployment will fail.</param>
        /// <param name="updateAppSettings">Update org app in the target
        /// workspace settings.</param>
        /// <param name="options">Options to control the behavior of the entire
        /// deployment.</param>
        public DeployRequestBase(int sourceStageOrder, bool? isBackwardDeployment = default(bool?), PipelineNewWorkspaceRequest newWorkspace = default(PipelineNewWorkspaceRequest), PipelineUpdateAppSettings updateAppSettings = default(PipelineUpdateAppSettings), DeploymentOptions options = default(DeploymentOptions))
        {
            SourceStageOrder = sourceStageOrder;
            IsBackwardDeployment = isBackwardDeployment;
            NewWorkspace = newWorkspace;
            UpdateAppSettings = updateAppSettings;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the order of the pipeline stages that the content
        /// should be deployed from.
        /// </summary>
        [JsonProperty(PropertyName = "sourceStageOrder")]
        public int SourceStageOrder { get; set; }

        /// <summary>
        /// Gets or sets whether the deployment should be done into the
        /// previous stage, if not provided treated as false.
        /// </summary>
        [JsonProperty(PropertyName = "isBackwardDeployment")]
        public bool? IsBackwardDeployment { get; set; }

        /// <summary>
        /// Gets or sets required for creating a new workspace when deploying
        /// into a stage which has no assigned workspaces. If not provided when
        /// required, deployment will fail.
        /// </summary>
        [JsonProperty(PropertyName = "newWorkspace")]
        public PipelineNewWorkspaceRequest NewWorkspace { get; set; }

        /// <summary>
        /// Gets or sets update org app in the target workspace settings.
        /// </summary>
        [JsonProperty(PropertyName = "updateAppSettings")]
        public PipelineUpdateAppSettings UpdateAppSettings { get; set; }

        /// <summary>
        /// Gets or sets options to control the behavior of the entire
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public DeploymentOptions Options { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
