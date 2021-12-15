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
    /// The type Entitlement Management.
    /// </summary>
    public partial class EntitlementManagement : Entity
    {
    
        /// <summary>
        /// Gets or sets access package assignment approvals.
        /// </summary>
        [JsonPropertyName("accessPackageAssignmentApprovals")]
        public IEntitlementManagementAccessPackageAssignmentApprovalsCollectionPage AccessPackageAssignmentApprovals { get; set; }

        /// <summary>
        /// Gets or sets accessPackageAssignmentApprovalsNextLink.
        /// </summary>
        [JsonPropertyName("accessPackageAssignmentApprovals@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AccessPackageAssignmentApprovalsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets access packages.
        /// Access packages.
        /// </summary>
        [JsonPropertyName("accessPackages")]
        public IEntitlementManagementAccessPackagesCollectionPage AccessPackages { get; set; }

        /// <summary>
        /// Gets or sets accessPackagesNextLink.
        /// </summary>
        [JsonPropertyName("accessPackages@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AccessPackagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets assignment requests.
        /// Access package assignment requests.
        /// </summary>
        [JsonPropertyName("assignmentRequests")]
        public IEntitlementManagementAssignmentRequestsCollectionPage AssignmentRequests { get; set; }

        /// <summary>
        /// Gets or sets assignmentRequestsNextLink.
        /// </summary>
        [JsonPropertyName("assignmentRequests@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentRequestsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Access package assignments.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IEntitlementManagementAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets catalogs.
        /// Access package catalogs.
        /// </summary>
        [JsonPropertyName("catalogs")]
        public IEntitlementManagementCatalogsCollectionPage Catalogs { get; set; }

        /// <summary>
        /// Gets or sets catalogsNextLink.
        /// </summary>
        [JsonPropertyName("catalogs@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CatalogsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets connected organizations.
        /// Connected organizations.
        /// </summary>
        [JsonPropertyName("connectedOrganizations")]
        public IEntitlementManagementConnectedOrganizationsCollectionPage ConnectedOrganizations { get; set; }

        /// <summary>
        /// Gets or sets connectedOrganizationsNextLink.
        /// </summary>
        [JsonPropertyName("connectedOrganizations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ConnectedOrganizationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// Entitlement management settings.
        /// </summary>
        [JsonPropertyName("settings")]
        public EntitlementManagementSettings Settings { get; set; }
    
    }
}

