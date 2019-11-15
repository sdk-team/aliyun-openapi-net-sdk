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
    public class InnerMonitorDataDescribeInstanceResponseUnmarshaller
    {
        public static InnerMonitorDataDescribeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			InnerMonitorDataDescribeInstanceResponse innerMonitorDataDescribeInstanceResponse = new InnerMonitorDataDescribeInstanceResponse();

			innerMonitorDataDescribeInstanceResponse.HttpResponse = context.HttpResponse;
			innerMonitorDataDescribeInstanceResponse.RequestId = context.StringValue("InnerMonitorDataDescribeInstance.RequestId");
			innerMonitorDataDescribeInstanceResponse.Count = context.IntegerValue("InnerMonitorDataDescribeInstance.count");

			InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_ErrorCode errorCode = new InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_ErrorCode();
			errorCode.Code = context.StringValue("InnerMonitorDataDescribeInstance.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerMonitorDataDescribeInstance.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerMonitorDataDescribeInstance.ErrorCode.isSuccess");
			innerMonitorDataDescribeInstanceResponse.ErrorCode = errorCode;

			List<InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_Item> innerMonitorDataDescribeInstanceResponse_data = new List<InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_Item>();
			for (int i = 0; i < context.Length("InnerMonitorDataDescribeInstance.Data.Length"); i++) {
				InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_Item item = new InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_Item();
				item.TimeStamp = context.StringValue("InnerMonitorDataDescribeInstance.Data["+ i +"].timeStamp");
				item.ResourceStatus = context.StringValue("InnerMonitorDataDescribeInstance.Data["+ i +"].resourceStatus");
				item.ResourceId = context.StringValue("InnerMonitorDataDescribeInstance.Data["+ i +"].resourceId");

				InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_Item.InnerMonitorDataDescribeInstance_Item2Value item2Value = new InnerMonitorDataDescribeInstanceResponse.InnerMonitorDataDescribeInstance_Item.InnerMonitorDataDescribeInstance_Item2Value();
				item2Value.CPU = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.CPU");
				item2Value.IntranetRX = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.IntranetRX");
				item2Value.IntranetTX = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.IntranetTX");
				item2Value.IntranetBandwidth = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.IntranetBandwidth");
				item2Value.InternetRX = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.InternetRX");
				item2Value.InternetTX = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.InternetTX");
				item2Value.InternetBandwidth = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.InternetBandwidth");
				item2Value.IOPSRead = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.IOPSRead");
				item2Value.IOPSWrite = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.IOPSWrite");
				item2Value.BPSRead = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.BPSRead");
				item2Value.BPSWrite = context.IntegerValue("InnerMonitorDataDescribeInstance.Data["+ i +"].Item2Value.BPSWrite");
				item.Item2Value = item2Value;

				innerMonitorDataDescribeInstanceResponse_data.Add(item);
			}
			innerMonitorDataDescribeInstanceResponse.Data = innerMonitorDataDescribeInstanceResponse_data;
        
			return innerMonitorDataDescribeInstanceResponse;
        }
    }
}
