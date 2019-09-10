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

			GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_PropertyInfo propertyInfo = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_PropertyInfo();
			propertyInfo.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.TmallFunctionId");
			propertyInfo.ThingTemplateKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.ThingTemplateKey");
			propertyInfo.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.DataType");
			propertyInfo.RwType = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.RwType");
			propertyInfo.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.Identifier");
			propertyInfo.Description = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.Description");
			propertyInfo.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.Name");
			propertyInfo.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.DataSpecs");
			propertyInfo.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.DataSpecsList");

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag> propertyInfo_tags = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.PropertyInfo.Tags.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag tag = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_PropertyInfo.GetThingTemplateFunctionForTmallGenie_Tag();
				tag.TagKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("GetThingTemplateFunctionForTmallGenie.PropertyInfo.Tags["+ i +"].TagValue");

				propertyInfo_tags.Add(tag);
			}
			propertyInfo.Tags = propertyInfo_tags;
			getThingTemplateFunctionForTmallGenieResponse.PropertyInfo = propertyInfo;

			GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo serviceInfo = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo();
			serviceInfo.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.TmallFunctionId");
			serviceInfo.ThingTemplateKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.ThingTemplateKey");
			serviceInfo.CallType = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.CallType");
			serviceInfo.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.Name");
			serviceInfo.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.Identifier");

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument> serviceInfo_inputParams = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument argument = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument();
				argument.Id = context.LongValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Id");
				argument.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].DataType");
				argument.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Identifier");
				argument.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Name");
				argument.ParaOrder = context.IntegerValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].ParaOrder");
				argument.Direction = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].Direction");
				argument.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].DataSpecs");
				argument.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].DataSpecsList");
				argument.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.InputParams["+ i +"].TmallFunctionId");

				serviceInfo_inputParams.Add(argument);
			}
			serviceInfo.InputParams = serviceInfo_inputParams;

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2> serviceInfo_outputParams = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2 argument2 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Argument2();
				argument2.Id = context.LongValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Id");
				argument2.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].DataType");
				argument2.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Identifier");
				argument2.ParaOrder = context.IntegerValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].ParaOrder");
				argument2.Direction = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Direction");
				argument2.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].Name");
				argument2.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].DataSpecs");
				argument2.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].DataSpecsList");
				argument2.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.OutputParams["+ i +"].TmallFunctionId");

				serviceInfo_outputParams.Add(argument2);
			}
			serviceInfo.OutputParams = serviceInfo_outputParams;

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3> serviceInfo_tags1 = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.ServiceInfo.Tags.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3 tag3 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_ServiceInfo.GetThingTemplateFunctionForTmallGenie_Tag3();
				tag3.TagKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.Tags["+ i +"].TagKey");
				tag3.TagValue = context.StringValue("GetThingTemplateFunctionForTmallGenie.ServiceInfo.Tags["+ i +"].TagValue");

				serviceInfo_tags1.Add(tag3);
			}
			serviceInfo.Tags1 = serviceInfo_tags1;
			getThingTemplateFunctionForTmallGenieResponse.ServiceInfo = serviceInfo;

			GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo eventInfo = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo();
			eventInfo.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.EventInfo.TmallFunctionId");
			eventInfo.ThingTemplateKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.ThingTemplateKey");
			eventInfo.EventType = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.EventType");
			eventInfo.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.Name");
			eventInfo.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.Identifier");

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Argument5> eventInfo_outputData = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Argument5>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Argument5 argument5 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Argument5();
				argument5.Id = context.LongValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].Id");
				argument5.DataType = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].DataType");
				argument5.Identifier = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].Identifier");
				argument5.Name = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].Name");
				argument5.ParaOrder = context.IntegerValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].ParaOrder");
				argument5.DataSpecs = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].DataSpecs");
				argument5.DataSpecsList = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].DataSpecsList");
				argument5.TmallFunctionId = context.LongValue("GetThingTemplateFunctionForTmallGenie.EventInfo.OutputData["+ i +"].TmallFunctionId");

				eventInfo_outputData.Add(argument5);
			}
			eventInfo.OutputData = eventInfo_outputData;

			List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Tag6> eventInfo_tags4 = new List<GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Tag6>();
			for (int i = 0; i < context.Length("GetThingTemplateFunctionForTmallGenie.EventInfo.Tags.Length"); i++) {
				GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Tag6 tag6 = new GetThingTemplateFunctionForTmallGenieResponse.GetThingTemplateFunctionForTmallGenie_EventInfo.GetThingTemplateFunctionForTmallGenie_Tag6();
				tag6.TagKey = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.Tags["+ i +"].TagKey");
				tag6.TagValue = context.StringValue("GetThingTemplateFunctionForTmallGenie.EventInfo.Tags["+ i +"].TagValue");

				eventInfo_tags4.Add(tag6);
			}
			eventInfo.Tags4 = eventInfo_tags4;
			getThingTemplateFunctionForTmallGenieResponse.EventInfo = eventInfo;
        
			return getThingTemplateFunctionForTmallGenieResponse;
        }
    }
}
