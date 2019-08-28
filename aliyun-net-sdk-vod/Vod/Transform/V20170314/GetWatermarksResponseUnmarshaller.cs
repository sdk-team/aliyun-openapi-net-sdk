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
    public class GetWatermarksResponseUnmarshaller
    {
        public static GetWatermarksResponse Unmarshall(UnmarshallerContext context)
        {
			GetWatermarksResponse getWatermarksResponse = new GetWatermarksResponse();

			getWatermarksResponse.HttpResponse = context.HttpResponse;
			getWatermarksResponse.RequestId = context.StringValue("GetWatermarks.RequestId");

			List<GetWatermarksResponse.GetWatermarks_Watermark> getWatermarksResponse_watermarks = new List<GetWatermarksResponse.GetWatermarks_Watermark>();
			for (int i = 0; i < context.Length("GetWatermarks.Watermarks.Length"); i++) {
				GetWatermarksResponse.GetWatermarks_Watermark watermark = new GetWatermarksResponse.GetWatermarks_Watermark();
				watermark.CreateTime = context.IntegerValue("GetWatermarks.Watermarks["+ i +"].CreateTime");
				watermark.HorizontalOffset = context.StringValue("GetWatermarks.Watermarks["+ i +"].HorizontalOffset");
				watermark.IsDefault = context.StringValue("GetWatermarks.Watermarks["+ i +"].IsDefault");
				watermark.Position = context.StringValue("GetWatermarks.Watermarks["+ i +"].Position");
				watermark.WatermarkId = context.StringValue("GetWatermarks.Watermarks["+ i +"].WatermarkId");
				watermark.VerticalOffset = context.StringValue("GetWatermarks.Watermarks["+ i +"].VerticalOffset");
				watermark.Width = context.StringValue("GetWatermarks.Watermarks["+ i +"].Width");
				watermark.Height = context.StringValue("GetWatermarks.Watermarks["+ i +"].Height");
				watermark.Active = context.StringValue("GetWatermarks.Watermarks["+ i +"].Active");
				watermark.Url = context.StringValue("GetWatermarks.Watermarks["+ i +"].Url");
				watermark.Name = context.StringValue("GetWatermarks.Watermarks["+ i +"].Name");
				watermark.VideoHeight = context.IntegerValue("GetWatermarks.Watermarks["+ i +"].VideoHeight");
				watermark.VideoWidth = context.IntegerValue("GetWatermarks.Watermarks["+ i +"].VideoWidth");
				watermark.ScreenMode = context.StringValue("GetWatermarks.Watermarks["+ i +"].ScreenMode");

				getWatermarksResponse_watermarks.Add(watermark);
			}
			getWatermarksResponse.Watermarks = getWatermarksResponse_watermarks;

			List<GetWatermarksResponse.GetWatermarks_WatermarkInfo> getWatermarksResponse_watermarkInfos = new List<GetWatermarksResponse.GetWatermarks_WatermarkInfo>();
			for (int i = 0; i < context.Length("GetWatermarks.WatermarkInfos.Length"); i++) {
				GetWatermarksResponse.GetWatermarks_WatermarkInfo watermarkInfo = new GetWatermarksResponse.GetWatermarks_WatermarkInfo();
				watermarkInfo.CreationTime = context.StringValue("GetWatermarks.WatermarkInfos["+ i +"].CreationTime");
				watermarkInfo.Type = context.StringValue("GetWatermarks.WatermarkInfos["+ i +"].Type");
				watermarkInfo.IsDefault = context.StringValue("GetWatermarks.WatermarkInfos["+ i +"].IsDefault");
				watermarkInfo.WatermarkId = context.StringValue("GetWatermarks.WatermarkInfos["+ i +"].WatermarkId");
				watermarkInfo.ScreenWidth = context.IntegerValue("GetWatermarks.WatermarkInfos["+ i +"].ScreenWidth");
				watermarkInfo.ScreenHeight = context.IntegerValue("GetWatermarks.WatermarkInfos["+ i +"].ScreenHeight");
				watermarkInfo.Name = context.StringValue("GetWatermarks.WatermarkInfos["+ i +"].Name");
				watermarkInfo.FileUrl = context.StringValue("GetWatermarks.WatermarkInfos["+ i +"].FileUrl");
				watermarkInfo.WatermarkConfig = context.StringValue("GetWatermarks.WatermarkInfos["+ i +"].WatermarkConfig");

				getWatermarksResponse_watermarkInfos.Add(watermarkInfo);
			}
			getWatermarksResponse.WatermarkInfos = getWatermarksResponse_watermarkInfos;
        
			return getWatermarksResponse;
        }
    }
}
