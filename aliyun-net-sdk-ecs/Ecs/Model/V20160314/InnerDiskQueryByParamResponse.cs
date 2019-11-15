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
	public class InnerDiskQueryByParamResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageNo;

		private int? pageSize;

		private List<InnerDiskQueryByParam_Item> data;

		private InnerDiskQueryByParam_ErrorCode errorCode;

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

		public List<InnerDiskQueryByParam_Item> Data
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

		public InnerDiskQueryByParam_ErrorCode ErrorCode
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

		public class InnerDiskQueryByParam_Item
		{

			private string seq;

			private bool? enableAutoSnapshot;

			private bool? active;

			private int? diskSize;

			private string diskDesc;

			private string businessStatus;

			private string zoneNo;

			private string regionNo;

			private string diskCategory;

			private string snapshotNo;

			private string houyiDiskId;

			private string diskName;

			private string productCode;

			private string mountPoint;

			private bool? deleteAutoSnapshot;

			private string imageNo;

			private long? id;

			private bool? bootable;

			private bool? deleteWithInstance;

			private string diskType;

			private string ecsInstanceId;

			private string lastAttachTime;

			private string lastDetachTime;

			private string izNo;

			private bool? portable;

			private int? iopsSize;

			private string autoSnapshotPolicyId;

			private List<InnerDiskQueryByParam_Tag> tags;

			public string Seq
			{
				get
				{
					return seq;
				}
				set	
				{
					seq = value;
				}
			}

			public bool? EnableAutoSnapshot
			{
				get
				{
					return enableAutoSnapshot;
				}
				set	
				{
					enableAutoSnapshot = value;
				}
			}

			public bool? Active
			{
				get
				{
					return active;
				}
				set	
				{
					active = value;
				}
			}

			public int? DiskSize
			{
				get
				{
					return diskSize;
				}
				set	
				{
					diskSize = value;
				}
			}

			public string DiskDesc
			{
				get
				{
					return diskDesc;
				}
				set	
				{
					diskDesc = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string ZoneNo
			{
				get
				{
					return zoneNo;
				}
				set	
				{
					zoneNo = value;
				}
			}

			public string RegionNo
			{
				get
				{
					return regionNo;
				}
				set	
				{
					regionNo = value;
				}
			}

			public string DiskCategory
			{
				get
				{
					return diskCategory;
				}
				set	
				{
					diskCategory = value;
				}
			}

			public string SnapshotNo
			{
				get
				{
					return snapshotNo;
				}
				set	
				{
					snapshotNo = value;
				}
			}

			public string HouyiDiskId
			{
				get
				{
					return houyiDiskId;
				}
				set	
				{
					houyiDiskId = value;
				}
			}

			public string DiskName
			{
				get
				{
					return diskName;
				}
				set	
				{
					diskName = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string MountPoint
			{
				get
				{
					return mountPoint;
				}
				set	
				{
					mountPoint = value;
				}
			}

			public bool? DeleteAutoSnapshot
			{
				get
				{
					return deleteAutoSnapshot;
				}
				set	
				{
					deleteAutoSnapshot = value;
				}
			}

			public string ImageNo
			{
				get
				{
					return imageNo;
				}
				set	
				{
					imageNo = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public bool? Bootable
			{
				get
				{
					return bootable;
				}
				set	
				{
					bootable = value;
				}
			}

			public bool? DeleteWithInstance
			{
				get
				{
					return deleteWithInstance;
				}
				set	
				{
					deleteWithInstance = value;
				}
			}

			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
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

			public string LastAttachTime
			{
				get
				{
					return lastAttachTime;
				}
				set	
				{
					lastAttachTime = value;
				}
			}

			public string LastDetachTime
			{
				get
				{
					return lastDetachTime;
				}
				set	
				{
					lastDetachTime = value;
				}
			}

			public string IzNo
			{
				get
				{
					return izNo;
				}
				set	
				{
					izNo = value;
				}
			}

			public bool? Portable
			{
				get
				{
					return portable;
				}
				set	
				{
					portable = value;
				}
			}

			public int? IopsSize
			{
				get
				{
					return iopsSize;
				}
				set	
				{
					iopsSize = value;
				}
			}

			public string AutoSnapshotPolicyId
			{
				get
				{
					return autoSnapshotPolicyId;
				}
				set	
				{
					autoSnapshotPolicyId = value;
				}
			}

			public List<InnerDiskQueryByParam_Tag> Tags
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

			public class InnerDiskQueryByParam_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}

		public class InnerDiskQueryByParam_ErrorCode
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
