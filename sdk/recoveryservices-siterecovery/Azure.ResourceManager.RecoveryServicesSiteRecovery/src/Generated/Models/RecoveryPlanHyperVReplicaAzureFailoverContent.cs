// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan HVR Azure failover input. </summary>
    public partial class RecoveryPlanHyperVReplicaAzureFailoverContent : RecoveryPlanProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>. </summary>
        public RecoveryPlanHyperVReplicaAzureFailoverContent()
        {
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> The primary KEK certificate PFX. </summary>
        public string PrimaryKekCertificatePfx { get; set; }
        /// <summary> The secondary KEK certificate PFX. </summary>
        public string SecondaryKekCertificatePfx { get; set; }
        /// <summary> The recovery point type. </summary>
        public HyperVReplicaAzureRpRecoveryPointType? RecoveryPointType { get; set; }
    }
}
