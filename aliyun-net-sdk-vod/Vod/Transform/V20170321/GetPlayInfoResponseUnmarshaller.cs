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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetPlayInfoResponseUnmarshaller
    {
        public static GetPlayInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetPlayInfoResponse getPlayInfoResponse = new GetPlayInfoResponse();

			getPlayInfoResponse.HttpResponse = context.HttpResponse;
			getPlayInfoResponse.RequestId = context.StringValue("GetPlayInfo.RequestId");

			GetPlayInfoResponse.GetPlayInfo_VideoBase videoBase = new GetPlayInfoResponse.GetPlayInfo_VideoBase();
			videoBase.OutputType = context.StringValue("GetPlayInfo.VideoBase.OutputType");
			videoBase.CoverURL = context.StringValue("GetPlayInfo.VideoBase.CoverURL");
			videoBase.Duration = context.StringValue("GetPlayInfo.VideoBase.Duration");
			videoBase.Status = context.StringValue("GetPlayInfo.VideoBase.Status");
			videoBase.Title = context.StringValue("GetPlayInfo.VideoBase.Title");
			videoBase.VideoId = context.StringValue("GetPlayInfo.VideoBase.VideoId");
			videoBase.MediaType = context.StringValue("GetPlayInfo.VideoBase.MediaType");
			videoBase.CreationTime = context.StringValue("GetPlayInfo.VideoBase.CreationTime");
			videoBase.TranscodeMode = context.StringValue("GetPlayInfo.VideoBase.TranscodeMode");

			List<GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail> videoBase_thumbnailList = new List<GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail>();
			for (int i = 0; i < context.Length("GetPlayInfo.VideoBase.ThumbnailList.Length"); i++) {
				GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail thumbnail = new GetPlayInfoResponse.GetPlayInfo_VideoBase.GetPlayInfo_Thumbnail();
				thumbnail.URL = context.StringValue("GetPlayInfo.VideoBase.ThumbnailList["+ i +"].URL");

				videoBase_thumbnailList.Add(thumbnail);
			}
			videoBase.ThumbnailList = videoBase_thumbnailList;
			getPlayInfoResponse.VideoBase = videoBase;

			List<GetPlayInfoResponse.GetPlayInfo_PlayInfo> getPlayInfoResponse_playInfoList = new List<GetPlayInfoResponse.GetPlayInfo_PlayInfo>();
			for (int i = 0; i < context.Length("GetPlayInfo.PlayInfoList.Length"); i++) {
				GetPlayInfoResponse.GetPlayInfo_PlayInfo playInfo = new GetPlayInfoResponse.GetPlayInfo_PlayInfo();
				playInfo.Width = context.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Width");
				playInfo.Height = context.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Height");
				playInfo.Size = context.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Size");
				playInfo.PlayURL = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].PlayURL");
				playInfo.Bitrate = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Bitrate");
				playInfo.Definition = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Definition");
				playInfo.Duration = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Duration");
				playInfo.Format = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Format");
				playInfo.Fps = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Fps");
				playInfo.Encrypt = context.LongValue("GetPlayInfo.PlayInfoList["+ i +"].Encrypt");
				playInfo.Plaintext = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Plaintext");
				playInfo.Complexity = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Complexity");
				playInfo.StreamType = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].StreamType");
				playInfo.Rand = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Rand");
				playInfo.JobId = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].JobId");
				playInfo.PreprocessStatus = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].PreprocessStatus");
				playInfo.WatermarkId = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].WatermarkId");
				playInfo.Status = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Status");
				playInfo.CreationTime = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].CreationTime");
				playInfo.ModificationTime = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].ModificationTime");
				playInfo.EncryptType = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].EncryptType");
				playInfo.NarrowBandType = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].NarrowBandType");
				playInfo.Specification = context.StringValue("GetPlayInfo.PlayInfoList["+ i +"].Specification");

				getPlayInfoResponse_playInfoList.Add(playInfo);
			}
			getPlayInfoResponse.PlayInfoList = getPlayInfoResponse_playInfoList;
        
			return getPlayInfoResponse;
        }
    }
}
