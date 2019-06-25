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

			GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data data = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data();

			GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_PropertyInfo propertyInfo = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_PropertyInfo();
			propertyInfo.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.TmallFunctionId");
			propertyInfo.ThingTemplateKey = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.ThingTemplateKey");
			propertyInfo.DataType = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.DataType");
			propertyInfo.RwType = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.RwType");
			propertyInfo.Identifier = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.Identifier");
			propertyInfo.Description = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.Description");
			propertyInfo.Name = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.Name");
			propertyInfo.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.DataSpecs");
			propertyInfo.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.DataSpecsList");

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag> propertyInfo_tags = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.Data.PropertyInfo.Tags.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag tag = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_PropertyInfo.GetProductFunctionForTmallGenie_Tag();
				tag.TagKey = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.Tags["+ i +"].TagKey");
				tag.TagValue = context.StringValue("GetProductFunctionForTmallGenie.Data.PropertyInfo.Tags["+ i +"].TagValue");

				propertyInfo_tags.Add(tag);
			}
			propertyInfo.Tags = propertyInfo_tags;
			data.PropertyInfo = propertyInfo;

			GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo serviceInfo = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo();
			serviceInfo.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.TmallFunctionId");
			serviceInfo.ThingTemplateKey = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.ThingTemplateKey");
			serviceInfo.CallType = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.CallType");
			serviceInfo.Name = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.Name");
			serviceInfo.Identifier = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.Identifier");

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument> serviceInfo_inputParams = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument argument = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument();
				argument.Id = context.LongValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Id");
				argument.DataType = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].DataType");
				argument.Identifier = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Identifier");
				argument.Name = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Name");
				argument.ParaOrder = context.LongValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].ParaOrder");
				argument.Direction = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].Direction");
				argument.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].DataSpecs");
				argument.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.InputParams["+ i +"].DataSpecsList");

				serviceInfo_inputParams.Add(argument);
			}
			serviceInfo.InputParams = serviceInfo_inputParams;

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2> serviceInfo_outputParams = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2 argument2 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Argument2();
				argument2.Id = context.LongValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Id");
				argument2.DataType = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].DataType");
				argument2.Identifier = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Identifier");
				argument2.ParaOrder = context.LongValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].ParaOrder");
				argument2.Direction = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Direction");
				argument2.Name = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].Name");
				argument2.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].DataSpecs");
				argument2.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.OutputParams["+ i +"].DataSpecsList");

				serviceInfo_outputParams.Add(argument2);
			}
			serviceInfo.OutputParams = serviceInfo_outputParams;

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3> serviceInfo_tags1 = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.Data.ServiceInfo.Tags.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3 tag3 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_ServiceInfo.GetProductFunctionForTmallGenie_Tag3();
				tag3.TagKey = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.Tags["+ i +"].TagKey");
				tag3.TagValue = context.StringValue("GetProductFunctionForTmallGenie.Data.ServiceInfo.Tags["+ i +"].TagValue");

				serviceInfo_tags1.Add(tag3);
			}
			serviceInfo.Tags1 = serviceInfo_tags1;
			data.ServiceInfo = serviceInfo;

			GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos eventInfos = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos();
			eventInfos.TmallFunctionId = context.LongValue("GetProductFunctionForTmallGenie.Data.EventInfos.TmallFunctionId");
			eventInfos.ThingTemplateKey = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.ThingTemplateKey");
			eventInfos.EventType = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.EventType");
			eventInfos.Name = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.Name");
			eventInfos.Identifier = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.Identifier");

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5> eventInfos_outputData = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5 argument5 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Argument5();
				argument5.Id = context.LongValue("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].Id");
				argument5.DataType = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].DataType");
				argument5.Identifier = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].Identifier");
				argument5.Name = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].Name");
				argument5.ParaOrder = context.LongValue("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].ParaOrder");
				argument5.DataSpecs = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].DataSpecs");
				argument5.DataSpecsList = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.OutputData["+ i +"].DataSpecsList");

				eventInfos_outputData.Add(argument5);
			}
			eventInfos.OutputData = eventInfos_outputData;

			List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6> eventInfos_tags4 = new List<GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6>();
			for (int i = 0; i < context.Length("GetProductFunctionForTmallGenie.Data.EventInfos.Tags.Length"); i++) {
				GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6 tag6 = new GetProductFunctionForTmallGenieResponse.GetProductFunctionForTmallGenie_Data.GetProductFunctionForTmallGenie_EventInfos.GetProductFunctionForTmallGenie_Tag6();
				tag6.TagKey = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.Tags["+ i +"].TagKey");
				tag6.TagValue = context.StringValue("GetProductFunctionForTmallGenie.Data.EventInfos.Tags["+ i +"].TagValue");

				eventInfos_tags4.Add(tag6);
			}
			eventInfos.Tags4 = eventInfos_tags4;
			data.EventInfos = eventInfos;
			getProductFunctionForTmallGenieResponse.Data = data;
        
			return getProductFunctionForTmallGenieResponse;
        }
    }
}
