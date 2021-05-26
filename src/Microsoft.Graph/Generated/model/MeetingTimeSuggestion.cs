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
    /// The type MeetingTimeSuggestion.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MeetingTimeSuggestion>))]
    public partial class MeetingTimeSuggestion
    {

        /// <summary>
        /// Gets or sets attendeeAvailability.
        /// An array that shows the availability status of each attendee for this meeting suggestion.
        /// </summary>
        [JsonPropertyName("attendeeAvailability")]
        public IEnumerable<AttendeeAvailability> AttendeeAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets confidence.
        /// A percentage that represents the likelhood of all the attendees attending.
        /// </summary>
        [JsonPropertyName("confidence")]
        public double? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// An array that specifies the name and geographic location of each meeting location for this meeting suggestion.
        /// </summary>
        [JsonPropertyName("locations")]
        public IEnumerable<Location> Locations { get; set; }
    
        /// <summary>
        /// Gets or sets meetingTimeSlot.
        /// A time period suggested for the meeting.
        /// </summary>
        [JsonPropertyName("meetingTimeSlot")]
        public TimeSlot MeetingTimeSlot { get; set; }
    
        /// <summary>
        /// Gets or sets order.
        /// Order of meeting time suggestions sorted by their computed confidence value from high to low, then by chronology if there are suggestions with the same confidence.
        /// </summary>
        [JsonPropertyName("order")]
        public Int32? Order { get; set; }
    
        /// <summary>
        /// Gets or sets organizerAvailability.
        /// Availability of the meeting organizer for this meeting suggestion. Possible values are: free, tentative, busy, oof, workingElsewhere, unknown.
        /// </summary>
        [JsonPropertyName("organizerAvailability")]
        public FreeBusyStatus? OrganizerAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets suggestionReason.
        /// Reason for suggesting the meeting time.
        /// </summary>
        [JsonPropertyName("suggestionReason")]
        public string SuggestionReason { get; set; }
    
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
