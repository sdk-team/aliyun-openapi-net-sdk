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
using Aliyun.Acs.Ecs.Model.V20160314;

namespace Aliyun.Acs.Ecs.Transform.V20160314
{
    public class InnerQueryNcInfoByInstanceIdResponseUnmarshaller
    {
        public static InnerQueryNcInfoByInstanceIdResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryNcInfoByInstanceIdResponse innerQueryNcInfoByInstanceIdResponse = new InnerQueryNcInfoByInstanceIdResponse();

			innerQueryNcInfoByInstanceIdResponse.HttpResponse = context.HttpResponse;
			innerQueryNcInfoByInstanceIdResponse.RequestId = context.StringValue("InnerQueryNcInfoByInstanceId.RequestId");

			InnerQueryNcInfoByInstanceIdResponse.InnerQueryNcInfoByInstanceId_EcsNcInfo ecsNcInfo = new InnerQueryNcInfoByInstanceIdResponse.InnerQueryNcInfoByInstanceId_EcsNcInfo();
			ecsNcInfo.NcIp = context.StringValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.NcIp");
			ecsNcInfo.AvaliableDisk = context.IntegerValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.AvaliableDisk");
			ecsNcInfo.TotalCpu = context.IntegerValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.TotalCpu");
			ecsNcInfo.AvaliableMem = context.IntegerValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.AvaliableMem");
			ecsNcInfo.AvaliableCpu = context.IntegerValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.AvaliableCpu");
			ecsNcInfo.TotalDisk = context.IntegerValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.TotalDisk");
			ecsNcInfo.ZoneNo = context.StringValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.ZoneNo");
			ecsNcInfo.TotalMem = context.IntegerValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.TotalMem");
			ecsNcInfo.RackId = context.StringValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.RackId");
			ecsNcInfo.NcId = context.StringValue("InnerQueryNcInfoByInstanceId.EcsNcInfo.NcId");
			innerQueryNcInfoByInstanceIdResponse.EcsNcInfo = ecsNcInfo;
        
			return innerQueryNcInfoByInstanceIdResponse;
        }
    }
}
