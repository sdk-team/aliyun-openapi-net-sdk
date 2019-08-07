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
    public class DataCleanSyncDeviceResponseUnmarshaller
    {
        public static DataCleanSyncDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			DataCleanSyncDeviceResponse dataCleanSyncDeviceResponse = new DataCleanSyncDeviceResponse();

			dataCleanSyncDeviceResponse.HttpResponse = context.HttpResponse;
			dataCleanSyncDeviceResponse.RequestId = context.StringValue("DataCleanSyncDevice.RequestId");
			dataCleanSyncDeviceResponse.Success = context.BooleanValue("DataCleanSyncDevice.Success");
			dataCleanSyncDeviceResponse.ErrorMessage = context.StringValue("DataCleanSyncDevice.ErrorMessage");
			dataCleanSyncDeviceResponse.Code = context.StringValue("DataCleanSyncDevice.Code");
			dataCleanSyncDeviceResponse.IotId = context.StringValue("DataCleanSyncDevice.IotId");
			dataCleanSyncDeviceResponse.ProductKey = context.StringValue("DataCleanSyncDevice.ProductKey");
			dataCleanSyncDeviceResponse.DeviceName = context.StringValue("DataCleanSyncDevice.DeviceName");
        
			return dataCleanSyncDeviceResponse;
        }
    }
}
