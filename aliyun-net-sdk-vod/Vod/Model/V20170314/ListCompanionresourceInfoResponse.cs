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
	public class ListCompanionresourceInfoResponse : AcsResponse
	{

		private string requestId;

		private List<ListCompanionresourceInfo_CompanionResourceInfo> companionResourceInfos;

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

		public List<ListCompanionresourceInfo_CompanionResourceInfo> CompanionResourceInfos
		{
			get
			{
				return companionResourceInfos;
			}
			set	
			{
				companionResourceInfos = value;
			}
		}

		public class ListCompanionresourceInfo_CompanionResourceInfo
		{

			private string companionResourceId;

			private string companionResourceType;

			private string creationTime;

			private string mediaFileUrl;

			private string resourceName;

			private string resourceTags;

			private string companionResourceConfig;

			public string CompanionResourceId
			{
				get
				{
					return companionResourceId;
				}
				set	
				{
					companionResourceId = value;
				}
			}

			public string CompanionResourceType
			{
				get
				{
					return companionResourceType;
				}
				set	
				{
					companionResourceType = value;
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

			public string MediaFileUrl
			{
				get
				{
					return mediaFileUrl;
				}
				set	
				{
					mediaFileUrl = value;
				}
			}

			public string ResourceName
			{
				get
				{
					return resourceName;
				}
				set	
				{
					resourceName = value;
				}
			}

			public string ResourceTags
			{
				get
				{
					return resourceTags;
				}
				set	
				{
					resourceTags = value;
				}
			}

			public string CompanionResourceConfig
			{
				get
				{
					return companionResourceConfig;
				}
				set	
				{
					companionResourceConfig = value;
				}
			}
		}
	}
}
