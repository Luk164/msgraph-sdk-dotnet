// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum PurgeType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PurgeType
    {
    
        /// <summary>
        /// Recoverable
        /// </summary>
        Recoverable = 0,
	
        /// <summary>
        /// Permanently Deleted
        /// </summary>
        PermanentlyDeleted = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
