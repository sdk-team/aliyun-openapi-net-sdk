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

			ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data data = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data();

			List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo> data_propertyInfos = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo>();
			for (int i = 0; i < context.Length("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos.Length"); i++) {
				ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo propertyInfo = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo();
				propertyInfo.TmallFunctionId = context.LongValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].TmallFunctionId");
				propertyInfo.ThingTemplateKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].ThingTemplateKey");
				propertyInfo.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].DataType");
				propertyInfo.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].Name");
				propertyInfo.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].DataSpecs");
				propertyInfo.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].DataSpecsList");

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag> propertyInfo_tags = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].Tags.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag tag = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_PropertyInfo.ListThingTemplateFuncsForTmallGenie_Tag();
					tag.TagKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.PropertyInfos["+ i +"].Tags["+ j +"].TagValue");

					propertyInfo_tags.Add(tag);
				}
				propertyInfo.Tags = propertyInfo_tags;

				data_propertyInfos.Add(propertyInfo);
			}
			data.PropertyInfos = data_propertyInfos;

			List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo> data_serviceInfos = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo>();
			for (int i = 0; i < context.Length("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos.Length"); i++) {
				ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo serviceInfo = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo();
				serviceInfo.TmallFunctionId = context.LongValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].TmallFunctionId");
				serviceInfo.ThingTemplateKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].ThingTemplateKey");
				serviceInfo.CallType = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].CallType");
				serviceInfo.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].Name");
				serviceInfo.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].Identifier");

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument> serviceInfo_inputParams = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument argument = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument();
					argument.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams["+ j +"].DataType");
					argument.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams["+ j +"].Identifier");
					argument.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams["+ j +"].Name");
					argument.ParaOrder = context.LongValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams["+ j +"].ParaOrder");
					argument.Direction = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams["+ j +"].Direction");
					argument.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams["+ j +"].DataSpecs");
					argument.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].InputParams["+ j +"].DataSpecsList");

					serviceInfo_inputParams.Add(argument);
				}
				serviceInfo.InputParams = serviceInfo_inputParams;

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument1> serviceInfo_outputParams = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument1>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument1 argument1 = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_ServiceInfo.ListThingTemplateFuncsForTmallGenie_Argument1();
					argument1.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams["+ j +"].DataType");
					argument1.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams["+ j +"].Identifier");
					argument1.ParaOrder = context.LongValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams["+ j +"].ParaOrder");
					argument1.Direction = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams["+ j +"].Direction");
					argument1.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams["+ j +"].Name");
					argument1.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams["+ j +"].DataSpecs");
					argument1.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.ServiceInfos["+ i +"].OutputParams["+ j +"].DataSpecsList");

					serviceInfo_outputParams.Add(argument1);
				}
				serviceInfo.OutputParams = serviceInfo_outputParams;

				data_serviceInfos.Add(serviceInfo);
			}
			data.ServiceInfos = data_serviceInfos;

			List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo> data_eventInfos = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo>();
			for (int i = 0; i < context.Length("ListThingTemplateFuncsForTmallGenie.Data.EventInfos.Length"); i++) {
				ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo eventInfo = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo();
				eventInfo.TmallFunctionId = context.LongValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].TmallFunctionId");
				eventInfo.ThingTemplateKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].ThingTemplateKey");
				eventInfo.EventType = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].EventType");
				eventInfo.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].Name");
				eventInfo.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].Identifier");

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument3> eventInfo_outputData = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument3>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].OutputData.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument3 argument3 = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Argument3();
					argument3.DataType = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].OutputData["+ j +"].DataType");
					argument3.Identifier = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].OutputData["+ j +"].Identifier");
					argument3.Name = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].OutputData["+ j +"].Name");
					argument3.ParaOrder = context.LongValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].OutputData["+ j +"].ParaOrder");
					argument3.DataSpecs = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].OutputData["+ j +"].DataSpecs");
					argument3.DataSpecsList = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].OutputData["+ j +"].DataSpecsList");

					eventInfo_outputData.Add(argument3);
				}
				eventInfo.OutputData = eventInfo_outputData;

				List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag4> eventInfo_tags2 = new List<ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag4>();
				for (int j = 0; j < context.Length("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].Tags.Length"); j++) {
					ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag4 tag4 = new ListThingTemplateFuncsForTmallGenieResponse.ListThingTemplateFuncsForTmallGenie_Data.ListThingTemplateFuncsForTmallGenie_EventInfo.ListThingTemplateFuncsForTmallGenie_Tag4();
					tag4.TagKey = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].Tags["+ j +"].TagKey");
					tag4.TagValue = context.StringValue("ListThingTemplateFuncsForTmallGenie.Data.EventInfos["+ i +"].Tags["+ j +"].TagValue");

					eventInfo_tags2.Add(tag4);
				}
				eventInfo.Tags2 = eventInfo_tags2;

				data_eventInfos.Add(eventInfo);
			}
			data.EventInfos = data_eventInfos;
			listThingTemplateFuncsForTmallGenieResponse.Data = data;
        
			return listThingTemplateFuncsForTmallGenieResponse;
        }
    }
}
