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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.vod.Model.V20170314
{
	public class GetMediaStreamResponse : AcsResponse
	{

		private string requestId;

		private GetMediaStream_StreamInfo streamInfo;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetMediaStream_StreamInfo StreamInfo
		{
			get
			{
				return streamInfo;
			}
			set	
			{
				streamInfo = value;
			}
		}

		public class GetMediaStream_StreamInfo
		{

			private string videoId;

			private string fileType;

			private GetMediaStream_AudioStream audioStream;

			private GetMediaStream_VideoStream videoStream;

			private GetMediaStream_PlayInfo playInfo;

			public string VideoId
			{
				get
				{
					return videoId;
				}
				set	
				{
					videoId = value;
				}
			}

			public string FileType
			{
				get
				{
					return fileType;
				}
				set	
				{
					fileType = value;
				}
			}

			public GetMediaStream_AudioStream AudioStream
			{
				get
				{
					return audioStream;
				}
				set	
				{
					audioStream = value;
				}
			}

			public GetMediaStream_VideoStream VideoStream
			{
				get
				{
					return videoStream;
				}
				set	
				{
					videoStream = value;
				}
			}

			public GetMediaStream_PlayInfo PlayInfo
			{
				get
				{
					return playInfo;
				}
				set	
				{
					playInfo = value;
				}
			}

			public class GetMediaStream_AudioStream
			{

				private string index;

				private string codecName;

				private string codecLongName;

				private string codecTimeBase;

				private string codecTagString;

				private string codecTag;

				private string sampleFmt;

				private string sampleRate;

				private string channels;

				private string channelLayout;

				private string timebase;

				private string startTime;

				private string duration;

				private string bitrate;

				private string numFrames;

				private string lang;

				public string Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string CodecName
				{
					get
					{
						return codecName;
					}
					set	
					{
						codecName = value;
					}
				}

				public string CodecLongName
				{
					get
					{
						return codecLongName;
					}
					set	
					{
						codecLongName = value;
					}
				}

				public string CodecTimeBase
				{
					get
					{
						return codecTimeBase;
					}
					set	
					{
						codecTimeBase = value;
					}
				}

				public string CodecTagString
				{
					get
					{
						return codecTagString;
					}
					set	
					{
						codecTagString = value;
					}
				}

				public string CodecTag
				{
					get
					{
						return codecTag;
					}
					set	
					{
						codecTag = value;
					}
				}

				public string SampleFmt
				{
					get
					{
						return sampleFmt;
					}
					set	
					{
						sampleFmt = value;
					}
				}

				public string SampleRate
				{
					get
					{
						return sampleRate;
					}
					set	
					{
						sampleRate = value;
					}
				}

				public string Channels
				{
					get
					{
						return channels;
					}
					set	
					{
						channels = value;
					}
				}

				public string ChannelLayout
				{
					get
					{
						return channelLayout;
					}
					set	
					{
						channelLayout = value;
					}
				}

				public string Timebase
				{
					get
					{
						return timebase;
					}
					set	
					{
						timebase = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public string Bitrate
				{
					get
					{
						return bitrate;
					}
					set	
					{
						bitrate = value;
					}
				}

				public string NumFrames
				{
					get
					{
						return numFrames;
					}
					set	
					{
						numFrames = value;
					}
				}

				public string Lang
				{
					get
					{
						return lang;
					}
					set	
					{
						lang = value;
					}
				}
			}

			public class GetMediaStream_VideoStream
			{

				private string index;

				private string codecName;

				private string codecLongName;

				private string profile;

				private string codecTimeBase;

				private string codecTagString;

				private string codecTag;

				private string width;

				private string height;

				private string hasBFrames;

				private string sar;

				private string dar;

				private string pixFmt;

				private string level;

				private string fps;

				private string avgFPS;

				private string timebase;

				private string startTime;

				private string duration;

				private string numFrames;

				private string lang;

				public string Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string CodecName
				{
					get
					{
						return codecName;
					}
					set	
					{
						codecName = value;
					}
				}

				public string CodecLongName
				{
					get
					{
						return codecLongName;
					}
					set	
					{
						codecLongName = value;
					}
				}

				public string Profile
				{
					get
					{
						return profile;
					}
					set	
					{
						profile = value;
					}
				}

				public string CodecTimeBase
				{
					get
					{
						return codecTimeBase;
					}
					set	
					{
						codecTimeBase = value;
					}
				}

				public string CodecTagString
				{
					get
					{
						return codecTagString;
					}
					set	
					{
						codecTagString = value;
					}
				}

				public string CodecTag
				{
					get
					{
						return codecTag;
					}
					set	
					{
						codecTag = value;
					}
				}

				public string Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public string Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public string HasBFrames
				{
					get
					{
						return hasBFrames;
					}
					set	
					{
						hasBFrames = value;
					}
				}

				public string Sar
				{
					get
					{
						return sar;
					}
					set	
					{
						sar = value;
					}
				}

				public string Dar
				{
					get
					{
						return dar;
					}
					set	
					{
						dar = value;
					}
				}

				public string PixFmt
				{
					get
					{
						return pixFmt;
					}
					set	
					{
						pixFmt = value;
					}
				}

				public string Level
				{
					get
					{
						return level;
					}
					set	
					{
						level = value;
					}
				}

				public string Fps
				{
					get
					{
						return fps;
					}
					set	
					{
						fps = value;
					}
				}

				public string AvgFPS
				{
					get
					{
						return avgFPS;
					}
					set	
					{
						avgFPS = value;
					}
				}

				public string Timebase
				{
					get
					{
						return timebase;
					}
					set	
					{
						timebase = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public string NumFrames
				{
					get
					{
						return numFrames;
					}
					set	
					{
						numFrames = value;
					}
				}

				public string Lang
				{
					get
					{
						return lang;
					}
					set	
					{
						lang = value;
					}
				}
			}

			public class GetMediaStream_PlayInfo
			{

				private long? width;

				private long? height;

				private long? size;

				private string playURL;

				private string bitrate;

				private string definition;

				private string duration;

				private string format;

				private string fps;

				private long? encrypt;

				private string plaintext;

				private string complexity;

				private string streamType;

				private string rand;

				private string jobId;

				private string preprocessStatus;

				private string watermarkId;

				private string status;

				private string creationTime;

				private string modificationTime;

				private string encryptType;

				private string templateGroupId;

				private string source;

				public long? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public long? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public long? Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public string PlayURL
				{
					get
					{
						return playURL;
					}
					set	
					{
						playURL = value;
					}
				}

				public string Bitrate
				{
					get
					{
						return bitrate;
					}
					set	
					{
						bitrate = value;
					}
				}

				public string Definition
				{
					get
					{
						return definition;
					}
					set	
					{
						definition = value;
					}
				}

				public string Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
					}
				}

				public string Fps
				{
					get
					{
						return fps;
					}
					set	
					{
						fps = value;
					}
				}

				public long? Encrypt
				{
					get
					{
						return encrypt;
					}
					set	
					{
						encrypt = value;
					}
				}

				public string Plaintext
				{
					get
					{
						return plaintext;
					}
					set	
					{
						plaintext = value;
					}
				}

				public string Complexity
				{
					get
					{
						return complexity;
					}
					set	
					{
						complexity = value;
					}
				}

				public string StreamType
				{
					get
					{
						return streamType;
					}
					set	
					{
						streamType = value;
					}
				}

				public string Rand
				{
					get
					{
						return rand;
					}
					set	
					{
						rand = value;
					}
				}

				public string JobId
				{
					get
					{
						return jobId;
					}
					set	
					{
						jobId = value;
					}
				}

				public string PreprocessStatus
				{
					get
					{
						return preprocessStatus;
					}
					set	
					{
						preprocessStatus = value;
					}
				}

				public string WatermarkId
				{
					get
					{
						return watermarkId;
					}
					set	
					{
						watermarkId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string CreationTime
				{
					get
					{
						return creationTime;
					}
					set	
					{
						creationTime = value;
					}
				}

				public string ModificationTime
				{
					get
					{
						return modificationTime;
					}
					set	
					{
						modificationTime = value;
					}
				}

				public string EncryptType
				{
					get
					{
						return encryptType;
					}
					set	
					{
						encryptType = value;
					}
				}

				public string TemplateGroupId
				{
					get
					{
						return templateGroupId;
					}
					set	
					{
						templateGroupId = value;
					}
				}

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}
			}
		}
	}
}
