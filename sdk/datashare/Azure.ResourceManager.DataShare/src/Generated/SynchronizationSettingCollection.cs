// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="SynchronizationSettingResource" /> and their operations.
    /// Each <see cref="SynchronizationSettingResource" /> in the collection will belong to the same instance of <see cref="ShareResource" />.
    /// To get a <see cref="SynchronizationSettingCollection" /> instance call the GetSynchronizationSettings method from an instance of <see cref="ShareResource" />.
    /// </summary>
    public partial class SynchronizationSettingCollection : ArmCollection, IEnumerable<SynchronizationSettingResource>, IAsyncEnumerable<SynchronizationSettingResource>
    {
        private readonly ClientDiagnostics _synchronizationSettingClientDiagnostics;
        private readonly SynchronizationSettingsRestOperations _synchronizationSettingRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynchronizationSettingCollection"/> class for mocking. </summary>
        protected SynchronizationSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynchronizationSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynchronizationSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synchronizationSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", SynchronizationSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynchronizationSettingResource.ResourceType, out string synchronizationSettingApiVersion);
            _synchronizationSettingRestClient = new SynchronizationSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synchronizationSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ShareResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ShareResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a synchronizationSetting
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="data"> The new synchronization setting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynchronizationSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string synchronizationSettingName, SynchronizationSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synchronizationSettingRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataShareArmOperation<SynchronizationSettingResource>(Response.FromValue(new SynchronizationSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a synchronizationSetting
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="data"> The new synchronization setting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynchronizationSettingResource> CreateOrUpdate(WaitUntil waitUntil, string synchronizationSettingName, SynchronizationSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synchronizationSettingRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, data, cancellationToken);
                var operation = new DataShareArmOperation<SynchronizationSettingResource>(Response.FromValue(new SynchronizationSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a synchronizationSetting in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Get
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual async Task<Response<SynchronizationSettingResource>> GetAsync(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _synchronizationSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynchronizationSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a synchronizationSetting in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Get
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual Response<SynchronizationSettingResource> Get(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _synchronizationSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynchronizationSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List synchronizationSettings in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings
        /// Operation Id: SynchronizationSettings_ListByShare
        /// </summary>
        /// <param name="skipToken"> continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynchronizationSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynchronizationSettingResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SynchronizationSettingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _synchronizationSettingRestClient.ListByShareAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SynchronizationSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SynchronizationSettingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _synchronizationSettingRestClient.ListByShareNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SynchronizationSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List synchronizationSettings in a share
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings
        /// Operation Id: SynchronizationSettings_ListByShare
        /// </summary>
        /// <param name="skipToken"> continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynchronizationSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynchronizationSettingResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<SynchronizationSettingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _synchronizationSettingRestClient.ListByShare(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SynchronizationSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SynchronizationSettingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _synchronizationSettingRestClient.ListByShareNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SynchronizationSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Get
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synchronizationSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}/shares/{shareName}/synchronizationSettings/{synchronizationSettingName}
        /// Operation Id: SynchronizationSettings_Get
        /// </summary>
        /// <param name="synchronizationSettingName"> The name of the synchronizationSetting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="synchronizationSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="synchronizationSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string synchronizationSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(synchronizationSettingName, nameof(synchronizationSettingName));

            using var scope = _synchronizationSettingClientDiagnostics.CreateScope("SynchronizationSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _synchronizationSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, synchronizationSettingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynchronizationSettingResource> IEnumerable<SynchronizationSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynchronizationSettingResource> IAsyncEnumerable<SynchronizationSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
