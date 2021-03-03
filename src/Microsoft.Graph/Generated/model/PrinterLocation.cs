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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PrinterLocation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PrinterLocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterLocation"/> class.
        /// </summary>
        public PrinterLocation()
        {
            this.ODataType = "microsoft.graph.printerLocation";
        }

        /// <summary>
        /// Gets or sets altitudeInMeters.
        /// The altitude, in meters, that the printer is located at.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "altitudeInMeters", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AltitudeInMeters { get; set; }
    
        /// <summary>
        /// Gets or sets building.
        /// The building that the printer is located in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "building", Required = Newtonsoft.Json.Required.Default)]
        public string Building { get; set; }
    
        /// <summary>
        /// Gets or sets city.
        /// The city that the printer is located in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city", Required = Newtonsoft.Json.Required.Default)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets countryOrRegion.
        /// The country or region that the printer is located in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryOrRegion", Required = Newtonsoft.Json.Required.Default)]
        public string CountryOrRegion { get; set; }
    
        /// <summary>
        /// Gets or sets floor.
        /// The floor that the printer is located on. Only numerical values are supported right now.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "floor", Required = Newtonsoft.Json.Required.Default)]
        public string Floor { get; set; }
    
        /// <summary>
        /// Gets or sets floorDescription.
        /// The description of the floor that the printer is located on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "floorDescription", Required = Newtonsoft.Json.Required.Default)]
        public string FloorDescription { get; set; }
    
        /// <summary>
        /// Gets or sets latitude.
        /// The latitude that the printer is located at.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "latitude", Required = Newtonsoft.Json.Required.Default)]
        public double? Latitude { get; set; }
    
        /// <summary>
        /// Gets or sets longitude.
        /// The longitude that the printer is located at.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "longitude", Required = Newtonsoft.Json.Required.Default)]
        public double? Longitude { get; set; }
    
        /// <summary>
        /// Gets or sets organization.
        /// The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organization", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Organization { get; set; }
    
        /// <summary>
        /// Gets or sets postalCode.
        /// The postal code that the printer is located in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postalCode", Required = Newtonsoft.Json.Required.Default)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or sets roomDescription.
        /// The description of the room that the printer is located in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roomDescription", Required = Newtonsoft.Json.Required.Default)]
        public string RoomDescription { get; set; }
    
        /// <summary>
        /// Gets or sets roomName.
        /// The room that the printer is located in. Only numerical values are supported right now.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roomName", Required = Newtonsoft.Json.Required.Default)]
        public string RoomName { get; set; }
    
        /// <summary>
        /// Gets or sets site.
        /// The site that the printer is located in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "site", Required = Newtonsoft.Json.Required.Default)]
        public string Site { get; set; }
    
        /// <summary>
        /// Gets or sets stateOrProvince.
        /// The state or province that the printer is located in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "stateOrProvince", Required = Newtonsoft.Json.Required.Default)]
        public string StateOrProvince { get; set; }
    
        /// <summary>
        /// Gets or sets streetAddress.
        /// The street address where the printer is located.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "streetAddress", Required = Newtonsoft.Json.Required.Default)]
        public string StreetAddress { get; set; }
    
        /// <summary>
        /// Gets or sets subdivision.
        /// The subdivision that the printer is located in. The elements should be in hierarchical order.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subdivision", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Subdivision { get; set; }
    
        /// <summary>
        /// Gets or sets subunit.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subunit", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Subunit { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
