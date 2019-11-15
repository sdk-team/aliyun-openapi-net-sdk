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
    public class InnerMonitorDataDescribeDiskResponseUnmarshaller
    {
        public static InnerMonitorDataDescribeDiskResponse Unmarshall(UnmarshallerContext context)
        {
			InnerMonitorDataDescribeDiskResponse innerMonitorDataDescribeDiskResponse = new InnerMonitorDataDescribeDiskResponse();

			innerMonitorDataDescribeDiskResponse.HttpResponse = context.HttpResponse;
			innerMonitorDataDescribeDiskResponse.RequestId = context.StringValue("InnerMonitorDataDescribeDisk.RequestId");
			innerMonitorDataDescribeDiskResponse.Count = context.IntegerValue("InnerMonitorDataDescribeDisk.count");

			InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_ErrorCode errorCode = new InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_ErrorCode();
			errorCode.Code = context.StringValue("InnerMonitorDataDescribeDisk.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerMonitorDataDescribeDisk.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerMonitorDataDescribeDisk.ErrorCode.isSuccess");
			innerMonitorDataDescribeDiskResponse.ErrorCode = errorCode;

			List<InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_Item> innerMonitorDataDescribeDiskResponse_data = new List<InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_Item>();
			for (int i = 0; i < context.Length("InnerMonitorDataDescribeDisk.Data.Length"); i++) {
				InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_Item item = new InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_Item();
				item.TimeStamp = context.StringValue("InnerMonitorDataDescribeDisk.Data["+ i +"].timeStamp");
				item.ResourceStatus = context.StringValue("InnerMonitorDataDescribeDisk.Data["+ i +"].resourceStatus");
				item.ResourceId = context.StringValue("InnerMonitorDataDescribeDisk.Data["+ i +"].resourceId");

				InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_Item.InnerMonitorDataDescribeDisk_Item2Value item2Value = new InnerMonitorDataDescribeDiskResponse.InnerMonitorDataDescribeDisk_Item.InnerMonitorDataDescribeDisk_Item2Value();
				item2Value.BPSRead = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.BPSRead");
				item2Value.BPSWrite = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.BPSWrite");
				item2Value.IOPSRead = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.IOPSRead");
				item2Value.IOPSWrite = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.IOPSWrite");
				item2Value.LatencyRead = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.LatencyRead");
				item2Value.LatencyWrite = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.LatencyWrite");
				item2Value.IOBlockRead = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.IOBlockRead");
				item2Value.IOBlockWrite = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.IOBlockWrite");
				item2Value.BPSTotal = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.BPSTotal");
				item2Value.IOPSTotal = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.IOPSTotal");
				item2Value.IOBlockTotal = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.IOBlockTotal");
				item2Value.ReadPercent = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.ReadPercent");
				item2Value.WritePercent = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.WritePercent");
				item2Value.LatencyTotal = context.IntegerValue("InnerMonitorDataDescribeDisk.Data["+ i +"].Item2Value.LatencyTotal");
				item.Item2Value = item2Value;

				innerMonitorDataDescribeDiskResponse_data.Add(item);
			}
			innerMonitorDataDescribeDiskResponse.Data = innerMonitorDataDescribeDiskResponse_data;
        
			return innerMonitorDataDescribeDiskResponse;
        }
    }
}
