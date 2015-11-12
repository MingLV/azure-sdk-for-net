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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The properties of the Failover Process Server request.
    /// </summary>
    public partial class FailoverProcessServerRequestProperties
    {
        private string _containerId;
        
        /// <summary>
        /// Optional. The container identifier.
        /// </summary>
        public string ContainerId
        {
            get { return this._containerId; }
            set { this._containerId = value; }
        }
        
        private string _failoverType;
        
        /// <summary>
        /// Optional. Gets or sets a value for failover type. It can be
        /// systemlevel/serverlevel
        /// </summary>
        public string FailoverType
        {
            get { return this._failoverType; }
            set { this._failoverType = value; }
        }
        
        private string _sourceProcessServerId;
        
        /// <summary>
        /// Optional. The source process server.
        /// </summary>
        public string SourceProcessServerId
        {
            get { return this._sourceProcessServerId; }
            set { this._sourceProcessServerId = value; }
        }
        
        private string _targetProcessServerId;
        
        /// <summary>
        /// Optional. The new process server.
        /// </summary>
        public string TargetProcessServerId
        {
            get { return this._targetProcessServerId; }
            set { this._targetProcessServerId = value; }
        }
        
        private IList<string> _vmsToMigrate;
        
        /// <summary>
        /// Optional. The VMS to migrate.
        /// </summary>
        public IList<string> VmsToMigrate
        {
            get { return this._vmsToMigrate; }
            set { this._vmsToMigrate = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// FailoverProcessServerRequestProperties class.
        /// </summary>
        public FailoverProcessServerRequestProperties()
        {
            this.VmsToMigrate = new LazyList<string>();
        }
    }
}
