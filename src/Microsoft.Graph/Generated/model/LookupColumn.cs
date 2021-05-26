// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type LookupColumn.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<LookupColumn>))]
    public partial class LookupColumn
    {

        /// <summary>
        /// Gets or sets allowMultipleValues.
        /// Indicates whether multiple values can be selected from the source.
        /// </summary>
        [JsonPropertyName("allowMultipleValues")]
        public bool? AllowMultipleValues { get; set; }
    
        /// <summary>
        /// Gets or sets allowUnlimitedLength.
        /// Indicates whether values in the column should be able to exceed the standard limit of 255 characters.
        /// </summary>
        [JsonPropertyName("allowUnlimitedLength")]
        public bool? AllowUnlimitedLength { get; set; }
    
        /// <summary>
        /// Gets or sets columnName.
        /// The name of the lookup source column.
        /// </summary>
        [JsonPropertyName("columnName")]
        public string ColumnName { get; set; }
    
        /// <summary>
        /// Gets or sets listId.
        /// The unique identifier of the lookup source list.
        /// </summary>
        [JsonPropertyName("listId")]
        public string ListId { get; set; }
    
        /// <summary>
        /// Gets or sets primaryLookupColumnId.
        /// If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.
        /// </summary>
        [JsonPropertyName("primaryLookupColumnId")]
        public string PrimaryLookupColumnId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
