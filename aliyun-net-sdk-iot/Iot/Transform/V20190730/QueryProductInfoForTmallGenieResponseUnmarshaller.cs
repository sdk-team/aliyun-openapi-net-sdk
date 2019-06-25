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
    public class QueryProductInfoForTmallGenieResponseUnmarshaller
    {
        public static QueryProductInfoForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			QueryProductInfoForTmallGenieResponse queryProductInfoForTmallGenieResponse = new QueryProductInfoForTmallGenieResponse();

			queryProductInfoForTmallGenieResponse.HttpResponse = context.HttpResponse;
			queryProductInfoForTmallGenieResponse.RequestId = context.StringValue("QueryProductInfoForTmallGenie.RequestId");
			queryProductInfoForTmallGenieResponse.Success = context.BooleanValue("QueryProductInfoForTmallGenie.Success");
			queryProductInfoForTmallGenieResponse.Code = context.StringValue("QueryProductInfoForTmallGenie.Code");
			queryProductInfoForTmallGenieResponse.ErrorMessage = context.StringValue("QueryProductInfoForTmallGenie.ErrorMessage");
			queryProductInfoForTmallGenieResponse.DslString = context.StringValue("QueryProductInfoForTmallGenie.DslString");
			queryProductInfoForTmallGenieResponse.Mapping = context.StringValue("QueryProductInfoForTmallGenie.Mapping");

			QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_ProductInfo productInfo = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_ProductInfo();
			productInfo.GmtCreate = context.LongValue("QueryProductInfoForTmallGenie.ProductInfo.GmtCreate");
			productInfo.DataFormat = context.IntegerValue("QueryProductInfoForTmallGenie.ProductInfo.DataFormat");
			productInfo.Description = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.Description");
			productInfo.DeviceCount = context.IntegerValue("QueryProductInfoForTmallGenie.ProductInfo.DeviceCount");
			productInfo.NodeType = context.IntegerValue("QueryProductInfoForTmallGenie.ProductInfo.NodeType");
			productInfo.ProductKey = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.ProductKey");
			productInfo.ProductName = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.ProductName");
			productInfo.ProductSecret = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.ProductSecret");
			productInfo.CategoryName = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.CategoryName");
			productInfo.CategoryKey = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.CategoryKey");
			productInfo.AliyunCommodityCode = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.AliyunCommodityCode");
			productInfo.Id2 = context.BooleanValue("QueryProductInfoForTmallGenie.ProductInfo.Id2");
			productInfo.ProtocolType = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.ProtocolType");
			productInfo.ProductStatus = context.StringValue("QueryProductInfoForTmallGenie.ProductInfo.ProductStatus");
			productInfo.Owner = context.BooleanValue("QueryProductInfoForTmallGenie.ProductInfo.Owner");
			productInfo.NetType = context.IntegerValue("QueryProductInfoForTmallGenie.ProductInfo.NetType");
			queryProductInfoForTmallGenieResponse.ProductInfo = productInfo;

			List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property> queryProductInfoForTmallGenieResponse_properties = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property>();
			for (int i = 0; i < context.Length("QueryProductInfoForTmallGenie.Properties.Length"); i++) {
				QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property property = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property();
				property.TmallFunctionId = context.LongValue("QueryProductInfoForTmallGenie.Properties["+ i +"].TmallFunctionId");
				property.ThingTemplateKey = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].ThingTemplateKey");
				property.DataType = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].DataType");
				property.RwType = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].RwType");
				property.Name = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].Name");
				property.DataSpecs = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].DataSpecs");
				property.DataSpecsList = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].DataSpecsList");

				List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property.QueryProductInfoForTmallGenie_Tag> property_tags = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property.QueryProductInfoForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("QueryProductInfoForTmallGenie.Properties["+ i +"].Tags.Length"); j++) {
					QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property.QueryProductInfoForTmallGenie_Tag tag = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Property.QueryProductInfoForTmallGenie_Tag();
					tag.TagKey = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("QueryProductInfoForTmallGenie.Properties["+ i +"].Tags["+ j +"].TagValue");

					property_tags.Add(tag);
				}
				property.Tags = property_tags;

				queryProductInfoForTmallGenieResponse_properties.Add(property);
			}
			queryProductInfoForTmallGenieResponse.Properties = queryProductInfoForTmallGenieResponse_properties;

			List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event> queryProductInfoForTmallGenieResponse_events = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event>();
			for (int i = 0; i < context.Length("QueryProductInfoForTmallGenie.Events.Length"); i++) {
				QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event _event = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event();
				_event.TmallFunctionId = context.LongValue("QueryProductInfoForTmallGenie.Events["+ i +"].TmallFunctionId");
				_event.ThingTemplateKey = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].ThingTemplateKey");
				_event.EventType = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].EventType");
				_event.Name = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].Name");
				_event.Identifier = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].Identifier");

				List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Argument> _event_outputData = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Argument>();
				for (int j = 0; j < context.Length("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData.Length"); j++) {
					QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Argument argument = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Argument();
					argument.Id = context.LongValue("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData["+ j +"].Id");
					argument.DataType = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData["+ j +"].DataType");
					argument.Identifier = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData["+ j +"].Identifier");
					argument.Name = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData["+ j +"].Name");
					argument.ParaOrder = context.LongValue("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData["+ j +"].ParaOrder");
					argument.DataSpecs = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData["+ j +"].DataSpecs");
					argument.DataSpecsList = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].OutputData["+ j +"].DataSpecsList");

					_event_outputData.Add(argument);
				}
				_event.OutputData = _event_outputData;

				List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Tag2> _event_tags1 = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Tag2>();
				for (int j = 0; j < context.Length("QueryProductInfoForTmallGenie.Events["+ i +"].Tags.Length"); j++) {
					QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Tag2 tag2 = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie__Event.QueryProductInfoForTmallGenie_Tag2();
					tag2.TagKey = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].Tags["+ j +"].TagKey");
					tag2.TagValue = context.StringValue("QueryProductInfoForTmallGenie.Events["+ i +"].Tags["+ j +"].TagValue");

					_event_tags1.Add(tag2);
				}
				_event.Tags1 = _event_tags1;

				queryProductInfoForTmallGenieResponse_events.Add(_event);
			}
			queryProductInfoForTmallGenieResponse.Events = queryProductInfoForTmallGenieResponse_events;

			List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service> queryProductInfoForTmallGenieResponse_services = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service>();
			for (int i = 0; i < context.Length("QueryProductInfoForTmallGenie.Services.Length"); i++) {
				QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service service = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service();
				service.TmallFunctionId = context.LongValue("QueryProductInfoForTmallGenie.Services["+ i +"].TmallFunctionId");
				service.ThingTemplateKey = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].ThingTemplateKey");
				service.CallType = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].CallType");
				service.Name = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].Name");
				service.Identifier = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].Identifier");

				List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument3> service_inputParams = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument3>();
				for (int j = 0; j < context.Length("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams.Length"); j++) {
					QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument3 argument3 = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument3();
					argument3.Id = context.LongValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].Id");
					argument3.DataType = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].DataType");
					argument3.Identifier = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].Identifier");
					argument3.Name = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].Name");
					argument3.ParaOrder = context.LongValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].ParaOrder");
					argument3.Direction = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].Direction");
					argument3.DataSpecs = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].DataSpecs");
					argument3.DataSpecsList = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].InputParams["+ j +"].DataSpecsList");

					service_inputParams.Add(argument3);
				}
				service.InputParams = service_inputParams;

				List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument4> service_outputParams = new List<QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument4>();
				for (int j = 0; j < context.Length("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams.Length"); j++) {
					QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument4 argument4 = new QueryProductInfoForTmallGenieResponse.QueryProductInfoForTmallGenie_Service.QueryProductInfoForTmallGenie_Argument4();
					argument4.Id = context.LongValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Id");
					argument4.DataType = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].DataType");
					argument4.Identifier = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Identifier");
					argument4.ParaOrder = context.LongValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].ParaOrder");
					argument4.Direction = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Direction");
					argument4.Name = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Name");
					argument4.DataSpecs = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].DataSpecs");
					argument4.DataSpecsList = context.StringValue("QueryProductInfoForTmallGenie.Services["+ i +"].OutputParams["+ j +"].DataSpecsList");

					service_outputParams.Add(argument4);
				}
				service.OutputParams = service_outputParams;

				queryProductInfoForTmallGenieResponse_services.Add(service);
			}
			queryProductInfoForTmallGenieResponse.Services = queryProductInfoForTmallGenieResponse_services;
        
			return queryProductInfoForTmallGenieResponse;
        }
    }
}
