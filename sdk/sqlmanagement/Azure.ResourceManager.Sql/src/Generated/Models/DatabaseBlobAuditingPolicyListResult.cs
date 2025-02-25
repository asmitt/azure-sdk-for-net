// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of database auditing settings. </summary>
    internal partial class DatabaseBlobAuditingPolicyListResult
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseBlobAuditingPolicyListResult"/>. </summary>
        internal DatabaseBlobAuditingPolicyListResult()
        {
            Value = new ChangeTrackingList<SqlDatabaseBlobAuditingPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseBlobAuditingPolicyListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal DatabaseBlobAuditingPolicyListResult(IReadOnlyList<SqlDatabaseBlobAuditingPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlDatabaseBlobAuditingPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
