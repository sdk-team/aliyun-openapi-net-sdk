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
    public class GetPoolFunctionsByIdListForTmallGenieResponseUnmarshaller
    {
        public static GetPoolFunctionsByIdListForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			GetPoolFunctionsByIdListForTmallGenieResponse getPoolFunctionsByIdListForTmallGenieResponse = new GetPoolFunctionsByIdListForTmallGenieResponse();

			getPoolFunctionsByIdListForTmallGenieResponse.HttpResponse = context.HttpResponse;
			getPoolFunctionsByIdListForTmallGenieResponse.RequestId = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.RequestId");
			getPoolFunctionsByIdListForTmallGenieResponse.Success = context.BooleanValue("GetPoolFunctionsByIdListForTmallGenie.Success");
			getPoolFunctionsByIdListForTmallGenieResponse.Code = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.Code");
			getPoolFunctionsByIdListForTmallGenieResponse.ErrorMessage = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ErrorMessage");

			List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo> getPoolFunctionsByIdListForTmallGenieResponse_propertyInfos = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo>();
			for (int i = 0; i < context.Length("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos.Length"); i++) {
				GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo propertyInfo = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo();
				propertyInfo.TmallFunctionId = context.LongValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].TmallFunctionId");
				propertyInfo.Identifier = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].Identifier");
				propertyInfo.ThingTemplateKey = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].ThingTemplateKey");
				propertyInfo.DataType = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].DataType");
				propertyInfo.Name = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].Name");
				propertyInfo.RwType = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].RwType");
				propertyInfo.Description = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].Description");
				propertyInfo.DataSpecs = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].DataSpecs");
				propertyInfo.DataSpecsList = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].DataSpecsList");

				List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo.GetPoolFunctionsByIdListForTmallGenie_Tag> propertyInfo_tags = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo.GetPoolFunctionsByIdListForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].Tags.Length"); j++) {
					GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo.GetPoolFunctionsByIdListForTmallGenie_Tag tag = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_PropertyInfo.GetPoolFunctionsByIdListForTmallGenie_Tag();
					tag.TagKey = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.PropertyInfos["+ i +"].Tags["+ j +"].TagValue");

					propertyInfo_tags.Add(tag);
				}
				propertyInfo.Tags = propertyInfo_tags;

				getPoolFunctionsByIdListForTmallGenieResponse_propertyInfos.Add(propertyInfo);
			}
			getPoolFunctionsByIdListForTmallGenieResponse.PropertyInfos = getPoolFunctionsByIdListForTmallGenieResponse_propertyInfos;

			List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo> getPoolFunctionsByIdListForTmallGenieResponse_serviceInfos = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo>();
			for (int i = 0; i < context.Length("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos.Length"); i++) {
				GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo serviceInfo = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo();
				serviceInfo.TmallFunctionId = context.LongValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].TmallFunctionId");
				serviceInfo.ThingTemplateKey = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].ThingTemplateKey");
				serviceInfo.CallType = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].CallType");
				serviceInfo.Name = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].Name");
				serviceInfo.Identifier = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].Identifier");

				List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument> serviceInfo_inputParams = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument>();
				for (int j = 0; j < context.Length("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams.Length"); j++) {
					GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument argument = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument();
					argument.DataType = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].DataType");
					argument.Identifier = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].Identifier");
					argument.Name = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].Name");
					argument.ParaOrder = context.IntegerValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].ParaOrder");
					argument.Direction = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].Direction");
					argument.DataSpecs = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].DataSpecs");
					argument.DataSpecsList = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].DataSpecsList");
					argument.TmallFunctionId = context.LongValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].TmallFunctionId");

					serviceInfo_inputParams.Add(argument);
				}
				serviceInfo.InputParams = serviceInfo_inputParams;

				List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument2> serviceInfo_outputParams = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument2>();
				for (int j = 0; j < context.Length("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams.Length"); j++) {
					GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument2 argument2 = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Argument2();
					argument2.DataType = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].DataType");
					argument2.Identifier = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].Identifier");
					argument2.ParaOrder = context.IntegerValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].ParaOrder");
					argument2.Direction = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].Direction");
					argument2.Name = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].Name");
					argument2.DataSpecs = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].DataSpecs");
					argument2.DataSpecsList = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].DataSpecsList");
					argument2.TmallFunctionId = context.LongValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].TmallFunctionId");

					serviceInfo_outputParams.Add(argument2);
				}
				serviceInfo.OutputParams = serviceInfo_outputParams;

				List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Tag3> serviceInfo_tags1 = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Tag3>();
				for (int j = 0; j < context.Length("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].Tags.Length"); j++) {
					GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Tag3 tag3 = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_ServiceInfo.GetPoolFunctionsByIdListForTmallGenie_Tag3();
					tag3.TagKey = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].Tags["+ j +"].TagKey");
					tag3.TagValue = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.ServiceInfos["+ i +"].Tags["+ j +"].TagValue");

					serviceInfo_tags1.Add(tag3);
				}
				serviceInfo.Tags1 = serviceInfo_tags1;

				getPoolFunctionsByIdListForTmallGenieResponse_serviceInfos.Add(serviceInfo);
			}
			getPoolFunctionsByIdListForTmallGenieResponse.ServiceInfos = getPoolFunctionsByIdListForTmallGenieResponse_serviceInfos;

			List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo> getPoolFunctionsByIdListForTmallGenieResponse_eventInfos = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo>();
			for (int i = 0; i < context.Length("GetPoolFunctionsByIdListForTmallGenie.EventInfos.Length"); i++) {
				GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo eventInfo = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo();
				eventInfo.TmallFunctionId = context.LongValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].TmallFunctionId");
				eventInfo.ThingTemplateKey = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].ThingTemplateKey");
				eventInfo.EventType = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].EventType");
				eventInfo.Name = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].Name");
				eventInfo.Identifier = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].Identifier");

				List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Argument5> eventInfo_outputData = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Argument5>();
				for (int j = 0; j < context.Length("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData.Length"); j++) {
					GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Argument5 argument5 = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Argument5();
					argument5.DataType = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].DataType");
					argument5.Identifier = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].Identifier");
					argument5.Name = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].Name");
					argument5.ParaOrder = context.IntegerValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].ParaOrder");
					argument5.DataSpecs = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].DataSpecs");
					argument5.DataSpecsList = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].DataSpecsList");
					argument5.TmallFunctionId = context.LongValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].TmallFunctionId");

					eventInfo_outputData.Add(argument5);
				}
				eventInfo.OutputData = eventInfo_outputData;

				List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Tag6> eventInfo_tags4 = new List<GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Tag6>();
				for (int j = 0; j < context.Length("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].Tags.Length"); j++) {
					GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Tag6 tag6 = new GetPoolFunctionsByIdListForTmallGenieResponse.GetPoolFunctionsByIdListForTmallGenie_EventInfo.GetPoolFunctionsByIdListForTmallGenie_Tag6();
					tag6.TagKey = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].Tags["+ j +"].TagKey");
					tag6.TagValue = context.StringValue("GetPoolFunctionsByIdListForTmallGenie.EventInfos["+ i +"].Tags["+ j +"].TagValue");

					eventInfo_tags4.Add(tag6);
				}
				eventInfo.Tags4 = eventInfo_tags4;

				getPoolFunctionsByIdListForTmallGenieResponse_eventInfos.Add(eventInfo);
			}
			getPoolFunctionsByIdListForTmallGenieResponse.EventInfos = getPoolFunctionsByIdListForTmallGenieResponse_eventInfos;
        
			return getPoolFunctionsByIdListForTmallGenieResponse;
        }
    }
}
