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
    public class GetDeviceApplyStatusForTmallGenieResponseUnmarshaller
    {
        public static GetDeviceApplyStatusForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			GetDeviceApplyStatusForTmallGenieResponse getDeviceApplyStatusForTmallGenieResponse = new GetDeviceApplyStatusForTmallGenieResponse();

			getDeviceApplyStatusForTmallGenieResponse.HttpResponse = context.HttpResponse;
			getDeviceApplyStatusForTmallGenieResponse.RequestId = context.StringValue("GetDeviceApplyStatusForTmallGenie.RequestId");
			getDeviceApplyStatusForTmallGenieResponse.Success = context.BooleanValue("GetDeviceApplyStatusForTmallGenie.Success");
			getDeviceApplyStatusForTmallGenieResponse.Code = context.StringValue("GetDeviceApplyStatusForTmallGenie.Code");
			getDeviceApplyStatusForTmallGenieResponse.ErrorMessage = context.StringValue("GetDeviceApplyStatusForTmallGenie.ErrorMessage");

			List<GetDeviceApplyStatusForTmallGenieResponse.GetDeviceApplyStatusForTmallGenie_ApplyStatus> getDeviceApplyStatusForTmallGenieResponse_data = new List<GetDeviceApplyStatusForTmallGenieResponse.GetDeviceApplyStatusForTmallGenie_ApplyStatus>();
			for (int i = 0; i < context.Length("GetDeviceApplyStatusForTmallGenie.Data.Length"); i++) {
				GetDeviceApplyStatusForTmallGenieResponse.GetDeviceApplyStatusForTmallGenie_ApplyStatus applyStatus = new GetDeviceApplyStatusForTmallGenieResponse.GetDeviceApplyStatusForTmallGenie_ApplyStatus();
				applyStatus.Status = context.StringValue("GetDeviceApplyStatusForTmallGenie.Data["+ i +"].Status");
				applyStatus.SuccessCount = context.IntegerValue("GetDeviceApplyStatusForTmallGenie.Data["+ i +"].SuccessCount");
				applyStatus.TotalCount = context.IntegerValue("GetDeviceApplyStatusForTmallGenie.Data["+ i +"].TotalCount");
				applyStatus.DownloadHref = context.StringValue("GetDeviceApplyStatusForTmallGenie.Data["+ i +"].DownloadHref");
				applyStatus.ApplyId = context.StringValue("GetDeviceApplyStatusForTmallGenie.Data["+ i +"].ApplyId");
				applyStatus.Exist = context.BooleanValue("GetDeviceApplyStatusForTmallGenie.Data["+ i +"].Exist");

				getDeviceApplyStatusForTmallGenieResponse_data.Add(applyStatus);
			}
			getDeviceApplyStatusForTmallGenieResponse.Data = getDeviceApplyStatusForTmallGenieResponse_data;
        
			return getDeviceApplyStatusForTmallGenieResponse;
        }
    }
}
