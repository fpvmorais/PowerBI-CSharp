// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI artifact access list for user
    /// </summary>
    public partial class ArtifactAccessResponse
    {
        /// <summary>
        /// Initializes a new instance of the ArtifactAccessResponse class.
        /// </summary>
        public ArtifactAccessResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArtifactAccessResponse class.
        /// </summary>
        /// <param name="value">The artifact access list for user</param>
        /// <param name="continuationUri">The URI for the next chunk in the
        /// result set</param>
        /// <param name="continuationToken">Token to get the next chunk of the
        /// result set</param>
        public ArtifactAccessResponse(string odatacontext = default(string), IList<ArtifactAccessEntry> value = default(IList<ArtifactAccessEntry>), string continuationUri = default(string), string continuationToken = default(string))
        {
            Odatacontext = odatacontext;
            Value = value;
            ContinuationUri = continuationUri;
            ContinuationToken = continuationToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the artifact access list for user
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ArtifactAccessEntry> Value { get; set; }

        /// <summary>
        /// Gets or sets the URI for the next chunk in the result set
        /// </summary>
        [JsonProperty(PropertyName = "continuationUri")]
        public string ContinuationUri { get; set; }

        /// <summary>
        /// Gets or sets token to get the next chunk of the result set
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

    }
}
