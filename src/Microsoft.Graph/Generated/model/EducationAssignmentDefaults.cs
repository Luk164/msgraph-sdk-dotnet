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
    /// The type Education Assignment Defaults.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EducationAssignmentDefaults>))]
    public partial class EducationAssignmentDefaults : Entity
    {
    
        /// <summary>
        /// Gets or sets added student action.
        /// Class-level default behavior for handling students who are added after the assignment is published. Possible values are: none, assignIfOpen.
        /// </summary>
        [JsonPropertyName("addedStudentAction")]
        public EducationAddedStudentAction? AddedStudentAction { get; set; }
    
        /// <summary>
        /// Gets or sets add to calendar action.
        /// Optional field to control adding assignments to students' and teachers' calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: studentsOnly. The default value is none.
        /// </summary>
        [JsonPropertyName("addToCalendarAction")]
        public EducationAddToCalendarOptions? AddToCalendarAction { get; set; }
    
        /// <summary>
        /// Gets or sets due time.
        /// Class-level default value for due time field. Default value is 23:59:00.
        /// </summary>
        [JsonPropertyName("dueTime")]
        public TimeOfDay DueTime { get; set; }
    
        /// <summary>
        /// Gets or sets notification channel url.
        /// Default Teams channel to which notifications will be sent. Default value is null.
        /// </summary>
        [JsonPropertyName("notificationChannelUrl")]
        public string NotificationChannelUrl { get; set; }
    
    }
}

