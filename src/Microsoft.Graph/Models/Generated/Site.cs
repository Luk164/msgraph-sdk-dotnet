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
    /// The type Site.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Site : BaseItem
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "root", Required = Newtonsoft.Json.Required.Default)]
        public Root Root { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharepointIds", Required = Newtonsoft.Json.Required.Default)]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets site collection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteCollection", Required = Newtonsoft.Json.Required.Default)]
        public SiteCollection SiteCollection { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drive", Required = Newtonsoft.Json.Required.Default)]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drives", Required = Newtonsoft.Json.Required.Default)]
        public ISiteDrivesCollectionPage Drives { get; set; }
    
        /// <summary>
        /// Gets or sets sites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sites", Required = Newtonsoft.Json.Required.Default)]
        public ISiteSitesCollectionPage Sites { get; set; }
    
    }
}

