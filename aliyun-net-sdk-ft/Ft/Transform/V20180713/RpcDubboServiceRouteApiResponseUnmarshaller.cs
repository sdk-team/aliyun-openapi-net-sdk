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
using Aliyun.Acs.Ft.Model.V20180713;

namespace Aliyun.Acs.Ft.Transform.V20180713
{
    public class RpcDubboServiceRouteApiResponseUnmarshaller
    {
        public static RpcDubboServiceRouteApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RpcDubboServiceRouteApiResponse rpcDubboServiceRouteApiResponse = new RpcDubboServiceRouteApiResponse();

			rpcDubboServiceRouteApiResponse.HttpResponse = _ctx.HttpResponse;
			rpcDubboServiceRouteApiResponse.Age = _ctx.StringValue("RpcDubboServiceRouteApi.Age");
			rpcDubboServiceRouteApiResponse.CheckNumberValue = _ctx.StringValue("RpcDubboServiceRouteApi.CheckNumberValue");
			rpcDubboServiceRouteApiResponse.Code = _ctx.StringValue("RpcDubboServiceRouteApi.Code");
			rpcDubboServiceRouteApiResponse.DefaultValue = _ctx.StringValue("RpcDubboServiceRouteApi.DefaultValue");
			rpcDubboServiceRouteApiResponse.EnumValue = _ctx.StringValue("RpcDubboServiceRouteApi.EnumValue");
			rpcDubboServiceRouteApiResponse.HttpStatusCode = _ctx.StringValue("RpcDubboServiceRouteApi.HttpStatusCode");
			rpcDubboServiceRouteApiResponse.IntValue = _ctx.StringValue("RpcDubboServiceRouteApi.IntValue");
			rpcDubboServiceRouteApiResponse.JsonListStrig = _ctx.StringValue("RpcDubboServiceRouteApi.JsonListStrig");
			rpcDubboServiceRouteApiResponse.Message = _ctx.StringValue("RpcDubboServiceRouteApi.Message");
			rpcDubboServiceRouteApiResponse.Name = _ctx.StringValue("RpcDubboServiceRouteApi.Name");
			rpcDubboServiceRouteApiResponse.NullToEmptyValue = _ctx.StringValue("RpcDubboServiceRouteApi.NullToEmptyValue");
			rpcDubboServiceRouteApiResponse.NumberRange = _ctx.StringValue("RpcDubboServiceRouteApi.NumberRange");
			rpcDubboServiceRouteApiResponse.RegionId = _ctx.StringValue("RpcDubboServiceRouteApi.RegionId");
			rpcDubboServiceRouteApiResponse.RequiredValue = _ctx.StringValue("RpcDubboServiceRouteApi.RequiredValue");
			rpcDubboServiceRouteApiResponse.ResultSwitchValue = _ctx.StringValue("RpcDubboServiceRouteApi.ResultSwitchValue");
			rpcDubboServiceRouteApiResponse.StringValue = _ctx.StringValue("RpcDubboServiceRouteApi.StringValue");
			rpcDubboServiceRouteApiResponse.Success = _ctx.StringValue("RpcDubboServiceRouteApi.Success");
			rpcDubboServiceRouteApiResponse.SwitchValue = _ctx.StringValue("RpcDubboServiceRouteApi.SwitchValue");
			rpcDubboServiceRouteApiResponse.Ak_mfa_present = _ctx.StringValue("RpcDubboServiceRouteApi.ak_mfa_present");
			rpcDubboServiceRouteApiResponse.App_ip = _ctx.StringValue("RpcDubboServiceRouteApi.app_ip");
			rpcDubboServiceRouteApiResponse.CallerBid = _ctx.StringValue("RpcDubboServiceRouteApi.callerBid");
			rpcDubboServiceRouteApiResponse.CallerParentId = _ctx.StringValue("RpcDubboServiceRouteApi.callerParentId");
			rpcDubboServiceRouteApiResponse.CallerType = _ctx.StringValue("RpcDubboServiceRouteApi.callerType");
			rpcDubboServiceRouteApiResponse.CallerUid = _ctx.StringValue("RpcDubboServiceRouteApi.callerUid");
			rpcDubboServiceRouteApiResponse.Proxy_original_security_transport = _ctx.StringValue("RpcDubboServiceRouteApi.proxy_original_security_transport");
			rpcDubboServiceRouteApiResponse.Proxy_original_source_ip = _ctx.StringValue("RpcDubboServiceRouteApi.proxy_original_source_ip");
			rpcDubboServiceRouteApiResponse.Proxy_trust_transport_info = _ctx.StringValue("RpcDubboServiceRouteApi.proxy_trust_transport_info");
			rpcDubboServiceRouteApiResponse.RequestId = _ctx.StringValue("RpcDubboServiceRouteApi.requestId");
			rpcDubboServiceRouteApiResponse.ResourceOwnerId = _ctx.StringValue("RpcDubboServiceRouteApi.resourceOwnerId");
			rpcDubboServiceRouteApiResponse.Security_transport = _ctx.StringValue("RpcDubboServiceRouteApi.security_transport");

			RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_NullToEmptyStructValue nullToEmptyStructValue = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_NullToEmptyStructValue();
			nullToEmptyStructValue.NullToEmptyStructChildValue = _ctx.StringValue("RpcDubboServiceRouteApi.NullToEmptyStructValue.NullToEmptyStructChildValue");
			rpcDubboServiceRouteApiResponse.NullToEmptyStructValue = nullToEmptyStructValue;

			RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_StructValue structValue = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_StructValue();
			structValue.StructChildValue = _ctx.StringValue("RpcDubboServiceRouteApi.StructValue.StructChildValue");
			rpcDubboServiceRouteApiResponse.StructValue = structValue;

			List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem> rpcDubboServiceRouteApiResponse_arrayValue = new List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem>();
			for (int i = 0; i < _ctx.Length("RpcDubboServiceRouteApi.ArrayValue.Length"); i++) {
				RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem arrayItem = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem();
				arrayItem.ArrayChildValue = _ctx.StringValue("RpcDubboServiceRouteApi.ArrayValue["+ i +"].ArrayChildValue");

				rpcDubboServiceRouteApiResponse_arrayValue.Add(arrayItem);
			}
			rpcDubboServiceRouteApiResponse.ArrayValue = rpcDubboServiceRouteApiResponse_arrayValue;

			List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem> rpcDubboServiceRouteApiResponse_l1Array = new List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem>();
			for (int i = 0; i < _ctx.Length("RpcDubboServiceRouteApi.L1Array.Length"); i++) {
				RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem l1ArrayItem = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem();
				l1ArrayItem.L1Member1 = _ctx.StringValue("RpcDubboServiceRouteApi.L1Array["+ i +"].L1Member1");

				RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L1Struct l1Struct = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L1Struct();
				l1Struct.L1StructMember = _ctx.StringValue("RpcDubboServiceRouteApi.L1Array["+ i +"].L1Struct.L1StructMember");
				l1ArrayItem.L1Struct = l1Struct;

				List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem> l1ArrayItem_l2Array = new List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem>();
				for (int j = 0; j < _ctx.Length("RpcDubboServiceRouteApi.L1Array["+ i +"].L2Array.Length"); j++) {
					RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem l2ArrayItem = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem();
					l2ArrayItem.L2Member1 = _ctx.StringValue("RpcDubboServiceRouteApi.L1Array["+ i +"].L2Array["+ j +"].L2Member1");

					List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem.RpcDubboServiceRouteApi_L3ArrayItem> l2ArrayItem_l3Array = new List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem.RpcDubboServiceRouteApi_L3ArrayItem>();
					for (int k = 0; k < _ctx.Length("RpcDubboServiceRouteApi.L1Array["+ i +"].L2Array["+ j +"].L3Array.Length"); k++) {
						RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem.RpcDubboServiceRouteApi_L3ArrayItem l3ArrayItem = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_L1ArrayItem.RpcDubboServiceRouteApi_L2ArrayItem.RpcDubboServiceRouteApi_L3ArrayItem();
						l3ArrayItem.L3Member1 = _ctx.StringValue("RpcDubboServiceRouteApi.L1Array["+ i +"].L2Array["+ j +"].L3Array["+ k +"].L3Member1");

						l2ArrayItem_l3Array.Add(l3ArrayItem);
					}
					l2ArrayItem.L3Array = l2ArrayItem_l3Array;

					l1ArrayItem_l2Array.Add(l2ArrayItem);
				}
				l1ArrayItem.L2Array = l1ArrayItem_l2Array;

				rpcDubboServiceRouteApiResponse_l1Array.Add(l1ArrayItem);
			}
			rpcDubboServiceRouteApiResponse.L1Array = rpcDubboServiceRouteApiResponse_l1Array;

			List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem> rpcDubboServiceRouteApiResponse_nullArrayValue = new List<RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem>();
			for (int i = 0; i < _ctx.Length("RpcDubboServiceRouteApi.NullArrayValue.Length"); i++) {
				RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem arrayItem = new RpcDubboServiceRouteApiResponse.RpcDubboServiceRouteApi_ArrayItem();
				arrayItem.ArrayChildValue = _ctx.StringValue("RpcDubboServiceRouteApi.NullArrayValue["+ i +"].ArrayChildValue");

				rpcDubboServiceRouteApiResponse_nullArrayValue.Add(arrayItem);
			}
			rpcDubboServiceRouteApiResponse.NullArrayValue = rpcDubboServiceRouteApiResponse_nullArrayValue;
        
			return rpcDubboServiceRouteApiResponse;
        }
    }
}
