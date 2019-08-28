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
    public class GetMediaInfoListResponseUnmarshaller
    {
        public static GetMediaInfoListResponse Unmarshall(UnmarshallerContext context)
        {
			GetMediaInfoListResponse getMediaInfoListResponse = new GetMediaInfoListResponse();

			getMediaInfoListResponse.HttpResponse = context.HttpResponse;
			getMediaInfoListResponse.RequestId = context.StringValue("GetMediaInfoList.RequestId");

			List<GetMediaInfoListResponse.GetMediaInfoList_MediaInfo> getMediaInfoListResponse_videoList = new List<GetMediaInfoListResponse.GetMediaInfoList_MediaInfo>();
			for (int i = 0; i < context.Length("GetMediaInfoList.VideoList.Length"); i++) {
				GetMediaInfoListResponse.GetMediaInfoList_MediaInfo mediaInfo = new GetMediaInfoListResponse.GetMediaInfoList_MediaInfo();
				mediaInfo.VideoId = context.StringValue("GetMediaInfoList.VideoList["+ i +"].VideoId");
				mediaInfo.Title = context.StringValue("GetMediaInfoList.VideoList["+ i +"].Title");
				mediaInfo.Tags = context.StringValue("GetMediaInfoList.VideoList["+ i +"].Tags");
				mediaInfo.Status = context.StringValue("GetMediaInfoList.VideoList["+ i +"].Status");
				mediaInfo.Size = context.LongValue("GetMediaInfoList.VideoList["+ i +"].Size");
				mediaInfo.Privilege = context.IntegerValue("GetMediaInfoList.VideoList["+ i +"].Privilege");
				mediaInfo.Duration = context.LongValue("GetMediaInfoList.VideoList["+ i +"].Duration");
				mediaInfo.Description = context.StringValue("GetMediaInfoList.VideoList["+ i +"].Description");
				mediaInfo.CustomerId = context.LongValue("GetMediaInfoList.VideoList["+ i +"].CustomerId");
				mediaInfo.CreateTime = context.StringValue("GetMediaInfoList.VideoList["+ i +"].CreateTime");
				mediaInfo.ModifyTime = context.StringValue("GetMediaInfoList.VideoList["+ i +"].ModifyTime");
				mediaInfo.CoverURL = context.StringValue("GetMediaInfoList.VideoList["+ i +"].CoverURL");
				mediaInfo.CateId = context.IntegerValue("GetMediaInfoList.VideoList["+ i +"].CateId");

				List<string> mediaInfo_snapshots = new List<string>();
				for (int j = 0; j < context.Length("GetMediaInfoList.VideoList["+ i +"].Snapshots.Length"); j++) {
					mediaInfo_snapshots.Add(context.StringValue("GetMediaInfoList.VideoList["+ i +"].Snapshots["+ j +"]"));
				}
				mediaInfo.Snapshots = mediaInfo_snapshots;

				getMediaInfoListResponse_videoList.Add(mediaInfo);
			}
			getMediaInfoListResponse.VideoList = getMediaInfoListResponse_videoList;
        
			return getMediaInfoListResponse;
        }
    }
}
