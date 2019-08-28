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
	public class GetDomainListResponse : AcsResponse
	{

		private string requestId;

		private List<GetDomainList_DomainDTO> domainDTOList;

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

		public List<GetDomainList_DomainDTO> DomainDTOList
		{
			get
			{
				return domainDTOList;
			}
			set	
			{
				domainDTOList = value;
			}
		}

		public class GetDomainList_DomainDTO
		{

			private long? userId;

			private string domainName;

			private string domainType;

			private string domainCname;

			private string domainStatus;

			private string bucketName;

			private string bucketEndpoint;

			private bool? defaultPlay;

			private string sourceLocation;

			public long? UserId
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

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string DomainType
			{
				get
				{
					return domainType;
				}
				set	
				{
					domainType = value;
				}
			}

			public string DomainCname
			{
				get
				{
					return domainCname;
				}
				set	
				{
					domainCname = value;
				}
			}

			public string DomainStatus
			{
				get
				{
					return domainStatus;
				}
				set	
				{
					domainStatus = value;
				}
			}

			public string BucketName
			{
				get
				{
					return bucketName;
				}
				set	
				{
					bucketName = value;
				}
			}

			public string BucketEndpoint
			{
				get
				{
					return bucketEndpoint;
				}
				set	
				{
					bucketEndpoint = value;
				}
			}

			public bool? DefaultPlay
			{
				get
				{
					return defaultPlay;
				}
				set	
				{
					defaultPlay = value;
				}
			}

			public string SourceLocation
			{
				get
				{
					return sourceLocation;
				}
				set	
				{
					sourceLocation = value;
				}
			}
		}
	}
}
