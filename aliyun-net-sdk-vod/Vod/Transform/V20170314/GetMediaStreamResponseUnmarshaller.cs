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
    public class GetMediaStreamResponseUnmarshaller
    {
        public static GetMediaStreamResponse Unmarshall(UnmarshallerContext context)
        {
			GetMediaStreamResponse getMediaStreamResponse = new GetMediaStreamResponse();

			getMediaStreamResponse.HttpResponse = context.HttpResponse;
			getMediaStreamResponse.RequestId = context.StringValue("GetMediaStream.RequestId");

			GetMediaStreamResponse.GetMediaStream_StreamInfo streamInfo = new GetMediaStreamResponse.GetMediaStream_StreamInfo();
			streamInfo.VideoId = context.StringValue("GetMediaStream.StreamInfo.VideoId");
			streamInfo.FileType = context.StringValue("GetMediaStream.StreamInfo.FileType");

			GetMediaStreamResponse.GetMediaStream_StreamInfo.GetMediaStream_AudioStream audioStream = new GetMediaStreamResponse.GetMediaStream_StreamInfo.GetMediaStream_AudioStream();
			audioStream.Index = context.StringValue("GetMediaStream.StreamInfo.AudioStream.Index");
			audioStream.CodecName = context.StringValue("GetMediaStream.StreamInfo.AudioStream.CodecName");
			audioStream.CodecLongName = context.StringValue("GetMediaStream.StreamInfo.AudioStream.CodecLongName");
			audioStream.CodecTimeBase = context.StringValue("GetMediaStream.StreamInfo.AudioStream.CodecTimeBase");
			audioStream.CodecTagString = context.StringValue("GetMediaStream.StreamInfo.AudioStream.CodecTagString");
			audioStream.CodecTag = context.StringValue("GetMediaStream.StreamInfo.AudioStream.CodecTag");
			audioStream.SampleFmt = context.StringValue("GetMediaStream.StreamInfo.AudioStream.SampleFmt");
			audioStream.SampleRate = context.StringValue("GetMediaStream.StreamInfo.AudioStream.SampleRate");
			audioStream.Channels = context.StringValue("GetMediaStream.StreamInfo.AudioStream.Channels");
			audioStream.ChannelLayout = context.StringValue("GetMediaStream.StreamInfo.AudioStream.ChannelLayout");
			audioStream.Timebase = context.StringValue("GetMediaStream.StreamInfo.AudioStream.Timebase");
			audioStream.StartTime = context.StringValue("GetMediaStream.StreamInfo.AudioStream.StartTime");
			audioStream.Duration = context.StringValue("GetMediaStream.StreamInfo.AudioStream.Duration");
			audioStream.Bitrate = context.StringValue("GetMediaStream.StreamInfo.AudioStream.Bitrate");
			audioStream.NumFrames = context.StringValue("GetMediaStream.StreamInfo.AudioStream.NumFrames");
			audioStream.Lang = context.StringValue("GetMediaStream.StreamInfo.AudioStream.Lang");
			streamInfo.AudioStream = audioStream;

			GetMediaStreamResponse.GetMediaStream_StreamInfo.GetMediaStream_VideoStream videoStream = new GetMediaStreamResponse.GetMediaStream_StreamInfo.GetMediaStream_VideoStream();
			videoStream.Index = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Index");
			videoStream.CodecName = context.StringValue("GetMediaStream.StreamInfo.VideoStream.CodecName");
			videoStream.CodecLongName = context.StringValue("GetMediaStream.StreamInfo.VideoStream.CodecLongName");
			videoStream.Profile = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Profile");
			videoStream.CodecTimeBase = context.StringValue("GetMediaStream.StreamInfo.VideoStream.CodecTimeBase");
			videoStream.CodecTagString = context.StringValue("GetMediaStream.StreamInfo.VideoStream.CodecTagString");
			videoStream.CodecTag = context.StringValue("GetMediaStream.StreamInfo.VideoStream.CodecTag");
			videoStream.Width = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Width");
			videoStream.Height = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Height");
			videoStream.HasBFrames = context.StringValue("GetMediaStream.StreamInfo.VideoStream.HasBFrames");
			videoStream.Sar = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Sar");
			videoStream.Dar = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Dar");
			videoStream.PixFmt = context.StringValue("GetMediaStream.StreamInfo.VideoStream.PixFmt");
			videoStream.Level = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Level");
			videoStream.Fps = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Fps");
			videoStream.AvgFPS = context.StringValue("GetMediaStream.StreamInfo.VideoStream.AvgFPS");
			videoStream.Timebase = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Timebase");
			videoStream.StartTime = context.StringValue("GetMediaStream.StreamInfo.VideoStream.StartTime");
			videoStream.Duration = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Duration");
			videoStream.NumFrames = context.StringValue("GetMediaStream.StreamInfo.VideoStream.NumFrames");
			videoStream.Lang = context.StringValue("GetMediaStream.StreamInfo.VideoStream.Lang");
			streamInfo.VideoStream = videoStream;

			GetMediaStreamResponse.GetMediaStream_StreamInfo.GetMediaStream_PlayInfo playInfo = new GetMediaStreamResponse.GetMediaStream_StreamInfo.GetMediaStream_PlayInfo();
			playInfo.Width = context.LongValue("GetMediaStream.StreamInfo.PlayInfo.Width");
			playInfo.Height = context.LongValue("GetMediaStream.StreamInfo.PlayInfo.Height");
			playInfo.Size = context.LongValue("GetMediaStream.StreamInfo.PlayInfo.Size");
			playInfo.PlayURL = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.PlayURL");
			playInfo.Bitrate = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Bitrate");
			playInfo.Definition = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Definition");
			playInfo.Duration = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Duration");
			playInfo.Format = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Format");
			playInfo.Fps = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Fps");
			playInfo.Encrypt = context.LongValue("GetMediaStream.StreamInfo.PlayInfo.Encrypt");
			playInfo.Plaintext = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Plaintext");
			playInfo.Complexity = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Complexity");
			playInfo.StreamType = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.StreamType");
			playInfo.Rand = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Rand");
			playInfo.JobId = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.JobId");
			playInfo.PreprocessStatus = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.PreprocessStatus");
			playInfo.WatermarkId = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.WatermarkId");
			playInfo.Status = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Status");
			playInfo.CreationTime = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.CreationTime");
			playInfo.ModificationTime = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.ModificationTime");
			playInfo.EncryptType = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.EncryptType");
			playInfo.TemplateGroupId = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.TemplateGroupId");
			playInfo.Source = context.StringValue("GetMediaStream.StreamInfo.PlayInfo.Source");
			streamInfo.PlayInfo = playInfo;
			getMediaStreamResponse.StreamInfo = streamInfo;
        
			return getMediaStreamResponse;
        }
    }
}
