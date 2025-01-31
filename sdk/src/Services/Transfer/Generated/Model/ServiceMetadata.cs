/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// A container object for the session details associated with a workflow.
    /// </summary>
    public partial class ServiceMetadata
    {
        private UserDetails _userDetails;

        /// <summary>
        /// Gets and sets the property UserDetails. 
        /// <para>
        /// The Server ID (<code>ServerId</code>), Session ID (<code>SessionId</code>) and user
        /// (<code>UserName</code>) make up the <code>UserDetails</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserDetails UserDetails
        {
            get { return this._userDetails; }
            set { this._userDetails = value; }
        }

        // Check to see if UserDetails property is set
        internal bool IsSetUserDetails()
        {
            return this._userDetails != null;
        }

    }
}