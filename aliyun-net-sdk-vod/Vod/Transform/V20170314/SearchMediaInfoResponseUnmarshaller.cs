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
    public class SearchMediaInfoResponseUnmarshaller
    {
        public static SearchMediaInfoResponse Unmarshall(UnmarshallerContext context)
        {
			SearchMediaInfoResponse searchMediaInfoResponse = new SearchMediaInfoResponse();

			searchMediaInfoResponse.HttpResponse = context.HttpResponse;
			searchMediaInfoResponse.RequestId = context.StringValue("SearchMediaInfo.RequestId");
			searchMediaInfoResponse.Total = context.IntegerValue("SearchMediaInfo.Total");

			List<SearchMediaInfoResponse.SearchMediaInfo_MediaInfo> searchMediaInfoResponse_videoList = new List<SearchMediaInfoResponse.SearchMediaInfo_MediaInfo>();
			for (int i = 0; i < context.Length("SearchMediaInfo.VideoList.Length"); i++) {
				SearchMediaInfoResponse.SearchMediaInfo_MediaInfo mediaInfo = new SearchMediaInfoResponse.SearchMediaInfo_MediaInfo();
				mediaInfo.VideoId = context.StringValue("SearchMediaInfo.VideoList["+ i +"].VideoId");
				mediaInfo.Title = context.StringValue("SearchMediaInfo.VideoList["+ i +"].Title");
				mediaInfo.Tags = context.StringValue("SearchMediaInfo.VideoList["+ i +"].Tags");
				mediaInfo.Status = context.StringValue("SearchMediaInfo.VideoList["+ i +"].Status");
				mediaInfo.Size = context.LongValue("SearchMediaInfo.VideoList["+ i +"].Size");
				mediaInfo.Privilege = context.IntegerValue("SearchMediaInfo.VideoList["+ i +"].Privilege");
				mediaInfo.Duration = context.LongValue("SearchMediaInfo.VideoList["+ i +"].Duration");
				mediaInfo.Description = context.StringValue("SearchMediaInfo.VideoList["+ i +"].Description");
				mediaInfo.CustomerId = context.LongValue("SearchMediaInfo.VideoList["+ i +"].CustomerId");
				mediaInfo.CreateTime = context.StringValue("SearchMediaInfo.VideoList["+ i +"].CreateTime");
				mediaInfo.ModifyTime = context.StringValue("SearchMediaInfo.VideoList["+ i +"].ModifyTime");
				mediaInfo.CoverURL = context.StringValue("SearchMediaInfo.VideoList["+ i +"].CoverURL");
				mediaInfo.CateId = context.IntegerValue("SearchMediaInfo.VideoList["+ i +"].CateId");

				List<string> mediaInfo_snapshots = new List<string>();
				for (int j = 0; j < context.Length("SearchMediaInfo.VideoList["+ i +"].Snapshots.Length"); j++) {
					mediaInfo_snapshots.Add(context.StringValue("SearchMediaInfo.VideoList["+ i +"].Snapshots["+ j +"]"));
				}
				mediaInfo.Snapshots = mediaInfo_snapshots;

				searchMediaInfoResponse_videoList.Add(mediaInfo);
			}
			searchMediaInfoResponse.VideoList = searchMediaInfoResponse_videoList;
        
			return searchMediaInfoResponse;
        }
    }
}
