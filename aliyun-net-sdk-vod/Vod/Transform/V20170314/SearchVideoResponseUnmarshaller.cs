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
    public class SearchVideoResponseUnmarshaller
    {
        public static SearchVideoResponse Unmarshall(UnmarshallerContext context)
        {
			SearchVideoResponse searchVideoResponse = new SearchVideoResponse();

			searchVideoResponse.HttpResponse = context.HttpResponse;
			searchVideoResponse.RequestId = context.StringValue("SearchVideo.RequestId");
			searchVideoResponse.ScrollToken = context.StringValue("SearchVideo.ScrollToken");
			searchVideoResponse.Total = context.IntegerValue("SearchVideo.Total");

			List<SearchVideoResponse.SearchVideo_Video> searchVideoResponse_videoList = new List<SearchVideoResponse.SearchVideo_Video>();
			for (int i = 0; i < context.Length("SearchVideo.VideoList.Length"); i++) {
				SearchVideoResponse.SearchVideo_Video video = new SearchVideoResponse.SearchVideo_Video();
				video.VideoId = context.StringValue("SearchVideo.VideoList["+ i +"].VideoId");
				video.Source = context.StringValue("SearchVideo.VideoList["+ i +"].Source");
				video.MediaType = context.StringValue("SearchVideo.VideoList["+ i +"].MediaType");
				video.Title = context.StringValue("SearchVideo.VideoList["+ i +"].Title");
				video.Tags = context.StringValue("SearchVideo.VideoList["+ i +"].Tags");
				video.Status = context.StringValue("SearchVideo.VideoList["+ i +"].Status");
				video.Size = context.LongValue("SearchVideo.VideoList["+ i +"].Size");
				video.Duration = context.FloatValue("SearchVideo.VideoList["+ i +"].Duration");
				video.Description = context.StringValue("SearchVideo.VideoList["+ i +"].Description");
				video.CustomerId = context.LongValue("SearchVideo.VideoList["+ i +"].CustomerId");
				video.CreateTime = context.StringValue("SearchVideo.VideoList["+ i +"].CreateTime");
				video.ModifyTime = context.StringValue("SearchVideo.VideoList["+ i +"].ModifyTime");
				video.ModificationTime = context.StringValue("SearchVideo.VideoList["+ i +"].ModificationTime");
				video.CreationTime = context.StringValue("SearchVideo.VideoList["+ i +"].CreationTime");
				video.CoverURL = context.StringValue("SearchVideo.VideoList["+ i +"].CoverURL");
				video.CateId = context.IntegerValue("SearchVideo.VideoList["+ i +"].CateId");
				video.CateName = context.StringValue("SearchVideo.VideoList["+ i +"].CateName");
				video.DownloadSwitch = context.StringValue("SearchVideo.VideoList["+ i +"].DownloadSwitch");
				video.PreprocessStatus = context.StringValue("SearchVideo.VideoList["+ i +"].PreprocessStatus");
				video.StorageLocation = context.StringValue("SearchVideo.VideoList["+ i +"].StorageLocation");
				video.RegionId = context.StringValue("SearchVideo.VideoList["+ i +"].RegionId");

				List<string> video_snapshots = new List<string>();
				for (int j = 0; j < context.Length("SearchVideo.VideoList["+ i +"].Snapshots.Length"); j++) {
					video_snapshots.Add(context.StringValue("SearchVideo.VideoList["+ i +"].Snapshots["+ j +"]"));
				}
				video.Snapshots = video_snapshots;

				List<string> video_spriteSnapshots = new List<string>();
				for (int j = 0; j < context.Length("SearchVideo.VideoList["+ i +"].SpriteSnapshots.Length"); j++) {
					video_spriteSnapshots.Add(context.StringValue("SearchVideo.VideoList["+ i +"].SpriteSnapshots["+ j +"]"));
				}
				video.SpriteSnapshots = video_spriteSnapshots;

				List<SearchVideoResponse.SearchVideo_Video.SearchVideo_PlayInfo> video_playInfoList = new List<SearchVideoResponse.SearchVideo_Video.SearchVideo_PlayInfo>();
				for (int j = 0; j < context.Length("SearchVideo.VideoList["+ i +"].PlayInfoList.Length"); j++) {
					SearchVideoResponse.SearchVideo_Video.SearchVideo_PlayInfo playInfo = new SearchVideoResponse.SearchVideo_Video.SearchVideo_PlayInfo();
					playInfo.Width = context.LongValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Width");
					playInfo.Height = context.LongValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Height");
					playInfo.Size = context.LongValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Size");
					playInfo.PlayURL = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].PlayURL");
					playInfo.Bitrate = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Bitrate");
					playInfo.Definition = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Definition");
					playInfo.Duration = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Duration");
					playInfo.Format = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Format");
					playInfo.Fps = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Fps");
					playInfo.Encrypt = context.LongValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Encrypt");
					playInfo.Plaintext = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Plaintext");
					playInfo.Complexity = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Complexity");
					playInfo.StreamType = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].StreamType");
					playInfo.Rand = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].Rand");
					playInfo.JobId = context.StringValue("SearchVideo.VideoList["+ i +"].PlayInfoList["+ j +"].JobId");

					video_playInfoList.Add(playInfo);
				}
				video.PlayInfoList = video_playInfoList;

				searchVideoResponse_videoList.Add(video);
			}
			searchVideoResponse.VideoList = searchVideoResponse_videoList;
        
			return searchVideoResponse;
        }
    }
}
