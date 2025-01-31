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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStudioComponent Request Marshaller
    /// </summary>       
    public class UpdateStudioComponentRequestMarshaller : IMarshaller<IRequest, UpdateStudioComponentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStudioComponentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStudioComponentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NimbleStudio");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetStudioComponentId())
                throw new AmazonNimbleStudioException("Request object does not have required field StudioComponentId set");
            request.AddPathResource("{studioComponentId}", StringUtils.FromString(publicRequest.StudioComponentId));
            if (!publicRequest.IsSetStudioId())
                throw new AmazonNimbleStudioException("Request object does not have required field StudioId set");
            request.AddPathResource("{studioId}", StringUtils.FromString(publicRequest.StudioId));
            request.ResourcePath = "/2020-08-01/studios/{studioId}/studio-components/{studioComponentId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = StudioComponentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEc2SecurityGroupIds())
                {
                    context.Writer.WritePropertyName("ec2SecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEc2SecurityGroupIdsListValue in publicRequest.Ec2SecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestEc2SecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInitializationScripts())
                {
                    context.Writer.WritePropertyName("initializationScripts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInitializationScriptsListValue in publicRequest.InitializationScripts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StudioComponentInitializationScriptMarshaller.Instance;
                        marshaller.Marshall(publicRequestInitializationScriptsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetScriptParameters())
                {
                    context.Writer.WritePropertyName("scriptParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestScriptParametersListValue in publicRequest.ScriptParameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ScriptParameterKeyValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestScriptParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubtype())
                {
                    context.Writer.WritePropertyName("subtype");
                    context.Writer.Write(publicRequest.Subtype);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static UpdateStudioComponentRequestMarshaller _instance = new UpdateStudioComponentRequestMarshaller();        

        internal static UpdateStudioComponentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStudioComponentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}