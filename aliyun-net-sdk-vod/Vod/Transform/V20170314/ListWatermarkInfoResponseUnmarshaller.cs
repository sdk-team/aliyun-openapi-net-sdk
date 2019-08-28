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
    public class ListWatermarkInfoResponseUnmarshaller
    {
        public static ListWatermarkInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ListWatermarkInfoResponse listWatermarkInfoResponse = new ListWatermarkInfoResponse();

			listWatermarkInfoResponse.HttpResponse = context.HttpResponse;
			listWatermarkInfoResponse.RequestId = context.StringValue("ListWatermarkInfo.RequestId");

			List<ListWatermarkInfoResponse.ListWatermarkInfo_WatermarkInfo> listWatermarkInfoResponse_watermarkInfos = new List<ListWatermarkInfoResponse.ListWatermarkInfo_WatermarkInfo>();
			for (int i = 0; i < context.Length("ListWatermarkInfo.WatermarkInfos.Length"); i++) {
				ListWatermarkInfoResponse.ListWatermarkInfo_WatermarkInfo watermarkInfo = new ListWatermarkInfoResponse.ListWatermarkInfo_WatermarkInfo();
				watermarkInfo.WatermarkConfig = context.StringValue("ListWatermarkInfo.WatermarkInfos["+ i +"].WatermarkConfig");
				watermarkInfo.WatermarkId = context.StringValue("ListWatermarkInfo.WatermarkInfos["+ i +"].WatermarkId");
				watermarkInfo.WatermarkType = context.StringValue("ListWatermarkInfo.WatermarkInfos["+ i +"].WatermarkType");
				watermarkInfo.WatermarkName = context.StringValue("ListWatermarkInfo.WatermarkInfos["+ i +"].WatermarkName");
				watermarkInfo.WatermarkFileUrl = context.StringValue("ListWatermarkInfo.WatermarkInfos["+ i +"].WatermarkFileUrl");

				listWatermarkInfoResponse_watermarkInfos.Add(watermarkInfo);
			}
			listWatermarkInfoResponse.WatermarkInfos = listWatermarkInfoResponse_watermarkInfos;
        
			return listWatermarkInfoResponse;
        }
    }
}
