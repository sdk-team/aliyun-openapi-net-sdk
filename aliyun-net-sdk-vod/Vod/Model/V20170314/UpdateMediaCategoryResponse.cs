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
	public class UpdateMediaCategoryResponse : AcsResponse
	{

		private string requestId;

		private UpdateMediaCategory_Media media;

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

		public UpdateMediaCategory_Media Media
		{
			get
			{
				return media;
			}
			set	
			{
				media = value;
			}
		}

		public class UpdateMediaCategory_Media
		{

			private string mediaId;

			private string title;

			private string description;

			private string coverUrl;

			private long? cateId;

			private string tags;

			private string duration;

			private string fileSize;

			private int? state;

			private string mediaWorkflowRunId;

			private string createTime;

			private string createIp;

			private string mediaWorkflowId;

			private int? publicType;

			private List<string> snapshots;

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string CoverUrl
			{
				get
				{
					return coverUrl;
				}
				set	
				{
					coverUrl = value;
				}
			}

			public long? CateId
			{
				get
				{
					return cateId;
				}
				set	
				{
					cateId = value;
				}
			}

			public string Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
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

			public string FileSize
			{
				get
				{
					return fileSize;
				}
				set	
				{
					fileSize = value;
				}
			}

			public int? State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string MediaWorkflowRunId
			{
				get
				{
					return mediaWorkflowRunId;
				}
				set	
				{
					mediaWorkflowRunId = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string CreateIp
			{
				get
				{
					return createIp;
				}
				set	
				{
					createIp = value;
				}
			}

			public string MediaWorkflowId
			{
				get
				{
					return mediaWorkflowId;
				}
				set	
				{
					mediaWorkflowId = value;
				}
			}

			public int? PublicType
			{
				get
				{
					return publicType;
				}
				set	
				{
					publicType = value;
				}
			}

			public List<string> Snapshots
			{
				get
				{
					return snapshots;
				}
				set	
				{
					snapshots = value;
				}
			}
		}
	}
}
