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
	public class GetStorageInfoResponse : AcsResponse
	{

		private string requestId;

		private string storageACL;

		private List<GetStorageInfo_DomainInfo> domainInfoList;

		private GetStorageInfo_Storage storage;

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

		public List<GetStorageInfo_DomainInfo> DomainInfoList
		{
			get
			{
				return domainInfoList;
			}
			set	
			{
				domainInfoList = value;
			}
		}

		public GetStorageInfo_Storage Storage
		{
			get
			{
				return storage;
			}
			set	
			{
				storage = value;
			}
		}

		public class GetStorageInfo_DomainInfo
		{

			private string domainName;

			private string domainStatus;

			private string domainCname;

			private bool? defaultPlay;

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
		}

		public class GetStorageInfo_Storage
		{

			private string gmtCreate;

			private string gmtModified;

			private string groupId;

			private string location;

			private int? type;

			private string region;

			private int? status;

			private int? storageUsage;

			private bool? defaultUpload;

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

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

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

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public int? Status
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

			public int? StorageUsage
			{
				get
				{
					return storageUsage;
				}
				set	
				{
					storageUsage = value;
				}
			}

			public bool? DefaultUpload
			{
				get
				{
					return defaultUpload;
				}
				set	
				{
					defaultUpload = value;
				}
			}
		}
	}
}
