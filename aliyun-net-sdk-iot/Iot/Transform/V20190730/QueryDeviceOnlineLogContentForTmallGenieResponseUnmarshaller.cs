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
    public class QueryDeviceOnlineLogContentForTmallGenieResponseUnmarshaller
    {
        public static QueryDeviceOnlineLogContentForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceOnlineLogContentForTmallGenieResponse queryDeviceOnlineLogContentForTmallGenieResponse = new QueryDeviceOnlineLogContentForTmallGenieResponse();

			queryDeviceOnlineLogContentForTmallGenieResponse.HttpResponse = context.HttpResponse;
			queryDeviceOnlineLogContentForTmallGenieResponse.RequestId = context.StringValue("QueryDeviceOnlineLogContentForTmallGenie.RequestId");
			queryDeviceOnlineLogContentForTmallGenieResponse.Success = context.BooleanValue("QueryDeviceOnlineLogContentForTmallGenie.Success");
			queryDeviceOnlineLogContentForTmallGenieResponse.Code = context.StringValue("QueryDeviceOnlineLogContentForTmallGenie.Code");
			queryDeviceOnlineLogContentForTmallGenieResponse.ErrorMessage = context.StringValue("QueryDeviceOnlineLogContentForTmallGenie.ErrorMessage");

			QueryDeviceOnlineLogContentForTmallGenieResponse.QueryDeviceOnlineLogContentForTmallGenie_Data data = new QueryDeviceOnlineLogContentForTmallGenieResponse.QueryDeviceOnlineLogContentForTmallGenie_Data();
			data.Count = context.LongValue("QueryDeviceOnlineLogContentForTmallGenie.Data.Count");
			data.TotalPage = context.IntegerValue("QueryDeviceOnlineLogContentForTmallGenie.Data.TotalPage");
			data.CurrentPage = context.IntegerValue("QueryDeviceOnlineLogContentForTmallGenie.Data.CurrentPage");
			data.PageSize = context.IntegerValue("QueryDeviceOnlineLogContentForTmallGenie.Data.PageSize");

			List<QueryDeviceOnlineLogContentForTmallGenieResponse.QueryDeviceOnlineLogContentForTmallGenie_Data.QueryDeviceOnlineLogContentForTmallGenie_DebugLogContentInfo> data_logs = new List<QueryDeviceOnlineLogContentForTmallGenieResponse.QueryDeviceOnlineLogContentForTmallGenie_Data.QueryDeviceOnlineLogContentForTmallGenie_DebugLogContentInfo>();
			for (int i = 0; i < context.Length("QueryDeviceOnlineLogContentForTmallGenie.Data.Logs.Length"); i++) {
				QueryDeviceOnlineLogContentForTmallGenieResponse.QueryDeviceOnlineLogContentForTmallGenie_Data.QueryDeviceOnlineLogContentForTmallGenie_DebugLogContentInfo debugLogContentInfo = new QueryDeviceOnlineLogContentForTmallGenieResponse.QueryDeviceOnlineLogContentForTmallGenie_Data.QueryDeviceOnlineLogContentForTmallGenie_DebugLogContentInfo();
				debugLogContentInfo.LogTime = context.StringValue("QueryDeviceOnlineLogContentForTmallGenie.Data.Logs["+ i +"].LogTime");
				debugLogContentInfo.Content = context.StringValue("QueryDeviceOnlineLogContentForTmallGenie.Data.Logs["+ i +"].Content");

				data_logs.Add(debugLogContentInfo);
			}
			data.Logs = data_logs;
			queryDeviceOnlineLogContentForTmallGenieResponse.Data = data;
        
			return queryDeviceOnlineLogContentForTmallGenieResponse;
        }
    }
}
