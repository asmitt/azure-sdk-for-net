// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Update parameters for accounts. </summary>
    public partial class DataShareAccountPatch
    {
        /// <summary> Initializes a new instance of <see cref="DataShareAccountPatch"/>. </summary>
        public DataShareAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Tags on the azure resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
