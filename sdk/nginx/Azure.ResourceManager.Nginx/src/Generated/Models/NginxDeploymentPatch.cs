// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxDeploymentPatch. </summary>
    public partial class NginxDeploymentPatch
    {
        /// <summary> Initializes a new instance of <see cref="NginxDeploymentPatch"/>. </summary>
        public NginxDeploymentPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the sku. </summary>
        internal ResourceSku Sku { get; set; }
        /// <summary> Name of the SKU. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new ResourceSku(value);
        }

        /// <summary> Gets or sets the location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the properties. </summary>
        public NginxDeploymentUpdateProperties Properties { get; set; }
    }
}
