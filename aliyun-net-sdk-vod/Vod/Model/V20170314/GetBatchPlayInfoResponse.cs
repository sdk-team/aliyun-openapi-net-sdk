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
	public class GetBatchPlayInfoResponse : AcsResponse
	{

		private string requestId;

		private List<GetBatchPlayInfo_BatchPlayInfo> batchPlayInfoList;

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

		public List<GetBatchPlayInfo_BatchPlayInfo> BatchPlayInfoList
		{
			get
			{
				return batchPlayInfoList;
			}
			set	
			{
				batchPlayInfoList = value;
			}
		}

		public class GetBatchPlayInfo_BatchPlayInfo
		{

			private string videoId;

			private string errorCode;

			private string errorMessage;

			private long? httpStatusCode;

			private List<GetBatchPlayInfo_PlayInfo> playInfoList;

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

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public long? HttpStatusCode
			{
				get
				{
					return httpStatusCode;
				}
				set	
				{
					httpStatusCode = value;
				}
			}

			public List<GetBatchPlayInfo_PlayInfo> PlayInfoList
			{
				get
				{
					return playInfoList;
				}
				set	
				{
					playInfoList = value;
				}
			}

			public class GetBatchPlayInfo_PlayInfo
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
			}
		}
	}
}
