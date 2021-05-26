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
    /// The type OnlineMeetingInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnlineMeetingInfo>))]
    public partial class OnlineMeetingInfo
    {

        /// <summary>
        /// Gets or sets conferenceId.
        /// The ID of the conference.
        /// </summary>
        [JsonPropertyName("conferenceId")]
        public string ConferenceId { get; set; }
    
        /// <summary>
        /// Gets or sets joinUrl.
        /// The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.
        /// </summary>
        [JsonPropertyName("joinUrl")]
        public string JoinUrl { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// All of the phone numbers associated with this conference.
        /// </summary>
        [JsonPropertyName("phones")]
        public IEnumerable<Phone> Phones { get; set; }
    
        /// <summary>
        /// Gets or sets quickDial.
        /// The pre-formatted quickdial for this call.
        /// </summary>
        [JsonPropertyName("quickDial")]
        public string QuickDial { get; set; }
    
        /// <summary>
        /// Gets or sets tollFreeNumbers.
        /// The toll free numbers that can be used to join the conference.
        /// </summary>
        [JsonPropertyName("tollFreeNumbers")]
        public IEnumerable<string> TollFreeNumbers { get; set; }
    
        /// <summary>
        /// Gets or sets tollNumber.
        /// The toll number that can be used to join the conference.
        /// </summary>
        [JsonPropertyName("tollNumber")]
        public string TollNumber { get; set; }
    
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
