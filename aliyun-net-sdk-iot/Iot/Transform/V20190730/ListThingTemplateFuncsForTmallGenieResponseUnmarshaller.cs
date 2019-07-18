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
    public class ListThingTemplateFuncsForTmallGenieResponseUnmarshaller
    {
        public static ListThingTemplateFuncsForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			ListThingTemplateFuncsForTmallGenieResponse listThingTemplateFuncsForTmallGenieResponse = new ListThingTemplateFuncsForTmallGenieResponse();

			listThingTemplateFuncsForTmallGenieResponse.HttpResponse = context.HttpResponse;
			listThingTemplateFuncsForTmallGenieResponse.RequestId = context.StringValue("ListThingTemplateFuncsForTmallGenie.RequestId");
			listThingTemplateFuncsForTmallGenieResponse.Success = context.BooleanValue("ListThingTemplateFuncsForTmallGenie.Success");
			listThingTemplateFuncsForTmallGenieResponse.Code = context.StringValue("ListThingTemplateFuncsForTmallGenie.Code");
			listThingTemplateFuncsForTmallGenieResponse.ErrorMessage = context.StringValue("ListThingTemplateFuncsForTmallGenie.ErrorMessage");

			List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo> listThingTemplateFuncsForTmallGenieResponse_propertyInfos = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo>();
			for (int i = 0; i < context.Length("ListThingTemplateFuncsForTmallGenie.PropertyInfos.Length"); i++) {
				ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo propertyInfo = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo();
				propertyInfo.TmallFunctionId = context.LongValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].TmallFunctionId");
				propertyInfo.ThingTemplateKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].ThingTemplateKey");
				propertyInfo.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].Identifier");
				propertyInfo.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].DataType");
				propertyInfo.RwType = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].RwType");
				propertyInfo.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].Name");
				propertyInfo.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].DataSpecs");
				propertyInfo.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].DataSpecsList");
				propertyInfo.Description = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].Description");

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag> propertyInfo_tags = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].Tags.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag tag = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag();
					tag.TagKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("ListThingTemplateFuncsForTmallGenie.PropertyInfos["+ i +"].Tags["+ j +"].TagValue");

					propertyInfo_tags.Add(tag);
				}
				propertyInfo.Tags = propertyInfo_tags;

				listThingTemplateFuncsForTmallGenieResponse_propertyInfos.Add(propertyInfo);
			}
			listThingTemplateFuncsForTmallGenieResponse.PropertyInfos = listThingTemplateFuncsForTmallGenieResponse_propertyInfos;

			List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo> listThingTemplateFuncsForTmallGenieResponse_serviceInfos = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo>();
			for (int i = 0; i < context.Length("ListThingTemplateFuncsForTmallGenie.ServiceInfos.Length"); i++) {
				ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo serviceInfo = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo();
				serviceInfo.TmallFunctionId = context.LongValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].TmallFunctionId");
				serviceInfo.ThingTemplateKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].ThingTemplateKey");
				serviceInfo.CallType = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].CallType");
				serviceInfo.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].Name");
				serviceInfo.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].Identifier");
				serviceInfo.Description = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].Description");

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument> serviceInfo_inputParams = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument argument = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument();
					argument.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].DataType");
					argument.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].Identifier");
					argument.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].Name");
					argument.ParaOrder = context.IntegerValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].ParaOrder");
					argument.Direction = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].Direction");
					argument.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].DataSpecs");
					argument.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].InputParams["+ j +"].DataSpecsList");

					serviceInfo_inputParams.Add(argument);
				}
				serviceInfo.InputParams = serviceInfo_inputParams;

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument2> serviceInfo_outputParams = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument2>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument2 argument2 = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument2();
					argument2.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].DataType");
					argument2.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].Identifier");
					argument2.ParaOrder = context.IntegerValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].ParaOrder");
					argument2.Direction = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].Direction");
					argument2.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].Name");
					argument2.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].DataSpecs");
					argument2.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].OutputParams["+ j +"].DataSpecsList");

					serviceInfo_outputParams.Add(argument2);
				}
				serviceInfo.OutputParams = serviceInfo_outputParams;

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Tag3> serviceInfo_tags1 = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Tag3>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].Tags.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Tag3 tag3 = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Tag3();
					tag3.TagKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].Tags["+ j +"].TagKey");
					tag3.TagValue = context.StringValue("ListThingTemplateFuncsForTmallGenie.ServiceInfos["+ i +"].Tags["+ j +"].TagValue");

					serviceInfo_tags1.Add(tag3);
				}
				serviceInfo.Tags1 = serviceInfo_tags1;

				listThingTemplateFuncsForTmallGenieResponse_serviceInfos.Add(serviceInfo);
			}
			listThingTemplateFuncsForTmallGenieResponse.ServiceInfos = listThingTemplateFuncsForTmallGenieResponse_serviceInfos;

			List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo> listThingTemplateFuncsForTmallGenieResponse_eventInfos = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo>();
			for (int i = 0; i < context.Length("ListThingTemplateFuncsForTmallGenie.EventInfos.Length"); i++) {
				ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo eventInfo = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo();
				eventInfo.TmallFunctionId = context.LongValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].TmallFunctionId");
				eventInfo.ThingTemplateKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].ThingTemplateKey");
				eventInfo.EventType = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].EventType");
				eventInfo.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].Name");
				eventInfo.Description = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].Description");
				eventInfo.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].Identifier");

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument5> eventInfo_outputData = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument5>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].OutputData.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument5 argument5 = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument5();
					argument5.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].DataType");
					argument5.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].Identifier");
					argument5.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].Name");
					argument5.ParaOrder = context.IntegerValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].ParaOrder");
					argument5.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].DataSpecs");
					argument5.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].OutputData["+ j +"].DataSpecsList");

					eventInfo_outputData.Add(argument5);
				}
				eventInfo.OutputData = eventInfo_outputData;

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag6> eventInfo_tags4 = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag6>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].Tags.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag6 tag6 = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag6();
					tag6.TagKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].Tags["+ j +"].TagKey");
					tag6.TagValue = context.StringValue("ListThingTemplateFuncsForTmallGenie.EventInfos["+ i +"].Tags["+ j +"].TagValue");

					eventInfo_tags4.Add(tag6);
				}
				eventInfo.Tags4 = eventInfo_tags4;

				listThingTemplateFuncsForTmallGenieResponse_eventInfos.Add(eventInfo);
			}
			listThingTemplateFuncsForTmallGenieResponse.EventInfos = listThingTemplateFuncsForTmallGenieResponse_eventInfos;
        
			return listThingTemplateFuncsForTmallGenieResponse;
        }
    }
}
