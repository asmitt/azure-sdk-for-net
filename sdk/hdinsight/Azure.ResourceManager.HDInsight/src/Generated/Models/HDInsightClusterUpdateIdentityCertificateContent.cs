// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The update cluster identity certificate request parameters. </summary>
    public partial class HDInsightClusterUpdateIdentityCertificateContent
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightClusterUpdateIdentityCertificateContent"/>. </summary>
        public HDInsightClusterUpdateIdentityCertificateContent()
        {
        }

        /// <summary> The application id. </summary>
        public string ApplicationId { get; set; }
        /// <summary> The certificate in base64 encoded format. </summary>
        public string Certificate { get; set; }
        /// <summary> The password of the certificate. </summary>
        public string CertificatePassword { get; set; }
    }
}
