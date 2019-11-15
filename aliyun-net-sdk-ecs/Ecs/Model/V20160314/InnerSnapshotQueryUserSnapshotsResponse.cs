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
	public class InnerSnapshotQueryUserSnapshotsResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageNo;

		private int? pageSize;

		private List<InnerSnapshotQueryUserSnapshots_Item> data;

		private InnerSnapshotQueryUserSnapshots_ErrorCode errorCode;

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

		public List<InnerSnapshotQueryUserSnapshots_Item> Data
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

		public InnerSnapshotQueryUserSnapshots_ErrorCode ErrorCode
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

		public class InnerSnapshotQueryUserSnapshots_Item
		{

			private string snapshotType;

			private string gmtModified;

			private string snapshotId;

			private long? aliUid;

			private string imgPc;

			private string diskType;

			private string snapshotNickname;

			private string deviceType;

			private string snapshotName;

			private string description;

			private long? id;

			private string ecsSnapshotStatus;

			private string gmtCreated;

			private string bid;

			private long? ecsId;

			private string diskId;

			private string snapshotProcess;

			private int? status;

			private int? snapshotSize;

			private string snapshotNo;

			private string quoteType;

			private long? imgId;

			private string deviceNo;

			private int? diskSize;

			private List<InnerSnapshotQueryUserSnapshots_Tag> tags;

			public string SnapshotType
			{
				get
				{
					return snapshotType;
				}
				set	
				{
					snapshotType = value;
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

			public string SnapshotId
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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string ImgPc
			{
				get
				{
					return imgPc;
				}
				set	
				{
					imgPc = value;
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

			public string SnapshotNickname
			{
				get
				{
					return snapshotNickname;
				}
				set	
				{
					snapshotNickname = value;
				}
			}

			public string DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
				}
			}

			public string SnapshotName
			{
				get
				{
					return snapshotName;
				}
				set	
				{
					snapshotName = value;
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

			public string EcsSnapshotStatus
			{
				get
				{
					return ecsSnapshotStatus;
				}
				set	
				{
					ecsSnapshotStatus = value;
				}
			}

			public string GmtCreated
			{
				get
				{
					return gmtCreated;
				}
				set	
				{
					gmtCreated = value;
				}
			}

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			public long? EcsId
			{
				get
				{
					return ecsId;
				}
				set	
				{
					ecsId = value;
				}
			}

			public string DiskId
			{
				get
				{
					return diskId;
				}
				set	
				{
					diskId = value;
				}
			}

			public string SnapshotProcess
			{
				get
				{
					return snapshotProcess;
				}
				set	
				{
					snapshotProcess = value;
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

			public int? SnapshotSize
			{
				get
				{
					return snapshotSize;
				}
				set	
				{
					snapshotSize = value;
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

			public string QuoteType
			{
				get
				{
					return quoteType;
				}
				set	
				{
					quoteType = value;
				}
			}

			public long? ImgId
			{
				get
				{
					return imgId;
				}
				set	
				{
					imgId = value;
				}
			}

			public string DeviceNo
			{
				get
				{
					return deviceNo;
				}
				set	
				{
					deviceNo = value;
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

			public List<InnerSnapshotQueryUserSnapshots_Tag> Tags
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

			public class InnerSnapshotQueryUserSnapshots_Tag
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

		public class InnerSnapshotQueryUserSnapshots_ErrorCode
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
