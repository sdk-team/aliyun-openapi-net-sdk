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
	public class GetMTSStatisResponse : AcsResponse
	{

		private string requestId;

		private List<GetMTSStatis_MTSStatisBySpec> mTSStatisBySpecList;

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

		public List<GetMTSStatis_MTSStatisBySpec> MTSStatisBySpecList
		{
			get
			{
				return mTSStatisBySpecList;
			}
			set	
			{
				mTSStatisBySpecList = value;
			}
		}

		public class GetMTSStatis_MTSStatisBySpec
		{

			private string specification;

			private List<GetMTSStatis_MTSStatisDO> mTSStatisDOList;

			public string Specification
			{
				get
				{
					return specification;
				}
				set	
				{
					specification = value;
				}
			}

			public List<GetMTSStatis_MTSStatisDO> MTSStatisDOList
			{
				get
				{
					return mTSStatisDOList;
				}
				set	
				{
					mTSStatisDOList = value;
				}
			}

			public class GetMTSStatis_MTSStatisDO
			{

				private string userId;

				private string specification;

				private long? duration;

				private string statTime;

				private string statTimeUTC;

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

				public string Specification
				{
					get
					{
						return specification;
					}
					set	
					{
						specification = value;
					}
				}

				public long? Duration
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

				public string StatTimeUTC
				{
					get
					{
						return statTimeUTC;
					}
					set	
					{
						statTimeUTC = value;
					}
				}
			}
		}
	}
}
