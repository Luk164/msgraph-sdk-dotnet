// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ReviewSetQueryApplyTagsRequestBody.
    /// </summary>
    public partial class ReviewSetQueryApplyTagsRequestBody
    {
    
        /// <summary>
        /// Gets or sets TagsToAdd.
        /// </summary>
        [JsonPropertyName("tagsToAdd")]
        public IEnumerable<Tag> TagsToAdd { get; set; }
    
        /// <summary>
        /// Gets or sets TagsToRemove.
        /// </summary>
        [JsonPropertyName("tagsToRemove")]
        public IEnumerable<Tag> TagsToRemove { get; set; }
    
    }
}
