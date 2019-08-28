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
    public class GetVideoPlayInfoForCloudResponseUnmarshaller
    {
        public static GetVideoPlayInfoForCloudResponse Unmarshall(UnmarshallerContext context)
        {
			GetVideoPlayInfoForCloudResponse getVideoPlayInfoForCloudResponse = new GetVideoPlayInfoForCloudResponse();

			getVideoPlayInfoForCloudResponse.HttpResponse = context.HttpResponse;
			getVideoPlayInfoForCloudResponse.RequestId = context.StringValue("GetVideoPlayInfoForCloud.RequestId");

			GetVideoPlayInfoForCloudResponse.GetVideoPlayInfoForCloud_PlayInfo playInfo = new GetVideoPlayInfoForCloudResponse.GetVideoPlayInfoForCloud_PlayInfo();
			playInfo.AccessKeyId = context.StringValue("GetVideoPlayInfoForCloud.PlayInfo.AccessKeyId");
			playInfo.AccessKeySecret = context.StringValue("GetVideoPlayInfoForCloud.PlayInfo.AccessKeySecret");
			playInfo.AuthInfo = context.StringValue("GetVideoPlayInfoForCloud.PlayInfo.AuthInfo");
			playInfo.SecurityToken = context.StringValue("GetVideoPlayInfoForCloud.PlayInfo.SecurityToken");
			playInfo.Region = context.StringValue("GetVideoPlayInfoForCloud.PlayInfo.Region");
			playInfo.PlayDomain = context.StringValue("GetVideoPlayInfoForCloud.PlayInfo.PlayDomain");
			getVideoPlayInfoForCloudResponse.PlayInfo = playInfo;

			GetVideoPlayInfoForCloudResponse.GetVideoPlayInfoForCloud_VideoInfo videoInfo = new GetVideoPlayInfoForCloudResponse.GetVideoPlayInfoForCloud_VideoInfo();
			videoInfo.CoverURL = context.StringValue("GetVideoPlayInfoForCloud.VideoInfo.CoverURL");
			videoInfo.CustomerId = context.LongValue("GetVideoPlayInfoForCloud.VideoInfo.CustomerId");
			videoInfo.Duration = context.FloatValue("GetVideoPlayInfoForCloud.VideoInfo.Duration");
			videoInfo.Status = context.StringValue("GetVideoPlayInfoForCloud.VideoInfo.Status");
			videoInfo.Title = context.StringValue("GetVideoPlayInfoForCloud.VideoInfo.Title");
			videoInfo.VideoId = context.StringValue("GetVideoPlayInfoForCloud.VideoInfo.VideoId");
			getVideoPlayInfoForCloudResponse.VideoInfo = videoInfo;
        
			return getVideoPlayInfoForCloudResponse;
        }
    }
}
