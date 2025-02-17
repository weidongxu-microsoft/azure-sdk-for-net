// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Orbital.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Orbital
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Orbital. </summary>
    public static partial class OrbitalExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of AvailableGroundStationResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AvailableGroundStationResources and their operations over a AvailableGroundStationResource. </returns>
        public static AvailableGroundStationCollection GetAvailableGroundStations(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetAvailableGroundStations();
        }

        /// <summary>
        /// Gets the specified available ground station.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}
        /// Operation Id: AvailableGroundStations_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AvailableGroundStationResource>> GetAvailableGroundStationAsync(this SubscriptionResource subscriptionResource, string groundStationName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetAvailableGroundStations().GetAsync(groundStationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified available ground station.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/availableGroundStations/{groundStationName}
        /// Operation Id: AvailableGroundStations_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="groundStationName"> Ground Station name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groundStationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groundStationName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AvailableGroundStationResource> GetAvailableGroundStation(this SubscriptionResource subscriptionResource, string groundStationName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetAvailableGroundStations().Get(groundStationName, cancellationToken);
        }

        /// <summary>
        /// Returns list of spacecrafts by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/spacecrafts
        /// Operation Id: Spacecrafts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SpacecraftResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SpacecraftResource> GetSpacecraftsAsync(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSpacecraftsAsync(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Returns list of spacecrafts by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/spacecrafts
        /// Operation Id: Spacecrafts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SpacecraftResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SpacecraftResource> GetSpacecrafts(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSpacecrafts(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Returns list of contact profiles by Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/contactProfiles
        /// Operation Id: ContactProfiles_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContactProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ContactProfileResource> GetContactProfilesAsync(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetContactProfilesAsync(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Returns list of contact profiles by Subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/contactProfiles
        /// Operation Id: ContactProfiles_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> An opaque string that the resource provider uses to skip over previously-returned results. This is used when a previous list operation call returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContactProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ContactProfileResource> GetContactProfiles(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetContactProfiles(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Returns operation results.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/locations/{location}/operationResults/{operationId}
        /// Operation Id: OperationsResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<ArmOperation<OperationResult>> GetOperationsResultAsync(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetOperationsResultAsync(waitUntil, location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns operation results.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Orbital/locations/{location}/operationResults/{operationId}
        /// Operation Id: OperationsResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static ArmOperation<OperationResult> GetOperationsResult(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetOperationsResult(waitUntil, location, operationId, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of SpacecraftResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SpacecraftResources and their operations over a SpacecraftResource. </returns>
        public static SpacecraftCollection GetSpacecrafts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSpacecrafts();
        }

        /// <summary>
        /// Gets the specified spacecraft in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}
        /// Operation Id: Spacecrafts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SpacecraftResource>> GetSpacecraftAsync(this ResourceGroupResource resourceGroupResource, string spacecraftName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSpacecrafts().GetAsync(spacecraftName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified spacecraft in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/spacecrafts/{spacecraftName}
        /// Operation Id: Spacecrafts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="spacecraftName"> Spacecraft ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="spacecraftName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="spacecraftName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SpacecraftResource> GetSpacecraft(this ResourceGroupResource resourceGroupResource, string spacecraftName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSpacecrafts().Get(spacecraftName, cancellationToken);
        }

        /// <summary> Gets a collection of ContactProfileResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ContactProfileResources and their operations over a ContactProfileResource. </returns>
        public static ContactProfileCollection GetContactProfiles(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetContactProfiles();
        }

        /// <summary>
        /// Gets the specified contact Profile in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/contactProfiles/{contactProfileName}
        /// Operation Id: ContactProfiles_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="contactProfileName"> Contact Profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactProfileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ContactProfileResource>> GetContactProfileAsync(this ResourceGroupResource resourceGroupResource, string contactProfileName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetContactProfiles().GetAsync(contactProfileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified contact Profile in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Orbital/contactProfiles/{contactProfileName}
        /// Operation Id: ContactProfiles_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="contactProfileName"> Contact Profile name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contactProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contactProfileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ContactProfileResource> GetContactProfile(this ResourceGroupResource resourceGroupResource, string contactProfileName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetContactProfiles().Get(contactProfileName, cancellationToken);
        }

        #region SpacecraftResource
        /// <summary>
        /// Gets an object representing a <see cref="SpacecraftResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SpacecraftResource.CreateResourceIdentifier" /> to create a <see cref="SpacecraftResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SpacecraftResource" /> object. </returns>
        public static SpacecraftResource GetSpacecraftResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SpacecraftResource.ValidateResourceId(id);
                return new SpacecraftResource(client, id);
            }
            );
        }
        #endregion

        #region ContactResource
        /// <summary>
        /// Gets an object representing a <see cref="ContactResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContactResource.CreateResourceIdentifier" /> to create a <see cref="ContactResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContactResource" /> object. </returns>
        public static ContactResource GetContactResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContactResource.ValidateResourceId(id);
                return new ContactResource(client, id);
            }
            );
        }
        #endregion

        #region ContactProfileResource
        /// <summary>
        /// Gets an object representing a <see cref="ContactProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContactProfileResource.CreateResourceIdentifier" /> to create a <see cref="ContactProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContactProfileResource" /> object. </returns>
        public static ContactProfileResource GetContactProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContactProfileResource.ValidateResourceId(id);
                return new ContactProfileResource(client, id);
            }
            );
        }
        #endregion

        #region AvailableGroundStationResource
        /// <summary>
        /// Gets an object representing an <see cref="AvailableGroundStationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailableGroundStationResource.CreateResourceIdentifier" /> to create an <see cref="AvailableGroundStationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailableGroundStationResource" /> object. </returns>
        public static AvailableGroundStationResource GetAvailableGroundStationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AvailableGroundStationResource.ValidateResourceId(id);
                return new AvailableGroundStationResource(client, id);
            }
            );
        }
        #endregion
    }
}
