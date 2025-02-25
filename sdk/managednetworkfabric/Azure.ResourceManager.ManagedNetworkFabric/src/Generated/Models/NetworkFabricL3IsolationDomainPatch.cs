// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The L3 Isolation Domain patch resource definition. </summary>
    public partial class NetworkFabricL3IsolationDomainPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkFabricL3IsolationDomainPatch"/>. </summary>
        public NetworkFabricL3IsolationDomainPatch()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Advertise Connected Subnets. Ex: "True" | "False". </summary>
        public RedistributeConnectedSubnet? RedistributeConnectedSubnets { get; set; }
        /// <summary> Advertise Static Routes. Ex: "True" | "False". </summary>
        public RedistributeStaticRoute? RedistributeStaticRoutes { get; set; }
        /// <summary> Aggregate route configurations. </summary>
        public AggregateRouteConfiguration AggregateRouteConfiguration { get; set; }
        /// <summary> Connected Subnet RoutePolicy. </summary>
        public ConnectedSubnetRoutePolicy ConnectedSubnetRoutePolicy { get; set; }
    }
}
