// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Transport options availability details for given region. </summary>
    public partial class TransportAvailabilityDetails
    {
        /// <summary> Initializes a new instance of <see cref="TransportAvailabilityDetails"/>. </summary>
        internal TransportAvailabilityDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TransportAvailabilityDetails"/>. </summary>
        /// <param name="shipmentType"> Transport Shipment Type supported for given region. </param>
        internal TransportAvailabilityDetails(TransportShipmentType? shipmentType)
        {
            ShipmentType = shipmentType;
        }

        /// <summary> Transport Shipment Type supported for given region. </summary>
        public TransportShipmentType? ShipmentType { get; }
    }
}
