// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Base class of the specific document types. </summary>
    internal partial class DocumentIngress
    {
        /// <summary> Initializes a new instance of <see cref="DocumentIngress"/>. </summary>
        public DocumentIngress()
        {
            DocumentStreamIds = new ChangeTrackingList<string>();
            Properties = new ChangeTrackingList<KeyValuePairString>();
        }

        /// <summary> Telemetry type. Types not defined in enum will get replaced with a 'Unknown' type. </summary>
        public DocumentIngressDocumentType? DocumentType { get; set; }
        /// <summary> An array of document streaming ids. Each id identifies a flow of documents customized by UX customers. </summary>
        public IList<string> DocumentStreamIds { get; }
        /// <summary> Collection of custom properties. </summary>
        public IList<KeyValuePairString> Properties { get; }
    }
}
