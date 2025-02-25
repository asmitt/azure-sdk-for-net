// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for feature request
    /// Please note <see cref="FeatureSupportContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BackupGoalFeatureSupportContent"/> and <see cref="VmResourceFeatureSupportContent"/>.
    /// </summary>
    public abstract partial class FeatureSupportContent
    {
        /// <summary> Initializes a new instance of <see cref="FeatureSupportContent"/>. </summary>
        protected FeatureSupportContent()
        {
        }

        /// <summary> backup support feature type. </summary>
        internal string FeatureType { get; set; }
    }
}
