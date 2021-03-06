// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A managed database restore details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedDatabaseRestoreDetailsResult : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedDatabaseRestoreDetailsResult class.
        /// </summary>
        public ManagedDatabaseRestoreDetailsResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedDatabaseRestoreDetailsResult class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="status">Restore status.</param>
        /// <param name="currentRestoringFileName">Current restoring file
        /// name.</param>
        /// <param name="lastRestoredFileName">Last restored file name.</param>
        /// <param name="lastRestoredFileTime">Last restored file time.</param>
        /// <param name="percentCompleted">Percent completed.</param>
        /// <param name="unrestorableFiles">List of unrestorable files.</param>
        /// <param name="numberOfFilesDetected">Number of files
        /// detected.</param>
        /// <param name="lastUploadedFileName">Last uploaded file name.</param>
        /// <param name="lastUploadedFileTime">Last uploaded file time.</param>
        /// <param name="blockReason">The reason why restore is in Blocked
        /// state.</param>
        public ManagedDatabaseRestoreDetailsResult(string id = default(string), string name = default(string), string type = default(string), string status = default(string), string currentRestoringFileName = default(string), string lastRestoredFileName = default(string), System.DateTime? lastRestoredFileTime = default(System.DateTime?), double? percentCompleted = default(double?), IList<string> unrestorableFiles = default(IList<string>), long? numberOfFilesDetected = default(long?), string lastUploadedFileName = default(string), System.DateTime? lastUploadedFileTime = default(System.DateTime?), string blockReason = default(string))
            : base(id, name, type)
        {
            Status = status;
            CurrentRestoringFileName = currentRestoringFileName;
            LastRestoredFileName = lastRestoredFileName;
            LastRestoredFileTime = lastRestoredFileTime;
            PercentCompleted = percentCompleted;
            UnrestorableFiles = unrestorableFiles;
            NumberOfFilesDetected = numberOfFilesDetected;
            LastUploadedFileName = lastUploadedFileName;
            LastUploadedFileTime = lastUploadedFileTime;
            BlockReason = blockReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets restore status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets current restoring file name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentRestoringFileName")]
        public string CurrentRestoringFileName { get; private set; }

        /// <summary>
        /// Gets last restored file name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastRestoredFileName")]
        public string LastRestoredFileName { get; private set; }

        /// <summary>
        /// Gets last restored file time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastRestoredFileTime")]
        public System.DateTime? LastRestoredFileTime { get; private set; }

        /// <summary>
        /// Gets percent completed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.percentCompleted")]
        public double? PercentCompleted { get; private set; }

        /// <summary>
        /// Gets list of unrestorable files.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unrestorableFiles")]
        public IList<string> UnrestorableFiles { get; private set; }

        /// <summary>
        /// Gets number of files detected.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfFilesDetected")]
        public long? NumberOfFilesDetected { get; private set; }

        /// <summary>
        /// Gets last uploaded file name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUploadedFileName")]
        public string LastUploadedFileName { get; private set; }

        /// <summary>
        /// Gets last uploaded file time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUploadedFileTime")]
        public System.DateTime? LastUploadedFileTime { get; private set; }

        /// <summary>
        /// Gets the reason why restore is in Blocked state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blockReason")]
        public string BlockReason { get; private set; }

    }
}
