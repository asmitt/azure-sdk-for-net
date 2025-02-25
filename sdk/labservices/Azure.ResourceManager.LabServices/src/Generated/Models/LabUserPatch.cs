// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> User of a lab that can register for and use virtual machines within the lab. Used for updates. </summary>
    public partial class LabUserPatch
    {
        /// <summary> Initializes a new instance of <see cref="LabUserPatch"/>. </summary>
        public LabUserPatch()
        {
        }

        /// <summary> The amount of usage quota time the user gets in addition to the lab usage quota. </summary>
        public TimeSpan? AdditionalUsageQuota { get; set; }
    }
}
