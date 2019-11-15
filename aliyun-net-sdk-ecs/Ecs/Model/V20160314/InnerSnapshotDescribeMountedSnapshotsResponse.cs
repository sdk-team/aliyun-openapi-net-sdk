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

namespace Aliyun.Acs.Ecs.Model.V20160314
{
	public class InnerSnapshotDescribeMountedSnapshotsResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageNo;

		private int? pageSize;

		private int? totalCount;

		private List<InnerSnapshotDescribeMountedSnapshots_Item> data;

		private InnerSnapshotDescribeMountedSnapshots_ErrorCode errorCode;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<InnerSnapshotDescribeMountedSnapshots_Item> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public InnerSnapshotDescribeMountedSnapshots_ErrorCode ErrorCode
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

		public class InnerSnapshotDescribeMountedSnapshots_Item
		{

			private string device;

			private long? ecsOwnerAliUid;

			private string ecsInstanceId;

			private long? snapshotId;

			private string ecsRegionNo;

			private long? snapshotOwnerAliUid;

			private string status;

			private string mountedTime;

			public string Device
			{
				get
				{
					return device;
				}
				set	
				{
					device = value;
				}
			}

			public long? EcsOwnerAliUid
			{
				get
				{
					return ecsOwnerAliUid;
				}
				set	
				{
					ecsOwnerAliUid = value;
				}
			}

			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
				}
			}

			public long? SnapshotId
			{
				get
				{
					return snapshotId;
				}
				set	
				{
					snapshotId = value;
				}
			}

			public string EcsRegionNo
			{
				get
				{
					return ecsRegionNo;
				}
				set	
				{
					ecsRegionNo = value;
				}
			}

			public long? SnapshotOwnerAliUid
			{
				get
				{
					return snapshotOwnerAliUid;
				}
				set	
				{
					snapshotOwnerAliUid = value;
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

			public string MountedTime
			{
				get
				{
					return mountedTime;
				}
				set	
				{
					mountedTime = value;
				}
			}
		}

		public class InnerSnapshotDescribeMountedSnapshots_ErrorCode
		{

			private string code;

			private string message;

			private bool? isSuccess;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public bool? IsSuccess
			{
				get
				{
					return isSuccess;
				}
				set	
				{
					isSuccess = value;
				}
			}
		}
	}
}
