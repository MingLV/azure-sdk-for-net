// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Management.Compute.Models
{
    /// <summary> The List Virtual Machine Scale Set VMs operation response. </summary>
    public partial class VirtualMachineScaleSetVMListResult
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMListResult. </summary>
        /// <param name="value"> The list of virtual machine scale sets VMs. </param>
        internal VirtualMachineScaleSetVMListResult(IEnumerable<VirtualMachineScaleSetVM> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMListResult. </summary>
        /// <param name="value"> The list of virtual machine scale sets VMs. </param>
        /// <param name="nextLink"> The uri to fetch the next page of Virtual Machine Scale Set VMs. Call ListNext() with this to fetch the next page of VMSS VMs. </param>
        internal VirtualMachineScaleSetVMListResult(IReadOnlyList<VirtualMachineScaleSetVM> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of virtual machine scale sets VMs. </summary>
        public IReadOnlyList<VirtualMachineScaleSetVM> Value { get; }
        /// <summary> The uri to fetch the next page of Virtual Machine Scale Set VMs. Call ListNext() with this to fetch the next page of VMSS VMs. </summary>
        public string NextLink { get; }
    }
}
