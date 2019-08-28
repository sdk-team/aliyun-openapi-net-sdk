/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class GetCustomerTranscodeConfResponseUnmarshaller
    {
        public static GetCustomerTranscodeConfResponse Unmarshall(UnmarshallerContext context)
        {
			GetCustomerTranscodeConfResponse getCustomerTranscodeConfResponse = new GetCustomerTranscodeConfResponse();

			getCustomerTranscodeConfResponse.HttpResponse = context.HttpResponse;
			getCustomerTranscodeConfResponse.RequestId = context.StringValue("GetCustomerTranscodeConf.RequestId");

			List<GetCustomerTranscodeConfResponse.GetCustomerTranscodeConf_Template> getCustomerTranscodeConfResponse_templates = new List<GetCustomerTranscodeConfResponse.GetCustomerTranscodeConf_Template>();
			for (int i = 0; i < context.Length("GetCustomerTranscodeConf.Templates.Length"); i++) {
				GetCustomerTranscodeConfResponse.GetCustomerTranscodeConf_Template template = new GetCustomerTranscodeConfResponse.GetCustomerTranscodeConf_Template();
				template.Id = context.StringValue("GetCustomerTranscodeConf.Templates["+ i +"].Id");
				template.CustomerId = context.StringValue("GetCustomerTranscodeConf.Templates["+ i +"].CustomerId");
				template.TemplateId = context.StringValue("GetCustomerTranscodeConf.Templates["+ i +"].TemplateId");
				template.MtstemplateId = context.StringValue("GetCustomerTranscodeConf.Templates["+ i +"].MtstemplateId");
				template.Status = context.StringValue("GetCustomerTranscodeConf.Templates["+ i +"].Status");
				template.Name = context.StringValue("GetCustomerTranscodeConf.Templates["+ i +"].Name");
				template.Encrypt = context.StringValue("GetCustomerTranscodeConf.Templates["+ i +"].Encrypt");

				getCustomerTranscodeConfResponse_templates.Add(template);
			}
			getCustomerTranscodeConfResponse.Templates = getCustomerTranscodeConfResponse_templates;
        
			return getCustomerTranscodeConfResponse;
        }
    }
}
