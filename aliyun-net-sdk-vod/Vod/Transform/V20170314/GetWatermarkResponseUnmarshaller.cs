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
    public class GetWatermarkResponseUnmarshaller
    {
        public static GetWatermarkResponse Unmarshall(UnmarshallerContext context)
        {
			GetWatermarkResponse getWatermarkResponse = new GetWatermarkResponse();

			getWatermarkResponse.HttpResponse = context.HttpResponse;
			getWatermarkResponse.RequestId = context.StringValue("GetWatermark.RequestId");

			GetWatermarkResponse.GetWatermark_Watermark watermark = new GetWatermarkResponse.GetWatermark_Watermark();
			watermark.CreateTime = context.IntegerValue("GetWatermark.Watermark.CreateTime");
			watermark.HorizontalOffset = context.StringValue("GetWatermark.Watermark.HorizontalOffset");
			watermark.IsDefault = context.StringValue("GetWatermark.Watermark.IsDefault");
			watermark.Position = context.StringValue("GetWatermark.Watermark.Position");
			watermark.WatermarkId = context.StringValue("GetWatermark.Watermark.WatermarkId");
			watermark.VerticalOffset = context.StringValue("GetWatermark.Watermark.VerticalOffset");
			watermark.Width = context.StringValue("GetWatermark.Watermark.Width");
			watermark.Height = context.StringValue("GetWatermark.Watermark.Height");
			watermark.Active = context.StringValue("GetWatermark.Watermark.Active");
			watermark.Url = context.StringValue("GetWatermark.Watermark.Url");
			watermark.Name = context.StringValue("GetWatermark.Watermark.Name");
			watermark.VideoHeight = context.IntegerValue("GetWatermark.Watermark.VideoHeight");
			watermark.VideoWidth = context.IntegerValue("GetWatermark.Watermark.VideoWidth");
			watermark.ScreenMode = context.StringValue("GetWatermark.Watermark.ScreenMode");
			getWatermarkResponse.Watermark = watermark;

			GetWatermarkResponse.GetWatermark_WatermarkInfo watermarkInfo = new GetWatermarkResponse.GetWatermark_WatermarkInfo();
			watermarkInfo.CreationTime = context.StringValue("GetWatermark.WatermarkInfo.CreationTime");
			watermarkInfo.Type = context.StringValue("GetWatermark.WatermarkInfo.Type");
			watermarkInfo.IsDefault = context.StringValue("GetWatermark.WatermarkInfo.IsDefault");
			watermarkInfo.WatermarkId = context.StringValue("GetWatermark.WatermarkInfo.WatermarkId");
			watermarkInfo.ScreenWidth = context.IntegerValue("GetWatermark.WatermarkInfo.ScreenWidth");
			watermarkInfo.ScreenHeight = context.IntegerValue("GetWatermark.WatermarkInfo.ScreenHeight");
			watermarkInfo.Name = context.StringValue("GetWatermark.WatermarkInfo.Name");
			watermarkInfo.FileUrl = context.StringValue("GetWatermark.WatermarkInfo.FileUrl");
			watermarkInfo.WatermarkConfig = context.StringValue("GetWatermark.WatermarkInfo.WatermarkConfig");
			getWatermarkResponse.WatermarkInfo = watermarkInfo;
        
			return getWatermarkResponse;
        }
    }
}
