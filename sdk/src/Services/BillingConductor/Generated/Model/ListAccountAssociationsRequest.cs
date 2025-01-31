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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Container for the parameters to the ListAccountAssociations operation.
    /// <i> <b>Amazon Web Services Billing Conductor is in beta release and is subject to
    /// change. Your use of Amazon Web Services Billing Conductor is subject to the Beta Service
    /// Participation terms of the <a href="https://aws.amazon.com/service-terms/">Amazon
    /// Web Services Service Terms</a> (Section 1.10).</b> </i> 
    /// 
    ///  
    /// <para>
    ///  This is a paginated call to list linked accounts that are linked to the payer account
    /// for the specified time period. If no information is provided, the current billing
    /// period is used. The response will optionally include the billing group associated
    /// with the linked account.
    /// </para>
    /// </summary>
    public partial class ListAccountAssociationsRequest : AmazonBillingConductorRequest
    {
        private string _billingPeriod;
        private ListAccountAssociationsFilter _filters;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The preferred billing period to get account associations. 
        /// </para>
        /// </summary>
        public string BillingPeriod
        {
            get { return this._billingPeriod; }
            set { this._billingPeriod = value; }
        }

        // Check to see if BillingPeriod property is set
        internal bool IsSetBillingPeriod()
        {
            return this._billingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filter on the account ID of the linked account, or any of the following:
        /// </para>
        ///  
        /// <para>
        ///  <code>MONITORED</code>: linked accounts that are associated to billing groups.
        /// </para>
        ///  
        /// <para>
        ///  <code>UNMONITORED</code>: linked accounts that are not associated to billing groups.
        /// </para>
        ///  
        /// <para>
        ///  <code>Billing Group Arn</code>: linked accounts that are associated to the provided
        /// billing group Arn. 
        /// </para>
        /// </summary>
        public ListAccountAssociationsFilter Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token used on subsequent calls to retrieve accounts. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}