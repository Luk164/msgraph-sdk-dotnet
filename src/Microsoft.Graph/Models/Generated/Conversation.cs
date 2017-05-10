// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Conversation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Conversation : Entity
    {
    
        /// <summary>
        /// Gets or sets topic.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topic", Required = Newtonsoft.Json.Required.Default)]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets last delivered date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastDeliveredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets unique senders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uniqueSenders", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> UniqueSenders { get; set; }
    
        /// <summary>
        /// Gets or sets preview.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preview", Required = Newtonsoft.Json.Required.Default)]
        public string Preview { get; set; }
    
        /// <summary>
        /// Gets or sets threads.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "threads", Required = Newtonsoft.Json.Required.Default)]
        public IConversationThreadsCollectionPage Threads { get; set; }
    
    }
}

