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
    public class ListServicePoolForTmallGenieResponseUnmarshaller
    {
        public static ListServicePoolForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			ListServicePoolForTmallGenieResponse listServicePoolForTmallGenieResponse = new ListServicePoolForTmallGenieResponse();

			listServicePoolForTmallGenieResponse.HttpResponse = context.HttpResponse;
			listServicePoolForTmallGenieResponse.RequestId = context.StringValue("ListServicePoolForTmallGenie.RequestId");
			listServicePoolForTmallGenieResponse.Success = context.BooleanValue("ListServicePoolForTmallGenie.Success");
			listServicePoolForTmallGenieResponse.Code = context.StringValue("ListServicePoolForTmallGenie.Code");
			listServicePoolForTmallGenieResponse.ErrorMessage = context.StringValue("ListServicePoolForTmallGenie.ErrorMessage");
			listServicePoolForTmallGenieResponse.PageNo = context.IntegerValue("ListServicePoolForTmallGenie.PageNo");
			listServicePoolForTmallGenieResponse.Total = context.IntegerValue("ListServicePoolForTmallGenie.Total");
			listServicePoolForTmallGenieResponse.PageSize = context.IntegerValue("ListServicePoolForTmallGenie.PageSize");

			List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service> listServicePoolForTmallGenieResponse_services = new List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service>();
			for (int i = 0; i < context.Length("ListServicePoolForTmallGenie.Services.Length"); i++) {
				ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service service = new ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service();
				service.TmallFunctionId = context.LongValue("ListServicePoolForTmallGenie.Services["+ i +"].TmallFunctionId");
				service.ThingTemplateKey = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].ThingTemplateKey");
				service.CallType = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].CallType");
				service.Name = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].Name");
				service.Identifier = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].Identifier");

				List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument> service_inputParams = new List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument>();
				for (int j = 0; j < context.Length("ListServicePoolForTmallGenie.Services["+ i +"].InputParams.Length"); j++) {
					ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument argument = new ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument();
					argument.Id = context.LongValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].Id");
					argument.DataType = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].DataType");
					argument.Identifier = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].Identifier");
					argument.Name = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].Name");
					argument.ParaOrder = context.IntegerValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].ParaOrder");
					argument.Direction = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].Direction");
					argument.DataSpecs = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].DataSpecs");
					argument.DataSpecsList = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].DataSpecsList");
					argument.TmallFunctionId = context.LongValue("ListServicePoolForTmallGenie.Services["+ i +"].InputParams["+ j +"].TmallFunctionId");

					service_inputParams.Add(argument);
				}
				service.InputParams = service_inputParams;

				List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument1> service_outputParams = new List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument1>();
				for (int j = 0; j < context.Length("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams.Length"); j++) {
					ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument1 argument1 = new ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Argument1();
					argument1.Id = context.LongValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Id");
					argument1.DataType = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].DataType");
					argument1.Identifier = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Identifier");
					argument1.ParaOrder = context.IntegerValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].ParaOrder");
					argument1.Direction = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Direction");
					argument1.Name = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].Name");
					argument1.DataSpecs = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].DataSpecs");
					argument1.DataSpecsList = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].DataSpecsList");
					argument1.TmallFunctionId = context.LongValue("ListServicePoolForTmallGenie.Services["+ i +"].OutputParams["+ j +"].TmallFunctionId");

					service_outputParams.Add(argument1);
				}
				service.OutputParams = service_outputParams;

				List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Tag> service_tags = new List<ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("ListServicePoolForTmallGenie.Services["+ i +"].Tags.Length"); j++) {
					ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Tag tag = new ListServicePoolForTmallGenieResponse.ListServicePoolForTmallGenie_Service.ListServicePoolForTmallGenie_Tag();
					tag.TagKey = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("ListServicePoolForTmallGenie.Services["+ i +"].Tags["+ j +"].TagValue");

					service_tags.Add(tag);
				}
				service.Tags = service_tags;

				listServicePoolForTmallGenieResponse_services.Add(service);
			}
			listServicePoolForTmallGenieResponse.Services = listServicePoolForTmallGenieResponse_services;
        
			return listServicePoolForTmallGenieResponse;
        }
    }
}
