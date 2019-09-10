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
    public class QueryDeviceLocalLogContentResponseUnmarshaller
    {
        public static QueryDeviceLocalLogContentResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceLocalLogContentResponse queryDeviceLocalLogContentResponse = new QueryDeviceLocalLogContentResponse();

			queryDeviceLocalLogContentResponse.HttpResponse = context.HttpResponse;
			queryDeviceLocalLogContentResponse.RequestId = context.StringValue("QueryDeviceLocalLogContent.RequestId");
			queryDeviceLocalLogContentResponse.Success = context.BooleanValue("QueryDeviceLocalLogContent.Success");
			queryDeviceLocalLogContentResponse.Code = context.StringValue("QueryDeviceLocalLogContent.Code");
			queryDeviceLocalLogContentResponse.ErrorMessage = context.StringValue("QueryDeviceLocalLogContent.ErrorMessage");

			QueryDeviceLocalLogContentResponse.QueryDeviceLocalLogContent_Data data = new QueryDeviceLocalLogContentResponse.QueryDeviceLocalLogContent_Data();
			data.Count = context.LongValue("QueryDeviceLocalLogContent.Data.Count");
			data.TotalPage = context.IntegerValue("QueryDeviceLocalLogContent.Data.TotalPage");
			data.CurrentPage = context.IntegerValue("QueryDeviceLocalLogContent.Data.CurrentPage");
			data.PageSize = context.IntegerValue("QueryDeviceLocalLogContent.Data.PageSize");

			List<QueryDeviceLocalLogContentResponse.QueryDeviceLocalLogContent_Data.QueryDeviceLocalLogContent_DeviceLocalLogContentInfo> data_logs = new List<QueryDeviceLocalLogContentResponse.QueryDeviceLocalLogContent_Data.QueryDeviceLocalLogContent_DeviceLocalLogContentInfo>();
			for (int i = 0; i < context.Length("QueryDeviceLocalLogContent.Data.Logs.Length"); i++) {
				QueryDeviceLocalLogContentResponse.QueryDeviceLocalLogContent_Data.QueryDeviceLocalLogContent_DeviceLocalLogContentInfo deviceLocalLogContentInfo = new QueryDeviceLocalLogContentResponse.QueryDeviceLocalLogContent_Data.QueryDeviceLocalLogContent_DeviceLocalLogContentInfo();
				deviceLocalLogContentInfo.LogTime = context.StringValue("QueryDeviceLocalLogContent.Data.Logs["+ i +"].LogTime");
				deviceLocalLogContentInfo.Content = context.StringValue("QueryDeviceLocalLogContent.Data.Logs["+ i +"].Content");

				data_logs.Add(deviceLocalLogContentInfo);
			}
			data.Logs = data_logs;
			queryDeviceLocalLogContentResponse.Data = data;
        
			return queryDeviceLocalLogContentResponse;
        }
    }
}
