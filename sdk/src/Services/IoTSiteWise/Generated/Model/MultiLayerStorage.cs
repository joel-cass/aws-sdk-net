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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains information about the storage destination.
    /// </summary>
    public partial class MultiLayerStorage
    {
        private CustomerManagedS3Storage _customerManagedS3Storage;

        /// <summary>
        /// Gets and sets the property CustomerManagedS3Storage. 
        /// <para>
        /// Contains information about a customer managed Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomerManagedS3Storage CustomerManagedS3Storage
        {
            get { return this._customerManagedS3Storage; }
            set { this._customerManagedS3Storage = value; }
        }

        // Check to see if CustomerManagedS3Storage property is set
        internal bool IsSetCustomerManagedS3Storage()
        {
            return this._customerManagedS3Storage != null;
        }

    }
}