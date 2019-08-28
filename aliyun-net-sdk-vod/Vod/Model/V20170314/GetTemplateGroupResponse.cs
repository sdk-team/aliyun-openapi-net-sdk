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
	public class GetTemplateGroupResponse : AcsResponse
	{

		private string requestId;

		private GetTemplateGroup_TemplateGroup templateGroup;

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

		public GetTemplateGroup_TemplateGroup TemplateGroup
		{
			get
			{
				return templateGroup;
			}
			set	
			{
				templateGroup = value;
			}
		}

		public class GetTemplateGroup_TemplateGroup
		{

			private string groupId;

			private string defaultGroup;

			private string status;

			private string groupType;

			private string name;

			private string transcodeMode;

			private string groupSymbol;

			private string isLocked;

			private List<GetTemplateGroup_Template> templates;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string DefaultGroup
			{
				get
				{
					return defaultGroup;
				}
				set	
				{
					defaultGroup = value;
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

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string TranscodeMode
			{
				get
				{
					return transcodeMode;
				}
				set	
				{
					transcodeMode = value;
				}
			}

			public string GroupSymbol
			{
				get
				{
					return groupSymbol;
				}
				set	
				{
					groupSymbol = value;
				}
			}

			public string IsLocked
			{
				get
				{
					return isLocked;
				}
				set	
				{
					isLocked = value;
				}
			}

			public List<GetTemplateGroup_Template> Templates
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

			public class GetTemplateGroup_Template
			{

				private string definition;

				private string mediaDefinition;

				private string condition;

				private string templateId;

				private string status;

				private string userWaterMark;

				private string useWaterMark;

				private string narrowBand;

				private string encrypt;

				private string isLocked;

				private string name;

				private GetTemplateGroup_Video video;

				private GetTemplateGroup_Audio audio;

				private GetTemplateGroup_Container container;

				private GetTemplateGroup_TransConfig transConfig;

				private GetTemplateGroup_MuxConfig muxConfig;

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

				public string MediaDefinition
				{
					get
					{
						return mediaDefinition;
					}
					set	
					{
						mediaDefinition = value;
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

				public string UseWaterMark
				{
					get
					{
						return useWaterMark;
					}
					set	
					{
						useWaterMark = value;
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

				public string IsLocked
				{
					get
					{
						return isLocked;
					}
					set	
					{
						isLocked = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public GetTemplateGroup_Video Video
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

				public GetTemplateGroup_Audio Audio
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

				public GetTemplateGroup_Container Container
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

				public GetTemplateGroup_TransConfig TransConfig
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

				public GetTemplateGroup_MuxConfig MuxConfig
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

				public class GetTemplateGroup_Video
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

					private string longShortMode;

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

					public string LongShortMode
					{
						get
						{
							return longShortMode;
						}
						set	
						{
							longShortMode = value;
						}
					}
				}

				public class GetTemplateGroup_Audio
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

				public class GetTemplateGroup_Container
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

				public class GetTemplateGroup_TransConfig
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

				public class GetTemplateGroup_MuxConfig
				{

					private GetTemplateGroup_Segment segment;

					public GetTemplateGroup_Segment Segment
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

					public class GetTemplateGroup_Segment
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
}
