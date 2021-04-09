// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Managed integration runtime, including managed elastic and managed dedicated integration runtimes. </summary>
    public partial class ManagedIntegrationRuntime : IntegrationRuntime
    {
        /// <summary> Initializes a new instance of ManagedIntegrationRuntime. </summary>
        public ManagedIntegrationRuntime()
        {
            Type = IntegrationRuntimeType.Managed;
        }

        /// <summary> Initializes a new instance of ManagedIntegrationRuntime. </summary>
        /// <param name="type"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="state"> Integration runtime state, only valid for managed dedicated integration runtime. </param>
        /// <param name="managedVirtualNetwork"> Managed Virtual Network reference. </param>
        /// <param name="computeProperties"> The compute resource for managed integration runtime. </param>
        /// <param name="ssisProperties"> SSIS properties for managed integration runtime. </param>
        internal ManagedIntegrationRuntime(IntegrationRuntimeType type, string description, IDictionary<string, object> additionalProperties, IntegrationRuntimeState? state, ManagedVirtualNetworkReference managedVirtualNetwork, IntegrationRuntimeComputeProperties computeProperties, IntegrationRuntimeSsisProperties ssisProperties) : base(type, description, additionalProperties)
        {
            State = state;
            ManagedVirtualNetwork = managedVirtualNetwork;
            ComputeProperties = computeProperties;
            SsisProperties = ssisProperties;
            Type = type;
        }

        /// <summary> Integration runtime state, only valid for managed dedicated integration runtime. </summary>
        public IntegrationRuntimeState? State { get; }
        /// <summary> Managed Virtual Network reference. </summary>
        public ManagedVirtualNetworkReference ManagedVirtualNetwork { get; set; }
        /// <summary> The compute resource for managed integration runtime. </summary>
        public IntegrationRuntimeComputeProperties ComputeProperties { get; set; }
        /// <summary> SSIS properties for managed integration runtime. </summary>
        public IntegrationRuntimeSsisProperties SsisProperties { get; set; }
    }
}
