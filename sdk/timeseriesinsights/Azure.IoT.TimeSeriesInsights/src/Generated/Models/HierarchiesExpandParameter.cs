// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Definition of whether to expand hierarchy nodes in the same search instances call. </summary>
    internal partial class HierarchiesExpandParameter
    {
        /// <summary> Initializes a new instance of <see cref="HierarchiesExpandParameter"/>. </summary>
        public HierarchiesExpandParameter()
        {
        }

        /// <summary> Kind of the expansion of hierarchy nodes. When it is set to 'UntilChildren', the hierarchy nodes are expanded recursively until there is more than one child. When it is set to 'OneLevel', the hierarchies are expanded only at the single level matching path search instances parameter. Optional, default is 'UntilChildren'. </summary>
        public HierarchiesExpandKind? Kind { get; set; }
    }
}
