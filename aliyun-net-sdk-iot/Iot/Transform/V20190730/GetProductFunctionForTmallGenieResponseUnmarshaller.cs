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
using Aliyun.Acs.Iot.Model.V20190730;

namespace Aliyun.Acs.Iot.Transform.V20190730
{
    public class GetProductFunctionForTmallGenieResponseUnmarshaller
    {
        public static GetProductFunctionForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			GetProductFunctionForTmallGenieResponse getProductFunctionForTmallGenieResponse = new GetProductFunctionForTmallGenieResponse();

			getProductFunctionForTmallGenieResponse.HttpResponse = context.HttpResponse;
			getProductFunctionForTmallGenieResponse.RequestId = context.StringValue("GetProductFunctionForTmallGenie.RequestId");
			getProductFunctionForTmallGenieResponse.Success = context.BooleanValue("GetProductFunctionForTmallGenie.Success");
			getProductFunctionForTmallGenieResponse.Code = context.StringValue("GetProductFunctionForTmallGenie.Code");
			getProductFunctionForTmallGenieResponse.ErrorMessage = context.StringValue("GetProductFunctionForTmallGenie.ErrorMessage");

			GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_PropertyInfo propertyInfo = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_PropertyInfo();
			propertyInfo.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.PropertyInfo.TmallFunctionId");
			propertyInfo.ThingTemplateKey = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.ThingTemplateKey");
			propertyInfo.DataType = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.DataType");
			propertyInfo.RwType = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.RwType");
			propertyInfo.Identifier = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.Identifier");
			propertyInfo.Description = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.Description");
			propertyInfo.Name = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.Name");
			propertyInfo.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.DataSpecs");
			propertyInfo.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.DataSpecsList");

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag> propertyInfo_tags = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.PropertyInfo.Tags.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag tag = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag();
				tag.TagKey = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("GetProductFunctionForTmallGenie.PropertyInfo.Tags["+ i +"].TagValue");

				propertyInfo_tags.Add(tag);
			}
			propertyInfo.Tags = propertyInfo_tags;
			getProductFunctionForTmallGenieResponse.PropertyInfo = propertyInfo;

			GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo serviceInfo = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo();
			serviceInfo.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.ServiceInfo.TmallFunctionId");
			serviceInfo.ThingTemplateKey = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.ThingTemplateKey");
			serviceInfo.CallType = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.CallType");
			serviceInfo.Name = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.Name");
			serviceInfo.Identifier = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.Identifier");

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument> serviceInfo_inputParams = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.ServiceInfo.InputParams.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument argument = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument();
				argument.Id = context.LongValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Id");
				argument.DataType = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].DataType");
				argument.Identifier = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Identifier");
				argument.Name = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Name");
				argument.ParaOrder = context.IntegerValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].ParaOrder");
				argument.Direction = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Direction");
				argument.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].DataSpecs");
				argument.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].DataSpecsList");
				argument.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].TmallFunctionId");

				serviceInfo_inputParams.Add(argument);
			}
			serviceInfo.InputParams = serviceInfo_inputParams;

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2> serviceInfo_outputParams = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2 argument2 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2();
				argument2.Id = context.LongValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Id");
				argument2.DataType = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].DataType");
				argument2.Identifier = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Identifier");
				argument2.ParaOrder = context.IntegerValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].ParaOrder");
				argument2.Direction = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Direction");
				argument2.Name = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Name");
				argument2.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].DataSpecs");
				argument2.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].DataSpecsList");
				argument2.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].TmallFunctionId");

				serviceInfo_outputParams.Add(argument2);
			}
			serviceInfo.OutputParams = serviceInfo_outputParams;

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3> serviceInfo_tags1 = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.ServiceInfo.Tags.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3 tag3 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3();
				tag3.TagKey = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.Tags["+ i +"].TagKey");
				tag3.TagValue = context.StringValue("GetProductFunctionForTmallGenie.ServiceInfo.Tags["+ i +"].TagValue");

				serviceInfo_tags1.Add(tag3);
			}
			serviceInfo.Tags1 = serviceInfo_tags1;
			getProductFunctionForTmallGenieResponse.ServiceInfo = serviceInfo;

			GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos eventInfos = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos();
			eventInfos.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.EventInfos.TmallFunctionId");
			eventInfos.ThingTemplateKey = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.ThingTemplateKey");
			eventInfos.EventType = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.EventType");
			eventInfos.Name = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.Name");
			eventInfos.Identifier = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.Identifier");

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5> eventInfos_outputData = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.EventInfos.OutputData.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5 argument5 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5();
				argument5.Id = context.LongValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].Id");
				argument5.DataType = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].DataType");
				argument5.Identifier = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].Identifier");
				argument5.Name = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].Name");
				argument5.ParaOrder = context.IntegerValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].ParaOrder");
				argument5.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].DataSpecs");
				argument5.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].DataSpecsList");
				argument5.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.EventInfos.OutputData["+ i +"].TmallFunctionId");

				eventInfos_outputData.Add(argument5);
			}
			eventInfos.OutputData = eventInfos_outputData;

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6> eventInfos_tags4 = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.EventInfos.Tags.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6 tag6 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6();
				tag6.TagKey = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.Tags["+ i +"].TagKey");
				tag6.TagValue = context.StringValue("GetProductFunctionForTmallGenie.EventInfos.Tags["+ i +"].TagValue");

				eventInfos_tags4.Add(tag6);
			}
			eventInfos.Tags4 = eventInfos_tags4;
			getProductFunctionForTmallGenieResponse.EventInfos = eventInfos;
        
			return getProductFunctionForTmallGenieResponse;
        }
    }
}
