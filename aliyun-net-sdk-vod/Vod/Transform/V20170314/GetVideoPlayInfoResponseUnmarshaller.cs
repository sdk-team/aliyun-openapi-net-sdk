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
    public class GetVideoPlayInfoResponseUnmarshaller
    {
        public static GetVideoPlayInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetVideoPlayInfoResponse getVideoPlayInfoResponse = new GetVideoPlayInfoResponse();

			getVideoPlayInfoResponse.HttpResponse = context.HttpResponse;
			getVideoPlayInfoResponse.RequestId = context.StringValue("GetVideoPlayInfo.RequestId");

			GetVideoPlayInfoResponse.GetVideoPlayInfo_PlayInfo playInfo = new GetVideoPlayInfoResponse.GetVideoPlayInfo_PlayInfo();
			playInfo.AccessKeyId = context.StringValue("GetVideoPlayInfo.PlayInfo.AccessKeyId");
			playInfo.AccessKeySecret = context.StringValue("GetVideoPlayInfo.PlayInfo.AccessKeySecret");
			playInfo.AuthInfo = context.StringValue("GetVideoPlayInfo.PlayInfo.AuthInfo");
			playInfo.SecurityToken = context.StringValue("GetVideoPlayInfo.PlayInfo.SecurityToken");
			playInfo.Region = context.StringValue("GetVideoPlayInfo.PlayInfo.Region");
			playInfo.PlayDomain = context.StringValue("GetVideoPlayInfo.PlayInfo.PlayDomain");
			getVideoPlayInfoResponse.PlayInfo = playInfo;

			GetVideoPlayInfoResponse.GetVideoPlayInfo_VideoInfo videoInfo = new GetVideoPlayInfoResponse.GetVideoPlayInfo_VideoInfo();
			videoInfo.CoverURL = context.StringValue("GetVideoPlayInfo.VideoInfo.CoverURL");
			videoInfo.CustomerId = context.LongValue("GetVideoPlayInfo.VideoInfo.CustomerId");
			videoInfo.Duration = context.FloatValue("GetVideoPlayInfo.VideoInfo.Duration");
			videoInfo.Status = context.StringValue("GetVideoPlayInfo.VideoInfo.Status");
			videoInfo.Title = context.StringValue("GetVideoPlayInfo.VideoInfo.Title");
			videoInfo.VideoId = context.StringValue("GetVideoPlayInfo.VideoInfo.VideoId");
			getVideoPlayInfoResponse.VideoInfo = videoInfo;
        
			return getVideoPlayInfoResponse;
        }
    }
}
