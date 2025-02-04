// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Operation status job extended info.
    /// </summary>
    [Newtonsoft.Json.JsonObject("OperationStatusJobExtendedInfo")]
    public partial class OperationStatusJobExtendedInfo : OperationStatusExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusJobExtendedInfo class.
        /// </summary>
        public OperationStatusJobExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationStatusJobExtendedInfo class.
        /// </summary>

        /// <param name="jobId">ID of the job created for this protected item.
        /// </param>
        public OperationStatusJobExtendedInfo(string jobId = default(string))

        {
            this.JobId = jobId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets iD of the job created for this protected item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobId")]
        public string JobId {get; set; }
    }
}