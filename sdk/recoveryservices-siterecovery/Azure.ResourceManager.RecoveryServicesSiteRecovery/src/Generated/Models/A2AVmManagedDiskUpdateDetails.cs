// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A Vm managed disk update details. </summary>
    public partial class A2AVmManagedDiskUpdateDetails
    {
        /// <summary> Initializes a new instance of <see cref="A2AVmManagedDiskUpdateDetails"/>. </summary>
        public A2AVmManagedDiskUpdateDetails()
        {
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; set; }
        /// <summary> The target disk type before failover. </summary>
        public string RecoveryTargetDiskAccountType { get; set; }
        /// <summary> The replica disk type before failover. </summary>
        public string RecoveryReplicaDiskAccountType { get; set; }
        /// <summary> The recovery os disk encryption information. </summary>
        public SiteRecoveryDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary> The target disk name for unplanned failover operation. </summary>
        public string FailoverDiskName { get; set; }
        /// <summary> The target disk name for test failover operation. </summary>
        public string TfoDiskName { get; set; }
    }
}
