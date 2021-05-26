// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Time Off Request.
    /// </summary>
    public partial class TimeOffRequestObject : ScheduleChangeRequestObject
    {
    
        ///<summary>
        /// The TimeOffRequest constructor
        ///</summary>
        public TimeOffRequestObject()
        {
            this.ODataType = "microsoft.graph.timeOffRequest";
        }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets time off reason id.
        /// The reason for the time off.
        /// </summary>
        [JsonPropertyName("timeOffReasonId")]
        public string TimeOffReasonId { get; set; }
    
    }
}

