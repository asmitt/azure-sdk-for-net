// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary>
    /// The Endpoint resource, which contains information about file sources and targets.
    /// Please note <see cref="EndpointBaseUpdateProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureStorageBlobContainerEndpointUpdateProperties"/>, <see cref="AzureStorageSmbFileShareEndpointUpdateProperties"/>, <see cref="NfsMountEndpointUpdateProperties"/> and <see cref="SmbMountEndpointUpdateProperties"/>.
    /// </summary>
    public abstract partial class EndpointBaseUpdateProperties
    {
        /// <summary> Initializes a new instance of <see cref="EndpointBaseUpdateProperties"/>. </summary>
        protected EndpointBaseUpdateProperties()
        {
        }

        /// <summary> The Endpoint resource type. </summary>
        internal EndpointType EndpointType { get; set; }
        /// <summary> A description for the Endpoint. </summary>
        public string Description { get; set; }
    }
}
