// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ProfilePhotoRequestBuilder.
    /// </summary>
    public partial class ProfilePhotoRequestBuilder : EntityRequestBuilder, IProfilePhotoRequestBuilder
    {

        /// <summary>
        /// Constructs a new ProfilePhotoRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ProfilePhotoRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IProfilePhotoRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IProfilePhotoRequest Request(IEnumerable<Option> options)
        {
            return new ProfilePhotoRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoContentRequestBuilder"/>.</returns>
        public IProfilePhotoContentRequestBuilder Content
        {
            get
            {
                return new ProfilePhotoContentRequestBuilder(this.AppendSegmentToRequestUrl("$value"), this.Client);
            }
        }
    
    }
}
