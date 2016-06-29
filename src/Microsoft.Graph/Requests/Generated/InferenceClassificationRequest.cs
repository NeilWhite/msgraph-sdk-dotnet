// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type InferenceClassificationRequest.
    /// </summary>
    public partial class InferenceClassificationRequest : BaseRequest, IInferenceClassificationRequest
    {
        /// <summary>
        /// Constructs a new InferenceClassificationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public InferenceClassificationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified InferenceClassification using PUT.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <returns>The created InferenceClassification.</returns>
        public Task<InferenceClassification> CreateAsync(InferenceClassification inferenceClassificationToCreate)
        {
            return this.CreateAsync(inferenceClassificationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified InferenceClassification using PUT.
        /// </summary>
        /// <param name="inferenceClassificationToCreate">The InferenceClassification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InferenceClassification.</returns>
        public async Task<InferenceClassification> CreateAsync(InferenceClassification inferenceClassificationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<InferenceClassification>(inferenceClassificationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified InferenceClassification.
        /// </summary>
        /// <returns>The task to await.</returns>
        public Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified InferenceClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<InferenceClassification>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified InferenceClassification.
        /// </summary>
        /// <returns>The InferenceClassification.</returns>
        public Task<InferenceClassification> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified InferenceClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InferenceClassification.</returns>
        public async Task<InferenceClassification> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<InferenceClassification>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <returns>The updated InferenceClassification.</returns>
        public Task<InferenceClassification> UpdateAsync(InferenceClassification inferenceClassificationToUpdate)
        {
            return this.UpdateAsync(inferenceClassificationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified InferenceClassification using PATCH.
        /// </summary>
        /// <param name="inferenceClassificationToUpdate">The InferenceClassification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated InferenceClassification.</returns>
        public async Task<InferenceClassification> UpdateAsync(InferenceClassification inferenceClassificationToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<InferenceClassification>(inferenceClassificationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IInferenceClassificationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IInferenceClassificationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="inferenceClassificationToInitialize">The <see cref="InferenceClassification"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(InferenceClassification inferenceClassificationToInitialize)
        {

            if (inferenceClassificationToInitialize != null && inferenceClassificationToInitialize.AdditionalData != null)
            {

                if (inferenceClassificationToInitialize.Overrides != null && inferenceClassificationToInitialize.Overrides.CurrentPage != null)
                {
                    inferenceClassificationToInitialize.Overrides.AdditionalData = inferenceClassificationToInitialize.AdditionalData;

                    object nextPageLink;
                    inferenceClassificationToInitialize.AdditionalData.TryGetValue("overrides@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        inferenceClassificationToInitialize.Overrides.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
