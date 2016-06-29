// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IMessageRequest.
    /// </summary>
    public partial interface IMessageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Message using PUT.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <returns>The created Message.</returns>
        Task<Message> CreateAsync(Message messageToCreate);        /// <summary>
        /// Creates the specified Message using PUT.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Message.</returns>
        Task<Message> CreateAsync(Message messageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Message.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Message.
        /// </summary>
        /// <returns>The Message.</returns>
        Task<Message> GetAsync();

        /// <summary>
        /// Gets the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Message.</returns>
        Task<Message> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Message using PATCH.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <returns>The updated Message.</returns>
        Task<Message> UpdateAsync(Message messageToUpdate);

        /// <summary>
        /// Updates the specified Message using PATCH.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Message.</returns>
        Task<Message> UpdateAsync(Message messageToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRequest Select(string value);

    }
}
