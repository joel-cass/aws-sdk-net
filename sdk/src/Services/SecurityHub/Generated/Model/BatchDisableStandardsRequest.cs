/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDisableStandards operation.
    /// Disables the standards specified by the provided <code>StandardsSubscriptionArns</code>.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Security
    /// Standards</a> section of the <i>AWS Security Hub User Guide</i>.
    /// </para>
    /// </summary>
    public partial class BatchDisableStandardsRequest : AmazonSecurityHubRequest
    {
        private List<string> _standardsSubscriptionArns = new List<string>();

        /// <summary>
        /// Gets and sets the property StandardsSubscriptionArns. 
        /// <para>
        /// The ARNs of the standards subscriptions to disable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> StandardsSubscriptionArns
        {
            get { return this._standardsSubscriptionArns; }
            set { this._standardsSubscriptionArns = value; }
        }

        // Check to see if StandardsSubscriptionArns property is set
        internal bool IsSetStandardsSubscriptionArns()
        {
            return this._standardsSubscriptionArns != null && this._standardsSubscriptionArns.Count > 0; 
        }

    }
}