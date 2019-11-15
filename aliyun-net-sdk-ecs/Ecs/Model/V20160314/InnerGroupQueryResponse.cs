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
	public class InnerGroupQueryResponse : AcsResponse
	{

		private string requestId;

		private InnerGroupQuery_ErrorCode errorCode;

		private InnerGroupQuery_Data data;

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

		public InnerGroupQuery_ErrorCode ErrorCode
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

		public InnerGroupQuery_Data Data
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

		public class InnerGroupQuery_ErrorCode
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

		public class InnerGroupQuery_Data
		{

			private int? total;

			private string vpcInstanceId;

			private int? pageNo;

			private int? pageSize;

			private string regionNo;

			private List<InnerGroupQuery_Group> groups;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
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

			public List<InnerGroupQuery_Group> Groups
			{
				get
				{
					return groups;
				}
				set	
				{
					groups = value;
				}
			}

			public class InnerGroupQuery_Group
			{

				private int? ecsCount;

				private string vpcInstanceId;

				private string groupDesc;

				private string gmtCreated;

				private string groupName;

				private string gmtModified;

				private string groupNo;

				private List<InnerGroupQuery_Tag> tags;

				public int? EcsCount
				{
					get
					{
						return ecsCount;
					}
					set	
					{
						ecsCount = value;
					}
				}

				public string VpcInstanceId
				{
					get
					{
						return vpcInstanceId;
					}
					set	
					{
						vpcInstanceId = value;
					}
				}

				public string GroupDesc
				{
					get
					{
						return groupDesc;
					}
					set	
					{
						groupDesc = value;
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

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
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

				public string GroupNo
				{
					get
					{
						return groupNo;
					}
					set	
					{
						groupNo = value;
					}
				}

				public List<InnerGroupQuery_Tag> Tags
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

				public class InnerGroupQuery_Tag
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
		}
	}
}
