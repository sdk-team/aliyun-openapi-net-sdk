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
    public class InnerEcsQueryNcInfoByInstanceIdResponseUnmarshaller
    {
        public static InnerEcsQueryNcInfoByInstanceIdResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryNcInfoByInstanceIdResponse innerEcsQueryNcInfoByInstanceIdResponse = new InnerEcsQueryNcInfoByInstanceIdResponse();

			innerEcsQueryNcInfoByInstanceIdResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryNcInfoByInstanceIdResponse.RequestId = context.StringValue("InnerEcsQueryNcInfoByInstanceId.RequestId");

			InnerEcsQueryNcInfoByInstanceIdResponse.InnerEcsQueryNcInfoByInstanceId_ErrorCode errorCode = new InnerEcsQueryNcInfoByInstanceIdResponse.InnerEcsQueryNcInfoByInstanceId_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryNcInfoByInstanceId.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryNcInfoByInstanceId.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryNcInfoByInstanceId.ErrorCode.isSuccess");
			innerEcsQueryNcInfoByInstanceIdResponse.ErrorCode = errorCode;

			InnerEcsQueryNcInfoByInstanceIdResponse.InnerEcsQueryNcInfoByInstanceId_Data data = new InnerEcsQueryNcInfoByInstanceIdResponse.InnerEcsQueryNcInfoByInstanceId_Data();
			data.NcId = context.StringValue("InnerEcsQueryNcInfoByInstanceId.Data.ncId");
			data.NcIp = context.StringValue("InnerEcsQueryNcInfoByInstanceId.Data.ncIp");
			data.RackId = context.StringValue("InnerEcsQueryNcInfoByInstanceId.Data.rackId");
			data.ZoneNo = context.StringValue("InnerEcsQueryNcInfoByInstanceId.Data.zoneNo");
			data.AvaliableDisk = context.IntegerValue("InnerEcsQueryNcInfoByInstanceId.Data.avaliableDisk");
			data.TotalDisk = context.IntegerValue("InnerEcsQueryNcInfoByInstanceId.Data.totalDisk");
			data.AvaliableCpu = context.IntegerValue("InnerEcsQueryNcInfoByInstanceId.Data.avaliableCpu");
			data.TotalCpu = context.IntegerValue("InnerEcsQueryNcInfoByInstanceId.Data.totalCpu");
			data.AvaliableMem = context.IntegerValue("InnerEcsQueryNcInfoByInstanceId.Data.avaliableMem");
			data.TotalMem = context.IntegerValue("InnerEcsQueryNcInfoByInstanceId.Data.totalMem");
			innerEcsQueryNcInfoByInstanceIdResponse.Data = data;
        
			return innerEcsQueryNcInfoByInstanceIdResponse;
        }
    }
}
