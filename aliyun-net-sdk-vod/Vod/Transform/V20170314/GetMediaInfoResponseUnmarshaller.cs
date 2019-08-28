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
    public class GetMediaInfoResponseUnmarshaller
    {
        public static GetMediaInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetMediaInfoResponse getMediaInfoResponse = new GetMediaInfoResponse();

			getMediaInfoResponse.HttpResponse = context.HttpResponse;
			getMediaInfoResponse.RequestId = context.StringValue("GetMediaInfo.RequestId");

			GetMediaInfoResponse.GetMediaInfo_Video video = new GetMediaInfoResponse.GetMediaInfo_Video();
			video.VideoId = context.StringValue("GetMediaInfo.Video.VideoId");
			video.Title = context.StringValue("GetMediaInfo.Video.Title");
			video.Tags = context.StringValue("GetMediaInfo.Video.Tags");
			video.Status = context.StringValue("GetMediaInfo.Video.Status");
			video.Size = context.LongValue("GetMediaInfo.Video.Size");
			video.Privilege = context.IntegerValue("GetMediaInfo.Video.Privilege");
			video.Duration = context.LongValue("GetMediaInfo.Video.Duration");
			video.Description = context.StringValue("GetMediaInfo.Video.Description");
			video.CustomerId = context.LongValue("GetMediaInfo.Video.CustomerId");
			video.CreateTime = context.StringValue("GetMediaInfo.Video.CreateTime");
			video.ModifyTime = context.StringValue("GetMediaInfo.Video.ModifyTime");
			video.CoverURL = context.StringValue("GetMediaInfo.Video.CoverURL");
			video.CateId = context.IntegerValue("GetMediaInfo.Video.CateId");

			List<string> video_snapshots = new List<string>();
			for (int i = 0; i < context.Length("GetMediaInfo.Video.Snapshots.Length"); i++) {
				video_snapshots.Add(context.StringValue("GetMediaInfo.Video.Snapshots["+ i +"]"));
			}
			video.Snapshots = video_snapshots;
			getMediaInfoResponse.Video = video;
        
			return getMediaInfoResponse;
        }
    }
}
