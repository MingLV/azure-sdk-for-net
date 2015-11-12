// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery
{
    /// <summary>
    /// Definition of vCenter entity operations for the Site Recovery extension.
    /// </summary>
    public partial interface IVCenterOperations
    {
        /// <summary>
        /// Creates a vCenter
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='vCenterName'>
        /// vCenter Name.
        /// </param>
        /// <param name='input'>
        /// Input to create vCenter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginCreatingAsync(string fabricName, string vCenterName, CreateVCenterInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a vCenter
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='vCenterName'>
        /// vCenter Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDeletingAsync(string fabricName, string vCenterName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update vCenter.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='vCenterName'>
        /// vCenter Name.
        /// </param>
        /// <param name='input'>
        /// Input to update vCenter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginUpdatingAsync(string fabricName, string vCenterName, UpdateVCenterInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a vCenter
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='vCenterName'>
        /// vCenter Name.
        /// </param>
        /// <param name='input'>
        /// Input to create vCenter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> CreateAsync(string fabricName, string vCenterName, CreateVCenterInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a vCenter
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='vCenterName'>
        /// vCenter Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DeleteAsync(string fabricName, string vCenterName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the vCenter object by Id.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='vCenterName'>
        /// vCenter Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the vCenter object
        /// </returns>
        Task<VCenterResponse> GetAsync(string fabricName, string vCenterName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<CreateVCenterOperationResponse> GetCreateStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> GetDeleteStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<UpdateVCenterOperationResponse> GetUpdateStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all vCenters under a fabric.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list vCenters operation.
        /// </returns>
        Task<VCenterListResponse> ListAsync(string fabricName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all vCenters under the vault.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list vCenters operation.
        /// </returns>
        Task<VCenterListResponse> ListAllAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update vCenter.
        /// </summary>
        /// <param name='fabricName'>
        /// Fabric Name.
        /// </param>
        /// <param name='vCenterName'>
        /// vCenter Name.
        /// </param>
        /// <param name='input'>
        /// Input to update vCenter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> UpdateAsync(string fabricName, string vCenterName, UpdateVCenterInput input, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
