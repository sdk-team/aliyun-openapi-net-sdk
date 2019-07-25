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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class GetServiceSecurityListResponseUnmarshaller
    {
        public static GetServiceSecurityListResponse Unmarshall(UnmarshallerContext context)
        {
			GetServiceSecurityListResponse getServiceSecurityListResponse = new GetServiceSecurityListResponse();

			getServiceSecurityListResponse.HttpResponse = context.HttpResponse;
			getServiceSecurityListResponse.RequestId = context.StringValue("GetServiceSecurityList.RequestId");

			List<GetServiceSecurityListResponse.GetServiceSecurityList_ServiceSg> getServiceSecurityListResponse_serviceSgs = new List<GetServiceSecurityListResponse.GetServiceSecurityList_ServiceSg>();
			for (int i = 0; i < context.Length("GetServiceSecurityList.ServiceSgs.Length"); i++) {
				GetServiceSecurityListResponse.GetServiceSecurityList_ServiceSg serviceSg = new GetServiceSecurityListResponse.GetServiceSecurityList_ServiceSg();
				serviceSg.CreatedAt = context.StringValue("GetServiceSecurityList.ServiceSgs["+ i +"].CreatedAt");
				serviceSg.UpdateAt = context.StringValue("GetServiceSecurityList.ServiceSgs["+ i +"].UpdateAt");
				serviceSg.GroupName = context.StringValue("GetServiceSecurityList.ServiceSgs["+ i +"].GroupName");
				serviceSg.NetType = context.StringValue("GetServiceSecurityList.ServiceSgs["+ i +"].NetType");
				serviceSg.ServiceId = context.StringValue("GetServiceSecurityList.ServiceSgs["+ i +"].ServiceId");
				serviceSg.Ips = context.StringValue("GetServiceSecurityList.ServiceSgs["+ i +"].Ips");
				serviceSg.Enabled = context.StringValue("GetServiceSecurityList.ServiceSgs["+ i +"].Enabled");

				getServiceSecurityListResponse_serviceSgs.Add(serviceSg);
			}
			getServiceSecurityListResponse.ServiceSgs = getServiceSecurityListResponse_serviceSgs;
        
			return getServiceSecurityListResponse;
        }
    }
}
