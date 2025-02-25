// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of managed HSM Pools. </summary>
    internal partial class ManagedHsmListResult
    {
        /// <summary> Initializes a new instance of <see cref="ManagedHsmListResult"/>. </summary>
        internal ManagedHsmListResult()
        {
            Value = new ChangeTrackingList<ManagedHsmData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmListResult"/>. </summary>
        /// <param name="value"> The list of managed HSM Pools. </param>
        /// <param name="nextLink"> The URL to get the next set of managed HSM Pools. </param>
        internal ManagedHsmListResult(IReadOnlyList<ManagedHsmData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of managed HSM Pools. </summary>
        public IReadOnlyList<ManagedHsmData> Value { get; }
        /// <summary> The URL to get the next set of managed HSM Pools. </summary>
        public string NextLink { get; }
    }
}
