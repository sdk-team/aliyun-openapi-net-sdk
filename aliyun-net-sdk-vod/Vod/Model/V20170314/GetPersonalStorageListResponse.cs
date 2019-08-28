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
	public class GetPersonalStorageListResponse : AcsResponse
	{

		private string requestId;

		private List<GetPersonalStorageList_StorageInfo> storageInfoList;

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

		public List<GetPersonalStorageList_StorageInfo> StorageInfoList
		{
			get
			{
				return storageInfoList;
			}
			set	
			{
				storageInfoList = value;
			}
		}

		public class GetPersonalStorageList_StorageInfo
		{

			private string location;

			private string gmtCreate;

			private long? ownerId;

			private string storageClass;

			private string extranetEndpoint;

			private string intranetEndpoint;

			private string storageACL;

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public string StorageClass
			{
				get
				{
					return storageClass;
				}
				set	
				{
					storageClass = value;
				}
			}

			public string ExtranetEndpoint
			{
				get
				{
					return extranetEndpoint;
				}
				set	
				{
					extranetEndpoint = value;
				}
			}

			public string IntranetEndpoint
			{
				get
				{
					return intranetEndpoint;
				}
				set	
				{
					intranetEndpoint = value;
				}
			}

			public string StorageACL
			{
				get
				{
					return storageACL;
				}
				set	
				{
					storageACL = value;
				}
			}
		}
	}
}
