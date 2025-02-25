// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of managed API operations. </summary>
    internal partial class LogicApiOperationListResult
    {
        /// <summary> Initializes a new instance of <see cref="LogicApiOperationListResult"/>. </summary>
        internal LogicApiOperationListResult()
        {
            Value = new ChangeTrackingList<LogicApiOperationInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicApiOperationListResult"/>. </summary>
        /// <param name="value"> The api operation definitions for an API. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal LogicApiOperationListResult(IReadOnlyList<LogicApiOperationInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The api operation definitions for an API. </summary>
        public IReadOnlyList<LogicApiOperationInfo> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
