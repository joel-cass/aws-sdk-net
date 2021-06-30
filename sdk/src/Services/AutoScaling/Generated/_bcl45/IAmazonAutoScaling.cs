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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Interface for accessing AutoScaling
    ///
    /// Amazon EC2 Auto Scaling 
    /// <para>
    /// Amazon EC2 Auto Scaling is designed to automatically launch or terminate EC2 instances
    /// based on user-defined scaling policies, scheduled actions, and health checks.
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon EC2 Auto Scaling, see the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/what-is-amazon-ec2-auto-scaling.html">Amazon
    /// EC2 Auto Scaling User Guide</a>. For information about granting IAM users required
    /// permissions for calls to Amazon EC2 Auto Scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/ec2-auto-scaling-api-permissions.html">Granting
    /// IAM users required permissions for Amazon EC2 Auto Scaling resources</a> in the <i>Amazon
    /// EC2 Auto Scaling API Reference</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAutoScaling : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAutoScalingPaginatorFactory Paginators { get; }

        
        #region  AttachInstances


        /// <summary>
        /// Attaches one or more EC2 instances to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you attach instances, Amazon EC2 Auto Scaling increases the desired capacity
        /// of the group by the number of instances being attached. If the number of instances
        /// being attached plus the desired capacity of the group exceeds the maximum size of
        /// the group, the operation fails.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to your Auto Scaling group, the instances
        /// are also registered with the load balancer. If there are target groups attached to
        /// your Auto Scaling group, the instances are also registered with the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/attach-instance-asg.html">Attach
        /// EC2 instances to your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachInstances">REST API Reference for AttachInstances Operation</seealso>
        AttachInstancesResponse AttachInstances(AttachInstancesRequest request);



        /// <summary>
        /// Attaches one or more EC2 instances to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you attach instances, Amazon EC2 Auto Scaling increases the desired capacity
        /// of the group by the number of instances being attached. If the number of instances
        /// being attached plus the desired capacity of the group exceeds the maximum size of
        /// the group, the operation fails.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to your Auto Scaling group, the instances
        /// are also registered with the load balancer. If there are target groups attached to
        /// your Auto Scaling group, the instances are also registered with the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/attach-instance-asg.html">Attach
        /// EC2 instances to your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachInstances">REST API Reference for AttachInstances Operation</seealso>
        Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachLoadBalancers


        /// <summary>
        /// <note> 
        /// <para>
        /// To attach an Application Load Balancer, Network Load Balancer, or Gateway Load Balancer,
        /// use the <a>AttachLoadBalancerTargetGroups</a> API operation instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches one or more Classic Load Balancers to the specified Auto Scaling group. Amazon
        /// EC2 Auto Scaling registers the running instances with these Classic Load Balancers.
        /// </para>
        ///  
        /// <para>
        /// To describe the load balancers for an Auto Scaling group, call the <a>DescribeLoadBalancers</a>
        /// API. To detach the load balancer from the Auto Scaling group, call the <a>DetachLoadBalancers</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancers">REST API Reference for AttachLoadBalancers Operation</seealso>
        AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// To attach an Application Load Balancer, Network Load Balancer, or Gateway Load Balancer,
        /// use the <a>AttachLoadBalancerTargetGroups</a> API operation instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches one or more Classic Load Balancers to the specified Auto Scaling group. Amazon
        /// EC2 Auto Scaling registers the running instances with these Classic Load Balancers.
        /// </para>
        ///  
        /// <para>
        /// To describe the load balancers for an Auto Scaling group, call the <a>DescribeLoadBalancers</a>
        /// API. To detach the load balancer from the Auto Scaling group, call the <a>DetachLoadBalancers</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancers">REST API Reference for AttachLoadBalancers Operation</seealso>
        Task<AttachLoadBalancersResponse> AttachLoadBalancersAsync(AttachLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachLoadBalancerTargetGroups


        /// <summary>
        /// Attaches one or more target groups to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is used with the following load balancer types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Application Load Balancer - Operates at the application layer (layer 7) and supports
        /// HTTP and HTTPS. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Network Load Balancer - Operates at the transport layer (layer 4) and supports TCP,
        /// TLS, and UDP. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Gateway Load Balancer - Operates at the network layer (layer 3).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To describe the target groups for an Auto Scaling group, call the <a>DescribeLoadBalancerTargetGroups</a>
        /// API. To detach the target group from the Auto Scaling group, call the <a>DetachLoadBalancerTargetGroups</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancerTargetGroups">REST API Reference for AttachLoadBalancerTargetGroups Operation</seealso>
        AttachLoadBalancerTargetGroupsResponse AttachLoadBalancerTargetGroups(AttachLoadBalancerTargetGroupsRequest request);



        /// <summary>
        /// Attaches one or more target groups to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is used with the following load balancer types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Application Load Balancer - Operates at the application layer (layer 7) and supports
        /// HTTP and HTTPS. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Network Load Balancer - Operates at the transport layer (layer 4) and supports TCP,
        /// TLS, and UDP. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Gateway Load Balancer - Operates at the network layer (layer 3).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To describe the target groups for an Auto Scaling group, call the <a>DescribeLoadBalancerTargetGroups</a>
        /// API. To detach the target group from the Auto Scaling group, call the <a>DetachLoadBalancerTargetGroups</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancerTargetGroups">REST API Reference for AttachLoadBalancerTargetGroups Operation</seealso>
        Task<AttachLoadBalancerTargetGroupsResponse> AttachLoadBalancerTargetGroupsAsync(AttachLoadBalancerTargetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteScheduledAction


        /// <summary>
        /// Deletes one or more scheduled actions for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchDeleteScheduledAction">REST API Reference for BatchDeleteScheduledAction Operation</seealso>
        BatchDeleteScheduledActionResponse BatchDeleteScheduledAction(BatchDeleteScheduledActionRequest request);



        /// <summary>
        /// Deletes one or more scheduled actions for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchDeleteScheduledAction">REST API Reference for BatchDeleteScheduledAction Operation</seealso>
        Task<BatchDeleteScheduledActionResponse> BatchDeleteScheduledActionAsync(BatchDeleteScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchPutScheduledUpdateGroupAction


        /// <summary>
        /// Creates or updates one or more scheduled scaling actions for an Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the BatchPutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchPutScheduledUpdateGroupAction">REST API Reference for BatchPutScheduledUpdateGroupAction Operation</seealso>
        BatchPutScheduledUpdateGroupActionResponse BatchPutScheduledUpdateGroupAction(BatchPutScheduledUpdateGroupActionRequest request);



        /// <summary>
        /// Creates or updates one or more scheduled scaling actions for an Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutScheduledUpdateGroupAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchPutScheduledUpdateGroupAction">REST API Reference for BatchPutScheduledUpdateGroupAction Operation</seealso>
        Task<BatchPutScheduledUpdateGroupActionResponse> BatchPutScheduledUpdateGroupActionAsync(BatchPutScheduledUpdateGroupActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelInstanceRefresh


        /// <summary>
        /// Cancels an instance refresh operation in progress. Cancellation does not roll back
        /// any replacements that have already been completed, but it prevents new replacements
        /// from being started. 
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelInstanceRefresh service method.</param>
        /// 
        /// <returns>The response from the CancelInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ActiveInstanceRefreshNotFoundException">
        /// The request failed because an active instance refresh for the specified Auto Scaling
        /// group was not found.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CancelInstanceRefresh">REST API Reference for CancelInstanceRefresh Operation</seealso>
        CancelInstanceRefreshResponse CancelInstanceRefresh(CancelInstanceRefreshRequest request);



        /// <summary>
        /// Cancels an instance refresh operation in progress. Cancellation does not roll back
        /// any replacements that have already been completed, but it prevents new replacements
        /// from being started. 
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelInstanceRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ActiveInstanceRefreshNotFoundException">
        /// The request failed because an active instance refresh for the specified Auto Scaling
        /// group was not found.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CancelInstanceRefresh">REST API Reference for CancelInstanceRefresh Operation</seealso>
        Task<CancelInstanceRefreshResponse> CancelInstanceRefreshAsync(CancelInstanceRefreshRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CompleteLifecycleAction


        /// <summary>
        /// Completes the lifecycle action for the specified token or instance with the specified
        /// result.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Amazon EC2 Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you finish before the timeout period ends, complete the lifecycle action.</b>
        /// 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CompleteLifecycleAction">REST API Reference for CompleteLifecycleAction Operation</seealso>
        CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request);



        /// <summary>
        /// Completes the lifecycle action for the specified token or instance with the specified
        /// result.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Amazon EC2 Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you finish before the timeout period ends, complete the lifecycle action.</b>
        /// 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CompleteLifecycleAction">REST API Reference for CompleteLifecycleAction Operation</seealso>
        Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAutoScalingGroup


        /// <summary>
        /// <b>We strongly recommend using a launch template when calling this operation to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Creates an Auto Scaling group with the specified name and attributes. 
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of Auto Scaling groups, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For introductory exercises for creating an Auto Scaling group, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/GettingStartedTutorial.html">Getting
        /// started with Amazon EC2 Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-register-lbs-with-asg.html">Tutorial:
        /// Set up a scaled and load-balanced application</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroup.html">Auto
        /// Scaling groups</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Every Auto Scaling group has three size parameters (<code>DesiredCapacity</code>,
        /// <code>MaxSize</code>, and <code>MinSize</code>). Usually, you set these sizes based
        /// on a specific number of instances. However, if you configure a mixed instances policy
        /// that defines weights for the instance types, you must specify these sizes with the
        /// same units that you use for weighting instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateAutoScalingGroup">REST API Reference for CreateAutoScalingGroup Operation</seealso>
        CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request);



        /// <summary>
        /// <b>We strongly recommend using a launch template when calling this operation to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Creates an Auto Scaling group with the specified name and attributes. 
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of Auto Scaling groups, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For introductory exercises for creating an Auto Scaling group, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/GettingStartedTutorial.html">Getting
        /// started with Amazon EC2 Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-register-lbs-with-asg.html">Tutorial:
        /// Set up a scaled and load-balanced application</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroup.html">Auto
        /// Scaling groups</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Every Auto Scaling group has three size parameters (<code>DesiredCapacity</code>,
        /// <code>MaxSize</code>, and <code>MinSize</code>). Usually, you set these sizes based
        /// on a specific number of instances. However, if you configure a mixed instances policy
        /// that defines weights for the instance types, you must specify these sizes with the
        /// same units that you use for weighting instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateAutoScalingGroup">REST API Reference for CreateAutoScalingGroup Operation</seealso>
        Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLaunchConfiguration


        /// <summary>
        /// Creates a launch configuration.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of launch configurations, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/LaunchConfiguration.html">Launch
        /// configurations</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateLaunchConfiguration">REST API Reference for CreateLaunchConfiguration Operation</seealso>
        CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request);



        /// <summary>
        /// Creates a launch configuration.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of launch configurations, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/LaunchConfiguration.html">Launch
        /// configurations</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateLaunchConfiguration">REST API Reference for CreateLaunchConfiguration Operation</seealso>
        Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOrUpdateTags


        /// <summary>
        /// Creates or updates tags for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you specify a tag with a key that already exists, the operation overwrites the
        /// previous tag definition, and you do not get an error message.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateOrUpdateTags">REST API Reference for CreateOrUpdateTags Operation</seealso>
        CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request);



        /// <summary>
        /// Creates or updates tags for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you specify a tag with a key that already exists, the operation overwrites the
        /// previous tag definition, and you do not get an error message.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateOrUpdateTags">REST API Reference for CreateOrUpdateTags Operation</seealso>
        Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAutoScalingGroup


        /// <summary>
        /// Deletes the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If the group has instances or scaling activities in progress, you must specify the
        /// option to force the deletion in order for it to succeed.
        /// </para>
        ///  
        /// <para>
        /// If the group has policies, deleting the group deletes the policies, the underlying
        /// alarm actions, and any alarm that no longer has an associated action.
        /// </para>
        ///  
        /// <para>
        /// To remove instances from the Auto Scaling group before deleting it, call the <a>DetachInstances</a>
        /// API with the list of instances and the option to decrement the desired capacity. This
        /// ensures that Amazon EC2 Auto Scaling does not launch replacement instances.
        /// </para>
        ///  
        /// <para>
        /// To terminate all instances before deleting the Auto Scaling group, call the <a>UpdateAutoScalingGroup</a>
        /// API and set the minimum size and desired capacity of the Auto Scaling group to zero.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteAutoScalingGroup">REST API Reference for DeleteAutoScalingGroup Operation</seealso>
        DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request);



        /// <summary>
        /// Deletes the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If the group has instances or scaling activities in progress, you must specify the
        /// option to force the deletion in order for it to succeed.
        /// </para>
        ///  
        /// <para>
        /// If the group has policies, deleting the group deletes the policies, the underlying
        /// alarm actions, and any alarm that no longer has an associated action.
        /// </para>
        ///  
        /// <para>
        /// To remove instances from the Auto Scaling group before deleting it, call the <a>DetachInstances</a>
        /// API with the list of instances and the option to decrement the desired capacity. This
        /// ensures that Amazon EC2 Auto Scaling does not launch replacement instances.
        /// </para>
        ///  
        /// <para>
        /// To terminate all instances before deleting the Auto Scaling group, call the <a>UpdateAutoScalingGroup</a>
        /// API and set the minimum size and desired capacity of the Auto Scaling group to zero.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteAutoScalingGroup">REST API Reference for DeleteAutoScalingGroup Operation</seealso>
        Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLaunchConfiguration


        /// <summary>
        /// Deletes the specified launch configuration.
        /// 
        ///  
        /// <para>
        /// The launch configuration must not be attached to an Auto Scaling group. When this
        /// call completes, the launch configuration is no longer available for use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLaunchConfiguration">REST API Reference for DeleteLaunchConfiguration Operation</seealso>
        DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request);



        /// <summary>
        /// Deletes the specified launch configuration.
        /// 
        ///  
        /// <para>
        /// The launch configuration must not be attached to an Auto Scaling group. When this
        /// call completes, the launch configuration is no longer available for use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLaunchConfiguration">REST API Reference for DeleteLaunchConfiguration Operation</seealso>
        Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLifecycleHook


        /// <summary>
        /// Deletes the specified lifecycle hook.
        /// 
        ///  
        /// <para>
        /// If there are any outstanding lifecycle actions, they are completed first (<code>ABANDON</code>
        /// for launching instances, <code>CONTINUE</code> for terminating instances).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLifecycleHook">REST API Reference for DeleteLifecycleHook Operation</seealso>
        DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request);



        /// <summary>
        /// Deletes the specified lifecycle hook.
        /// 
        ///  
        /// <para>
        /// If there are any outstanding lifecycle actions, they are completed first (<code>ABANDON</code>
        /// for launching instances, <code>CONTINUE</code> for terminating instances).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLifecycleHook">REST API Reference for DeleteLifecycleHook Operation</seealso>
        Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNotificationConfiguration


        /// <summary>
        /// Deletes the specified notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request);



        /// <summary>
        /// Deletes the specified notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified scaling policy.
        /// 
        ///  
        /// <para>
        /// Deleting either a step scaling policy or a simple scaling policy deletes the underlying
        /// alarm action, but does not delete the alarm, even if it no longer has an associated
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/deleting-scaling-policy.html">Deleting
        /// a scaling policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);



        /// <summary>
        /// Deletes the specified scaling policy.
        /// 
        ///  
        /// <para>
        /// Deleting either a step scaling policy or a simple scaling policy deletes the underlying
        /// alarm action, but does not delete the alarm, even if it no longer has an associated
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/deleting-scaling-policy.html">Deleting
        /// a scaling policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScheduledAction


        /// <summary>
        /// Deletes the specified scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request);



        /// <summary>
        /// Deletes the specified scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);



        /// <summary>
        /// Deletes the specified tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWarmPool


        /// <summary>
        /// Deletes the warm pool for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWarmPool service method.</param>
        /// 
        /// <returns>The response from the DeleteWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteWarmPool">REST API Reference for DeleteWarmPool Operation</seealso>
        DeleteWarmPoolResponse DeleteWarmPool(DeleteWarmPoolRequest request);



        /// <summary>
        /// Deletes the warm pool for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWarmPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteWarmPool">REST API Reference for DeleteWarmPool Operation</seealso>
        Task<DeleteWarmPoolResponse> DeleteWarmPoolAsync(DeleteWarmPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an account, the account has initial quotas on the maximum number
        /// of Auto Scaling groups and launch configurations that you can create in a given Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse DescribeAccountLimits();


        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an account, the account has initial quotas on the maximum number
        /// of Auto Scaling groups and launch configurations that you can create in a given Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request);


        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an account, the account has initial quotas on the maximum number
        /// of Auto Scaling groups and launch configurations that you can create in a given Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an account, the account has initial quotas on the maximum number
        /// of Auto Scaling groups and launch configurations that you can create in a given Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAdjustmentTypes


        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes();


        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request);


        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAutoScalingGroups


        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// This operation returns information about instances in Auto Scaling groups. To retrieve
        /// information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups();


        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// This operation returns information about instances in Auto Scaling groups. To retrieve
        /// information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request);


        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// This operation returns information about instances in Auto Scaling groups. To retrieve
        /// information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// This operation returns information about instances in Auto Scaling groups. To retrieve
        /// information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAutoScalingInstances


        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances();


        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request);


        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAutoScalingNotificationTypes


        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes();


        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request);


        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstanceRefreshes


        /// <summary>
        /// Gets information about the instance refreshes for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// To help you determine the status of an instance refresh, this operation returns information
        /// about the instance refreshes you previously initiated, including their status, end
        /// time, the percentage of the instance refresh that is complete, and the number of instances
        /// remaining to update before the instance refresh is complete.
        /// </para>
        ///  
        /// <para>
        /// The following are the possible statuses: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Pending</code> - The request was created, but the operation has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InProgress</code> - The operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Successful</code> - The operation completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - The operation failed to complete. You can troubleshoot using
        /// the status reason and the scaling activities. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelling</code> - An ongoing operation is being cancelled. Cancellation does
        /// not roll back any replacements that have already been completed, but it prevents new
        /// replacements from being started. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelled</code> - The operation is cancelled. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceRefreshes service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceRefreshes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeInstanceRefreshes">REST API Reference for DescribeInstanceRefreshes Operation</seealso>
        DescribeInstanceRefreshesResponse DescribeInstanceRefreshes(DescribeInstanceRefreshesRequest request);



        /// <summary>
        /// Gets information about the instance refreshes for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// To help you determine the status of an instance refresh, this operation returns information
        /// about the instance refreshes you previously initiated, including their status, end
        /// time, the percentage of the instance refresh that is complete, and the number of instances
        /// remaining to update before the instance refresh is complete.
        /// </para>
        ///  
        /// <para>
        /// The following are the possible statuses: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Pending</code> - The request was created, but the operation has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InProgress</code> - The operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Successful</code> - The operation completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - The operation failed to complete. You can troubleshoot using
        /// the status reason and the scaling activities. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelling</code> - An ongoing operation is being cancelled. Cancellation does
        /// not roll back any replacements that have already been completed, but it prevents new
        /// replacements from being started. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelled</code> - The operation is cancelled. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceRefreshes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceRefreshes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeInstanceRefreshes">REST API Reference for DescribeInstanceRefreshes Operation</seealso>
        Task<DescribeInstanceRefreshesResponse> DescribeInstanceRefreshesAsync(DescribeInstanceRefreshesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLaunchConfigurations


        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations();


        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request);


        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLifecycleHooks


        /// <summary>
        /// Gets information about the lifecycle hooks for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHooks">REST API Reference for DescribeLifecycleHooks Operation</seealso>
        DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request);



        /// <summary>
        /// Gets information about the lifecycle hooks for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHooks">REST API Reference for DescribeLifecycleHooks Operation</seealso>
        Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLifecycleHookTypes


        /// <summary>
        /// Describes the available types of lifecycle hooks.
        /// 
        ///  
        /// <para>
        /// The following hook types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_LAUNCHING</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_TERMINATING</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHookTypes">REST API Reference for DescribeLifecycleHookTypes Operation</seealso>
        DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request);



        /// <summary>
        /// Describes the available types of lifecycle hooks.
        /// 
        ///  
        /// <para>
        /// The following hook types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_LAUNCHING</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_TERMINATING</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHookTypes">REST API Reference for DescribeLifecycleHookTypes Operation</seealso>
        Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancers


        /// <summary>
        /// Gets information about the load balancers for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation describes only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DescribeLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// To determine the availability of registered instances, use the <code>State</code>
        /// element in the response. When you attach a load balancer to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the load
        /// balancer. If Elastic Load Balancing health checks are enabled for the Auto Scaling
        /// group, the state transitions to <code>InService</code> after at least one Auto Scaling
        /// instance passes the health check. When the load balancer is in the <code>InService</code>
        /// state, Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the load balancer
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Load balancers also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your load balancer state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request);



        /// <summary>
        /// Gets information about the load balancers for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation describes only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DescribeLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// To determine the availability of registered instances, use the <code>State</code>
        /// element in the response. When you attach a load balancer to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the load
        /// balancer. If Elastic Load Balancing health checks are enabled for the Auto Scaling
        /// group, the state transitions to <code>InService</code> after at least one Auto Scaling
        /// instance passes the health check. When the load balancer is in the <code>InService</code>
        /// state, Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the load balancer
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Load balancers also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your load balancer state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancerTargetGroups


        /// <summary>
        /// Gets information about the load balancer target groups for the specified Auto Scaling
        /// group.
        /// 
        ///  
        /// <para>
        /// To determine the availability of registered instances, use the <code>State</code>
        /// element in the response. When you attach a target group to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the target
        /// group. If Elastic Load Balancing health checks are enabled for the Auto Scaling group,
        /// the state transitions to <code>InService</code> after at least one Auto Scaling instance
        /// passes the health check. When the target group is in the <code>InService</code> state,
        /// Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the target group
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Target groups also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your target group state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancerTargetGroups">REST API Reference for DescribeLoadBalancerTargetGroups Operation</seealso>
        DescribeLoadBalancerTargetGroupsResponse DescribeLoadBalancerTargetGroups(DescribeLoadBalancerTargetGroupsRequest request);



        /// <summary>
        /// Gets information about the load balancer target groups for the specified Auto Scaling
        /// group.
        /// 
        ///  
        /// <para>
        /// To determine the availability of registered instances, use the <code>State</code>
        /// element in the response. When you attach a target group to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the target
        /// group. If Elastic Load Balancing health checks are enabled for the Auto Scaling group,
        /// the state transitions to <code>InService</code> after at least one Auto Scaling instance
        /// passes the health check. When the target group is in the <code>InService</code> state,
        /// Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the target group
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Target groups also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your target group state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancerTargetGroups">REST API Reference for DescribeLoadBalancerTargetGroups Operation</seealso>
        Task<DescribeLoadBalancerTargetGroupsResponse> DescribeLoadBalancerTargetGroupsAsync(DescribeLoadBalancerTargetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMetricCollectionTypes


        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// The <code>GroupStandbyInstances</code> metric is not returned by default. You must
        /// explicitly request this metric when calling the <a>EnableMetricsCollection</a> API.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes();


        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// The <code>GroupStandbyInstances</code> metric is not returned by default. You must
        /// explicitly request this metric when calling the <a>EnableMetricsCollection</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request);


        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// The <code>GroupStandbyInstances</code> metric is not returned by default. You must
        /// explicitly request this metric when calling the <a>EnableMetricsCollection</a> API.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// The <code>GroupStandbyInstances</code> metric is not returned by default. You must
        /// explicitly request this metric when calling the <a>EnableMetricsCollection</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNotificationConfigurations


        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations();


        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request);


        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePolicies


        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        DescribePoliciesResponse DescribePolicies();


        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request);


        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        Task<DescribePoliciesResponse> DescribePoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScalingActivities


        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        DescribeScalingActivitiesResponse DescribeScalingActivities();


        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request);


        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScalingProcessTypes


        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes();


        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request);


        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScheduledActions


        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        DescribeScheduledActionsResponse DescribeScheduledActions();


        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request);


        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags();


        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);


        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTerminationPolicyTypes


        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// which Auto Scaling instances terminate during scale in</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes();


        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// which Auto Scaling instances terminate during scale in</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request);


        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// which Auto Scaling instances terminate during scale in</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// which Auto Scaling instances terminate during scale in</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWarmPool


        /// <summary>
        /// Gets information about a warm pool and its instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWarmPool service method.</param>
        /// 
        /// <returns>The response from the DescribeWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeWarmPool">REST API Reference for DescribeWarmPool Operation</seealso>
        DescribeWarmPoolResponse DescribeWarmPool(DescribeWarmPoolRequest request);



        /// <summary>
        /// Gets information about a warm pool and its instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWarmPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeWarmPool">REST API Reference for DescribeWarmPool Operation</seealso>
        Task<DescribeWarmPoolResponse> DescribeWarmPoolAsync(DescribeWarmPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachInstances


        /// <summary>
        /// Removes one or more instances from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// After the instances are detached, you can manage them independent of the Auto Scaling
        /// group.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are detached.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to the Auto Scaling group, the instances
        /// are deregistered from the load balancer. If there are target groups attached to the
        /// Auto Scaling group, the instances are deregistered from the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/detach-instance-asg.html">Detach
        /// EC2 instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachInstances">REST API Reference for DetachInstances Operation</seealso>
        DetachInstancesResponse DetachInstances(DetachInstancesRequest request);



        /// <summary>
        /// Removes one or more instances from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// After the instances are detached, you can manage them independent of the Auto Scaling
        /// group.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are detached.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to the Auto Scaling group, the instances
        /// are deregistered from the load balancer. If there are target groups attached to the
        /// Auto Scaling group, the instances are deregistered from the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/detach-instance-asg.html">Detach
        /// EC2 instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachInstances">REST API Reference for DetachInstances Operation</seealso>
        Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachLoadBalancers


        /// <summary>
        /// Detaches one or more Classic Load Balancers from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation detaches only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DetachLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// When you detach a load balancer, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the load balancer using the <a>DescribeLoadBalancers</a> API call. The instances
        /// remain running.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancers">REST API Reference for DetachLoadBalancers Operation</seealso>
        DetachLoadBalancersResponse DetachLoadBalancers(DetachLoadBalancersRequest request);



        /// <summary>
        /// Detaches one or more Classic Load Balancers from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation detaches only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DetachLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// When you detach a load balancer, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the load balancer using the <a>DescribeLoadBalancers</a> API call. The instances
        /// remain running.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancers">REST API Reference for DetachLoadBalancers Operation</seealso>
        Task<DetachLoadBalancersResponse> DetachLoadBalancersAsync(DetachLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachLoadBalancerTargetGroups


        /// <summary>
        /// Detaches one or more target groups from the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancerTargetGroups">REST API Reference for DetachLoadBalancerTargetGroups Operation</seealso>
        DetachLoadBalancerTargetGroupsResponse DetachLoadBalancerTargetGroups(DetachLoadBalancerTargetGroupsRequest request);



        /// <summary>
        /// Detaches one or more target groups from the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancerTargetGroups">REST API Reference for DetachLoadBalancerTargetGroups Operation</seealso>
        Task<DetachLoadBalancerTargetGroupsResponse> DetachLoadBalancerTargetGroupsAsync(DetachLoadBalancerTargetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableMetricsCollection


        /// <summary>
        /// Disables group metrics for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DisableMetricsCollection">REST API Reference for DisableMetricsCollection Operation</seealso>
        DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request);



        /// <summary>
        /// Disables group metrics for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DisableMetricsCollection">REST API Reference for DisableMetricsCollection Operation</seealso>
        Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableMetricsCollection


        /// <summary>
        /// Enables group metrics for the specified Auto Scaling group. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-monitoring.html">Monitoring
        /// CloudWatch metrics for your Auto Scaling groups and instances</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnableMetricsCollection">REST API Reference for EnableMetricsCollection Operation</seealso>
        EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request);



        /// <summary>
        /// Enables group metrics for the specified Auto Scaling group. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-monitoring.html">Monitoring
        /// CloudWatch metrics for your Auto Scaling groups and instances</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnableMetricsCollection">REST API Reference for EnableMetricsCollection Operation</seealso>
        Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnterStandby


        /// <summary>
        /// Moves the specified instances into the standby state.
        /// 
        ///  
        /// <para>
        /// If you choose to decrement the desired capacity of the Auto Scaling group, the instances
        /// can enter standby as long as the desired capacity of the Auto Scaling group after
        /// the instances are placed into standby is equal to or greater than the minimum capacity
        /// of the group.
        /// </para>
        ///  
        /// <para>
        /// If you choose not to decrement the desired capacity of the Auto Scaling group, the
        /// Auto Scaling group launches new instances to replace the instances on standby.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnterStandby">REST API Reference for EnterStandby Operation</seealso>
        EnterStandbyResponse EnterStandby(EnterStandbyRequest request);



        /// <summary>
        /// Moves the specified instances into the standby state.
        /// 
        ///  
        /// <para>
        /// If you choose to decrement the desired capacity of the Auto Scaling group, the instances
        /// can enter standby as long as the desired capacity of the Auto Scaling group after
        /// the instances are placed into standby is equal to or greater than the minimum capacity
        /// of the group.
        /// </para>
        ///  
        /// <para>
        /// If you choose not to decrement the desired capacity of the Auto Scaling group, the
        /// Auto Scaling group launches new instances to replace the instances on standby.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnterStandby">REST API Reference for EnterStandby Operation</seealso>
        Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecutePolicy


        /// <summary>
        /// Executes the specified policy. This can be useful for testing the design of your scaling
        /// policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExecutePolicy">REST API Reference for ExecutePolicy Operation</seealso>
        ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request);



        /// <summary>
        /// Executes the specified policy. This can be useful for testing the design of your scaling
        /// policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExecutePolicy">REST API Reference for ExecutePolicy Operation</seealso>
        Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExitStandby


        /// <summary>
        /// Moves the specified instances out of the standby state.
        /// 
        ///  
        /// <para>
        /// After you put the instances back in service, the desired capacity is incremented.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExitStandby">REST API Reference for ExitStandby Operation</seealso>
        ExitStandbyResponse ExitStandby(ExitStandbyRequest request);



        /// <summary>
        /// Moves the specified instances out of the standby state.
        /// 
        ///  
        /// <para>
        /// After you put the instances back in service, the desired capacity is incremented.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExitStandby">REST API Reference for ExitStandby Operation</seealso>
        Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPredictiveScalingForecast


        /// <summary>
        /// Retrieves the forecast data for a predictive scaling policy.
        /// 
        ///  
        /// <para>
        /// Load forecasts are predictions of the hourly load values using historical load data
        /// from CloudWatch and an analysis of historical trends. Capacity forecasts are represented
        /// as predicted values for the minimum capacity that is needed on an hourly basis, based
        /// on the hourly load forecast.
        /// </para>
        ///  
        /// <para>
        /// A minimum of 24 hours of data is required to create the initial forecasts. However,
        /// having a full 14 days of historical data results in more accurate forecasts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPredictiveScalingForecast service method.</param>
        /// 
        /// <returns>The response from the GetPredictiveScalingForecast service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/GetPredictiveScalingForecast">REST API Reference for GetPredictiveScalingForecast Operation</seealso>
        GetPredictiveScalingForecastResponse GetPredictiveScalingForecast(GetPredictiveScalingForecastRequest request);



        /// <summary>
        /// Retrieves the forecast data for a predictive scaling policy.
        /// 
        ///  
        /// <para>
        /// Load forecasts are predictions of the hourly load values using historical load data
        /// from CloudWatch and an analysis of historical trends. Capacity forecasts are represented
        /// as predicted values for the minimum capacity that is needed on an hourly basis, based
        /// on the hourly load forecast.
        /// </para>
        ///  
        /// <para>
        /// A minimum of 24 hours of data is required to create the initial forecasts. However,
        /// having a full 14 days of historical data results in more accurate forecasts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPredictiveScalingForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPredictiveScalingForecast service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/GetPredictiveScalingForecast">REST API Reference for GetPredictiveScalingForecast Operation</seealso>
        Task<GetPredictiveScalingForecastResponse> GetPredictiveScalingForecastAsync(GetPredictiveScalingForecastRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLifecycleHook


        /// <summary>
        /// Creates or updates a lifecycle hook for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// A lifecycle hook tells Amazon EC2 Auto Scaling to perform an action on an instance
        /// when the instance launches (before it is put into service) or as the instance terminates
        /// (before it is fully terminated).
        /// </para>
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Amazon EC2 Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create the lifecycle hook. Specify whether the hook is used when the instances
        /// launch or terminate.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state using the <a>RecordLifecycleActionHeartbeat</a> API call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, complete the lifecycle action using
        /// the <a>CompleteLifecycleAction</a> API call.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of lifecycle hooks, which by default is 50 per Auto
        /// Scaling group, the call fails.
        /// </para>
        ///  
        /// <para>
        /// You can view the lifecycle hooks for an Auto Scaling group using the <a>DescribeLifecycleHooks</a>
        /// API call. If you are no longer using a lifecycle hook, you can delete it by calling
        /// the <a>DeleteLifecycleHook</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutLifecycleHook">REST API Reference for PutLifecycleHook Operation</seealso>
        PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request);



        /// <summary>
        /// Creates or updates a lifecycle hook for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// A lifecycle hook tells Amazon EC2 Auto Scaling to perform an action on an instance
        /// when the instance launches (before it is put into service) or as the instance terminates
        /// (before it is fully terminated).
        /// </para>
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Amazon EC2 Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create the lifecycle hook. Specify whether the hook is used when the instances
        /// launch or terminate.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state using the <a>RecordLifecycleActionHeartbeat</a> API call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, complete the lifecycle action using
        /// the <a>CompleteLifecycleAction</a> API call.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of lifecycle hooks, which by default is 50 per Auto
        /// Scaling group, the call fails.
        /// </para>
        ///  
        /// <para>
        /// You can view the lifecycle hooks for an Auto Scaling group using the <a>DescribeLifecycleHooks</a>
        /// API call. If you are no longer using a lifecycle hook, you can delete it by calling
        /// the <a>DeleteLifecycleHook</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutLifecycleHook">REST API Reference for PutLifecycleHook Operation</seealso>
        Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutNotificationConfiguration


        /// <summary>
        /// Configures an Auto Scaling group to send notifications when specified events take
        /// place. Subscribers to the specified topic can have messages delivered to an endpoint
        /// such as a web server or an email address.
        /// 
        ///  
        /// <para>
        /// This configuration overwrites any existing configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ASGettingNotifications.html">Getting
        /// Amazon SNS notifications when your Auto Scaling group scales</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of SNS topics, which is 10 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutNotificationConfiguration">REST API Reference for PutNotificationConfiguration Operation</seealso>
        PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request);



        /// <summary>
        /// Configures an Auto Scaling group to send notifications when specified events take
        /// place. Subscribers to the specified topic can have messages delivered to an endpoint
        /// such as a web server or an email address.
        /// 
        ///  
        /// <para>
        /// This configuration overwrites any existing configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ASGettingNotifications.html">Getting
        /// Amazon SNS notifications when your Auto Scaling group scales</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of SNS topics, which is 10 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutNotificationConfiguration">REST API Reference for PutNotificationConfiguration Operation</seealso>
        Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutScalingPolicy


        /// <summary>
        /// Creates or updates a scaling policy for an Auto Scaling group. Scaling policies are
        /// used to scale an Auto Scaling group based on configurable metrics. If no policies
        /// are defined, the dynamic scaling and predictive scaling features are not used. 
        /// 
        ///  
        /// <para>
        /// For more information about using dynamic scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-target-tracking.html">Target
        /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html">Step
        /// and simple scaling policies</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using predictive scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scaling policies for an Auto Scaling group using the <a>DescribePolicies</a>
        /// API call. If you are no longer using a scaling policy, you can delete it by calling
        /// the <a>DeletePolicy</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request);



        /// <summary>
        /// Creates or updates a scaling policy for an Auto Scaling group. Scaling policies are
        /// used to scale an Auto Scaling group based on configurable metrics. If no policies
        /// are defined, the dynamic scaling and predictive scaling features are not used. 
        /// 
        ///  
        /// <para>
        /// For more information about using dynamic scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-target-tracking.html">Target
        /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html">Step
        /// and simple scaling policies</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using predictive scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scaling policies for an Auto Scaling group using the <a>DescribePolicies</a>
        /// API call. If you are no longer using a scaling policy, you can delete it by calling
        /// the <a>DeletePolicy</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutScheduledUpdateGroupAction


        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/schedule_time.html">Scheduled
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scheduled actions for an Auto Scaling group using the <a>DescribeScheduledActions</a>
        /// API call. If you are no longer using a scheduled action, you can delete it by calling
        /// the <a>DeleteScheduledAction</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScheduledUpdateGroupAction">REST API Reference for PutScheduledUpdateGroupAction Operation</seealso>
        PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request);



        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/schedule_time.html">Scheduled
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scheduled actions for an Auto Scaling group using the <a>DescribeScheduledActions</a>
        /// API call. If you are no longer using a scheduled action, you can delete it by calling
        /// the <a>DeleteScheduledAction</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScheduledUpdateGroupAction">REST API Reference for PutScheduledUpdateGroupAction Operation</seealso>
        Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutWarmPool


        /// <summary>
        /// Creates or updates a warm pool for the specified Auto Scaling group. A warm pool is
        /// a pool of pre-initialized EC2 instances that sits alongside the Auto Scaling group.
        /// Whenever your application needs to scale out, the Auto Scaling group can draw on the
        /// warm pool to meet its new desired capacity. For more information and example configurations,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation must be called from the Region in which the Auto Scaling group was
        /// created. This operation cannot be called on an Auto Scaling group that has a mixed
        /// instances policy or a launch template or launch configuration that requests Spot Instances.
        /// </para>
        ///  
        /// <para>
        /// You can view the instances in the warm pool using the <a>DescribeWarmPool</a> API
        /// call. If you are no longer using a warm pool, you can delete it by calling the <a>DeleteWarmPool</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWarmPool service method.</param>
        /// 
        /// <returns>The response from the PutWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutWarmPool">REST API Reference for PutWarmPool Operation</seealso>
        PutWarmPoolResponse PutWarmPool(PutWarmPoolRequest request);



        /// <summary>
        /// Creates or updates a warm pool for the specified Auto Scaling group. A warm pool is
        /// a pool of pre-initialized EC2 instances that sits alongside the Auto Scaling group.
        /// Whenever your application needs to scale out, the Auto Scaling group can draw on the
        /// warm pool to meet its new desired capacity. For more information and example configurations,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation must be called from the Region in which the Auto Scaling group was
        /// created. This operation cannot be called on an Auto Scaling group that has a mixed
        /// instances policy or a launch template or launch configuration that requests Spot Instances.
        /// </para>
        ///  
        /// <para>
        /// You can view the instances in the warm pool using the <a>DescribeWarmPool</a> API
        /// call. If you are no longer using a warm pool, you can delete it by calling the <a>DeleteWarmPool</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWarmPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutWarmPool">REST API Reference for PutWarmPool Operation</seealso>
        Task<PutWarmPoolResponse> PutWarmPoolAsync(PutWarmPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RecordLifecycleActionHeartbeat


        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with the specified token or
        /// instance. This extends the timeout by the length of time defined using the <a>PutLifecycleHook</a>
        /// API call.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Amazon EC2 Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, complete the lifecycle action.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RecordLifecycleActionHeartbeat">REST API Reference for RecordLifecycleActionHeartbeat Operation</seealso>
        RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request);



        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with the specified token or
        /// instance. This extends the timeout by the length of time defined using the <a>PutLifecycleHook</a>
        /// API call.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Amazon EC2 Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, complete the lifecycle action.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RecordLifecycleActionHeartbeat">REST API Reference for RecordLifecycleActionHeartbeat Operation</seealso>
        Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResumeProcesses


        /// <summary>
        /// Resumes the specified suspended auto scaling processes, or all suspended process,
        /// for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ResumeProcesses">REST API Reference for ResumeProcesses Operation</seealso>
        ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request);



        /// <summary>
        /// Resumes the specified suspended auto scaling processes, or all suspended process,
        /// for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ResumeProcesses">REST API Reference for ResumeProcesses Operation</seealso>
        Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetDesiredCapacity


        /// <summary>
        /// Sets the size of the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-manual-scaling.html">Manual
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetDesiredCapacity">REST API Reference for SetDesiredCapacity Operation</seealso>
        SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request);



        /// <summary>
        /// Sets the size of the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-manual-scaling.html">Manual
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetDesiredCapacity">REST API Reference for SetDesiredCapacity Operation</seealso>
        Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetInstanceHealth


        /// <summary>
        /// Sets the health status of the specified instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// checks for Auto Scaling instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceHealth">REST API Reference for SetInstanceHealth Operation</seealso>
        SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request);



        /// <summary>
        /// Sets the health status of the specified instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// checks for Auto Scaling instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceHealth">REST API Reference for SetInstanceHealth Operation</seealso>
        Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetInstanceProtection


        /// <summary>
        /// Updates the instance protection settings of the specified instances. This operation
        /// cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// For more information about preventing instances that are part of an Auto Scaling group
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of instance IDs, which is 50 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceProtection service method.</param>
        /// 
        /// <returns>The response from the SetInstanceProtection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceProtection">REST API Reference for SetInstanceProtection Operation</seealso>
        SetInstanceProtectionResponse SetInstanceProtection(SetInstanceProtectionRequest request);



        /// <summary>
        /// Updates the instance protection settings of the specified instances. This operation
        /// cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// For more information about preventing instances that are part of an Auto Scaling group
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of instance IDs, which is 50 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetInstanceProtection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceProtection">REST API Reference for SetInstanceProtection Operation</seealso>
        Task<SetInstanceProtectionResponse> SetInstanceProtectionAsync(SetInstanceProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartInstanceRefresh


        /// <summary>
        /// Starts a new instance refresh operation, which triggers a rolling replacement of previously
        /// launched instances in the Auto Scaling group with a new group of instances.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// If the call succeeds, it creates a new instance refresh request with a unique ID that
        /// you can use to track its progress. To query its status, call the <a>DescribeInstanceRefreshes</a>
        /// API. To describe the instance refreshes that have already run, call the <a>DescribeInstanceRefreshes</a>
        /// API. To cancel an instance refresh operation in progress, use the <a>CancelInstanceRefresh</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceRefresh service method.</param>
        /// 
        /// <returns>The response from the StartInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InstanceRefreshInProgressException">
        /// The request failed because an active instance refresh operation already exists for
        /// the specified Auto Scaling group.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/StartInstanceRefresh">REST API Reference for StartInstanceRefresh Operation</seealso>
        StartInstanceRefreshResponse StartInstanceRefresh(StartInstanceRefreshRequest request);



        /// <summary>
        /// Starts a new instance refresh operation, which triggers a rolling replacement of previously
        /// launched instances in the Auto Scaling group with a new group of instances.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// If the call succeeds, it creates a new instance refresh request with a unique ID that
        /// you can use to track its progress. To query its status, call the <a>DescribeInstanceRefreshes</a>
        /// API. To describe the instance refreshes that have already run, call the <a>DescribeInstanceRefreshes</a>
        /// API. To cancel an instance refresh operation in progress, use the <a>CancelInstanceRefresh</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InstanceRefreshInProgressException">
        /// The request failed because an active instance refresh operation already exists for
        /// the specified Auto Scaling group.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/StartInstanceRefresh">REST API Reference for StartInstanceRefresh Operation</seealso>
        Task<StartInstanceRefreshResponse> StartInstanceRefreshAsync(StartInstanceRefreshRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SuspendProcesses


        /// <summary>
        /// Suspends the specified auto scaling processes, or all processes, for the specified
        /// Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If you suspend either the <code>Launch</code> or <code>Terminate</code> process types,
        /// it can prevent other process types from functioning properly. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To resume processes that have been suspended, call the <a>ResumeProcesses</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SuspendProcesses">REST API Reference for SuspendProcesses Operation</seealso>
        SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request);



        /// <summary>
        /// Suspends the specified auto scaling processes, or all processes, for the specified
        /// Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If you suspend either the <code>Launch</code> or <code>Terminate</code> process types,
        /// it can prevent other process types from functioning properly. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To resume processes that have been suspended, call the <a>ResumeProcesses</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SuspendProcesses">REST API Reference for SuspendProcesses Operation</seealso>
        Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateInstanceInAutoScalingGroup


        /// <summary>
        /// Terminates the specified instance and optionally adjusts the desired group size. This
        /// operation cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// This call simply makes a termination request. The instance is not terminated immediately.
        /// When an instance is terminated, the instance status changes to <code>terminated</code>.
        /// You can't connect to or start an instance after you've terminated it.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are terminated. 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 Auto Scaling balances instances across all Availability Zones.
        /// If you decrement the desired capacity, your Auto Scaling group can become unbalanced
        /// between Availability Zones. Amazon EC2 Auto Scaling tries to rebalance the group,
        /// and rebalancing might terminate instances in other zones. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/auto-scaling-benefits.html#AutoScalingBehavior.InstanceUsage">Rebalancing
        /// activities</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/TerminateInstanceInAutoScalingGroup">REST API Reference for TerminateInstanceInAutoScalingGroup Operation</seealso>
        TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request);



        /// <summary>
        /// Terminates the specified instance and optionally adjusts the desired group size. This
        /// operation cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// This call simply makes a termination request. The instance is not terminated immediately.
        /// When an instance is terminated, the instance status changes to <code>terminated</code>.
        /// You can't connect to or start an instance after you've terminated it.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are terminated. 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 Auto Scaling balances instances across all Availability Zones.
        /// If you decrement the desired capacity, your Auto Scaling group can become unbalanced
        /// between Availability Zones. Amazon EC2 Auto Scaling tries to rebalance the group,
        /// and rebalancing might terminate instances in other zones. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/auto-scaling-benefits.html#AutoScalingBehavior.InstanceUsage">Rebalancing
        /// activities</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/TerminateInstanceInAutoScalingGroup">REST API Reference for TerminateInstanceInAutoScalingGroup Operation</seealso>
        Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAutoScalingGroup


        /// <summary>
        /// <b>We strongly recommend that all Auto Scaling groups use launch templates to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Updates the configuration for the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// To update an Auto Scaling group, specify the name of the group and the parameter that
        /// you want to change. Any parameters that you don't specify are not changed by this
        /// update request. The new settings take effect on any scaling activities after this
        /// call returns. 
        /// </para>
        ///  
        /// <para>
        /// If you associate a new launch configuration or template with an Auto Scaling group,
        /// all new instances will get the updated configuration. Existing instances continue
        /// to run with the configuration that they were originally launched with. When you update
        /// a group to specify a mixed instances policy instead of a launch configuration or template,
        /// existing instances may be replaced to match the new purchasing options that you specified
        /// in the policy. For example, if the group currently has 100% On-Demand capacity and
        /// the policy specifies 50% Spot capacity, this means that half of your instances will
        /// be gradually terminated and relaunched as Spot Instances. When replacing instances,
        /// Amazon EC2 Auto Scaling launches new instances before terminating the old ones, so
        /// that updating your group does not compromise the performance or availability of your
        /// application.
        /// </para>
        ///  
        /// <para>
        /// Note the following about changing <code>DesiredCapacity</code>, <code>MaxSize</code>,
        /// or <code>MinSize</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MinSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MinSize</code> is larger than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MinSize</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MaxSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MaxSize</code> is smaller than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MaxSize</code> value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To see which parameters have been set, call the <a>DescribeAutoScalingGroups</a> API.
        /// To view the scaling policies for an Auto Scaling group, call the <a>DescribePolicies</a>
        /// API. If the group has scaling policies, you can update them by calling the <a>PutScalingPolicy</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/UpdateAutoScalingGroup">REST API Reference for UpdateAutoScalingGroup Operation</seealso>
        UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request);



        /// <summary>
        /// <b>We strongly recommend that all Auto Scaling groups use launch templates to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Updates the configuration for the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// To update an Auto Scaling group, specify the name of the group and the parameter that
        /// you want to change. Any parameters that you don't specify are not changed by this
        /// update request. The new settings take effect on any scaling activities after this
        /// call returns. 
        /// </para>
        ///  
        /// <para>
        /// If you associate a new launch configuration or template with an Auto Scaling group,
        /// all new instances will get the updated configuration. Existing instances continue
        /// to run with the configuration that they were originally launched with. When you update
        /// a group to specify a mixed instances policy instead of a launch configuration or template,
        /// existing instances may be replaced to match the new purchasing options that you specified
        /// in the policy. For example, if the group currently has 100% On-Demand capacity and
        /// the policy specifies 50% Spot capacity, this means that half of your instances will
        /// be gradually terminated and relaunched as Spot Instances. When replacing instances,
        /// Amazon EC2 Auto Scaling launches new instances before terminating the old ones, so
        /// that updating your group does not compromise the performance or availability of your
        /// application.
        /// </para>
        ///  
        /// <para>
        /// Note the following about changing <code>DesiredCapacity</code>, <code>MaxSize</code>,
        /// or <code>MinSize</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MinSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MinSize</code> is larger than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MinSize</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MaxSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MaxSize</code> is smaller than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MaxSize</code> value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To see which parameters have been set, call the <a>DescribeAutoScalingGroups</a> API.
        /// To view the scaling policies for an Auto Scaling group, call the <a>DescribePolicies</a>
        /// API. If the group has scaling policies, you can update them by calling the <a>PutScalingPolicy</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/UpdateAutoScalingGroup">REST API Reference for UpdateAutoScalingGroup Operation</seealso>
        Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}