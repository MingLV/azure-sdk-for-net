// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The Subnets service client. </summary>
    public partial class SubnetsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SubnetsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of SubnetsClient for mocking. </summary>
        protected SubnetsClient()
        {
        }
        /// <summary> Initializes a new instance of SubnetsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal SubnetsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new SubnetsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified subnet by virtual network and resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Subnet>> GetAsync(string resourceGroupName, string virtualNetworkName, string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, virtualNetworkName, subnetName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified subnet by virtual network and resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Subnet> Get(string resourceGroupName, string virtualNetworkName, string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, virtualNetworkName, subnetName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all subnets in a virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Subnet> ListAsync(string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            async Task<Page<Subnet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, virtualNetworkName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Subnet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, virtualNetworkName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all subnets in a virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Subnet> List(string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            Page<Subnet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, virtualNetworkName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Subnet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, virtualNetworkName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified subnet. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<SubnetsDeleteOperation> StartDeleteAsync(string resourceGroupName, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, virtualNetworkName, subnetName, cancellationToken).ConfigureAwait(false);
                return new SubnetsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, virtualNetworkName, subnetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified subnet. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetsDeleteOperation StartDelete(string resourceGroupName, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, virtualNetworkName, subnetName, cancellationToken);
                return new SubnetsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, virtualNetworkName, subnetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a subnet in the specified virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<SubnetsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (subnetParameters == null)
            {
                throw new ArgumentNullException(nameof(subnetParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, subnetName, subnetParameters, cancellationToken).ConfigureAwait(false);
                return new SubnetsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, virtualNetworkName, subnetName, subnetParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a subnet in the specified virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string virtualNetworkName, string subnetName, Subnet subnetParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (subnetParameters == null)
            {
                throw new ArgumentNullException(nameof(subnetParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, virtualNetworkName, subnetName, subnetParameters, cancellationToken);
                return new SubnetsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, virtualNetworkName, subnetName, subnetParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Prepares a subnet by applying network intent policies. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="prepareNetworkPoliciesRequestParameters"> Parameters supplied to prepare subnet by applying network intent policies. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<SubnetsPrepareNetworkPoliciesOperation> StartPrepareNetworkPoliciesAsync(string resourceGroupName, string virtualNetworkName, string subnetName, PrepareNetworkPoliciesRequest prepareNetworkPoliciesRequestParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (prepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(prepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartPrepareNetworkPolicies");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PrepareNetworkPoliciesAsync(resourceGroupName, virtualNetworkName, subnetName, prepareNetworkPoliciesRequestParameters, cancellationToken).ConfigureAwait(false);
                return new SubnetsPrepareNetworkPoliciesOperation(_clientDiagnostics, _pipeline, RestClient.CreatePrepareNetworkPoliciesRequest(resourceGroupName, virtualNetworkName, subnetName, prepareNetworkPoliciesRequestParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Prepares a subnet by applying network intent policies. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="prepareNetworkPoliciesRequestParameters"> Parameters supplied to prepare subnet by applying network intent policies. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetsPrepareNetworkPoliciesOperation StartPrepareNetworkPolicies(string resourceGroupName, string virtualNetworkName, string subnetName, PrepareNetworkPoliciesRequest prepareNetworkPoliciesRequestParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (prepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(prepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartPrepareNetworkPolicies");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PrepareNetworkPolicies(resourceGroupName, virtualNetworkName, subnetName, prepareNetworkPoliciesRequestParameters, cancellationToken);
                return new SubnetsPrepareNetworkPoliciesOperation(_clientDiagnostics, _pipeline, RestClient.CreatePrepareNetworkPoliciesRequest(resourceGroupName, virtualNetworkName, subnetName, prepareNetworkPoliciesRequestParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="unprepareNetworkPoliciesRequestParameters"> Parameters supplied to unprepare subnet to remove network intent policies. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<SubnetsUnprepareNetworkPoliciesOperation> StartUnprepareNetworkPoliciesAsync(string resourceGroupName, string virtualNetworkName, string subnetName, UnprepareNetworkPoliciesRequest unprepareNetworkPoliciesRequestParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (unprepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(unprepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartUnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UnprepareNetworkPoliciesAsync(resourceGroupName, virtualNetworkName, subnetName, unprepareNetworkPoliciesRequestParameters, cancellationToken).ConfigureAwait(false);
                return new SubnetsUnprepareNetworkPoliciesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUnprepareNetworkPoliciesRequest(resourceGroupName, virtualNetworkName, subnetName, unprepareNetworkPoliciesRequestParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unprepares a subnet by removing network intent policies. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="unprepareNetworkPoliciesRequestParameters"> Parameters supplied to unprepare subnet to remove network intent policies. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubnetsUnprepareNetworkPoliciesOperation StartUnprepareNetworkPolicies(string resourceGroupName, string virtualNetworkName, string subnetName, UnprepareNetworkPoliciesRequest unprepareNetworkPoliciesRequestParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (unprepareNetworkPoliciesRequestParameters == null)
            {
                throw new ArgumentNullException(nameof(unprepareNetworkPoliciesRequestParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetsClient.StartUnprepareNetworkPolicies");
            scope.Start();
            try
            {
                var originalResponse = RestClient.UnprepareNetworkPolicies(resourceGroupName, virtualNetworkName, subnetName, unprepareNetworkPoliciesRequestParameters, cancellationToken);
                return new SubnetsUnprepareNetworkPoliciesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUnprepareNetworkPoliciesRequest(resourceGroupName, virtualNetworkName, subnetName, unprepareNetworkPoliciesRequestParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
