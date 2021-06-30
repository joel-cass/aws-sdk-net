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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Represents a metric pair for a predictive scaling policy.
    /// </summary>
    public partial class PredictiveScalingPredefinedMetricPair
    {
        private PredefinedMetricPairType _predefinedMetricType;
        private string _resourceLabel;

        /// <summary>
        /// Gets and sets the property PredefinedMetricType. 
        /// <para>
        /// Indicates which metrics to use. There are two different types of metrics for each
        /// metric type: one is a load metric and one is a scaling metric. For example, if the
        /// metric type is <code>ASGCPUUtilization</code>, the Auto Scaling group's total CPU
        /// metric is used as the load metric, and the average CPU metric is used for the scaling
        /// metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PredefinedMetricPairType PredefinedMetricType
        {
            get { return this._predefinedMetricType; }
            set { this._predefinedMetricType = value; }
        }

        // Check to see if PredefinedMetricType property is set
        internal bool IsSetPredefinedMetricType()
        {
            return this._predefinedMetricType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLabel. 
        /// <para>
        /// A label that uniquely identifies a specific Application Load Balancer target group
        /// from which to determine the total and average request count served by your Auto Scaling
        /// group. You can't specify a resource label unless the target group is attached to the
        /// Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// You create the resource label by appending the final portion of the load balancer
        /// ARN and the final portion of the target group ARN into a single value, separated by
        /// a forward slash (/). The format of the resource label is:
        /// </para>
        ///  
        /// <para>
        ///  <code>app/my-alb/778d41231b141a0f/targetgroup/my-alb-target-group/943f017f100becff</code>.
        /// </para>
        ///  
        /// <para>
        /// Where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// app/&lt;load-balancer-name&gt;/&lt;load-balancer-id&gt; is the final portion of the
        /// load balancer ARN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// targetgroup/&lt;target-group-name&gt;/&lt;target-group-id&gt; is the final portion
        /// of the target group ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To find the ARN for an Application Load Balancer, use the <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// API operation. To find the ARN for the target group, use the <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeTargetGroups.html">DescribeTargetGroups</a>
        /// API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1023)]
        public string ResourceLabel
        {
            get { return this._resourceLabel; }
            set { this._resourceLabel = value; }
        }

        // Check to see if ResourceLabel property is set
        internal bool IsSetResourceLabel()
        {
            return this._resourceLabel != null;
        }

    }
}