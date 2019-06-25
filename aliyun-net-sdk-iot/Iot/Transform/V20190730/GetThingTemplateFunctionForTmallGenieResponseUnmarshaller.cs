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
    public class GetThingTemplateFunctionForTmallGenieResponseUnmarshaller
    {
        public static GetThingTemplateFunctionForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			GetThingTemplateFunctionForTmallGenieResponse getThingTemplateFunctionForTmallGenieResponse = new GetThingTemplateFunctionForTmallGenieResponse();

			getThingTemplateFunctionForTmallGenieResponse.HttpResponse = context.HttpResponse;
			getThingTemplateFunctionForTmallGenieResponse.RequestId = context.StringValue("GetThingTemplateFunctionForTmallGenie.RequestId");
			getThingTemplateFunctionForTmallGenieResponse.Success = context.BooleanValue("GetThingTemplateFunctionForTmallGenie.Success");
			getThingTemplateFunctionForTmallGenieResponse.Code = context.StringValue("GetThingTemplateFunctionForTmallGenie.Code");
			getThingTemplateFunctionForTmallGenieResponse.ErrorMessage = context.StringValue("GetThingTemplateFunctionForTmallGenie.ErrorMessage");

			GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data data = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data();

			GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_PropertyInfo propertyInfo = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_PropertyInfo();
			propertyInfo.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.TmallFunctionId");
			propertyInfo.ThingTemplateKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.ThingTemplateKey");
			propertyInfo.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.DataType");
			propertyInfo.RwType = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.RwType");
			propertyInfo.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.Identifier");
			propertyInfo.Description = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.Description");
			propertyInfo.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.Name");
			propertyInfo.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.DataSpecs");
			propertyInfo.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.DataSpecsList");

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag> propertyInfo_tags = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.Tags.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag tag = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag();
				tag.TagKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.PropertyInfo.Tags["+ i +"].TagValue");

				propertyInfo_tags.Add(tag);
			}
			propertyInfo.Tags = propertyInfo_tags;
			data.PropertyInfo = propertyInfo;

			GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo serviceInfo = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo();
			serviceInfo.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.TmallFunctionId");
			serviceInfo.ThingTemplateKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.ThingTemplateKey");
			serviceInfo.CallType = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.CallType");
			serviceInfo.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.Name");
			serviceInfo.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.Identifier");

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument> serviceInfo_inputParams = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument argument = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument();
				argument.Id = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Id");
				argument.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].DataType");
				argument.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Identifier");
				argument.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Name");
				argument.ParaOrder = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].ParaOrder");
				argument.Direction = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Direction");
				argument.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].DataSpecs");
				argument.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].DataSpecsList");

				serviceInfo_inputParams.Add(argument);
			}
			serviceInfo.InputParams = serviceInfo_inputParams;

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2> serviceInfo_outputParams = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2 argument2 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2();
				argument2.Id = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Id");
				argument2.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].DataType");
				argument2.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Identifier");
				argument2.ParaOrder = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].ParaOrder");
				argument2.Direction = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Direction");
				argument2.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Name");
				argument2.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].DataSpecs");
				argument2.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].DataSpecsList");

				serviceInfo_outputParams.Add(argument2);
			}
			serviceInfo.OutputParams = serviceInfo_outputParams;

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3> serviceInfo_tags1 = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.Tags.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3 tag3 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3();
				tag3.TagKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.Tags["+ i +"].TagKey");
				tag3.TagValue = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.ServiceInfo.Tags["+ i +"].TagValue");

				serviceInfo_tags1.Add(tag3);
			}
			serviceInfo.Tags1 = serviceInfo_tags1;
			data.ServiceInfo = serviceInfo;

			GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos eventInfos = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos();
			eventInfos.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.TmallFunctionId");
			eventInfos.ThingTemplateKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.ThingTemplateKey");
			eventInfos.EventType = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.EventType");
			eventInfos.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.Name");
			eventInfos.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.Identifier");

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Argument5> eventInfos_outputData = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Argument5>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Argument5 argument5 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Argument5();
				argument5.Id = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].Id");
				argument5.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].DataType");
				argument5.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].Identifier");
				argument5.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].Name");
				argument5.ParaOrder = context.LongValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].ParaOrder");
				argument5.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].DataSpecs");
				argument5.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].DataSpecsList");

				eventInfos_outputData.Add(argument5);
			}
			eventInfos.OutputData = eventInfos_outputData;

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Tag6> eventInfos_tags4 = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Tag6>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.Tags.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Tag6 tag6 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_Data.GetThingTemplateFunctionForTmallGenie_EventInfos.GetThingTemplateFunctionForTmallGenie_Tag6();
				tag6.TagKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.Tags["+ i +"].TagKey");
				tag6.TagValue = context.StringValue("GetThingTemplateFunctionForTmallGenie.Data.EventInfos.Tags["+ i +"].TagValue");

				eventInfos_tags4.Add(tag6);
			}
			eventInfos.Tags4 = eventInfos_tags4;
			data.EventInfos = eventInfos;
			getThingTemplateFunctionForTmallGenieResponse.Data = data;
        
			return getThingTemplateFunctionForTmallGenieResponse;
        }
    }
}
