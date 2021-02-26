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
    public class RpcHsfServiceRouteMatchApiResponseUnmarshaller
    {
        public static RpcHsfServiceRouteMatchApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RpcHsfServiceRouteMatchApiResponse rpcHsfServiceRouteMatchApiResponse = new RpcHsfServiceRouteMatchApiResponse();

			rpcHsfServiceRouteMatchApiResponse.HttpResponse = _ctx.HttpResponse;
			rpcHsfServiceRouteMatchApiResponse.Age = _ctx.StringValue("RpcHsfServiceRouteMatchApi.Age");
			rpcHsfServiceRouteMatchApiResponse.CheckNumberValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.CheckNumberValue");
			rpcHsfServiceRouteMatchApiResponse.Code = _ctx.StringValue("RpcHsfServiceRouteMatchApi.Code");
			rpcHsfServiceRouteMatchApiResponse.DefaultValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.DefaultValue");
			rpcHsfServiceRouteMatchApiResponse.EnumValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.EnumValue");
			rpcHsfServiceRouteMatchApiResponse.HttpStatusCode = _ctx.StringValue("RpcHsfServiceRouteMatchApi.HttpStatusCode");
			rpcHsfServiceRouteMatchApiResponse.IntValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.IntValue");
			rpcHsfServiceRouteMatchApiResponse.JsonListStrig = _ctx.StringValue("RpcHsfServiceRouteMatchApi.JsonListStrig");
			rpcHsfServiceRouteMatchApiResponse.Message = _ctx.StringValue("RpcHsfServiceRouteMatchApi.Message");
			rpcHsfServiceRouteMatchApiResponse.Name = _ctx.StringValue("RpcHsfServiceRouteMatchApi.Name");
			rpcHsfServiceRouteMatchApiResponse.NullToEmptyValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.NullToEmptyValue");
			rpcHsfServiceRouteMatchApiResponse.NumberRange = _ctx.StringValue("RpcHsfServiceRouteMatchApi.NumberRange");
			rpcHsfServiceRouteMatchApiResponse.RegionId = _ctx.StringValue("RpcHsfServiceRouteMatchApi.RegionId");
			rpcHsfServiceRouteMatchApiResponse.RequiredValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.RequiredValue");
			rpcHsfServiceRouteMatchApiResponse.ResultSwitchValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.ResultSwitchValue");
			rpcHsfServiceRouteMatchApiResponse.StringValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.StringValue");
			rpcHsfServiceRouteMatchApiResponse.Success = _ctx.StringValue("RpcHsfServiceRouteMatchApi.Success");
			rpcHsfServiceRouteMatchApiResponse.SwitchValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.SwitchValue");
			rpcHsfServiceRouteMatchApiResponse.Ak_mfa_present = _ctx.StringValue("RpcHsfServiceRouteMatchApi.ak_mfa_present");
			rpcHsfServiceRouteMatchApiResponse.App_ip = _ctx.StringValue("RpcHsfServiceRouteMatchApi.app_ip");
			rpcHsfServiceRouteMatchApiResponse.CallerBid = _ctx.StringValue("RpcHsfServiceRouteMatchApi.callerBid");
			rpcHsfServiceRouteMatchApiResponse.CallerParentId = _ctx.StringValue("RpcHsfServiceRouteMatchApi.callerParentId");
			rpcHsfServiceRouteMatchApiResponse.CallerType = _ctx.StringValue("RpcHsfServiceRouteMatchApi.callerType");
			rpcHsfServiceRouteMatchApiResponse.CallerUid = _ctx.StringValue("RpcHsfServiceRouteMatchApi.callerUid");
			rpcHsfServiceRouteMatchApiResponse.Proxy_original_security_transport = _ctx.StringValue("RpcHsfServiceRouteMatchApi.proxy_original_security_transport");
			rpcHsfServiceRouteMatchApiResponse.Proxy_original_source_ip = _ctx.StringValue("RpcHsfServiceRouteMatchApi.proxy_original_source_ip");
			rpcHsfServiceRouteMatchApiResponse.Proxy_trust_transport_info = _ctx.StringValue("RpcHsfServiceRouteMatchApi.proxy_trust_transport_info");
			rpcHsfServiceRouteMatchApiResponse.RequestId = _ctx.StringValue("RpcHsfServiceRouteMatchApi.requestId");
			rpcHsfServiceRouteMatchApiResponse.ResourceOwnerId = _ctx.StringValue("RpcHsfServiceRouteMatchApi.resourceOwnerId");
			rpcHsfServiceRouteMatchApiResponse.Security_transport = _ctx.StringValue("RpcHsfServiceRouteMatchApi.security_transport");

			RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_NullToEmptyStructValue nullToEmptyStructValue = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_NullToEmptyStructValue();
			nullToEmptyStructValue.NullToEmptyStructChildValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.NullToEmptyStructValue.NullToEmptyStructChildValue");
			rpcHsfServiceRouteMatchApiResponse.NullToEmptyStructValue = nullToEmptyStructValue;

			RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_StructValue structValue = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_StructValue();
			structValue.StructChildValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.StructValue.StructChildValue");
			rpcHsfServiceRouteMatchApiResponse.StructValue = structValue;

			List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem> rpcHsfServiceRouteMatchApiResponse_arrayValue = new List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem>();
			for (int i = 0; i < _ctx.Length("RpcHsfServiceRouteMatchApi.ArrayValue.Length"); i++) {
				RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem arrayItem = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem();
				arrayItem.ArrayChildValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.ArrayValue["+ i +"].ArrayChildValue");

				rpcHsfServiceRouteMatchApiResponse_arrayValue.Add(arrayItem);
			}
			rpcHsfServiceRouteMatchApiResponse.ArrayValue = rpcHsfServiceRouteMatchApiResponse_arrayValue;

			List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem> rpcHsfServiceRouteMatchApiResponse_l1Array = new List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem>();
			for (int i = 0; i < _ctx.Length("RpcHsfServiceRouteMatchApi.L1Array.Length"); i++) {
				RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem l1ArrayItem = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem();
				l1ArrayItem.L1Member1 = _ctx.StringValue("RpcHsfServiceRouteMatchApi.L1Array["+ i +"].L1Member1");

				RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L1Struct l1Struct = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L1Struct();
				l1Struct.L1StructMember = _ctx.StringValue("RpcHsfServiceRouteMatchApi.L1Array["+ i +"].L1Struct.L1StructMember");
				l1ArrayItem.L1Struct = l1Struct;

				List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem> l1ArrayItem_l2Array = new List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem>();
				for (int j = 0; j < _ctx.Length("RpcHsfServiceRouteMatchApi.L1Array["+ i +"].L2Array.Length"); j++) {
					RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem l2ArrayItem = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem();
					l2ArrayItem.L2Member1 = _ctx.StringValue("RpcHsfServiceRouteMatchApi.L1Array["+ i +"].L2Array["+ j +"].L2Member1");

					List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem.RpcHsfServiceRouteMatchApi_L3ArrayItem> l2ArrayItem_l3Array = new List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem.RpcHsfServiceRouteMatchApi_L3ArrayItem>();
					for (int k = 0; k < _ctx.Length("RpcHsfServiceRouteMatchApi.L1Array["+ i +"].L2Array["+ j +"].L3Array.Length"); k++) {
						RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem.RpcHsfServiceRouteMatchApi_L3ArrayItem l3ArrayItem = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_L1ArrayItem.RpcHsfServiceRouteMatchApi_L2ArrayItem.RpcHsfServiceRouteMatchApi_L3ArrayItem();
						l3ArrayItem.L3Member1 = _ctx.StringValue("RpcHsfServiceRouteMatchApi.L1Array["+ i +"].L2Array["+ j +"].L3Array["+ k +"].L3Member1");

						l2ArrayItem_l3Array.Add(l3ArrayItem);
					}
					l2ArrayItem.L3Array = l2ArrayItem_l3Array;

					l1ArrayItem_l2Array.Add(l2ArrayItem);
				}
				l1ArrayItem.L2Array = l1ArrayItem_l2Array;

				rpcHsfServiceRouteMatchApiResponse_l1Array.Add(l1ArrayItem);
			}
			rpcHsfServiceRouteMatchApiResponse.L1Array = rpcHsfServiceRouteMatchApiResponse_l1Array;

			List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem> rpcHsfServiceRouteMatchApiResponse_nullArrayValue = new List<RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem>();
			for (int i = 0; i < _ctx.Length("RpcHsfServiceRouteMatchApi.NullArrayValue.Length"); i++) {
				RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem arrayItem = new RpcHsfServiceRouteMatchApiResponse.RpcHsfServiceRouteMatchApi_ArrayItem();
				arrayItem.ArrayChildValue = _ctx.StringValue("RpcHsfServiceRouteMatchApi.NullArrayValue["+ i +"].ArrayChildValue");

				rpcHsfServiceRouteMatchApiResponse_nullArrayValue.Add(arrayItem);
			}
			rpcHsfServiceRouteMatchApiResponse.NullArrayValue = rpcHsfServiceRouteMatchApiResponse_nullArrayValue;
        
			return rpcHsfServiceRouteMatchApiResponse;
        }
    }
}
