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
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class GetWatermarkGroupResponseUnmarshaller
    {
        public static GetWatermarkGroupResponse Unmarshall(UnmarshallerContext context)
        {
			GetWatermarkGroupResponse getWatermarkGroupResponse = new GetWatermarkGroupResponse();

			getWatermarkGroupResponse.HttpResponse = context.HttpResponse;
			getWatermarkGroupResponse.RequestId = context.StringValue("GetWatermarkGroup.RequestId");
			getWatermarkGroupResponse.Total = context.StringValue("GetWatermarkGroup.Total");

			List<GetWatermarkGroupResponse.GetWatermarkGroup_WatermarkGroup> getWatermarkGroupResponse_watermarkGroupList = new List<GetWatermarkGroupResponse.GetWatermarkGroup_WatermarkGroup>();
			for (int i = 0; i < context.Length("GetWatermarkGroup.WatermarkGroupList.Length"); i++) {
				GetWatermarkGroupResponse.GetWatermarkGroup_WatermarkGroup watermarkGroup = new GetWatermarkGroupResponse.GetWatermarkGroup_WatermarkGroup();
				watermarkGroup.WatermarkId = context.StringValue("GetWatermarkGroup.WatermarkGroupList["+ i +"].WatermarkId");
				watermarkGroup.WatermarkGroupId = context.StringValue("GetWatermarkGroup.WatermarkGroupList["+ i +"].WatermarkGroupId");
				watermarkGroup.WatermarkFileURL = context.StringValue("GetWatermarkGroup.WatermarkGroupList["+ i +"].WatermarkFileURL");
				watermarkGroup.WatermarkType = context.StringValue("GetWatermarkGroup.WatermarkGroupList["+ i +"].WatermarkType");
				watermarkGroup.WatermarkConfig = context.StringValue("GetWatermarkGroup.WatermarkGroupList["+ i +"].WatermarkConfig");

				getWatermarkGroupResponse_watermarkGroupList.Add(watermarkGroup);
			}
			getWatermarkGroupResponse.WatermarkGroupList = getWatermarkGroupResponse_watermarkGroupList;
        
			return getWatermarkGroupResponse;
        }
    }
}
