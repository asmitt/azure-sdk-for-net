// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Response of a list App Services Operation. </summary>
    internal partial class AppServiceListResponse
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceListResponse"/>. </summary>
        internal AppServiceListResponse()
        {
            Value = new ChangeTrackingList<DynatraceOneAgentEnabledAppServiceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceListResponse"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal AppServiceListResponse(IReadOnlyList<DynatraceOneAgentEnabledAppServiceInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<DynatraceOneAgentEnabledAppServiceInfo> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
