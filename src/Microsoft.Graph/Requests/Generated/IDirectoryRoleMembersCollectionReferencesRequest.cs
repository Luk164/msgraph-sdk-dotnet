// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IDirectoryRoleMembersCollectionReferencesRequest.
    /// </summary>
    public partial interface IDirectoryRoleMembersCollectionReferencesRequest : IBaseRequest
    {
        

        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(DirectoryObject directoryObject);

        /// <summary>
        /// Adds the specified DirectoryObject to the collection via POST.
        /// </summary>
        /// <param name="directoryObject">The DirectoryObject to add.</param>
        System.Threading.Tasks.Task AddAsync(DirectoryObject directoryObject, CancellationToken cancellationToken);
    }
}
