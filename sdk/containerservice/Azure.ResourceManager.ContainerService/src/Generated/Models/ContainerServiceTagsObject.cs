// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Tags object for patch operations. </summary>
    public partial class ContainerServiceTagsObject
    {
        /// <summary> Initializes a new instance of <see cref="ContainerServiceTagsObject"/>. </summary>
        public ContainerServiceTagsObject()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
