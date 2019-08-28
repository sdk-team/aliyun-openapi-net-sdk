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
	public class GetPlayStatisResponse : AcsResponse
	{

		private string requestId;

		private List<GetPlayStatis_PlayStatisByPlatform> playStatisByPlatformDOs;

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

		public List<GetPlayStatis_PlayStatisByPlatform> PlayStatisByPlatformDOs
		{
			get
			{
				return playStatisByPlatformDOs;
			}
			set	
			{
				playStatisByPlatformDOs = value;
			}
		}

		public class GetPlayStatis_PlayStatisByPlatform
		{

			private string platform;

			private List<GetPlayStatis_PlayStatisDO> playStatisDOs;

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public List<GetPlayStatis_PlayStatisDO> PlayStatisDOs
			{
				get
				{
					return playStatisDOs;
				}
				set	
				{
					playStatisDOs = value;
				}
			}

			public class GetPlayStatis_PlayStatisDO
			{

				private string userId;

				private string platform;

				private long? visitView;

				private long? viewTime;

				private string statTime;

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string Platform
				{
					get
					{
						return platform;
					}
					set	
					{
						platform = value;
					}
				}

				public long? VisitView
				{
					get
					{
						return visitView;
					}
					set	
					{
						visitView = value;
					}
				}

				public long? ViewTime
				{
					get
					{
						return viewTime;
					}
					set	
					{
						viewTime = value;
					}
				}

				public string StatTime
				{
					get
					{
						return statTime;
					}
					set	
					{
						statTime = value;
					}
				}
			}
		}
	}
}
