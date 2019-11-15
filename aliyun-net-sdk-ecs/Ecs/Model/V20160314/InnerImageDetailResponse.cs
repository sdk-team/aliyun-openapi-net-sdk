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
	public class InnerImageDetailResponse : AcsResponse
	{

		private string requestId;

		private InnerImageDetail_ErrorCode errorCode;

		private InnerImageDetail_Data data;

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

		public InnerImageDetail_ErrorCode ErrorCode
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

		public InnerImageDetail_Data Data
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

		public class InnerImageDetail_ErrorCode
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

		public class InnerImageDetail_Data
		{

			private string name;

			private long? srcImageId;

			private string imageId;

			private string gmtCreated;

			private long? id;

			private string bid;

			private bool? supportIoOptimizedInstance;

			private string remark;

			private string visibility;

			private string importOSSObject;

			private string gmtModified;

			private string progress;

			private string version;

			private string imageProductCode;

			private long? aliUid;

			private string gmtRelease;

			private string imageCategory;

			private string displayName;

			private string owner;

			private string status;

			private string importOSSBucket;

			private string regionNo;

			private string format;

			private int? imageSize;

			private string snapshotNo;

			private List<InnerImageDetail_Tag> tags;

			private InnerImageDetail_OsTypeModel osTypeModel;

			private InnerImageDetail_QuoteType quoteType;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public long? SrcImageId
			{
				get
				{
					return srcImageId;
				}
				set	
				{
					srcImageId = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
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

			public bool? SupportIoOptimizedInstance
			{
				get
				{
					return supportIoOptimizedInstance;
				}
				set	
				{
					supportIoOptimizedInstance = value;
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

			public string Visibility
			{
				get
				{
					return visibility;
				}
				set	
				{
					visibility = value;
				}
			}

			public string ImportOSSObject
			{
				get
				{
					return importOSSObject;
				}
				set	
				{
					importOSSObject = value;
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

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
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

			public string ImageProductCode
			{
				get
				{
					return imageProductCode;
				}
				set	
				{
					imageProductCode = value;
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

			public string ImageCategory
			{
				get
				{
					return imageCategory;
				}
				set	
				{
					imageCategory = value;
				}
			}

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
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

			public string ImportOSSBucket
			{
				get
				{
					return importOSSBucket;
				}
				set	
				{
					importOSSBucket = value;
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

			public string Format
			{
				get
				{
					return format;
				}
				set	
				{
					format = value;
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

			public List<InnerImageDetail_Tag> Tags
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

			public InnerImageDetail_OsTypeModel OsTypeModel
			{
				get
				{
					return osTypeModel;
				}
				set	
				{
					osTypeModel = value;
				}
			}

			public InnerImageDetail_QuoteType QuoteType
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

			public class InnerImageDetail_Tag
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

			public class InnerImageDetail_OsTypeModel
			{

				private string platform;

				private long? id;

				private int? osBit;

				private int? minCpu;

				private int? minMemory;

				private int? maxCpu;

				private int? maxMemory;

				private string osName;

				private string osMemo;

				private string type;

				private InnerImageDetail_Kind kind;

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

				public InnerImageDetail_Kind Kind
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

				public class InnerImageDetail_Kind
				{

					private string kind;

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
				}
			}

			public class InnerImageDetail_QuoteType
			{

				private string quoteType;

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
			}
		}
	}
}
