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
    public class ListTestDeviceForTmallGenieResponseUnmarshaller
    {
        public static ListTestDeviceForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			ListTestDeviceForTmallGenieResponse listTestDeviceForTmallGenieResponse = new ListTestDeviceForTmallGenieResponse();

			listTestDeviceForTmallGenieResponse.HttpResponse = context.HttpResponse;
			listTestDeviceForTmallGenieResponse.RequestId = context.StringValue("ListTestDeviceForTmallGenie.RequestId");
			listTestDeviceForTmallGenieResponse.Success = context.BooleanValue("ListTestDeviceForTmallGenie.Success");
			listTestDeviceForTmallGenieResponse.Code = context.StringValue("ListTestDeviceForTmallGenie.Code");
			listTestDeviceForTmallGenieResponse.ErrorMessage = context.StringValue("ListTestDeviceForTmallGenie.ErrorMessage");

			List<ListTestDeviceForTmallGenieResponse.ListTestDeviceForTmallGenie_DeviceInfo> listTestDeviceForTmallGenieResponse_data = new List<ListTestDeviceForTmallGenieResponse.ListTestDeviceForTmallGenie_DeviceInfo>();
			for (int i = 0; i < context.Length("ListTestDeviceForTmallGenie.Data.Length"); i++) {
				ListTestDeviceForTmallGenieResponse.ListTestDeviceForTmallGenie_DeviceInfo deviceInfo = new ListTestDeviceForTmallGenieResponse.ListTestDeviceForTmallGenie_DeviceInfo();
				deviceInfo.IotId = context.StringValue("ListTestDeviceForTmallGenie.Data["+ i +"].IotId");
				deviceInfo.ProductKey = context.StringValue("ListTestDeviceForTmallGenie.Data["+ i +"].ProductKey");
				deviceInfo.DeviceName = context.StringValue("ListTestDeviceForTmallGenie.Data["+ i +"].DeviceName");
				deviceInfo.DeviceSecret = context.StringValue("ListTestDeviceForTmallGenie.Data["+ i +"].DeviceSecret");

				listTestDeviceForTmallGenieResponse_data.Add(deviceInfo);
			}
			listTestDeviceForTmallGenieResponse.Data = listTestDeviceForTmallGenieResponse_data;
        
			return listTestDeviceForTmallGenieResponse;
        }
    }
}
