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
	public class InnerImageQueryUserImagesResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageNo;

		private int? pageSize;

		private List<InnerImageQueryUserImages_Item> data;

		private InnerImageQueryUserImages_ErrorCode errorCode;

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

		public List<InnerImageQueryUserImages_Item> Data
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

		public InnerImageQueryUserImages_ErrorCode ErrorCode
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

		public class InnerImageQueryUserImages_Item
		{

			private string kind;

			private string version;

			private bool? windowsOS;

			private long? aliUid;

			private string type;

			private string gmtRelease;

			private int? minMemory;

			private long? osTypeId;

			private int? maxCpu;

			private int? minCpu;

			private string remark;

			private string gmtModified;

			private string imageNo;

			private string bid;

			private int? osBit;

			private string gmtCreated;

			private long? id;

			private string osMemo;

			private int? imageSize;

			private string isPublic;

			private string regionNo;

			private int? maxMemory;

			private string snapshotNo;

			private string status;

			private string imageName;

			private string platform;

			private string osName;

			public string Kind
			{
				get
				{
					return kind;
				}
				set	
				{
					kind = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public bool? WindowsOS
			{
				get
				{
					return windowsOS;
				}
				set	
				{
					windowsOS = value;
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

			public string Type
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

			public string GmtRelease
			{
				get
				{
					return gmtRelease;
				}
				set	
				{
					gmtRelease = value;
				}
			}

			public int? MinMemory
			{
				get
				{
					return minMemory;
				}
				set	
				{
					minMemory = value;
				}
			}

			public long? OsTypeId
			{
				get
				{
					return osTypeId;
				}
				set	
				{
					osTypeId = value;
				}
			}

			public int? MaxCpu
			{
				get
				{
					return maxCpu;
				}
				set	
				{
					maxCpu = value;
				}
			}

			public int? MinCpu
			{
				get
				{
					return minCpu;
				}
				set	
				{
					minCpu = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
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

			public int? OsBit
			{
				get
				{
					return osBit;
				}
				set	
				{
					osBit = value;
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

			public string OsMemo
			{
				get
				{
					return osMemo;
				}
				set	
				{
					osMemo = value;
				}
			}

			public int? ImageSize
			{
				get
				{
					return imageSize;
				}
				set	
				{
					imageSize = value;
				}
			}

			public string IsPublic
			{
				get
				{
					return isPublic;
				}
				set	
				{
					isPublic = value;
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

			public int? MaxMemory
			{
				get
				{
					return maxMemory;
				}
				set	
				{
					maxMemory = value;
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

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
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

			public string OsName
			{
				get
				{
					return osName;
				}
				set	
				{
					osName = value;
				}
			}
		}

		public class InnerImageQueryUserImages_ErrorCode
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
