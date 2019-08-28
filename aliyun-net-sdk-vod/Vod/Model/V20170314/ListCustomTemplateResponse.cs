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
	public class ListCustomTemplateResponse : AcsResponse
	{

		private string requestId;

		private List<ListCustomTemplate_Template> templates;

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

		public List<ListCustomTemplate_Template> Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
			}
		}

		public class ListCustomTemplate_Template
		{

			private string definition;

			private string condition;

			private string templateId;

			private string status;

			private string userWaterMark;

			private string narrowBand;

			private string encrypt;

			private ListCustomTemplate_Video video;

			private ListCustomTemplate_Audio audio;

			private ListCustomTemplate_Container container;

			private ListCustomTemplate_TransConfig transConfig;

			private ListCustomTemplate_MuxConfig muxConfig;

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

			public string Condition
			{
				get
				{
					return condition;
				}
				set	
				{
					condition = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
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

			public string UserWaterMark
			{
				get
				{
					return userWaterMark;
				}
				set	
				{
					userWaterMark = value;
				}
			}

			public string NarrowBand
			{
				get
				{
					return narrowBand;
				}
				set	
				{
					narrowBand = value;
				}
			}

			public string Encrypt
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

			public ListCustomTemplate_Video Video
			{
				get
				{
					return video;
				}
				set	
				{
					video = value;
				}
			}

			public ListCustomTemplate_Audio Audio
			{
				get
				{
					return audio;
				}
				set	
				{
					audio = value;
				}
			}

			public ListCustomTemplate_Container Container
			{
				get
				{
					return container;
				}
				set	
				{
					container = value;
				}
			}

			public ListCustomTemplate_TransConfig TransConfig
			{
				get
				{
					return transConfig;
				}
				set	
				{
					transConfig = value;
				}
			}

			public ListCustomTemplate_MuxConfig MuxConfig
			{
				get
				{
					return muxConfig;
				}
				set	
				{
					muxConfig = value;
				}
			}

			public class ListCustomTemplate_Video
			{

				private string codec;

				private string profile;

				private string bitrate;

				private string crf;

				private string width;

				private string height;

				private string fps;

				private string gop;

				private string preset;

				private string scanMode;

				private string pixFmt;

				private string _remove;

				private string crop;

				private string pad;

				public string Codec
				{
					get
					{
						return codec;
					}
					set	
					{
						codec = value;
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

				public string Crf
				{
					get
					{
						return crf;
					}
					set	
					{
						crf = value;
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

				public string Gop
				{
					get
					{
						return gop;
					}
					set	
					{
						gop = value;
					}
				}

				public string Preset
				{
					get
					{
						return preset;
					}
					set	
					{
						preset = value;
					}
				}

				public string ScanMode
				{
					get
					{
						return scanMode;
					}
					set	
					{
						scanMode = value;
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

				public string _Remove
				{
					get
					{
						return _remove;
					}
					set	
					{
						_remove = value;
					}
				}

				public string Crop
				{
					get
					{
						return crop;
					}
					set	
					{
						crop = value;
					}
				}

				public string Pad
				{
					get
					{
						return pad;
					}
					set	
					{
						pad = value;
					}
				}
			}

			public class ListCustomTemplate_Audio
			{

				private string codec;

				private string profile;

				private string bitrate;

				private string samplerate;

				private string channels;

				private string _remove;

				public string Codec
				{
					get
					{
						return codec;
					}
					set	
					{
						codec = value;
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

				public string Samplerate
				{
					get
					{
						return samplerate;
					}
					set	
					{
						samplerate = value;
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

				public string _Remove
				{
					get
					{
						return _remove;
					}
					set	
					{
						_remove = value;
					}
				}
			}

			public class ListCustomTemplate_Container
			{

				private string format;

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
			}

			public class ListCustomTemplate_TransConfig
			{

				private string transMode;

				private string isCheckReso;

				private string isCheckResoFail;

				private string isCheckVideoBitrate;

				private string isCheckAudioBitrate;

				private string isCheckAudioBitrateFail;

				private string isCheckVideoBitrateFail;

				public string TransMode
				{
					get
					{
						return transMode;
					}
					set	
					{
						transMode = value;
					}
				}

				public string IsCheckReso
				{
					get
					{
						return isCheckReso;
					}
					set	
					{
						isCheckReso = value;
					}
				}

				public string IsCheckResoFail
				{
					get
					{
						return isCheckResoFail;
					}
					set	
					{
						isCheckResoFail = value;
					}
				}

				public string IsCheckVideoBitrate
				{
					get
					{
						return isCheckVideoBitrate;
					}
					set	
					{
						isCheckVideoBitrate = value;
					}
				}

				public string IsCheckAudioBitrate
				{
					get
					{
						return isCheckAudioBitrate;
					}
					set	
					{
						isCheckAudioBitrate = value;
					}
				}

				public string IsCheckAudioBitrateFail
				{
					get
					{
						return isCheckAudioBitrateFail;
					}
					set	
					{
						isCheckAudioBitrateFail = value;
					}
				}

				public string IsCheckVideoBitrateFail
				{
					get
					{
						return isCheckVideoBitrateFail;
					}
					set	
					{
						isCheckVideoBitrateFail = value;
					}
				}
			}

			public class ListCustomTemplate_MuxConfig
			{

				private ListCustomTemplate_Segment segment;

				public ListCustomTemplate_Segment Segment
				{
					get
					{
						return segment;
					}
					set	
					{
						segment = value;
					}
				}

				public class ListCustomTemplate_Segment
				{

					private string duration;

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
				}
			}
		}
	}
}
